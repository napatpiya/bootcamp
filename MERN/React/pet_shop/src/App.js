import React, { useState } from 'react';
import './App.css';
import PetComponent from './components/pet-component';
import Messages from './components/messages';
import PetForm from './components/pet-form';

const startingPets = [
  {species: "doggo", noise:"awooo~", backgroundColor: "rebeccapurple", color:"#fff"},
  {species: "turtle", noise:"...", backgroundColor: "tomato", color:"#fff"},
  {species: "parrot", noise:"Artemis Fowl", backgroundColor: "mediumseagreen", color:"#fff"},
  {species: "cat", noise:"nyan", backgroundColor: "orange", color:"#000"}
];


function App(props) {

  const [messages, setMessages] = useState(['starting message!']);
  const [pets, setPets] = useState(startingPets);

  const petInfoFromChild = yourNewMessage => {
    setMessages( [yourNewMessage, ...messages] );
  }

  const youveGotPets = newPet => {
    setPets( [...pets, newPet] );
  }

  return (
    <>
      <h1>Welcome to {props.name}'s petshop</h1>
      <Messages msgs={messages} />
      {
        pets.map( (pet, i) => 
        <PetComponent
          key={i}
          species={pet.species}
          noise={pet.noise}
          backgroundColor={pet.backgroundColor}
          color={pet.color}
          infoToParent={ petInfoFromChild }
        />
        )
      }
      <PetForm giveAPetToTheParent={ youveGotPets } />
    </>
  );
}

export default App;