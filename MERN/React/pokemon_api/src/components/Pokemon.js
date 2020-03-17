import React, { useState } from 'react';
import axios from 'axios';


const Pokemon = () => {
    const [pokeName, setPoke]=useState([]);
    const getPoke = e =>{
        axios.get("https://pokeapi.co/api/v2/pokemon?offset=0&limit=807")
        .then( res => setPoke(res.data.results));
    }

    return (
        <div className="container">
            <button onClick = {getPoke} className ="btn btn-lrg btn-dark">Fetch pokemon</button>
            <ul>
            {
                pokeName.map((pokemon,i) =>
                <li className= "list-group-item" key = {i}>{pokemon.name}</li>
                )
            }
            </ul>
        </div>
    );
        
}

export default Pokemon;