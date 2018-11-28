import json

data = json.load(open("datasrc.json"))

def translate(w):
  w = w.lower()
  if w in data:
      return data[w]
  else:
      return "Doesnt exist"



word = input("Kindly enter a word: ")

print(translate(word))