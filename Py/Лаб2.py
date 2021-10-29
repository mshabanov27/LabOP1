k = input("Введите число k: ")
if int(k) % 2 == 1:
                num = int(k) // 20 + 1
                print("Цифра дорівнює: " + str(num))
elif int(k) % 2 == 0:
                num = ((int(k) // 2) - 1) % 10
                print("Цифра дорівнює: " + str(num))
