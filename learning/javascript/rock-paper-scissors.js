const getUserChoice = userInput => {
    userInput = userInput.toLowerCase();
    if ( userInput === 'rock') {
      return userInput;
    } else if(userInput === 'paper'){
      return userInput;
    } else if(userInput === 'scissors'){
      return userInput;
    } else{
      return console.log('You need to choose one of \'rock\' \'paper\' \'scissors\'.');
    }
  };
  
  const getComputerChoice = () => {
    let randomNumber = Math.floor(Math.random() * 3);
    switch (randomNumber){
      case 0:
          return 'rock';
      case 1:
          return 'paper';
      case 2:
          return 'scissors';
      default:
          return 'You need to choose one of \'rock\' \'paper\' \'scissors\'.';
    }
  
  }
  
  function determineWinner(userChoice, computerChoice){
    if (userChoice === computerChoice){
      return 'It\'s tie!';
    }
  
    if (userChoice === 'rock'){
      if (computerChoice === 'scissors'){
        return 'User is winner!';
      }else if(computerChoice ==='paper'){
        return 'Computer is winner!';
      }
    }
  
    if (userChoice === 'paper'){
      if (computerChoice === 'rock'){
        return 'User is winner!';
      }else if(computerChoice ==='scissors'){
        return 'Computer is winner!';
      }
    }
  
    if (userChoice ==='scissors'){
      if(computerChoice === 'rock'){
        return 'Computer is winner!';
      }else if (computerChoince === 'paper'){
        return 'User is winner!'
      }
    }
  }
  
  //console.log(determineWinner(getUserChoice('rock'), getComputerChoice()))
  
  function playGame(){
    const userChoice = getUserChoice('rock');
    console.log(`The user choice is ${userChoice}!`);
    const computerChoice = getComputerChoice();
    console.log(`The computer choice is ${computerChoice}!`);
    console.log(determineWinner(userChoice, computerChoice));
  }
  
  playGame();
  