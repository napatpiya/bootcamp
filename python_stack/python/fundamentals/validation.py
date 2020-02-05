def braceValid1(string):
    parens = 0
    brace = 0
    bracket = 0
    arr = []
    for i in range(len(string)):
        if string[i] == "(":
            parens += 1
            arr.append(string[i])
        if string[i] == ")":
            parens -= 1
            if arr[len(arr)-1] == "(":
                arr.pop()
        if string[i] == "{":
            brace += 1
            arr.append(string[i])
        if string[i] == "}":
            brace -= 1
            if arr[len(arr)-1] == "{":
                arr.pop()
        if string[i] == "[":
            bracket += 1
            arr.append(string[i])
        if string[i] == "]":
            bracket -= 1
            if arr[len(arr)-1] == "[":
                arr.pop()
        
        if parens < 0 or brace < 0 or bracket < 0:
            print("premature closing symbol")
            return False

    if parens > 0 or brace > 0 or bracket > 0:
            print("premature closing symbol")
            return False
    elif len(arr) > 0:
        print("symbols not in valid order")
        return False
    else:
        return True

def braceValid2(string):
    newlist = []
    for i in range(len(string)):
        if string[i] in ('(','{','['):
            newlist.append(string[i])
        elif string[i] == ')':
            if newlist[len(newlist)-1] == '(':
                newlist.pop()
            else:
                return False
        elif string[i] == '}':
            if newlist[len(newlist)-1] == '{':
                newlist.pop()
            else:
                return False
        elif string[i] == ']':
            if newlist[len(newlist)-1] == '[':
                newlist.pop()
            else:
                return False
    if len(newlist) != 0:
        return False
    else:
        return True

print(braceValid1(['(',')','[',']','{','}']))
print(braceValid1(['[','[','{','(',')','}',']',']']))
print(braceValid2(['(','[','{','}',']',')']))
print(braceValid2(['[','{',']','}','(',')']))