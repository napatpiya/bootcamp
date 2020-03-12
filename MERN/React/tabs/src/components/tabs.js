import React, { useState } from 'react'

const Tabs = props =>{
    const [tabs, setTabs] = useState(["hi","hey","hello"])
    const [activeTab, setactiveTab] = useState(0) /*Starts at 0, showing "hi" at first. i is passed in the tabs.map function, which is then used to alter the state and show other tabs, becoming *active* */

    return <div>
        {tabs.map((tab, i)=>
        <button onClick={e=>setactiveTab(i)}>Tab {i+1}</button>)}
        <p> {tabs[activeTab]}</p>
        <form>
            
        </form>
    </div>
}

export default Tabs

// import React, { useState } from 'react';

// const items = [
//     {label: "Tab 1", content:"Tab 1 content is showing here"},
//     {label: "Tab 2", content:"Tab 2 content is showing here"},
//     {label: "Tab 3", content:"Tab 3 content is showing here"}
// ];

// let checkTab = true;
// let checkContent = true;

// const Tabs = () => {
//     const [ state, setState ] = useState({
        
//     })
//     const onChangeHandler = event => {
//         setState({
//             ...state,
//             [event.target.name]: event.target.value
//         })
//     }

//     const onClickHandler = event => {
//         event.target.className = "nav-link active"
//     }

//     const tabBar = item => {
//         if (checkTab) {
//             checkTab = false;
//             return (
//                 <li class="nav-item">
//                     <a class="nav-link active" data-toggle="tab" href={item.label} role="tab" aria-selected="true">{item.label}</a>
//                 </li>
//             )
//         } else {
//             return (
//                 <li class="nav-item">
//                     <a class="nav-link" data-toggle="tab" href={item.label} role="tab" aria-selected="false" onClick={onClickHandler}>{item.label}</a>
//                 </li>
//             )
//         }
//     }

//     const contentBar = content => {
//         if (checkContent) {
//             checkContent = false;
//             return (
//                 <div class="tab-pane fade show active" role="tabpanel">{content.content}</div>
//             )
//         } else {
//             return (
//                 <div class="tab-pane fade" role="tabpanel">{content.content}</div>
//             )
//         }
//     }

//     return (
//         <div class="container">
//             <ul class="nav nav-tabs" id="myTab" role="tablist">
//                 {items.map(tabBar)}
//             </ul>
//             <div class="tab-content" id="myTabContent">
//                 {items.map(contentBar)}
//             </div>
//         </div>
//     );
// }

// export default Tabs;