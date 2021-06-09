let raceNumber = Math.floor(Math.random() * 1000);
let registerEarly=true;
let runnerAge = 37;

if (runnerAge>=18 && registerEarly === true){
  raceNumber+=1000;
}

if (runnerAge>=18 && registerEarly ===true  ){
  console.log(`You ${raceNumber} will run at 9:30 am.`);
} else if (runnerAge>=18 && registerEarly !== true){
  console.log(`Late adults ${raceNumber}run at 11:00 am.`);
} else {
  console.log(`Youth registrants ${raceNumber} run at 12:30 pm`);
}
