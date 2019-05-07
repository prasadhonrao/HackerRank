def merge_the_tools(string, k):
    # your code goes here
    for i in range(0, len(string), k):
        short_str = ''
        for c in string[i:i+k]:
            if c not in short_str:
                short_str += c 
        print(short_str)

if __name__ == '__main__':
    string, k = input(), int(input())
    merge_the_tools(string, k)