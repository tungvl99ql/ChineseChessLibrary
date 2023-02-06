using System;
using System.Collections.Generic;
using System.Text;

namespace ChinaChessCheck
{
    public class Tot : ChessPiece
    {
        public override bool CheckMove(int X, int Y)
        {
            if (X == position.X && Y == position.Y)
            {
                return false;
            }

            switch (Team)
            {
                case 1:
                    if (position.Y < 5) //  chưa qua sông
                    {
                        if (position.X == X && Y == position.Y + 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else // đã qua sông
                    {
                        if (Y == position.Y && (X == position.X - 1 || X == position.X + 1))
                        {
                            return true;
                        }
                        else if (position.X == X && Y == position.Y + 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case 2:
                    if(position.Y > 4) //  chưa sang sông
                    {
                        if (position.X == X && Y == position.Y - 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else // đã qua sông
                    {
                        if (Y == position.Y && (X == position.X - 1 || X == position.X + 1))
                        {
                            return true;
                        }
                        else if (position.X == X && Y == position.Y - 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
            }
            return false;
        }
    }
}
