n = int(input())

inputs = input().split()[:n]

# print(inputs)

print(all([int(i)>0 for i in inputs]) and any([j == j[::-1] for j in inputs]))