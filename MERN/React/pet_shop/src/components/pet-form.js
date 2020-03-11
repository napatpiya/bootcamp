import React, { useState } from 'react';


const PetForm = props => {

    const [species, setSpecies] = useState("");
    const [noise, setNoise] = useState("");
    const [backgroundColor, setBColor] = useState("");
    const [color, setColor] = useState("");

    const addPet = e => {
        e.preventDefault();
        let newPet = { color, noise, backgroundColor, species };
        props.giveAPetToTheParent( newPet );
        setNoise("");
        setSpecies("");
        setBColor("#ffffff");
        setColor("#000000");
      }

    return (
        <form onSubmit={addPet} >
            <p>
                Species
                <input 
                    type="text" 
                    onChange={ e => setSpecies(e.target.value) } 
                    value={ species }
                />
            </p>
            <p>Noise <input type="text" onChange={ e => setNoise(e.target.value) } value={noise} /></p>
            <p>Background <input type="color" onChange={ e => setBColor(e.target.value) } value={backgroundColor}/></p>
            <p>Text Color <input type="color" onChange={ e => setColor(e.target.value) } value={color} /></p>
        <input type="submit" />
      </form>
    );
}

export default PetForm;