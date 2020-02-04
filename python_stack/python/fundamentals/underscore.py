# Assignment: Underscore

class Underscore:
    def map(self, iterable, callback):
        newList = []
        for i in range(0, len(iterable), 1):
            newList.append(callback(iterable[i]))
        return newList

    def find(self, iterable, callback):
        newList = []
        for i in range(0, len(iterable), 1):
            if callback(iterable[i]):
                newList.append(iterable[i])
        return newList

    def filter(self, iterable, callback):
        newList = []
        for i in range(0, len(iterable), 1):
            if callback(iterable[i]):
                newList.append(iterable[i])
        return newList

    def reject(self, iterable, callback):
        newList = []
        for i in range(0, len(iterable), 1):
            if not callback(iterable[i]):
                newList.append(iterable[i])
        return newList

# you just created a library with 4 methods!
# let's create an instance of our class
_ = Underscore() # yes we are setting our instance to a variable that is an underscore
evens = _.filter([1, 2, 3, 4, 5, 6], lambda x: x % 2 == 0)
# should return [2, 4, 6] after you finish implementing the code above

_.map([1,2,3], lambda x: x*2) # should return [2,4,6]
_.find([1,2,3,4,5,6], lambda x: x>4) # should return the first value that is greater than 4copy
_.filter([1,2,3,4,5,6], lambda x: x%2==0) # should return [2,4,6]
_.reject([1,2,3,4,5,6], lambda x: x%2==0) # should return [1,3,5]

