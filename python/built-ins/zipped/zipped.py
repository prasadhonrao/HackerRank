N, X = map(int, input().split())
# print("Students = ", N)
# print("Subjects = ", X)

scores = []

for _ in range(X):
    score = map(float, input().split())
    scores.append(score)

# print(scores)

for s in zip(*scores):
    print(sum(s) / len(s)) 