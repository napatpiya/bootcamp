# Biggie Size - Given a list, write a function that changes all positive numbers in the list to "big".
# Example: biggie_size([-1, 3, 5, -5]) returns that same list, but whose values are now [-1, "big", "big", -5]
def biggieSize(arr):
    for i in range(len(arr)):
        if arr[i] > 0:
            arr[i] = "big"
    return arr

print(biggieSize([-1,3,5,-5]))


# Count Positives - Given a list of numbers, create a function to replace the last value with the number of positive values. (Note that zero is not considered to be a positive number).
# Example: count_positives([-1,1,1,1]) changes the original list to [-1,1,1,3] and returns it
# Example: count_positives([1,6,-4,-2,-7,-2]) changes the list to [1,6,-4,-2,-7,2] and returns it
def countPositives(arr):
    count = 0
    for i in range(len(arr)):
        if arr[i] > 0:
            count += 1
    arr.pop()
    arr.append(count)

    return arr

print(countPositives([-1,1,1,1]))
print(countPositives([1,6,-4,-2,-7,-2]))


# Sum Total - Create a function that takes a list and returns the sum of all the values in the array.
# Example: sum_total([1,2,3,4]) should return 10
# Example: sum_total([6,3,-2]) should return 7
def sumTotal(arr):
    sum = 0
    for i in range(len(arr)):
        sum += arr[i]
    return sum

print(sumTotal([1,2,3,4]))
print(sumTotal([6,3,-2]))


# Average - Create a function that takes a list and returns the average of all the values.
# Example: average([1,2,3,4]) should return 2.5
def average(arr):
    sum = 0
    avg = 0
    for i in range(len(arr)):
        sum += arr[i]
    avg = sum/len(arr)
    return avg

print(average([1,2,3,4]))


# Length - Create a function that takes a list and returns the length of the list.
# Example: length([37,2,1,-9]) should return 4
# Example: length([]) should return 0
def lengthList(arr):
    return len(arr)

print(lengthList([37,2,1,-9]))
print(lengthList([]))


# Minimum - Create a function that takes a list of numbers and returns the minimum value in the list. If the list is empty, have the function return False.
# Example: minimum([37,2,1,-9]) should return -9
# Example: minimum([]) should return False
def minimum(arr):
    if len(arr) == 0:
        return False
    min = arr[0]
    for i in range(len(arr)):
        if arr[i] < min:
            min = arr[i]
    return min

print(minimum([37,2,1,-9]))
print(minimum([]))


# Maximum - Create a function that takes a list and returns the maximum value in the array. If the list is empty, have the function return False.
# Example: maximum([37,2,1,-9]) should return 37
# Example: maximum([]) should return False
def maximum(arr):
    if len(arr) == 0:
        return False
    max = arr[0]
    for i in range(len(arr)):
        if arr[i] > max:
            max = arr[i]
    return max

print(maximum([37,2,1,-9]))
print(maximum([]))


# Ultimate Analysis - Create a function that takes a list and returns a dictionary that has the sumTotal, average, minimum, maximum and length of the list.
# Example: ultimate_analysis([37,2,1,-9]) should return {'sumTotal': 31, 'average': 7.75, 'minimum': -9, 'maximum': 37, 'length': 4 }
def analysis(arr):
    newDic = {}

    max = arr[0]
    min = arr[0]
    sum = 0
    avg = 0

    for i in range(len(arr)):
        if max < arr[i]:
            max = arr[i]
        if min > arr[i]:
            min = arr[i]
        sum += arr[i]
    
    avg = sum/len(arr)

    newDic['sumTotal'] = sum
    newDic['average'] = avg
    newDic['minimum'] = min
    newDic['maximum'] = max
    newDic['length'] = len(arr)

    return newDic

print(analysis([37,2,1,-9]))


# Reverse List - Create a function that takes a list and return that list with values reversed. Do this without creating a second list. (This challenge is known to appear during basic technical interviews.)
# Example: reverse_list([37,2,1,-9]) should return [-9,1,2,37]
def reverseList(arr):
    for i in range(0, int((len(arr)/2)), 1):
        tmp = arr[len(arr)-i-1]
        arr[len(arr)-i-1] = arr[i]
        arr[i] = tmp
    return arr

print(reverseList([37,2,3,1,-9]))
