#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the plusMinus function below.
def plusMinus(arr):
    length = len(arr)

    positives = len([x for x in arr if x > 0])
    negatives = len([x for x in arr if x < 0])
    zeroes = len([x for x in arr if x == 0])

    print(format( positives / length, ".6f" ))
    print(format( negatives / length, ".6f" ))
    print(format( zeroes / length, ".6f" ))

if __name__ == '__main__':
    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    plusMinus(arr)
