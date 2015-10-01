__author__ = "Ice Shi"

from random import randint

board = []
size = int(raw_input("Please input the battle size: "))
for n in range(size):
    board.append("O" * size)

print "You have chosen the battlefield"


def print_battlefiled(battlefiled):
    for row in battlefiled:
        print " ".join(row)


ship_number = int(raw_input("How many ship you want:"))
battle_ship = {}


def create_ship(size, number=1):
    for n in range(number):
        while True:
            ship_row = randint(0, (size - 1))
            ship_col = randint(0, (size - 1))
            if ship_row in battle_ship and battle_ship[ship_row] == ship_col is not True:
                battle_ship[ship_row] = ship_col
                break
    return


create_ship(size, ship_number)

# main program

for n in range(ship_number * 4):
    guess_row = int(raw_input("Please choose row number:"))
    guess_col = int(raw_input("Please choose col number:"))
    if battle_ship[guess_row] == guess_col and board[guess_row][guess_col] == "O":
        board[guess_row][guess_col] = "K"
        print print_battlefiled(board)
        ship_number -= 1
        if ship_number == 0:
            break
    else:
        if (guess_row < 0 or guess_row >= size) or (guess_col < 0 or guess_col >= size):
            print "Your choice is out range, please choose the number under :", size - 1
        elif board[guess_row][guess_col] != "O":
            print "You have already guessed that position, please try again"
        else:
            board[guess_row][guess_col] = "X"
            print "You have missed the ship!"
    if n == ship_number * 4 - 1:
        print "Game Over"