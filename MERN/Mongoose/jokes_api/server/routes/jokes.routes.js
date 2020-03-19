const JokeController = require("../controllers/jokes.controller");

module.exports = app => {
  app.get("/api/jokes/", JokeController.getAll);
  app.get("/api/jokes/:id", JokeController.getOne);
  app.get("/api/jokes/random", JokeController.random);
  app.post("/api/jokes/new", JokeController.create);
  app.put("/api/jokes/update/:_id", JokeController.update);
  app.delete("/api/jokes/delete/:_id", JokeController.delete);
}