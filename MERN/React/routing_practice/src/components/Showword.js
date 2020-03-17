import React from 'react';



const Showword = props => {
    const myStyle = {
        color: props.text,
        backgroundColor: props.bg
    }

    return (
        <h3 style={myStyle}>The word is: {props.word} </h3>
    );
}

export default Showword;