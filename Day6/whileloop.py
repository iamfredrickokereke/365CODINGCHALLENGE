number = 25

while number > 0:
  print(number)
  number //= 2



# my interactive shell program

command = ""

while command != "quit":
  command = input(">>> ").lower()
  print("Echo", command)