import React from 'react';
import logo from './logo.svg';
import './App.css';
import { Router } from '@reach/router';
import Homepage from './components/Homepage';
import Shownumberpage from './components/Shownumberpage';
import Showhello from './components/Showhello';
import Showword from './components/Showword';

function App() {
  return (
    <div className="App">
      <Router>
        <Homepage path="/home" />
        <Shownumberpage path="/:num" />
        <Showhello path="/:word" />
        <Showword path="/:word/:text/:bg" />
      </Router>
    </div>
  );
}

export default App;
