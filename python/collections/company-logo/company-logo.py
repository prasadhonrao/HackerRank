#!/bin/python3

import math
import os
import random
import re
import sys
from collections import Counter

if __name__ == '__main__':
    chars = Counter(input()).items()
    for char, n in sorted(chars, key=lambda c: (-c[1], c[0]))[:3]:
        print(char, n)

