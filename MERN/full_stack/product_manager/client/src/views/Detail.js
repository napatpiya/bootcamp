import React, { useEffect, useState } from 'react'
import axios from 'axios';
import { navigate } from '@reach/router';

export default props => {
    const [product, setProduct] = useState({})

    // useEffect(() => {
    //     axios.get("http://localhost:8000/api/product/" + props.id)
    //         .then(res => setProduct({
    //             ...res.data
    //         }))
    // }, [])

    useEffect(() => {
        axios.get("http://localhost:8000/api/product/" + props.id)
            .then(res => setProduct({...res.data}))
            .catch(err => console.log(err));
    }, [])

    const deleteProduct = (productId) => {
        axios.delete('http://localhost:8000/api/product/' + productId)
            .then(res => navigate("/product"))
    }

    return (
        <div>
            <p>Title: {product.title}</p>
            <p>Price: {product.price}</p>
            <p>Description: {product.desc}</p>
            <button onClick={() => navigate("/product")}>Home</button>
            {" | "}
            <button onClick={() => navigate(`/product/${props.id}/edit`)}>Edit</button>
            {" | "}
            <button onClick={(e) => {deleteProduct(props.id)}}>Delete</button>
        </div>
    )
}
