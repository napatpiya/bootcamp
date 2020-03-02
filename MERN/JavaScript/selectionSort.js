function selectionsort(arr){
    for (var i=0; i<arr.length-1; i++) {
      var min = i
      for (var j=i+1; j<arr.length; j++) {
        if (arr[min] > arr[j]) {
          min = j;
        }
      }
      var temp = arr[min];
      arr[min] = arr[i];
      arr[i] = temp;
    }
    return arr;
  }
  
  console.log(selectionsort([4,5,2,6,1,8,3,11]))