# def bookIndex(somelist):
#     newstr = ""
#     start = somelist[0]
#     stop = somelist[0]
#     for i in range(1, len(somelist)):
#         if somelist[i] == stop+1:
#             stop = somelist[i]
#         elif stop == start:
#             newstr += f"{str(start)}, "
#             start = somelist[i]
#             stop = somelist[i]
#         else:
#             newstr += f"{str(start)}-{str(stop)}, "
#             start = somelist[i]
#             stop = somelist[i]
#     if stop == start:
#             newstr += f"{str(start)}, "
#     else:
#         newstr += f"{str(start)}-{str(stop)}, "


#     return newstr

def bookIndex(somelist):
    result = str(somelist[0])
    prev = somelist[0]
    for i in range(1, len(somelist)):
        if prev + 1 == somelist[i]:
            if i == len(somelist) -1:
                result = result
            else: 
                result[-1] != "-"
                result += "-"
        else:
            if result[-1] != "-":
                result += ", " + str(somelist[i])
            else:
                result += str(somelist[i-1]) + ", "
        if result[-1] == " ":
            result += str(somelist[i])
        
        print("{} | {}".format(i, result))
        prev = somelist[i]
    return result

print(bookIndex([1,2,3,8,10,11,12,20,30,31]))