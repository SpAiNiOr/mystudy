const getSleepHours = day =>{
    switch (day){
      case 'monday':
          return 8;
      case 'tuesday':
          return 4.6;
      case 'weneseday':
          return 7;
      case 'thuresday':
          return 6;
      case 'friday':
          return 7;
      case 'saturday':
          return 5.8;
      case 'sunday':
          return 3;
      default:
          return 'Please input a day';
  
    }
  }
  
  //console.log(getSleepHours('monday'));
  
  function getActualSleepHours(){
    let result = 0;
    result += getSleepHours('monday');
    result += getSleepHours('tuesday');
    result += getSleepHours('weneseday');
    result += getSleepHours('thuresday');
    result += getSleepHours('friday');
    result += getSleepHours('saturday');
    result += getSleepHours('sunday');
    return result;
  }
  
  function getIdealSleepHours(){
    const idealHours = 7;
    return idealHours*7;
  }
  
  console.log(getActualSleepHours());
  console.log(getIdealSleepHours());
  
  function calculatsSleepDebt(){
    actualSleepHours = getActualSleepHours();
    idealSleepHours = getIdealSleepHours();
    if (actualSleepHours === idealSleepHours){
      console.log('You got the perfect sleep hours!');
    } else if (actualSleepHours >= idealSleepHours){
      let hours = Math.float(actualSleepHours - idealSleepHours);
      console.log(`You got more sleep ${hours} hours than you need!`);
    } else {
      let hours = idealSleepHours - actualSleepHours;
      console.log(`You need more ${hours} hours sleep!`);
    }
  }
  
  calculatsSleepDebt()
  