import re

for _ in range(int(input())):
    print(bool(re.match("^[\+-]?\d*\.\d+$", input())))