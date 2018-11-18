# Global variable are accessible anywhere within the file

message = "a"

def scope():

  #bad pratice of declaring a global variable  e.g 
  global message
  message = "b"  # unused variable


   # note that message can not be found or cant access where its defined or created within the function scope
scope()
print(message)   # this will only access and print the global variable outside the scope.


#Take home - always use local scope, which has a short life span in the allocated memory before going to the garbage collector

