function Matrix(canvas, target){

    let output = [];
    for (let i=0; i<target.length; i++) {
        output[i] = false;
    }

    let countTrue = 0;

    for (let i=0; i<canvas.length; i++) {
        for (let j=0; j<canvas[i].length; j++) {
            for (let x=0; x<target.length; x++) {
                for (let y=0; y<target[x].length; y++) {
                    if (!output[x]) {
                        if (canvas[i][j] === target[x][y]) {
                            if (j+1 !== canvas[i].length) {
                                if (canvas[i][j+1] === target[x][y+1]) {
                                    output[x] = true;
                                    countTrue++;
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    if (countTrue === output.length) {
        console.log("All subsets are found in canvas");
    } else {
        console.log("Subsets were not found");
    }

    return output;
}

const canvas = [
    [1,3,5,9],
    [3,8,10,12],
    [-2,9,3,5],
    [2,1,1,0]
]

const target = [[1,4],[1,1],[8,10],[9,10]];

console.log(Matrix(canvas, target));

