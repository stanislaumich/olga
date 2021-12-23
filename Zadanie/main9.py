import math

print('Введите a') # выводим на экран приглашение
a=int(input())
print('Введите b') # выводим на экран приглашение
b=int(input())

a1=(math.cos(a)-math.cos(b))**2 - (math.sin(a)-math.sin(b))**2
print('a1=')
print(a1) # выводим на экран

a2=(-4*(math.sin((a-b)/2))**2)*math.cos(a+b)
print('a2=')
print(a2) # выводим на экран

quit()
