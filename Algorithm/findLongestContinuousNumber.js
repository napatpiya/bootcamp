function findLongestContinuousNumber(arr) {
    if (arr.length === 0) {
        return 0;
    }
    
    var longestLength = 1;
    var lengthCount = 1;

    for (var i = 1; i < arr.length; i++) {
        if (arr[i] === arr[i-1]) {
            lengthCount++;
        } else {
            lengthCount = 1;
        }

        if (lengthCount > longestLength) {
            longestLength = lengthCount;
        }
    }

    return longestLength;
}

arr = [];
arr1 = [1,7,-7,3,3];
arr2 = [1,7,7,3,9,9,9,4,9];
arr3 = [1,1,2,2,2,2,3,3,4,4,4,5,5,5,5,5,5,6];
arr4 = [11,11,234,234,234]

console.log(findLongestContinuousNumber(arr4));