import React from 'react';
import logo from './logo.svg';
import './App.css';
import { Router } from '@reach/router';
import StarWars from './component/Starwars';
import People from './component/People';
import Planet from './component/Planet';
// import axios from 'axios';

let searchfor = "";
let idfor = 0;

const onSubmitHandler = e => {
  // <Router>
  //   {(searchfor==="people") ?
  //     <People path="/:searchfor/:idfor" /> :
  //     <Planet path="/:searchfor/:idfor" />
  //   }
  // </Router>
}

function App() {
  return (
    <div className="App container">
      {/* <StarWars /> */}
      <form onSubmit={onSubmitHandler}>
        <div className="row">
          <label>Search for: </label>
          <select className="custom-select col-1" onSelect={e => searchfor=e.target.value}>
            <option>Planet</option>
            <option>People</option>
          </select>
          <label>ID: </label>
          <select className="custom-select col-1" onSelect={e => (idfor = e.target.value)}>
            <option>aaa</option>
            <option>bbb</option>
            <option>ccc</option>
          </select>
          <button className="btn btn-primary">Search</button>
        </div>
      </form>
      {/* <Router>
        
      </Router> */}
      {searchfor} {idfor}
    </div>
  );
}

export default App;
