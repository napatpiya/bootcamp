function cleanEmptyData(arr) {
    var cleanArray = [];
    for (var i = 0; i < arr.length; i++) {
        // Clean data if 
        //  - birth year is null.
        //  - death year is null.
        //  - birth year has minus value.
        //  - death year has minus value.
        //  - death year is less than birth year.
        if (arr[i][0] != null && arr[i][1] != null && arr[i][0] > 0 && arr[i][1] > 0 && arr[i][1] >= arr[i][0]) {
            cleanArray.push(arr[i]);
        }
    }

    return cleanArray;
}

function getMinBirthYear (arr) {

    return Math.min.apply(null, arr.map(function (e) { return e[0]}))

} 

function getMaxDeathYear (arr) {

    return Math.max.apply(null, arr.map(function (e) { return e[1]}))

} 

function findMaxPopulation(yearArr) {
    var maxPopulation = yearArr[0];
    for (var i = 1; i < yearArr.length; i++) {
        if (yearArr[i] > maxPopulation) {
            maxPopulation = yearArr[i];
        }
    }

    return maxPopulation;
}

function findHighestAliveYears(birthDeathYears) {
    // Check array is empty?
    let highestAliveYears = [];
    if (birthDeathYears.length === 0) {
        return highestAliveYears;
    }

    // Clean empty and invalid entry from array
    birthDeathYears = cleanEmptyData(birthDeathYears);
    console.log(birthDeathYears);

    // Check min birth year and max death year
    var minBirthYear = getMinBirthYear(birthDeathYears);
    var maxDeathYear = getMaxDeathYear(birthDeathYears);
    var yearRange = (maxDeathYear - minBirthYear) + 1;

    console.log(yearRange);

    // Count people in each year. Ignore negative input.
    let yearArr = new Array(yearRange).fill(0);
    for (var i = 0; i < birthDeathYears.length; i++) {
        for (var j = birthDeathYears[i][0] - minBirthYear; j <= birthDeathYears[i][1] - minBirthYear; j++) {
            yearArr[j]++;
        }
    }

    console.log(yearArr);

    // Find max people's year.
    var maxPopulation = findMaxPopulation(yearArr);

    // Check if doesn't have year that people were alive at the same time.
    if (maxPopulation === 0) {
        return highestAliveYears;
    }

    // Keep max people's year in a new array.
    for (var i = 0; i < yearArr.length; i++) {
        if (yearArr[i] === maxPopulation) {
            highestAliveYears.push(minBirthYear + i);
        }
    }

    return highestAliveYears;
}

ar = [];
arr = [[1910, 1920], [1911, 1919]];
arr1 = [[-1910, 1950], [1900, -1951], [1945, 2000],[1980, 2003]]
arr2 = [[1910, 1950], [], [1900, 1951], [1945, 2001], [], [1990, 2001], [1991, 2002]];
arr3 = [[1910, 1950], [1900, 1951], [1945, 2000], [199, 1921]];
arr4 = [[1910, 1950], [], [1900, 1951], [], [1945, 2000]];
arr5 = [[-1910, 1950], [1900, -1951], [1945, 2000]];

arr6 = [[1910, 1950], [1900, 1951], [1945, 2001], [1990, 2001], [1991, 2002]];

console.log(findHighestAliveYears(arr6));


// console.log(cleanEmptyData(arr1));