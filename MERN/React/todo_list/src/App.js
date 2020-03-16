import React, { useState } from 'react';
import './App.css';
// import ToDoList from './components/Todolist';
import Task from './components/Task';
import Input from './components/Input'

function App() {
  const [list, setList] = useState([]);

  return (
    <div className="App container" style={{ width: "800px"}}>
      {list.map(task => (
        <Task task={task} setList={setList} />
      ))}
      <Input list={list} setList={setList} />
    </div>
  );
}

export default App;
