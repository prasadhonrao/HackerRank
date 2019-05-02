def capitalize(string):
    for x in string[:].split():
        string = string.replace(x, x.capitalize())
    return string
