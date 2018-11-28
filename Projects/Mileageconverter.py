#A simple program which tells your distance convered in miles
#it can be improved to convert from any unit to mileage
# 
# 
# Commence
# 
# Request distance
# 

print("Enter your distance convered ")
kms = float(input(">> "))
miles = kms / 1.6039

print(f"Your distance cycled is {kms} kilometers but {round(miles, 3)} in miles ")

# KILOMETERS_TO_MILES =float(0.6214)




# def main():
#     Distance = input("please input the distance in kilometers to wish to convert:")
#     showMiles(Distance)

# def showmiles(Distance):
#     miles = Distance * KILOMETERS_TO_MILES
#     print=("Conversion of ", Distance,"kilometers to miles: ", miles, "miles")

# main()