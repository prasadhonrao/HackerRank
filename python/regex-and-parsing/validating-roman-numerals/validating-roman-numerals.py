regex_pattern = r"^M{0,3}(CM){0,3}D?(CD){0,3}C{0,3}(XC){0,3}L?(XL){0,3}X{0,3}(IX){0,3}V?(IV){0,3}I{0,3}$|^m{0,3}(cm){0,3}d?(cd){0,3}c{0,3}(xc){0,3}l?(xl){0,3}x{0,3}(ix){0,3}v?(iv){0,3}i{0,3}$"	# Do not delete 'r'.

import re
print(str(bool(re.match(regex_pattern, input()))))