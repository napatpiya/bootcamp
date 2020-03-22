const express = require('express');
const cors = require('cors');
const app = express();
// const db_name = ;
const port = 8000;

// require('./config/mongoose.config')(db_name); // This is new

app.use(cors());
app.use(express.json()); // This is new
app.use(express.urlencoded({ extended: true })); // This is new

// require('./routes/activity.route')(app);

app.listen(port, () => {
    console.log(`Listening at Port ${port}`)
})