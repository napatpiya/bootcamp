String.prototype.hash = function() {

    let result = 0;
    for(let i=0; i<this.length; i++) {
      result += this.charCodeAt(i);
    }
    return result;
  }
  
  
  class HashTable {
    constructor(cap = 10) {
      this._table = []
      for (var i = 0; i < cap; i++){
        this._table.push([]);
      }
    }
  
    put(key, value) {
      let index = key.hash() % this._table.length;
      for(var i = 0; i < this._table[index].length; i+=2){
        if (this._table[index][i] == key){
          this._table[index][i+1] = value;
          return this
          }
        }
  
      this._table[index].push(key);
      this._table[index].push(value);
  
      return this
    }
  
    get(key) {
      let index = key.hash() % this._table.length;
      for(var i = 0; i < this._table[index].length; i+=2){
       if (this._table[index][i] == key){
         return this._table[index][i+1]
  
       }
  
      }
      throw new Error(`Key Error: ${key} not present!`)
    }
  
  }
  const h1 = new HashTable(3);
  h1.put("fruit", "yes");
  h1.put("fruit", "no");
  h1.put("vegetable", "carrots");
  h1.get("Meat");
  console.log(h1._table);