# Enter your code here. Read input from STDIN. Print output to STDOUT
import re
m = re.search(r"([a-z0-9])\1+", input())
print(m.group(1) if m else -1)
