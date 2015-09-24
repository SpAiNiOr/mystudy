__author__ = 'ice'

dic1 = {
    "key1": 9393,
    "key2": 333

}

dic2 = {
    "key1": "ice",
    "key2": "qingliu",
    "key3": "jiji"
}

for item in dic1:
    print "the first key is %s" % dic1[item]
    print "the second dict's value is %s" % dic2[item]

print

print dic1["key1"]
print dic2["key1"]

print dic1["key2"]
print dic2["key2"]