#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the alternatingCharacters function below.
def alternatingCharacters(word):
    count = 0
    for i in range(len(word) - 1):
        if word[i] == word[i + 1]:
            count += 1
    return (count)    

if __name__ == '__main__':
    # fptr = open(os.environ['OUTPUT_PATH'], 'w')

    q = int(input())

    for q_itr in range(q):
        s = input()

        result = alternatingCharacters(s)
        print(str(result) + '\n')
        #fptr.write(str(result) + '\n')

    # fptr.close()