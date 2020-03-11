import React from 'react';


const Messages = props => {

    return (
        <>
            <h3>I am messages:</h3>
            <ul>
            {
                props.msgs.map( (msg, i) => 
                    <li key={i}>{msg}</li>
                )
            }
            </ul>
        </>
    );

}

export default Messages;