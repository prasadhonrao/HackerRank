#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the breakingRecords function below.
def breakingRecords(scores, n):
    max=min=scores[0]
    c1=c2=0
    for i in range(1,n):
        if scores[i]>max:
            c1+=1
            max=scores[i]
        if scores[i]<min:
            c2+=1
            min=scores[i]
    return c1,c2

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())
    scores = list(map(int, input().rstrip().split()))

    result = breakingRecords(scores, n)

    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
