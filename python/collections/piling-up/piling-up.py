from collections import deque

for _ in range(int(input())):  
    _, queue =input(), deque(map(int, input().split()))
    
    for cube in reversed(sorted(queue)):
        if queue[-1] == cube: queue.pop()
        elif queue[0] == cube: queue.popleft()
        else:
            print('No')
            break
    else: print('Yes')