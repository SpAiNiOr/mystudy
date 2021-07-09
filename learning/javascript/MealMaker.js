const menu = {
    _courses:{
      appetizers:[],
      mains:[],
      desserts:[]
    },
    get appetizers(){
      return this.appetizers;
    },
    set appetizers(appetizer){
      return this.appetizers = appetizer;
    },
    get mains(){
      return this.mains;
    },
    set mains(main){
      return this.mains=main;
    },
    get desserts(){
      return this.desserts;
    },
    set desserts(dessert){
      return this.desserts = desserts;
    },
    get courses(){
      return {
        appetizers:this.appetizers,
        mains: this.mains,
        desserts: this.desserts
      };
    },
    
    //add dishes
    addDishToCourse(courseName, dishName, dishPrice){
      const dish = {
        name:courseName,
        price:dishPrice
      };
      this._courses[courseName].push(dish);
    },
    
    //choose random dishes
    getRandomDishFromCourse(courseName){
      const dishes = this._courses[courseName];
      let index = Math.floor(Math.random() * dishes.length);
      return dishes[index];
    },

    //with giving course name, get the dishes to generate the meal
    generateRandomMeal(){
      const appetizer = this.getRandomDishFromCourse('appetizers');
      const main = this.getRandomDishFromCourse('mains');
      const dessert = this.getRandomDishFromCourse('desserts');
      const totalPrice = appetizer.price + main.price + dessert.price;
      return `The meals are ${appetizer.name} ${main.name} ${dessert.name}. And total price is ${totalPrice}.`;
    }
  };
  
  menu.addDishToCourse('appetizers', 'a', 10);
  menu.addDishToCourse('appetizers', 'b', 20);
  menu.addDishToCourse('appetizers', 'a', 30);
  
  menu.addDishToCourse('mains', 'ma', 100);
  menu.addDishToCourse('mains', 'mb', 200);
  menu.addDishToCourse('mains', 'mc', 300);
  
  menu.addDishToCourse('desserts', 'la', 50);
  menu.addDishToCourse('desserts', 'lb', 70);
  menu.addDishToCourse('desserts', 'lc', 90);
  
  const meal = menu.generateRandomMeal();
  console.log(meal);
  
    