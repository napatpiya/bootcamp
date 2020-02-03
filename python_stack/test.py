my_dict = { "name": "Noelle", "language": "Python" }

# another way to iterate through the keys
for key in my_dict.keys():
     print(key)
#to iterate through the values
for val in my_dict.values():
     print(val)
#to iterate through both keys and values
for key, val in my_dict.items():
     print(key, " = ", val)