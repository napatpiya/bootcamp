// Assignment 1
function a(x,y){
    return 5;
  }
  console.log(a(5,5))
// Output:
// 5

// Assignment 2
function a(x,y){
    z = []
    z.push(x);
    z.push(y);
    z.push(5);
    console.log(z);
    return z;
}
b = a(2,2)
console.log(b);
console.log(a(6,8));
// Output:
// [2,2,5]
// [2,2,5]
// [6,8,5]
// [6,8,5]

// Assignment 3 **********
function a(x){
    z = [];
    z.push(x);
    z.pop();
    z.push(x);
    z.push(x);
    return z;
 }
 y = a(2);
 y.push(5);
 console.log(y);
 // Output:
 // [2,2,5]

 // Assignment 4
 function a(x){
    if(x[0] < x[1]) {
       return true;
    }
    else {
       return false;
    }
 }
 b = a([2,3,4,5])
 console.log(b);
// Output:
// true

 // Assignment 5
 function a(x){
    for(var i=0; i<x.length; i++){
      if(x[i] > 0){
           x[i] = 'Coding';
      }
    }
    return x;
}
console.log(a([1,2,3,4]));
// Output: 
// [Coding,Coding,Coding,Coding]

// Assignment 6
function a(x){
    for(var i=0; i<x.length; i++){
      if(x[i] > 5){
           x[i] = 'Coding';
      }
      else if(x[i] < 0){
           x[i] = 'Dojo';
      }
    }
    return x;
}
console.log(a([5,7,-1,4]))
// Output: 
// [5,Coding,Dojo,4]

// Assignment 7 ************
function a(x) {
    if(x[0] > x[1]) {
        return x[1];
    }
    return 10;
 }
 b = a([5,10]);
 console.log(b);
 // Output:
 // 10

 // Assignment 8
 function sum(x){
    sum = 0;
    for(var i=0; i<x.length; i++){
       sum = sum + x[i];
       console.log(sum);
    }
    return sum;
}
sum([1,2,3])
// Output:
// 1
// 3
// 6

// Part 2 : 1) Analyze an array’s values and return the average of its values.
function printAverage(x){
    sum = 0;
    for (var i=0; i<x.length; i++) {
        sum += x[i];
    }
    return sum/x.length;
 }
 y = printAverage([1,2,3]);
 console.log(y); // should log 2
   
 y = printAverage([2,5,8]);
 console.log(y); // should log 5


 // Part 2 : 2) Create an array with all the odd integers between 1 and 255 (inclusive)
 function returnOddArray(){
    arr = [];
    for (var i=0; i<=255; i++) {
        if (i%2 != 0) {
            arr.push(i);
        }
    }
    return arr;
 }
 y = returnOddArray();
 console.log(y); // should log [1,3,5,...,253,255]



 // Part 2 : 3) Square each value in a given array, returning that same array with changed values.
 function squareValue(x){
    for (var i=0; i<x.length; i++) {
        x[i] = x[i] * x[i];
    }
    return x;
 }
 y = squareValue([1,2,3]);
 console.log(y); // should log [1,4,9]
   
 y = squareValue([2,5,8]);
 console.log(y); // should log [4,25,64]