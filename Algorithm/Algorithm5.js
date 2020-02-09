// Return the given array, after setting any negative values to zero.  For example resetNegatives( [1,2,-1, -3]) should return [1,2,0,0].
function resetNegatives(arr) {
    for (var i=0; i<arr.length; i++) {
        if (arr[i] < 0) {
            arr[i] = 0;
        }
    }
    return arr;
}

console.log(resetNegatives([1,2,-4,-5,4]));
// Output: [1,2,0,0,4]


// Given an array, move all values forward by one index, dropping the first and leaving a ‘0’ value at the end.  For example moveForward( [1,2,3]) should return [2,3,0].
function moveForward(arr) {
    for (var i=0; i<arr.length-1; i++) {
        var tmp = arr[i+1];
        arr[i+1] = arr[i];
        arr[i] = tmp;
    }
    arr.pop();
    arr.push(0);

    return arr;
}

console.log(moveForward([1,2,3,4,5,6,7,8]));
// Output: [2,3,4,5,6,7,8,0]



// Given an array, return an array with values in a reversed order.  For example, returnReversed([1,2,3]) should return [3,2,1].
function returnReversed(arr) {
    for (var i=0; i<arr.length/2; i++) {
        var tmp = arr[arr.length - i -1];
        arr[arr.length - i -1] = arr[i]; 
        arr[i] = tmp
    }
    return arr;
}

console.log(returnReversed([1,2,3,4]));
// Output: [4,3,2,1]


// Create a function that changes a given array to list each original element twice, retaining original order.  Have the function return the new array.  For example repeatTwice( [4,”Ulysses”, 42, false] ) should return [4,4, “Ulysses”, “Ulysses”, 42, 42, false, false].
function repeatTwice(arr) {
    var newarr = [];
    for (var i=0; i<arr.length; i++) {
        newarr.push(arr[i]);
        newarr.push(arr[i]);
    }
    return newarr;
}

console.log(repeatTwice([4,'Ulysses', 42, false]));
// Output: [4,4, “Ulysses”, “Ulysses”, 42, 42, false, false])