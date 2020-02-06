def palindrome(somelist):
    for i in range(len(somelist)//2):
        if somelist[i] != somelist[len(somelist)-i-1]:
            return False
    return True

print(palindrome(['t','a','c','o','c','a','t']))
print(palindrome(['t','a','c','o','c','t']))