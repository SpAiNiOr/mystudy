__author__ = 'root'
def purify(sequence):
    result = []
    for n in range(len(sequence)):
        if sequence[n] % 2 == 0:
            result.append(sequence[n])
    return result

print purify([4,5,5,4])