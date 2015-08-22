__author__ = 'Ice'
import re

word = raw_input('Pig Latin:')
p = re.compile(r'.*\d+')
m = p.search(word)


def translator(string):
    """
    string = list(string)
    pig = string[0]
    del string[0]
    string.append(pig)
    string.append("ay")
    string = str(string)
    return string
    # will get the result "['w', 'o']" . don't use this way
    """
    # the right way is to use slice to cut user input into different sections.
    pig = string[0:1]
    string = string[1:]
    string = string + pig + 'ay'
    return string


while m is not None:
    word = raw_input("your input is not word,please try again:")
    p = re.compile(r'.*\d+')
    m = p.search(word)

print translator(word)
