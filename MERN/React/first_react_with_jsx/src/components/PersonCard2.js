import React, { Component } from 'react';

const Button = (props) => {
    return (
        <button onClick={props.handleClick}>Birthday Button for {props.lastname} {props.firstname}</button>
    );
}

class PersonCard2 extends Component {
    constructor(props){
        super(props);
        this.state = {
            clickCount: 0
        }
    }

    handleClick = () => {
        this.setState({
            clickCount: this.state.clickCount + 1
        })
    }

    render() {
        return(
            <div>
                <h1>{this.props.firstName}, {this.props.lastName}</h1>
                <p>Age: {this.props.age+this.state.clickCount}</p>
                <p>Hair Color: {this.props.hairColor}</p>
                <Button handleClick={this.handleClick} firstname={this.props.firstName} lastname={this.props.lastName} />
            </div>
        );
    }
}

export default PersonCard2;