#!/bin/python3

import re

nm = input().split()
n = int(nm[0])
m = int(nm[1])
matrix = []

for _ in range(n):
    matrix_item = input()
    matrix.append(matrix_item)

b = ""

for z in zip(*matrix):
    b += "".join(z)

print(re.sub(r"(?<=\w)([^\w]+)(?=\w)", " ", b))
