def strSubsets(somestr):
    newlist = []
    if len(somestr) == 0:
        newlist.append("")
        return newlist
    else:
        newlist = strSubsets(somestr[1:])
        newlist.append(somestr[0])
        for i in range(len(somestr)-1):
            s = somestr[0]
            for j in range(len(somestr)-i-1, len(somestr), +1):
                s = s + somestr[j]
                newlist.append(s)
    return newlist

somestr = "abcde"
print(strSubsets(somestr))
