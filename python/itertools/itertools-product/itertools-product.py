from itertools import product

first = list(map(int, input().split()))
second = list(map(int, input().split()))

print(*product(first, second))