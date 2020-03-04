class Ninja {
    constructor(name) {
        this.name = name;
        this.health = 100;
        this.speed = 3;
        this.strength = 3;
    }

    sayName() {
        console.log("Name:", this.name);
    }

    showStats() {
        console.log("Show Stats of", this.name);
        console.log("Name:", this.name, ", Health:", this.health, ", Speed:", this.speed, ", Strength:", this.strength);
    }

    drinkSake() {
        this.health += 10;
        console.log("Ohhh!", this.name, "drink Sake!!")
        console.log("Name:", this.name, ", Health:", this.health, ", Speed:", this.speed, ", Strength:", this.strength);
    }
}

class Sensei extends Ninja {
    constructor(name) {
        super(name);
        this.health = 200;
        this.speed = 10;
        this.strength = 10;
        this.wisdom = 10;
    }

    speakWisdom() {
        const message = super.drinkSake();
        console.log("What one programmer can do in one month, two programmers can do in two months.");
    }
}

const ninja1 = new Ninja("Hyabusa");
ninja1.sayName();
ninja1.showStats();
ninja1.drinkSake();

console.log("")
// example output
const superSensei = new Sensei("Master Splinter");
superSensei.sayName();
superSensei.showStats();
// -> "Name: Master Splinter, Health: 210, Speed: 10, Strength:
superSensei.speakWisdom();
// -> "What one programmer can do in one month, two programmers can do in two months."copy
