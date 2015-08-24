__author__ = 'Ice'
import re

p = re.compile(r'.*\d+')

def read_input()
    f=True
    while True:
        m = 'Pig Latin:' if f else "your input is not word,please try again:"
        word = raw_input(m)
        f= False
        m = p.search(word)
        if m is None:
            return word


word = None
while True:
    m = 'Pig Latin:'
    word = raw_input(m)
    m = p.search(word)
    if m is None:
        break


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
