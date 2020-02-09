//Biggie Size - Given an array, write a function that changes all positive numbers in the array to the string "big".  Example: makeItBig([-1,3,5,-5]) returns that same array, changed to [-1, "big", "big", -5].
function biggie(arr) {
    for (var i=0; i<arr.length; i++) {
        if (arr[i] > 0) {
            arr[i] = 'big';
        }
    }
}


//Print Low, Return High - Create a function that takes in an array of numbers.  The function should print the lowest value in the array, and return the highest value in the array.
function printLowReturnHigh(arr) {
    var max = arr[0];
    var min = arr[0];
    for (var i=0; i<arr.length; i++) {
        if (max < arr[i]) {
            max = arr[i];
        } else if (min > arr[i]) {
            min = arr[i];
        }
    }
    console.log(min);
    return max;
}


//Print One, Return Another - Build a function that takes in an array of numbers.  The function should print the second-to-last value in the array, and return the first odd value in the array.
function printOneReturnAnother(arr) {
    var odd = 0;
    if (arr[0]%2 !== 0) {
        odd = arr[0];
    }
    for (var i=1; i<arr.length; i++) {
        if (arr[i]%2 !== 0 && odd == 0) {
            odd = arr[i];
        }
        console.log(arr[i]);
    }
    return odd;
}


//Double Vision - Given an array (similar to saying 'takes in an array'), create a function that returns a new array where each value in the original array has been doubled.  Calling double([1,2,3]) should return [2,4,6] without changing the original array.
function doubleVision(arr) {
    var newarr = [];
    for (var i=0; i<arr.length; i++) {
        newarr[i] = arr[i] * arr[i];
    }
    return newarr;
}


//Count Positives - Given an array of numbers, create a function to replace the last value with the number of positive values found in the array.  Example, countPositives([-1,1,1,1]) changes the original array to [-1,1,1,3] and returns it.
function countPositives(arr) {
    var count = 0;
    for (var i=0; i<arr.length; i++) {
        if (arr[i] > 0) {
            count += 1
        }
    }
    arr[arr.length-1] = count;
    return arr;
}


//Evens and Odds - Create a function that accepts an array.  Every time that array has three odd values in a row, print "That's odd!".  Every time the array has three evens in a row, print "Even more so!".
function evensAndOdds(arr) {
    var even = 0;
    var odd = 0;
    for (var i=0; i<arr.length; i++) {
        if (arr[i]%2 == 0) {
            even += 1;
        } else {
            odd += 1;
        }
    }
    if (odd >= 3) {
        console.log("That's odd!");
    } else if (even >= 3) {
        console.log("Even more so!");
    }
}


//Increment the Seconds - Given an array of numbers arr, add 1 to every other element, specifically those whose index is odd (arr[1], arr[3], arr[5], etc).  Afterward, console.log each array value and return arr.
function incrementTheSeconds(arr) {
    for (var i=0; i<arr.length; i++) {
        if (i%2 !== 0) {
            arr[i] = 1;
        }
        console.log(arr[i]);
    }
    return arr;
}



//Previous Lengths - You are passed an array (similar to saying 'takes in an array' or 'given an array') containing strings.  Working within that same array, replace each string with a number - the length of the string at the previous array index - and return the array.  For example, previousLengths(["hello", "dojo", "awesome"]) should return ["hello", 5, 4]. Hint: Can for loops only go forward?
function previousLengths(arr) {
    var len = 0;
    for (var i=arr.length-1; i>0; i--) {
        arr[i] = arr[i-1].length;
    }
    return arr;
}


//Add Seven - Build a function that accepts an array. Return a new array with all the values of the original, but add 7 to each. Do not alter the original array.  Example, addSeven([1,2,3]) should return [8,9,10] in a new array.
function addSeven(arr) {
    var newarr = [];
    for (var i=0; i<arr.length; i++) {
        newarr = arr[i] + 7;
    }
    return newarr;
}


//Reverse Array - Given an array, write a function that reverses its values, in-place.  Example: reverse([3,1,6,4,2]) returns the same array, but now contains values reversed like so... [2,4,6,1,3].  Do this without creating an empty temporary array.  (Hint: you'll need to swap values).
function reverseArray(arr) {
    for (var i=0; i<arr.length/2; i++) {
        var tmp = arr[arr.length-i-1];
        arr[arr.length-i-1] = arr[i];
        arr[i] = tmp;
    }
    return arr;
}


//Outlook: Negative - Given an array, create and return a new one containing all the values of the original array, but make them all negative (not simply multiplied by -1). Given [1,-3,5], return [-1,-3,-5].
function Negative(arr) {
    for (var i=0; i<arr.length; i++) {
        arr[i] = -Math.abs(arr[i]);
    }
    return arr;
}


//Always Hungry - Create a function that accepts an array, and prints "yummy" each time one of the values is equal to "food".  If no array values are "food", then print "I'm hungry" once.
function alwaysHungry(arr) {
    count = 0;
    for (var i=0; i<arr.length; i++) {
        if (arr[i] == 'food') {
            count = 1;
            console.log("yummy");
        }
    }
    if (count == 0) {
        console.log("I'm hungry");
    }
}


//Swap Toward the Center - Given an array, swap the first and last values, third and third-to-last values, etc.  Example: swapTowardCenter([true,42,"Ada",2,"pizza"]) turns the array into ["pizza", 42, "Ada", 2, true].  swapTowardCenter([1,2,3,4,5,6]) turns the array into [6,2,4,3,5,1].  No need to return the array this time.
function swapToward(arr) {
    for (var i=0; i<arr.length/2; i++) {
        var tmp = arr[arr.length-i-1];
        arr[arr.length-i-1] = arr[i];
        arr[i] = tmp;
        i++;
    }
    return arr;
}


//Scale the Array - Given an array arr and a number num, multiply all values in the array arr by the number num, and return the changed array arr.  For example, scaleArray([1,2,3], 3) should return [3,6,9].
function scaleTheArray(arr, n) {
    for (var i=0; i<arr.length; i++) {
        arr[i] = arr[i] * n;
    }
    return arr;
}

