i = 100
while i <= 200:
    dflt = 0
    j = i
    while j != 0:
        dflt = dflt + j % 10
        j = j // 10
    if dflt >= 10:
        dflt2 = 0
        f = dflt
        while f != 0:
            dflt2 = dflt2 + f % 10
            f = f // 10
        if dflt2 >= 10:
            dflt3 = 0
            k = dflt2
            while k != 0:
                dflt3 = dflt3 + k % 10
                k = k // 10
            if i % dflt3 == 0:
                print(f"{i} is {dflt3}")
        else:
            if i % dflt2 == 0:
                print(f"{i} is {dflt2}")
    else:
        if i % dflt == 0:
            print(f"{i} is {dflt}")
    i = i + 1
