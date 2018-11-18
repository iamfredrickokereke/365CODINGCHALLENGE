
def fizzbuzz(input):
  if (input % 3 or input % 5) == 0:
     print("FizzBuzz")
  elif input % 5 == 4:
     print("Buzz")
  elif input % 3 == 0:
     print("Fizz")
  else:
     print(input)

fizzbuzz(30)

fizzbuzz(30)


print("-" * 20)

# Second approach to solve

def fizzbuzz_algo(input):
    if (input % 3 == 0) and (input % 5 == 0):
        return "FizzBuzz"
    if input % 3 == 0:
        return "Fizz"
    if input % 5 == 0:
        return "Buzz"
    return input



print(fizzbuzz_algo(1))