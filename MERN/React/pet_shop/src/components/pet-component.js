import React, { useState } from 'react';


const PetComponent = props => {
  const [petsReceived, givePets] = useState(1);

  const pet = event => {
    event.target.style.backgroundColor = props.backgroundColor;
    event.target.style.color = props.color;
    givePets( petsReceived + 1 );
    props.infoToParent(`${props.noise} - The ${props.species} has been petted ${petsReceived} time(s)`);
  }

  return (
    <fieldset>
      <legend>{ props.species }</legend>
      <button onClick={ pet }>Pet the { props.species }</button>
    </fieldset>
  )
}

export default PetComponent;