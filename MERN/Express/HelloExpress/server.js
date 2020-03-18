const express = require("express");
const app = express();

// req is short for request
// res is short for response
// app.get("/api", (req, res) => {
//   res.send("Our express api server is now sending this over to the browser");
// });

app.get("/api/users", (req, res) => {
  const users = [
    { firstName: "Henry", lastName: "Baker", email: "hBaker@somewhere.com"},
    { firstName: "Samtron", lastName: "NONE", email: "samtron@somewhere.com"},
    { firstName: "Jim", lastName: "Baller", email: "jBaller@somewhere.com"},
    { firstName: "Janette", lastName: "Kiwi", email: "jKiwi@somewhere.com"},
    { firstName: "Olaf", lastName: "Otis", email: "oOtis@somewhere.com"},
  ];
  return res.json({users});
})

const server = app.listen(8000, () =>
  console.log(`Server is locked and loaded on port ${server.address().port}!`)
);
