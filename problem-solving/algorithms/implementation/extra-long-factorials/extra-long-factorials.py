#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the extraLongFactorials function below.
def extraLongFactorials(n):
    fact = 1
    while ( n > 0):
        fact = fact * n
        n = n -1
    print(fact)

if __name__ == '__main__':
    n = int(input())

    extraLongFactorials(n)
