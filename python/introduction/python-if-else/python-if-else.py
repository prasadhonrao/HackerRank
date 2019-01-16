if __name__ == '__main__':
    n = int(input())
    if (n % 2 == 1) or (n >=6 and n <= 20):
        print("Weird")
    elif (n >=2 and n <= 5) or (n > 20):
        print("Not Weird")
        