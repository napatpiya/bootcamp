import React from 'react';

const TaskDetail = props => {


    return (
        <fieldset>
            <legend>Show Task Details</legend>
            <p>Task: {props.task.title}</p>
            <p>Conpleted: {props.task.isComplete ? "yes" : "no"}</p>
            <p>Due: {props.task.due}</p>
        </fieldset>
    );
}

export default TaskDetail;