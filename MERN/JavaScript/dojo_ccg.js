class Card {
    constructor(name, cost) {
        this.name = name;
        this.cost = cost;
    }
}

class Unit extends Card {
    constructor(name, cost, power, res) {
        super(name, cost);
        this.power = power;
        this.res = res;
    }

    attack(target) {
        if( target instanceof Unit ) {
            console.log("(Before)Target Name:", target.name, "Resilience:", target.res)
            target.res -= this.power;
            console.log("(After)Target Name:", target.name, "Resilience:", target.res)
        } else {
            throw new Error( "Target must be a unit!" );
        }
    }

    showStats() {
        console.log("Sommons Name:", this.name, "Power:", this.power, "Resilience:", this.res);
    }
}

class Effect extends Card {
    constructor(name, cost, text, stat, mag) {
        super(name, cost);
        this.text = text;
        this.stat = stat;
        this.mag = mag;
    }

    play(target) {
        if( target instanceof Unit ) {
            if (this.stat === "resilience") {
                console.log("(Before)Target Name:", target.name, "Resilience:", target.res);
                target.res += this.mag;
                console.log("(After)Target Name:", target.name, "Resilience:", target.res);
            } else {
                console.log("(Before)Target Name:", target.name, "Power:", target.power);
                target.power += this.mag;
                console.log("(After)Target Name:", target.name, "Power:", target.power);
            }
        } else {
            throw new Error( "Target must be a unit!" );
        }
    }
}


let redbelt = new Unit("Red Belt Ninja", 3, 3, 4);
let blackbelt = new Unit("Black Belt Ninja", 4, 5, 4);

const hardAlgorithm = new Effect("Hard Algorithm", 2, "increase target's resilience by 3", "resilience", 3);
const unhandledPromise = new Effect("Unhandled Promise Rejection", 1, "reduce target's resilience by 2", "resilience", -2);
const pairProgramming = new Effect("Pair programming", 3, "increase target's power by 2", "power", 2);
console.log("")
console.log("")
console.log("***********************************");
console.log('Player 1 summons "Red Belt Ninja"');
console.log("***********************************");
redbelt.showStats()
console.log("")
console.log("")
console.log("****************************************************");
console.log('Player 1 plays "Hard Algorithm" on "Red Belt Ninja"');
console.log("****************************************************");
hardAlgorithm.play(redbelt);
console.log("")
console.log("")
console.log("***********************************");
console.log('Player 2 summons "Black Belt Ninja"');
console.log("***********************************");
blackbelt.showStats();
console.log("")
console.log("")
console.log("****************************************************************");
console.log('Player 2 plays "Unhandled Promise Rejection" on "Red Belt Ninja"');
console.log("****************************************************************");
unhandledPromise.play(redbelt);
console.log("")
console.log("")
console.log("******************************************************");
console.log('Player 1 plays "Pair Programming" on "Red Belt Ninja"');
console.log("******************************************************");
pairProgramming.play(redbelt);
console.log("")
console.log("")
console.log("********************************************************");
console.log('Player 1 has "Red Belt Ninja" attack "Black Belt Ninja"');
console.log("********************************************************");
redbelt.attack(blackbelt);
console.log("")
console.log("")