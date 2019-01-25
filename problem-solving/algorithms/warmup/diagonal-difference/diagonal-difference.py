#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the diagonalDifference function below.
def diagonalDifference(arr):
    arr_length = len(arr)
    primary_sum = 0
    secondary_sum = 0

    for i in range(arr_length):
        primary_sum += arr[i][i]
    
    for j in range(arr_length):
        secondary_sum += arr[j][arr_length-1]
        arr_length = arr_length - 1
    
    return abs(primary_sum - secondary_sum)

if __name__ == '__main__':
    # fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = []

    for _ in range(n):
        arr.append(list(map(int, input().rstrip().split())))

    result = diagonalDifference(arr)

    print(str(result))

    # fptr.write(str(result) + '\n')
    # fptr.close()
