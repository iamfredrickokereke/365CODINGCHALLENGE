import json
from difflib import get_close_matches

data = json.load(open("datasrc.json"))

def translate(word):
  #first check for non existing words
  word = word.lower()
  if word in data:
    return data[word]
  else:
    return "it doesnt exist"
    


word = input("Enter your word: ")

word = translate(word)

print(word)