import json

from difflib import get_close_matches

data = json.load(open("datasrc.json"))

def translate(w):
  w = w.lower()
  if w in data:
      return data[w]
  elif len(get_close_matches(w, data.keys())) > 0:
      user_option = input(f"Did you mean {get_close_matches(w, data.keys())[0]} instead? Enter Y as yes or N as No:")
      if user_option == "Y":
          return data[get_close_matches(w, data.keys())[0]]
      else:
          return "Entry do not exist"
  else:
      return "Doesnt exist"



word = input("Kindly enter a word: ")

output = translate(word)

if type(output) == list:
    for item in output:
        print(item)
else:
    print(output)



# print(output)