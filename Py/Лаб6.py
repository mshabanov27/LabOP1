def calcRoot(n, x):
    if n == 0:
        return x
    else:
        return 0.2 * ((x / pow(calcRoot(n - 1, x), 4)) + (4 * calcRoot(n - 1, x)))


a = input("Enter number a: ")
while float(a) <= 0:
         a = input("The number should be positive, try again: ")

b = input("Enter number b: ")
while float(b) <= 0:
         b = input("The number should be positive, try again: ")

accuracy = input("Enter how accurate the result should be: ")
while float(accuracy) <= 0:
         accuracy = input("The accuracy can be positive only, try again: ")

resultY = calcRoot(float(accuracy), calcRoot(float(accuracy), float(a) * float(b)) + calcRoot(float(accuracy), float(a)))
print(resultY)
