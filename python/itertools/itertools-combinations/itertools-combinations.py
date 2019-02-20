from itertools import *

s,k = input().split()

for l in range(1, int(k) + 1):
    for c in combinations (sorted(s),l):
        print(''.join(c))
