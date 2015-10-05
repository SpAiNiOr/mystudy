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
