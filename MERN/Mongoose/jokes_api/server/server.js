const express = require("express");
const app = express();
const cors = require("cors");
const port = 8000;
const db_name = "jokesdb";

app.use(cors());
app.use(express.json(), express.urlencoded({ extended: true }));

require("./config/mongoose.config")(db_name);
require("./routes/jokes.routes")(app);

app.listen({port}, () => console.log(`The server is all fired up on port ${port}`));