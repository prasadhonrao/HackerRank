k,room_numbers = int(input()),list(map(int, input().split()))

# print(k)
# print(room_numbers)

unique_room_numbers = set(room_numbers)

# print(unique_room_numbers)

print(((sum(unique_room_numbers)*k)-(sum(room_numbers)))//(k-1))