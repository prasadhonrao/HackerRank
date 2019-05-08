n, m = input().split()
ar = input().split()

A = set(input().split())
B = set(input().split())
print(sum([(i in A) - (i in B) for i in ar]))
