from nntplib import NNTP
server = NNTP('news.foo.bar')
server.group('comp.lang.python.announce')[0]
