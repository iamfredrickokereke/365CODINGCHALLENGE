#import the json library for external datasource
import json
from difflib import get_close_matches

# load the file in a variab
data_file = json.load(open("datasrc.json"))

# function to translate input

def translate(word):  

  # convert user input to upper case string
  word = word.upper()

  # check if string received exist else return message  
  if word in data_file:
      return data_file[word]
  elif len(word) > 0:
    checkss = input(f"Does your word require? these {get_close_matches(word, data_file.keys())[0]} if yes type Y or type N if no: ")
    if checkss == "Y":
        return get_close_matches(word, data_file.keys())[0]
    else:
      return "DOESN'T EXIST!"
      

# Store user input and print out by calling the translate function
user_input = input("Enter your word:  ")

input = translate(user_input)

if type(input) == list:
    for item in input:
        print(item)
else:
        print(input)