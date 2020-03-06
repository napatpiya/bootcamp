import React, { component } from 'react';
import './App.css';
// import { Provider } from 'styletron-react';
// import { Client as Styletron } from 'styletron-engine-atomic';
// import Styletron from 'styletron';
//import NewComponent from './components/NewComponent';
//import HelloWorld from './components/HelloWorld';
//import PersonCard from './components/PersonCard';
// import PersonCard2 from './components/PersonCard2';
import PersonCard3 from './components/PersonCard3';
import SomeOtherComponent from './components/SomeOtherComponent';
//import MyNewComponent from './components/MyNewComponent';

// function App() {
//     return (
//       <div className="App">
//         <NewComponent />
//       </div>
//     );
// }


// NOTE: We could have just as easily deconstructed our props.
// const Button = (props) => {
//       return (
//   // Remember -- props becomes an object containing all of the keys and values passed in from the parent component
//           <button onClick={props.click}>{props.text}</button>
//       );
// }
// const App = () => {
//     // We can define the click event handler function here so that the event is fired in this component 
//     // instead of the child component.
//     const clickHandler = () => console.log("Clicked");
//     // The text for the button will also come from this component
//     const buttonOneText = "I am the first button being clicked";
//     const buttonTwoText = "And I am the second button being clicked";
//     // This is where we are sending all the "props" down.
//     return (
//         <div>
//              <Button text={buttonOneText} click={clickHandler} />
//              <Button text={buttonTwoText} click={clickHandler} />
//         </div>
//     );
// }


// ### MyNewComponent ###
// function App() {
//   return (
//     <div className="App">
//       <MyNewComponent header={"Header Prop"}>
//         <p>This is a child</p>
//         <p>This is another child</p>
//         <p>This is even another child</p>
//       </MyNewComponent>
//     </div>
//   );
// }

// ### HelloWorld ###
// function App() {
//   return (
//     <div className="App">
//       <HelloWorld />
//     </div>
//   );
// }

// const engine = new Styletron();

// ### PersonCard ###
function App() {
  return (
      <div className="App">
        {/* <PersonCard3 firstName="Doe" lastName="Jane" age={45} hairColor="Black" />
        <PersonCard3 firstName="Smith" lastName="John" age={88} hairColor="Brown" />
        <PersonCard3 firstName="Fillmore" lastName="Millard" age={50} hairColor="Brown" />
        <PersonCard3 firstName="Smith" lastName="Maria" age={62} hairColor="Brown" /> */}
        <SomeOtherComponent />
      </div>
  );
}

export default App;
