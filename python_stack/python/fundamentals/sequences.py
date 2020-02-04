my_list = [99,4,2,5,-3,120]
my_tuple = (99,4,2,5,-3)
my_str = "sequoia"
print(my_list[:])
# output: [99,4,2,5,-3]
print(my_tuple[1:])
# output: (4,2,5,-3)
print(my_str[:3])
# output: "seq"
print(my_tuple[2:4])
# output: (2,5)
print(my_list, my_tuple, my_str)
# output: [99,4,2,5,-3] (99,4,2,5,-3) 'sequoia' -- note the original values have not changed


# max(sequence) returns the largest value in the sequence
print(max(my_list))
# sum(sequence) returns the sum of all values in sequence
print(sum(my_tuple))
# map(function, sequence) applies the function to every item in the sequence you pass in. Returns a list of the results.
print(map(lambda num: num+1, my_list))
# min(sequence) returns the lowest value in a sequence.
print(min(my_list))
# sorted(sequence) returns a sorted list of the sequence's values
print(sorted(my_list))
print(sorted(my_str))