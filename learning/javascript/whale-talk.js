let input = "turpentine and turtles";
const vowels = ['a', 'e', 'i', 'o', 'u'];
let resultArray = [];

for(let i = 0; i <input.length; i++){
  console.log(input[i]);
  for(let j =0; j< vowels.length; j++){
    console.log(j);
    if(input[i]===vowels[j]){
      resultArray.push(input[i]);
      if(vowels[j]==='e' || vowels[j]==='i'){
        resultArray.push(input[i]);
      }
    }
  }
}

console.log(resultArray);
let str = resultArray.join('');
str = str.toUpperCase();

console.log(str);