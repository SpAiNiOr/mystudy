import socket

s = socket.socket()

host = socket.gethostname()
port = 51234
s.bind((host,port))

s.listen(5)
while True:
    c, addr = s.accept()
    print 'GOt connection from' , addr
    c.send('Thank you for connecting')
    c.close()