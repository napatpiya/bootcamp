import React, { useState } from 'react';
const FormComponent = props => {
    const [ state, setState ] = useState({
        firstName: "",
        lastName: "",
        email: "",
        password: "",
        confirmPassword: "",
        submitted: false,
    })
    const onChangeHandler = event => {
        setState({
            ...state,
            [event.target.name]: event.target.value
        })
    }
    
    let message;
    let message_fname;
    let message_lname;
    let message_email;
    let message_pass;
    let message_cpass;
    let error = 0;

    // if(state.submitted){
    //     message=<h1>You have submitted the form</h1>;
    // }else{
    //     message=<h1>You have not yet submitted the form</h1>;
    // }

    if (state.firstName.length < 2 && state.firstName.length > 0) {
        error = 1;
        message_fname = "First name should be at least 2 character.";
    }
    if (state.lastName.length < 2 && state.lastName.length > 0) {
        error = 1;
        message_lname = "Last name should be at least 2 character.";
    }
    if (state.email.length < 5 && state.email.length > 0) {
        error = 1;
        message_email = "Email should be at least 5 character.";
    }
    if (state.password.length < 8 && state.password.length > 0) {
        error = 1;
        message_pass = "Password should be at least 8 character.";
    } else if (state.password != state.confirmPassword && state.confirmPassword.length > 0) {
        error = 1;
        message_cpass = "Passwords must match.";
    }
    if (state.firstName.length === 0 || state.lastName.length === 0 || state.email.length === 0 || state.password.length === 0 || state.confirmPassword === 0) {
        error = 1;
    }

    const onSubmitHandler = event => {
        event.preventDefault();
        console.log(message_fname);
        if (error === 0 ) {
            setState({
                ...state,
                submitted: true
            })
        }
    }

    return(
        <div class="container">
            <h1>Register Form</h1>
            {state.submitted ? <h5>You have submitted the form</h5> : <h5>Please complete the form.</h5> }
            <form onSubmit={onSubmitHandler}>
                <div class="col-3"></div>
                <div class="col">
                    <div class="form-group">
                        <label>First Name</label>
                        <input class="form-control" type="text" name="firstName" onChange={onChangeHandler}/>
                        <small class="form-text text-muted">{message_fname}</small>
                    </div>
                    <div class="form-group">
                        <label>Last Name</label>
                        <input class="form-control" type="text" name="lastName" onChange={onChangeHandler}/>
                        <small class="form-text text-muted">{message_lname}</small>
                    </div> 
                    <div class="form-group">  
                        <label>Email</label>
                        <input class="form-control" type="email" name="email" onChange={onChangeHandler}/>
                        <small class="form-text text-muted">{message_email}</small>
                    </div> 
                    <div class="form-group">
                        <label>Password</label>
                        <input class="form-control" type="password" name="password" onChange={onChangeHandler}/>
                        <small class="form-text text-muted">{message_pass}</small>
                    </div>   
                    <div class="form-group">     
                        <label>Confirm Password</label>
                        <input class="form-control" type="password" name="confirmPassword" onChange={onChangeHandler}/>
                        <small class="form-text text-muted">{message_cpass}</small>
                    </div>
                    <button type="submit" class="btn btn-primary">Submit</button>
                </div>
                <div class="col-3"></div>      
            </form>
        </div>
    );
}
export default FormComponent;
