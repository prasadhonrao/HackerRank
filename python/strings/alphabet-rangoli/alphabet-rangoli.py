import string

def print_rangoli(size):
    alpha = string.ascii_lowercase #contains all lowercase characters
    line = []
    for i in range(size):
        s = "-".join(alpha[i:size])
        line.append((s[::-1]+s[1:]).center(4*size-3, "-"))
    print('\n'.join(line[:0:-1]+line))
    

