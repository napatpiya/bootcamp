

function heap(arr) {

    for(var i=0; i<arr.length; i++){
        var j = i+1;
        while (j>1) {
            if (arr[j-1] < arr[(j/2)-1]) {
                var tmp = arr[j-1];
                arr[j-1] = arr[(j/2)-1];
                arr[(j/2)-1] = tmp;
            }
            j = j/2;
        }
    }

    return arr;
}

console.log(3/2);
// arr = [16,14,10,8,7,9,3,2,4,1];
arr = [4, 3, 1]
console.log(heap(arr));