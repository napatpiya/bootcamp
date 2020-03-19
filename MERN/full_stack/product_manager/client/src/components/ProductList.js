import React from 'react';
import axios from 'axios';
import { Link, navigate } from '@reach/router';

export default props => {
    
    const { removeFromDom } = props;
    const deleteProduct = (productId) => {
        axios.delete('http://localhost:8000/api/product/' + productId)
            .then(res => {
                removeFromDom(productId)
            })
    }

    return (
        <div>
            <h3>All Products:</h3>
            {props.product.map( (product, i) => {
                return(
                    <div key={i}>
                        <Link to={"/product/"+product._id}><h5>{product.title}</h5></Link>
                        <button onClick={() => navigate(`/product/${product._id}/edit`)}>Edit</button>
                        {" | "}
                        <button onClick={(e) => {deleteProduct(product._id)}}>Delete</button>
                    </div>
                )
            })}
        </div>
    )
}
