import random

def randInt(min=0 , max=100):
    if max<0:
        return "Max value less than 0"
    elif min>max:
        tmp = max
        max = min
        min = tmp
        print("Min value less than max value (we swap it!)")
    num = random.random() * (max-min) + min
    return num

print(randInt())
print(randInt(max=50))
print(randInt(min=50))
print(randInt(min=50, max=500))
print(randInt(max=-3))
print(randInt(min=500, max=10))