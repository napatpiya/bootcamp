s = ")(()"

def validation(s):
    check = 0
    for i in range(len(s)):
        if s[i] == "(":
            check += 1
        elif s[i] == ")" and check != 0:
            check -= 1
    if check != 0:
        return "invalid"
    
    return "valid"


# print(validation(s))


a = [1,3,5,7,9]

print(a)

a[0], a[2] = a[2], a[0]
print(a)


my_arr = [1,2,3,4,5]
# define a function that squares values
def square(num):
    return num ** 2
# invoke map function
print(list(map(square, my_arr)))
print(my_arr)

my_list = list(map(square, my_arr))
print(my_list)


# map()
# reduce()
# sort() - lambda is optional
# filter()