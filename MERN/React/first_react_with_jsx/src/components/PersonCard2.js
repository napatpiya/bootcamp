import React, { Component } from 'react';

const Button = (props) => {
    return (
        <button onClick={props.handleClick}>Birthday Button for {props.name}</button>
    );
}

class PersonCard2 extends Component {
    constructor(props){
        super(props);
        this.state = {
            age: this.props.age
        }
    }

    handleClick = () => {
        this.setState({
            age: this.state.age + 1
        })
    }

    render() {
        return(
            <div>
                <h1>{this.props.firstName}, {this.props.lastName}</h1>
                <p>Age: {this.props.age}</p>
                <p>Hair Color: {this.props.hairColor}</p>
                <Button handleClick={this.handleClick} name={this.props.firstName} />
            </div>
        );
    }
}

export default PersonCard2;