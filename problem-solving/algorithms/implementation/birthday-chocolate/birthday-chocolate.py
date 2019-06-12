#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the birthday function below.
def birthday(n, s, d, m):
    return sum(sum(s[i: i + m]) == d for i in range(n - m + 1))

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input().strip())

    s = list(map(int, input().rstrip().split()))

    dm = input().rstrip().split()

    d = int(dm[0])

    m = int(dm[1])

    result = birthday(n, s, d, m)

    fptr.write(str(result) + '\n')

    fptr.close()
