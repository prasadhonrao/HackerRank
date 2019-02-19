# Enter your code here. Read input from STDIN. Print output to STDOUT

from itertools import permutations
s, k = input().split()
[print(*p, sep="") for p in list(permutations(sorted(s), int(k)))]
