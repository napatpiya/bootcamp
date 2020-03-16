import React, { useState } from 'react';
import TaskDetail from './TaskDetail';

const listofTasks = [
    {title: "Learn React", due: "2020-03-15", isComplete: false},
    {title: "Learn Bulma", due: "2020-10-16", isComplete: false},
    {title: "Fly to Milan", due: "2020-04-02", isComplete: true},
    {title: "Visit scenic Wuhan", due: "2020-06-06", isComplete: false},
];


const YourNewComponent = props => {

    const [state, setState] = useState({});
    const [showTask, toggleShowTask] = useState(false);

    const displayTask = i => {
        console.log(i);
        setState(listofTasks[i]);
        toggleShowTask(true);
    }

    return (
        <>
            <fieldset>
                <legend>Task</legend>
                <ol>
                    {listofTasks.map( (task, i) =>
                        <li key={i}>{task.title} <button onClick={e => displayTask(i)}>Detail -></button></li>
                    )}
                </ol>
            </fieldset>
            { showTask ? <TaskDetail task={state}/> : ""}
            
        </>
    );
}

export default YourNewComponent;