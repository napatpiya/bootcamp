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


print(validation(s))