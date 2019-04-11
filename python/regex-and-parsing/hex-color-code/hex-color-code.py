# Enter your code here. Read input from STDIN. Print output to STDOUT

import re
n=int(input())
for i in range(n):
    res=re.findall(r".+?(#[A-F\d]{3,6})",input(),re.I)
    if res:
        print("\n".join(res))
