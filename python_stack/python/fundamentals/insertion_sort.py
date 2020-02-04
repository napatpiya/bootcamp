def insertion_sort(someList):
    for i in range(0, len(someList)-1, 1):
        for j in range(i+1, 0, -1):
            if someList[j] < someList[j-1]:
                someList[j-1], someList[j] = someList[j], someList[j-1]

    return someList

print(insertion_sort([4,3,5,1,2]))
print(insertion_sort([6,5,3,1,8,7,2,4]))
