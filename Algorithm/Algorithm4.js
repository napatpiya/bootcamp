// Given an array and a value Y, count and print the number of array values greater than Y.
function greaterY(arr, y) {
    var check = 0;
    for (var i=0; i<arr.length; i++) {
        if (arr[i] > y) {
            check = arr[i];
        }
    }
    return check;
}

console.log(greaterY([1,21,-2,10,3,6], 20));
// Output: 21




// Given an array, print the max, min and average values for that array.
function MMA(arr) {
    var max = arr[0];
    var min = arr[0];
    var sum = 0;
    var mma = [];
    for (var i = 0; i < arr.length; i++) {
        if (arr[i] > max) {
            max = arr[i];
        }
        if (arr[i] < min) {
            min = arr[i];
        }
        sum += arr[i];
    }
    var avg = sum/arr.length;
    mma.push(min, max, avg);
    return mma;
}

console.log(MMA([1,18,7,-4,4,12]));
// Output: [-4,18,6,33333333333333333]




// Given an array of numbers, create a function that returns a new array where negative values were replaced with the string ‘Dojo’.   For example, replaceNegatives( [1,2,-3,-5,5]) should return [1,2, "Dojo", "Dojo", 5].
function changeNegative(arr) {
    for (var i=0; i<arr.length; i++) {
        if (arr[i] < 0)
            arr[i] = 'Dojo';
    }
    return arr;
}

console.log(changeNegative([20,-2,4,-8,-10,12,6,-5]));
// Output: [20,Dojo,4,Dojo,Dojo,12,6,Dojo]




// Given array, and indices start and end, remove values in that index range, working in-place (hence shortening the array).  For example, removeVals([20,30,40,50,60,70],2,4) should return [20,30,70].
function removeValueIndex(arr, x, y) {
    var check = arr.length - x;
    for (var i=x; i<=y; i++) {
        for (var j=0; j<=check; j++) {
            var temp = arr[j+x+1];
            arr[j+x+1] = arr[j+x]
            arr[j+x] = temp
        }
        arr.pop();
        check = check - 1;
    }
    return arr;
}

console.log(removeValueIndex([20,30,40,50,60,70,80,90],2,4)); 
// Output: [20,30,70,80,90]


function removeValueIndex(arr,x,y) {
    var array = [];
    for (var i = 0; i < arr.length; i++) {
        if (i<x) {
            array.push(arr[i]);
        }
        else if (i>y) {
            array.push(arr[i]);
        }
    }
    return array;
}
