__author__ = 'root'
def reverse(text):
    reverse_text = ""
    for char in range(len(text)):
        reverse_text = text[char] + reverse_text
    return reverse_text

print reverse("abcd")