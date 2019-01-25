#!/bin/python3

import os
import sys
from time import strptime, strftime
#
# Complete the timeConversion function below.
#
def timeConversion(s):
    return strftime("%H:%M:%S", strptime(s, "%I:%M:%S%p"))

if __name__ == '__main__':
    f = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = timeConversion(s)

    f.write(result + '\n')

    f.close()
