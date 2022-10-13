using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    public class Tot : MoveModel
    {
        public Tot(string id, int x, int y, bool quando)
        {
            this.x = x;
            this.y = y;
            this.id = id;
            
        }


        public Tot() { }


        public override int Move_Test(int i, int j)
        {
            bool turn = false;
            if (Player == 0)
            {
                if (i >= 0 && i <= 4)
                    if (i == x + 1 && j == y)
                    {
                        if (BoardGame.Position[i, j].isEmpty == true) turn = true;
                        if (BoardGame.Position[i, j].isEmpty == false)
                            if (BoardGame.Position[i, j].Player != this.Player) turn = true;
                    }
                if (i > 4 && i <= 9)
                    if ((i == x + 1 && j == y) || (i == x && j == y - 1) || (i == x && j == y + 1))
                        if (i >= 0 && i <= 10 && j >= 0 && j <= 9)
                        {
                            if (BoardGame.Position[i, j].isEmpty == true) turn = true;
                            if (BoardGame.Position[i, j].isEmpty == false)
                                if (BoardGame.Position[i, j].Player != this.Player) turn = true;
                        }
            }
            if (Player == 1)
            {
                if ((i <= 9) && (i >= 5))
                    if ((i == x - 1) && (j == y))
                    {
                        if (BoardGame.Position[i, j].isEmpty == true) turn = true;
                        if (BoardGame.Position[i, j].isEmpty == false)
                            if (BoardGame.Position[i, j].Player != this.Player) turn = true;
                    }
                if ((i < 5) && (i >= 0))
                    if ((i == x - 1 && j == y) || (i == x && j == y - 1) || (i ==x && j == y + 1))
                        if (i >= 0 && i <= 10 && j >= 0 && j <= 9)
                        {
                            if (BoardGame.Position[i, j].isEmpty == true) turn = true;
                            if (BoardGame.Position[i, j].isEmpty == false)
                                if (BoardGame.Position[i, j].Player != this.Player) turn = true;
                        }
            }

           
            //Trả về kết quả
            if (turn) return 1;
            else return 0;
        }

    }
}