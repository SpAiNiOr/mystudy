def anti_vowel(text):
    result = ""
    vowel = ['a','e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U']
    for k in range(len(text)):
        if text[k] not in vowel:
            result = result + text[k]
    return result
