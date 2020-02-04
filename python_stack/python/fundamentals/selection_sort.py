def selection_sort(someList):
    for i in range(0, len(someList), 1):
        check = i
        for j in range(i+1, len(someList), 1):
            if someList[j] < someList[check]:
                check = j
        someList[i], someList[check] = someList[check], someList[i]
    return someList

# print(selection_sort([4,3,2]))
print(selection_sort([8,5,2,6,9,3,1,4,0,7]))