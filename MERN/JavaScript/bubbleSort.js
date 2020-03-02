function bubblesort(arr) {
    for (var i=0; i<arr.length-1; i++) {
        var alreadysorted = true;
        for (var j=0; j<arr.length-1; j++) {
            if (arr[j] > arr[j+1]) {
                var tmp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = tmp
                alreadysorted = false;
            }
        }
        if (alreadysorted) {
            return arr
        }
    }
}

console.log(bubblesort([5,2,4,7,1,3,9,]))