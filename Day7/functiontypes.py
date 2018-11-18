# there are two types of function implementations in programming.

# returned functions  and print functions

# 1. functions that performs a task, like printing or outputing a value

# 2. functions that calculates and returns a value


# print function

def greet(name):
  print(f"Hi, {name}")


# returned function

def get_greet(name):
  return f" Hi, {name}"


#calling the function
# case 1
greet("Fred")
#case 2
print(greet("Ethel"))  # A none object is returned default value of the greet function

# A none represents the absence of a value.

#using the returned value function with a file/open function

message = get_greet("Emma")

file = open("test.txt", "w")

file.write(message)
