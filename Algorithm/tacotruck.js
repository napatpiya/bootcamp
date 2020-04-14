
function findDistance(point, customer){
    var x = customer[0] - point[0];
    x = Math.abs(x);
    var y = customer[1] - point[1];
    y = Math.abs(y);
    return x+y;
  }
  
  function findMax(num , test){
    if (test > num){
      num = test;
    }
    return num;
  }
  
  function findMin(num , test){
    if (test < num){
      num = test;
    }
    return num;
  }
  
  function optimalDistance(cust1, cust2, cust3){
    var maxX = cust1[0];
    var minX = cust1[0];
    var maxY = cust1[1];
    var minY = cust1[1];
    
    maxX = findMax(maxX,cust2[0]);
    maxX = findMax(maxX,cust3[0]);
    maxY = findMax(maxY,cust2[1]);
    maxY = findMax(maxY,cust3[1]);
  
    minX = findMin(minX,cust2[0]);
    minX = findMin(minX,cust3[0]);
    minY = findMin(minY,cust2[1]);
    minY = findMin(minY,cust3[1]);
  
  
    var x = minX;
    var y = minY;
    var optimalPoint = [x,y];
    var optimalDist = 100;
    var point = [x,y];
  
    while(x < maxX){
      point = [x,y];
      var point1 = findDistance(point, cust1)
      var point2 = findDistance(point, cust2);
      var point3 = findDistance(point, cust3);
      var distance = point1 + point2 + point3;
      
  
      if(distance < optimalDist){
        optimalPoint = [x,y];
        
        var optimalDist = distance;
  
      }
      y+=1;
      if(y == maxY){
        y = minY;
        x++;
      }
      
    }
    return optimalPoint;
  }
  
  var cust1 = [10,0];
  var cust2 = [-1,-10];
  var cust3 = [2,4];
  
  console.log(optimalDistance(cust1, cust2, cust3));