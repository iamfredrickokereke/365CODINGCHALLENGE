# file = open("example.txt","w")
file = open("example.txt","r")
# use print(file.readable()) to check if its readable
content = file.read()

#file.readline will return the exact line to return from content, 
#file.seek() will return its pointer to the start head position
print(content)


# Also note that using file.write(".....") will enter strings into the specified file but wont be accessible until its closed

# file.close() is used to close the file session and make it exitable

# to add content we will use

newfile = open("newfile","w")
items = ["food","money","others"]
for item in items:
   newfile.write(item+"\n")

#to view the new file content use newfile.close().

newfile.close()

#but cant add to the existing file while open using write method except by appending

# using file = open("tt.tt","a")

#using a with state where its false or file isnt closed

with open("test","a+") as oldfile:
      oldfile.seek(0)
      content2 = oldfile.read()
      oldfile.write("\n its working")
