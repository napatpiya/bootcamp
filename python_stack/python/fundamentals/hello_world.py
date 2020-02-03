# 1. TASK: print "Hello World"
print("Hello World")
# 2. print "Hello Noelle!" with the name in a variable
name = "Napat"
print("Hello", name)	# with a comma
print("Hello " + name)	# with a +
# 3. print "Hello 42!" with the number in a variable
num = 6
print(f"Hello", num)	# with a comma
print(f"Hello " + str(num))	# with a +	-- this one should give us an error!
# 4. print "I love to eat sushi and pizza." with the foods in variables
fave_food1 = "sushi"
fave_food2 = "pizza"
print("I love to eat {} and {}".format(fave_food1, fave_food2)) # with .format()
print(f"I love to eat {fave_food1} and {fave_food2}.") # with an f string
# 5. print "My favorites sport are soccer and basketball" with %-formatting
fave_sport1 = "soccer"
fave_sport2 = "basketball"
print("My favorites sport are %s and %s." % (fave_sport1, fave_sport2))
# 6. use string.upper() and string.lower()
name1 = "hello"
name2 = "WORLD"
print(name1.upper(), name2.lower())
# 7. check type value in string
s1 = "Hello123"
s2 = "1234"
s3 = "hello"
s4 = "HELLO"
print(s1.isalnum())
print(s3.isalpha())
print(s2.isdigit())
print(s3.islower())
print(s4.isupper())
# 8. Count occurences in string
s1 = "aabbbccccddddd"
print(s1.count('c'))
# 9. sprit char
print(s1.split('b'))
# 10. find substring
print(s1.find('cccc'))
# 11. join list
s1 = ['Hello', 'World']
print('#'.join(s1))
# 12. check last string
s1 = ("Hello World")
print(s1.endswith('World'))