class School {
    constructor(name, level, numberOfStudents){
      this._name = name;
      this._level = level;
      this._numberOfStudents = numberOfStudents;
    }
  
    get name(){
      return this._name;
    }
    get level(){
      return this._levle;
    }
    get numberOfStudents(){
      return this._numberOfStudents;
    }
  
    set numberOfStudents(number){
      if (typeof number === 'number' ){
        this._numberOfStudents = number;
      } else{
        console.log('Invalid input: numberOfStudents must be set to a number.');
      }
    }
  
    quickFacts(){
      console.log(`${this._name} educates ${this._numberOfStudents} students at the ${this._level} school level.`);
    }
    static pickSubstituteTeacher(substituteTeachers){
      const index = Math.floor(Math.random()* (substituteTeachers.length-1));
      return substituteTeachers[index];
    }
  }
  
  class PrimarySchool extends School {
    constructor(name,numberOfStudents, pickupPolicy){
      super(name, 'Primary', numberOfStudents);
      this._pickupPolicy = pickupPolicy;
    }
    get pickupPolicy(){
        return this._pickupPolicy;
      }
  }
  
  class MiddleSchool extends School {
    constructor(name, numberOfStudents){
      super(name, 'Middel', numberOfStudents);
    }
  }
  
  class HighSchool extends School {
    constructor(name, numberOfStudents, sportsTeams){
      super(name, 'high',numberOfStudents);
      this._sportsTeams = sportsTeams;
    }
    get sportsTeams(){
        console.log(this._sportsTeams);
      }
  }
  
  //Primary school instance
  const lorraineHansbury = new PrimarySchool("Lorraine Hansbury", 514, 'Students must be picked up by a parent, guardian, or a family member over the age of 13.');
  
  lorraineHansbury.quickFacts();
  School.pickSubstituteTeacher(['Jamal Crawford', 'Lou Williams', 'J. R. Smith', 'James Harden', 'Jason Terry', 'Manu Ginobli']);
  
  //HighSchool instance
  const alSmith = new HighSchool('Al E. Smith', 415, ['Baseball', 'Basketball', 'Volleyball', 'Track and Field']);
  
  alSmith.sportsTeams;
  