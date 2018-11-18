#And,  OR,  Not

high_income = True
good_credit = False

if high_income and good_credit:
  print("Great, we can do business!")
else:
  print("Sorry, you do not qualify this time.")


print("#" *20)


high_income = True
good_credit = False
student = False

if (high_income and good_credit) and not student:
  print("Great, we can do business!")
elif (high_income or good_credit) and student:
  print("Yes, let's discuss further inside.")
else:
  print("Sorry, you do not qualify")

print("Done!")