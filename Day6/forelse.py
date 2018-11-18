login = False

for number in range(3):
  print("Atempt connection", number*".")
  if login:
    print("Login successful")
    break
else:
    print("Attemped 3 times")

    # types of iteration

    # using range, list, or strings to iterate

for x in "python":
  print (x)

for x in [1,2,3,4,5,6]:
  print(x)
  