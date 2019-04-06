# Enter your code here. Read input from STDIN. Print output to STDOUT

import re

VOWELS = '[aeiou]'
CONSONANTS = '[bcdfghjklmnpqrstvwxyz]'
REGEX = '(?<=' + CONSONANTS +')(' + VOWELS + '{2,})' + CONSONANTS

match = re.findall(REGEX, input(), re.I)
print('\n'.join(match or ['-1']))
