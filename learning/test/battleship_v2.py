__author__ = "Ice Shi"

from random import randint

# create battle board
board = []
size = int(raw_input("Please input the battle size: "))
for n in range(size):
    """ caution. because we need a grid, so we use ["O"] to stand for a place.
    if you use the "O", will make "OOOOO" instead of [[["O"],["O"],["O"],["O"]["O"]],[]].
    it's easy to change an element in list than try to change a string.
    """
    board.append(["O"] * size)

print "You have chosen the battlefield"

# print board on screen for player
def print_battlefiled(battlefiled):
    for row in battlefiled:
        print " ".join(row)


print print_battlefiled(board)

# create battle ships
ship_number = int(raw_input("How many ship you want:"))
battle_ship = []

# TODO: ship size is 1, extend to more
def create_ship(size, number=1):
    for n in range(number):
        while True:
            ship_row = randint(0, (size - 1))
            ship_col = randint(0, (size - 1))
            if [ship_row, ship_col] not in battle_ship:
                battle_ship.append([ship_row, ship_col])
                break
    return


create_ship(size, ship_number)

# main program
print "Game Start"


# based on player's input, compare with ship's coordinate which stored in battle_ship
def player_guess(guess_row, guess_col):
    if [guess_row, guess_col] in battle_ship and board[guess_row][guess_col] == "O":
        board[guess_row][guess_col] = "K"
        print print_battlefiled(board)
        ship_number -= 1
        return True
    else:
        if (guess_row < 0 or guess_row >= size) or (guess_col < 0 or guess_col >= size):
            print "Your choice is out range, please choose the number under :", size - 1
        elif board[guess_row][guess_col] != "O":
            print "You have already guessed that position, please try again"
        else:
            board[guess_row][guess_col] = "X"
            print "You have missed the ship!"
        return False

# ask user to input their name.
player_a = raw_input("please input first player's name: ") or "player_1"
player_b = raw_input("please input second player's name: ") or "player_2"
player_a_score = 0
player_b_score = 0
for n in range(ship_number * 8):
    if n % 2 == 0:
        print "It's %s's turn" % player_a
    else:
        print "It's %s's turn" % player_b
    print
    guess_row = int(raw_input("Please choose row number:"))
    guess_col = int(raw_input("Please choose col number:"))
    result = player_guess(guess_row, guess_row)
    print print_battlefiled(board)
    if n % 2 is False and result:
        player_a_score += 1
    if n % 2 and result:
        player_a_score += 1
    if n < ship_number * 8 - 1:
        print "%s's  score is " % player_a, player_a_score
        print "%s's  score is " % player_b, player_b_score
    if n == ship_number * 8 - 1 or ship_number == 0:  # if iterate over or ship all sank
        print "Game Over"
        print "%s's final score is " % player_a, player_a_score
        print "%s's final score is " % player_b, player_b_score
        break
