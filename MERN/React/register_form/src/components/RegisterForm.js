import React, { useState } from 'react';
const FormComponent = props => {
    const [ state, setState ] = useState({
        firstName: "",
        lastName: "",
        email: "",
        password: "",
        confirmPassword: "",
        submitted: false,
        check_fname: "",
        check_lname: "",
        check_email: "",
        check_pass: "",
        check_cpass: ""
    })
    const onChangeHandler = event => {
        setState({
            ...state,
            [event.target.name]: event.target.value
        })
    }
    // let message;
    // if(state.submitted){
    //     message=<h1>You have submitted the form</h1>;
    // }else{
    //     message=<h1>You have not yet submitted the form</h1>;
    // }
    const onSubmitHandler = event => {
        event.preventDefault();
        setState({
            ...state,
            submitted: true
        })
    }
    return(
        <div>
            <form onSubmit={onSubmitHandler}>
                <label>First Name</label>
                <input type="text" name="firstName" onChange={onChangeHandler}/>
                <br/>
                {state.check_fname}   
                <br/>
                <label>Last Name</label>
                <input type="text" name="lastName" onChange={onChangeHandler}/>
                <br/>
                {state.check_lname} 
                <br/>       
                <label>Email</label>
                <input type="email" name="email" onChange={onChangeHandler}/>
                <br/>
                {state.check_email} 
                <br/>       
                <label>Password</label>
                <input type="password" name="password" onChange={onChangeHandler}/>
                <br/>
                {state.check_pass}
                <br/>        
                <label>Confirm Password</label>
                <input type="password" name="confirmPassword" onChange={onChangeHandler}/>
                <br/>
                {state.check_cpass}
                <br/>
                <input type = "submit"/>        
            </form>
        </div>
    );
}
export default FormComponent;
