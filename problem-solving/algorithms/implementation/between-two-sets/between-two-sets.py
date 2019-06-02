#!/bin/python3

import os
import sys
import functools
import math

#
# Complete the getTotalX function below.
#
def getTotalX(a, b):
    g = functools.reduce(math.gcd, b)
    lcm = functools.reduce(lambda x, y: (x * y) // math.gcd(x, y), a)
    return sum(g%l==0 for l in range(lcm, g+1, lcm))

if __name__ == '__main__':
    f = open(os.environ['OUTPUT_PATH'], 'w')

    nm = input().split()

    n = int(nm[0])

    m = int(nm[1])

    a = list(map(int, input().rstrip().split()))

    b = list(map(int, input().rstrip().split()))

    total = getTotalX(a, b)

    f.write(str(total) + '\n')

    f.close()
