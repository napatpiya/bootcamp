const express = require("express");
const faker = require('faker');
const app = express();
const port = 8000;

const server = app.listen(port, () => {
    console.log(`Listening on port ${port}`);
});

let user_id = 0;
let company_id = 0;

class User {
    constructor() {
        this.userId = user_id,
        this.firstName = faker.name.firstName(),
        this.lastName = faker.name.lastName(),
        this.phoneNumber = faker.phone.phoneNumber(),
        this.email = faker.internet.email(),
        this.password = faker.internet.password()
    }
};

class Company {
    constructor() {
        this.companyId = company_id,
        this.name = faker.company.companyName(),
        this.street = faker.address.streetAddress(),
        this.city = faker.address.city(),
        this.state = faker.address.state(),
        this.zipCode = faker.address.zipCode(),
        this.country = faker.address.country()
    }
};

app.get("/api/users/new", (req, res) => {
    user = new User();
    res.json({user});
});

app.get("/api/companies/new", (req, res) => {
    company = new Company();
    res.json({company});
});

app.get("/api/user/company", (req, res) => {
    user = new User();
    company = new Company();
    res.json({user, company});
});