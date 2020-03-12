import React, { useState } from 'react';

const Tabs = props => {

    const [tabs, setTab] = useState(["Tab 1", "Tab 2", "Tab 3"]);
    const [desc, setDesc] = useState(["Tab1 description", "Tab2 description", "Tab3 description"]);
    const [active, setActive] = useState(0);

    const onSubmitHandler = event => {
        setActive(event.target.name)
    }

    const Button = tabs.map((tab,i) => <button name={i} type="submit" onClick={onSubmitHandler}>{tab}</button>);
        
    return (
        <div>
            {Button}
            <p>{desc[active]}</p>
        </div>
    );
}

export default Tabs;