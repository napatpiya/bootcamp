const { Product } = require('../models/product.models');

module.exports.index = (request, response) => {
    response.json({
        message: "Hello World"
    });
}

module.exports.getAllProduct = (request, response) => {
    Product.find({})
        .then(products => {
            response.json(products)
            response.json("aaaaaaa")
        })
        .catch(err => response.json(err));
}

module.exports.getProduct = (req, res) => {
    Product.findOne({"_id": req.params._id})
        .then(product => res.json(product))
        .catch(err => res.json(err))
}

module.exports.createProduct = (request, response) => {
    const { title, price, desc } = request.body;
    Product.create({
        title,
        price,
        desc
    })
        .then(product => response.json(product))
        .catch(err => response.json(err));
}

module.exports.updateProduct = (req, res) => {
    Product.findByIdAndUpdate({_id: req.params.id}, req.body, {new:true})
        .then(updateProduct => res.json(updateProduct))
        .catch(err => res.json(err));
}

module.exports.deleteProduct = (req, res) => {
    Product.findByIdAndDelete({_id: req.params.id})
        .then(deleteConfirm => res.json(deleteConfirm))
        .catch(err => res.json(err));
}