import React, { useState } from 'react';

const Button = (props) => {
    return (
        <button onClick={props.handleClick}>Birthday Button for {props.lastname} {props.firstname}</button>
    );
}

const PersonCard3 = props => {
    const [clickCount, clickEvent] = useState(0);

    const handleClick = event => {
        clickEvent(clickCount+1)
    }

    return (
        <>
            <h1>{props.firstName}, {props.lastName}</h1>
            <p>Age: {props.age+clickCount}</p>
            <p>Hair Color: {props.hairColor}</p>
            <Button handleClick={handleClick} firstname={props.firstName} lastname={props.lastName} />
        </>
    )
}

export default PersonCard3;