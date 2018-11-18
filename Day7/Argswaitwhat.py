
# using *args wait and what

# instances where more than one parameter is needed.

def add(*numbers):
    total = 1
    for number in numbers:
      total +=number
    return total


print(add(4,3,4,5,6))  # this returns a tuple that is iterable but not modifiable


# we could also store values from users and using key value pair

def save_user(**user):
    print(user)  # returns the arguments entered
    print(user["name"])  # prints value associated with the key


save_user(id=1, name = "fred")  # key value pair are inputed as arguments which returns an object