// Code Sample 1 - function and return I
function a(){
    console.log('hello');
}
console.log('Dojo');
// Output:
// Dojo

// Code Sample 2 - function and return I
function a() {
    console.log('hello');
    return 15;
}
x = a();
console.log('x is', x);
// Output:
// hello
// x is 15

// Code Sample 3 - function and return I
function a(n) {
    console.log('n is', n);
    return n + 15;
}
x = a(3);
console.log('x is', x);
// Output:
// n is 3
// x is 18

// Code Sample 4 - function and return I
function a(n) {
    console.log('n is', n);
    y = n*2;
    return y;
}
x = a(3) + a(5);
console.log('x is', x);
// Output:
// n is 3
// n is 5
// x is 16

// Code Sample 5 - function and return I
function op(a,b) {
    c = a + b;
    console.log('c is', c);
    return c;
}
x = op(2,3) + op(3,5);
console.log('x is', x);
// Output:
// c is 5
// c is 8
// x is 13

// Code Sample 6 - function and return I
function op(a,b) {
    c = a + b;
    console.log('c is', c);
    return c;
}
x = op(2,3) + op(3,op(2,1)) + op(op(2,1),op(2,3));
console.log('x is', x);
// Output:
// c is 5
// c is 3
// c is 6
// c is 3
// c is 5
// c is 8
// x is 19

// Code Sample 7 - function and return I
var x = 15;
function a() {
    var x = 10;
}
console.log(x);
a();
console.log(x);
// Output:
// 15
// 10

// Assignment 1
function multiply(x,y) {
    console.log(x);
    console.log(y);
}
b = multiply(2,3);
console.log(b);
// Output :
// 2
// 3
// Undefined

// Assignment 2
function multiply(x,y) {
    return x*y;
}
b = multiply(2,3);
console.log(b);
console.log(multiply(5,2));
// Output :
// 6
// 10

// Assignment 3
var x = [1,2,3,4,5,10];
for (var i=0; i<5; i++) {
    i = i + 3;
    console.log(i);
}
// Output:
// 3
// 7

// Assignment 4
var x = 15;
console.log(x);
function awesome() {
    var x = 10;
    console.log(x);
}
console.log(x);
awesome();
console.log(x);
// Output:
// 15
// 15
// 10
// 15

// Assignment 5
for (var i=0; i<15; i++) {
    console.log(i);
}
// Output:
// 0
// 1
// 2
// 3
// 4
// 5
// 6
// 7
// 8
// 9
// 10
// 11
// 12
// 13
// 14

// Assignment 6
for (var i=0; i<3; i++) {
    for (var j=0; j<2; j++) {
        console.log(i*j);
    }
}
// Output:
// 0
// 0
// 0
// 1
// 0
// 2

// Assignment 7
function looping(x,y) {
    for (var i=0; i<x; i++) {
        for (var j=0; j<x; j++){
            console.log(i*j);
        }
    }
}
z = looping(3,3);
console.log(z);
// Output:
// 0
// 0
// 0
// 0
// 1
// 2
// 0
// 2
// 4
// Undefined

// Assignment 8
function looping(x,y) {
    for (var i=0; i<x; i++) {
        for (var j=0; j<y; j++) {
            console.log(i*j);
        }
    }
    return x*y;
}
z = looping(3,5);
console.log(z);
// Output:
// 0
// 0
// 0
// 0
// 0
// 0
// 1
// 2
// 3
// 4
// 0
// 2
// 4
// 6
// 8
// 15


// Part 2 : Print 1 to x
function printUpTo(x){
    if (x < 0){
        return "negative number")
    } else {
        for (var i=1; i<=x; i++) {
            console.log(i);
        }
    }
}
printUpTo(1000);
y = printUpTo(-10);
console.log(y);

// Part 2 : PrintSum
function printSum(x){
    var sum = 0;
    for (var i=1; i<=x; i++) {
        sum += i;
    }
    return sum;
}
y = printSum(255);
console.log(y);

// Part 2 : PrintSumArray
function printSumArray(x) {
    var sum = 0;
    for (var i=0; i<x.length; i++) {
        sum += x[i];
    }
    return sum;
}
console.log(printSumArray([1,2,3]));

// Bonus : LargestElement
function largestElement(x) {
    var large = x[0];
    for (var i=1; ix.length; i++) {
        if (large < x[i]) {
            large = x[i];
        }
    }
    return large;
}
console.log(largestElement([1,-2,8,-4,18,5,-10]));