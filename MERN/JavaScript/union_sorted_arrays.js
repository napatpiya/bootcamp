function unionSortedArrays(arr1, arr2) {
    var index1 = 0;
    var index2 = 0;
    var newarr = [];
    while (index1 < arr1.length && index2 < arr2.length) {
        if (arr1[index1] === arr2[index2]){
            newarr.push(arr1[index1]);
            index1 += 1;
            index2 += 1;
        }else if (arr1[index1] < arr2[index2]) {
            newarr.push(arr1[index1]);
            index1 += 1;
        }else if (arr2[index2] < arr1[index1]) {
            newarr.push(arr2[index2]);
            index2 += 1;
        }
    }

    while (index1 < arr1.length) {
        newarr.push(arr1[index1]);
        index1 += 1;
    }

    while (index2 < arr2.length) {
        newarr.push(arr2[index2]);
        index2 += 1;
    }

    return newarr;
}



// arr1 = [1,2,2,2,7];
// arr2 = [2,2,6,6,7];

arr1 = [1,4,5,5,7,8,8,10];
arr2 = [1,1,1,1,1,1,1,1];

console.log(unionSortedArrays(arr1, arr2));