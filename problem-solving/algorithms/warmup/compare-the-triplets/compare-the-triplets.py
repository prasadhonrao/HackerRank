#!/bin/python3

import math
import os
import random
import re
import sys

def compareTriplets(a, b):
    aliceScore = 0
    bobScore = 0

    for i in range(len(a)):
        if a[i] == b[i]:
            continue
        else:
            if a[i] > b[i]:
                aliceScore = aliceScore + 1
            else:
                bobScore = bobScore + 1

    return [aliceScore, bobScore]

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    a = list(map(int, input().rstrip().split()))

    b = list(map(int, input().rstrip().split()))

    result = compareTriplets(a, b)
    
    # print(' '.join(map(str, result)))
    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')
    fptr.close()
