import React, { useState } from 'react';

const Pokemon = props => {

    const [pokemons, setPokemons] = useState([]);
    const [showpoke, setShowpoke] =  useState(false);

    const getPokemon = e => {
        e.preventDefault();
        setPokemons([]);
        fetch("https://pokeapi.co/api/v2/pokemon")
          .then(response => {
            return response.json();
        }).then(response => {
            console.log(response.results)
            let allpoke = response.results;
            {allpoke.map( (poke) => setPokemons(pokemons.push(poke)))};
            console.log(pokemons[1].name);
            setShowpoke(true);
        }).catch(err=>{
            console.log(err);
        });
    }

    return (
        <div className="container">
            <button className="btn btn-outline-danger" onClick={getPokemon}>Fetch Pokemon</button>
            <ul>
                {/* {showpoke ? <li>{pokemons[1]}</li> : <p></p>} */}
            </ul>
        </div>
    );
}

export default Pokemon;