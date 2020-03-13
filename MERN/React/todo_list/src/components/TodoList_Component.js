import React, { useState } from 'react';

const ToDo = props =>{

    const [todolist, settodolist] = useState([]);

    const [name,setname]= useState("");
    const [desc, setdesc] = useState("");

    const deletelistitem = e => {
        e.preventDefault();
        var i = e.target.value;
        console.log(i);
        let tmp = [...todolist];
        tmp.splice(i,1);
        settodolist(tmp);
    }
    /* Deleting by setting a temp variable to the entirity of the list, splicing at location i (passed by the value in the form) with one (1) object specified, and then setting the todolist to tmp  */

    const addlistitem = e =>{
        e.preventDefault();
        console.log("name:",name);
        console.log("desc:",desc);
        console.log("setting newitem, then printing newitem")
        let newitem ={taskname:name,
                    desc:desc,
                    completed:false};
        console.log("newitem:", newitem.taskname);
        console.log("printing the taskname of the new item")
        console.log("newitem.taskname", newitem.taskname);
        settodolist([...todolist,newitem]);
        console.log("printing to do list");
        console.log(todolist);
        setname("")
        setdesc("")
    }
    /*Add functionaility is adding an empty box beforehand, not sure why there is a delay - adds empty div and submit has to occur twice
    It seems that the onChange functionality is not working correctly?
    
    Need to set the newitem to a full variable, thereby requiring the state to update and be properly applied*/


    const toggleNeedTodo =i=>{
        let temp = [...todolist]; /*MAKE SURE AT ALL TIMES THE ARRAY IS BEING PASSED THRU, NOT A DICTIONARY, OTHERWISE THE MAP FUNCTION BREAKS */
        temp[i].completed = !temp[i].completed;
        settodolist(temp)
    }

    return <div>
        <form onSubmit={addlistitem}>
            <p>Add an item</p>
            <label>Task Name</label>
            <input type="text" onChange={e=> setname(e.target.value)} value={name}></input>
            <label>Task Description</label>
            <input type="text" onChange={e=>setdesc(e.target.value)} value={desc}></input>
            <button>Add</button>
        </form>
        {todolist.map((item, i) =>
        <div key ={i}> 
        <h3 className={item.completed? "have": ""}>{item.taskname}</h3>{/*ternary operator - if true:if false, allows for conditional rendering w/css. Example: text decoration of this component is applied only if the completed attribute of the component is true, else it appears normally.*/}
        <p className={item.completed? "have": ""}>{item.desc}</p>
        <form>
            {/* {item.completed ? */}
            {/* <input type="checkbox" onClick={e=>toggleNeedTodo(i)}/> */}
            {/* :<input type="checkbox" onClick={e=>toggleNeedTodo(i)}/>} */}
            {}
            <input type="checkbox" onClick={e=>toggleNeedTodo(i)}/> {/*No need for ternary toggle, lol*/}
            <button onClick={deletelistitem} value={i}>DELETE</button>{/* Set up delete function thru i iteration var, grab as per the tabs assignment*/}
        </form> 
        </div>)}
    </div>
}
export default ToDo