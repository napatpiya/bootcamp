import React from 'react';
import './App.css';
import Main from './views/Main';
import { Router } from '@reach/router';
import Detail from './views/Detail';
import Update from './views/Update';


function App() {
  return (
    <div className="App">
      <Router>
        <Main path="product/" />
        <Detail path="product/:id" />
        <Update path="product/:id/edit" />
      </Router>
    </div>
  );
}

export default App;
