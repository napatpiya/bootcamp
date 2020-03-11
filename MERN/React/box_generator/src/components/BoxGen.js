import React, { useState } from 'react';

let boxes = [];
// let newboxes = [];

const pStyle = {
    backgroundColor: "{box}"
}

const BoxGen = () => {
    const [state, setState] = useState({
        boxColor: "",
        // size: 100
    })

    const ListItem = box => <p style={{backgroundColor: box, color: "white"}}>{box}</p>;

    const onChangeHandler = event => {
        setState({
            ...state,
            [event.target.name]: event.target.value
        })
    }

    const onSubmitHandler = event => {
        event.preventDefault();
        boxes.push(state.boxColor);
        // newboxes.push({
        //     box_c: {state.boxColor},
        //     box_s: {state.size},
        // });
        setState({
            ...state,
            boxColor: "",
            size: 100
        })
    }

    return (
        <div class="container">
            <div class="header">
                <form onSubmit={onSubmitHandler}>
                    <div class="row row-cols-3">
                        <div class="col"></div>
                        <div class="col-8">
                            <div class="row">
                                <label>Color: </label>
                                <input name="boxColor" class="form-control col-2" type="text" onChange={onChangeHandler} value={state.boxColor}></input>
                                {/* <label>Size: </label>
                                <input name="size" class="form-control col-2" type="text" onChange={onChangeHandler} value=""></input>
                                <label>px </label> */}
                                <button type="submit" class="btn btn-primary">Add</button>
                            </div>
                        </div>
                        <div class="col"></div>
                    </div>
                </form>
            </div>
            <div class="box row">
                {boxes.map(ListItem)}
            </div>
            {/* <div class="box row">
                {newboxes.map(ListItem)}
            </div> */}
        </div>
    );
}

export default BoxGen;