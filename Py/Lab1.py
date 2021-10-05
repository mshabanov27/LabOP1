import math

a = input("Введите меньшее основание: ")
b = input("Введите большее основание: ")
h = input("Введите высоту: ")
S = (float(a) + float(b)) * float(h) / 2
c = math.sqrt(((float(b) - float(a))/2)**2 + float(h)**2)
P = float(a) + float(b) + 2 * float(c)
print("Площадь равна " + str(S))
print("Периметр равен " + str(P))