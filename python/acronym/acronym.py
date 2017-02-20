import re


def abbreviate(strings):
    return ''.join(word[0].upper() for word in
                   re.findall('[A-Z]+[a-z]*|[a-z]+', strings))
