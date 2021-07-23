class Media {
    constructor(title){
      this._title = title;
      this._isCheckout = false;
      this._rating = [];
    }
  
    get title(){
      return this._title;
    }
  
    get isCheckout() {
      return this._isCheckout;
    }
  
    get rating() {
      return this._rating;
    }
  
    set isCheckout(checkout){
      return this._isCheckout = checkout;
    }
  
    toggleCheckOutStatus(){
      if(this._isCheckedOut === true){
        return this._isCheckedOut = false;
      } else {
        return this._isCheckedOut = true;
      }
    }
  
      getAverageRating() {
        let ratingSum = this._rating.reduce((currentSum, rating)=> currentSum + rating, 0);
        return ratingSum;
  
      }
      addRating(rating){
        this._rating.push(rating);
      }
  
  }
  
  class Book extends Media{
     /*
    constructor(){
      this._author = auther;
     
      super(title);
      super(isCheckout);
      super(raings); 
      
      this._title = title;
      this._pages = pages;
      this._isCheckout = false;
      this._rating = [];
    }
    */
    constructor(author, title, pages){
      super(title);
      this._author = author;
      this._pages = pages;
    }
    get author() {
      return this._author;
    }
    get pages(){
      return this._pages;
    }
  }
  
  class Movie extends Media {
    constructor(director, title, runTime){
      super(title);
      this._director = director;
      this._runTime = runTime;
      this._isCheckout = false;
      this._ratings = [];
    }
    get director() {
      return this._director;
    }
    get runTime() {
      return this._runTime;
    }
      get isCheckout() {
      return this._isCheckout;
    }
  
    get rating() {
      return this._rating;
    }
  }
  
  const historyOfEverything = new Book('Bill Bryson', 'A Short History of Nearly Everything', 544);
  
  historyOfEverything.toggleCheckOutStatus();
  console.log(`The book is out [True, False]: ${historyOfEverything.isCheckout}!`);
  historyOfEverything.addRating(4);
  historyOfEverything.addRating(5);
  historyOfEverything.addRating(5);
  
  console.log(`The rating is ${historyOfEverything.getAverageRating()}`);
  
  const speed = new Movie('Jan de Bont', 'Speed', 116);
  speed.toggleCheckOutStatus();
  console.log(`The movie in the storage is ${speed.isCheckout}`);
  speed.addRating(1);
  speed.addRating(1);
  speed.addRating(5);
  
  console.log(`The rating of this movie is ${speed.getAverageRating()}`);
  
  