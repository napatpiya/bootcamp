// a = 2;
// b = function() { console.log("something"); };
// function doSomething(x) {
//   console.log(typeof(x));
// }
// doSomething(a);
// doSomething(b);


// function doSomething(possibleCallback) {
//     if (typeof(possibleCallback) === 'function'){
//       console.log('possibleCallback is a callback!');
//       possibleCallback(); //we can invoke the callback!
//     }
//     else {
//       console.log('possibleCallback: ', possibleCallback, ' is not a callback function.');
//     }
//   }
  
// doSomething(function myCallback(){ console.log('yes, I am a callback!') });
// doSomething('string');
  

// function makePasta(pasta, makeSauce) {
//     console.log("Boiling water");
//     console.log("Putting " + pasta + " pasta in the water");
//     // create a variable for sauce!
//     const sauce = makeSauce();          // invoke makeSauce, our callback
//     console.log("Mixing sauce");
//     console.log("Pasta is done!");
//     return pasta + " Pasta with " + sauce + " sauce! Voila!";
//   }
//   function makePesto() {
//     console.log("Making Pesto");
//     return "pesto";
//   }
//   function makeAlfredo() {
//     console.log("Making Alfredo");
//     return "alfredo";
//   }
//   // we pass the whole makePesto recipe to makePasta!
//   console.log(makePasta("Penne", makePesto));
//   // notice lack of parentheses after makePesto.
//   // Remember: we want to pass the function, not execute it and pass a return value.
//   console.log(makePasta("Farfalle", makeAlfredo));



// const ninja = 'Libby';
// setTimeout( function (){ console.log(ninja); }, 2000 ); // run the function defined after 2000 milliseconds
// console.log(ninja);



// console.log("NOW: ");
// console.log("Declaring and assigning variable 'ninja'.");
// const ninja = 'Libby';
// setTimeout( function myCallbackFunction(){
//   console.log("LATER: ")
//   console.log(ninja, "LATER"); }, 4000
// );
// console.log("Printing ninja value.");
// console.log(ninja, "NOW");


// const myVar = 10 < 20
// ? 10 < 10
//     ? true
//     : false
// : false

// console.log(myVar);

arr = [2,6,3,7,9,1,5,4,10]
let arr = [5,10,4,6,3,2,1,9,7,8]
function insertionsort(arr){
    for(let i=1; i<arr.length; i++) {
        for(let j=i; j>0; j--) {
            if(arr[j] < arr[j-1]) {
                let tmp = arr[j];
                arr[j] = arr[j-1];
                arr[j-1] = tmp;
            } else {
                console.log("break")
                break;
            }
        }
    }
    return arr;
}

console.log(insertionsort(arr));

