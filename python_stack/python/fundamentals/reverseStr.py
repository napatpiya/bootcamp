def reverseStr(someString):
	newString = ""
	for i in range(len(someString)-1, -1, -1):
		newString += someString[i]
	return newString

print(reverseStr("Hello"))
