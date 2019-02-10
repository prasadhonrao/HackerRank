#!/bin/python3

import math
import os
import random
import re
import sys

# using collections package
# import collections
# def birthdayCakeCandles(ar):
#     counter = collections.Counter(ar)
#     return max(counter.values())

def birthdayCakeCandles(ar):
    return ar.count(max(ar))


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    ar_count = int(input())

    ar = list(map(int, input().rstrip().split()))

    result = birthdayCakeCandles(ar)

    fptr.write(str(result) + '\n')

    fptr.close()
