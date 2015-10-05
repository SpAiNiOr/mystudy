"""
use to check the number 4 bit is on or off. it can be used on calculate subnet and mask
"""
def check_bit4(input):
    mask = 0b1000
    result = mask & input
    if result > 7:
        return "on"
    else:
        return "off"

"""
will flip nth bit with number, and n=1 mean 0b1
"""
def flip_bit(number,n):
    mask = (0b1<< (n-1))
    result = bin(number ^ mask)
    return result
