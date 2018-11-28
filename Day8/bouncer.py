import pydoc

age = int(input("How old are you?"))

if 18 <= age <=21:
  print("Welcome, kindly wear a wristband")
elif age > 21:
  print("Enjoy the party")
else:
  print("Kindly go home, you are underaged!")