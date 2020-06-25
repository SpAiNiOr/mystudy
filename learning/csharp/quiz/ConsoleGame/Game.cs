using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string str, out int x,out int y)
        {
           switch (str)
            {
                case "UpArrow":
                    x = 0;
                    y = -1;
                    break;

                case "DownArrow":
                    x = 0;
                    y = 1;
                    break;

                case "LeftArrow":
                    x = -1;
                    y = 0;
                    break;

                case "RightArrow":
                    x = 1;
                    y = 0;
                    break;

                default:
                    x = 0;
                    y = 0;
                    break;

            }

        }

    public new static char UpdateCursor(string str)
        {
            char cursor = ' ';
            switch(str)
            {
                case "UpArrow":
                    cursor = '^';
                    break;

                case "DownArrow":
                    cursor = 'v';
                    break;

                case "LeftArrow":
                    cursor = '<';
                    break;

                case "RightArrow":
                    cursor = '>';
                    break;
                default:
                    break;
            }
            return cursor;
        }

    public new static int KeepInBounds(int coordinate, int max)
        {
            if (coordinate<max)
            {
                return coordinate;
            }
            else if (coordinate >max)
            {
                coordinate = max - 1;
                return coordinate;
            }
            else
            {
                coordinate = 0;
                return coordinate;
            }
        }

    public new static bool DidScore(int x, int y, int xTarget, int yTarget)
        {
            if (x ==xTarget && y == yTarget)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
  }
}