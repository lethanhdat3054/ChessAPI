using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    public class Xe : MoveModel
    {

        public Xe(string id, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.id = id;
        }

        public Xe() { }




        public override int Move_Test(int i, int j)
        {
            bool turn = true;
            if (i < 0 || i > 9 || j < 0 || j > 8) turn = false;
            if (i != x && j != y) turn = false;
            if (i == x && j >= 0 && j <= 8)
            {
                if (j > y)
                    for (int k = y + 1; k < j; k++)
                    {
                        if (BoardGame.Position[i, k].isEmpty == false)
                        {
                            turn = false;
                            break;
                        }
                    }
                if (j < y)
                    for (int k = j + 1; k <= y - 1; k++)
                    {
                        if (BoardGame.Position[i, k].isEmpty == false)
                        {
                            turn = false;
                            break;
                        }
                    }
                if (BoardGame.Position[i, j].isEmpty == false)
                    if (BoardGame.Position[i, j].Player == this.Player) turn = false;
            }
            if (j == y && i >= 0 && i <= 9)
            {
                if (i > x)
                    for (int k = x + 1; k < i; k++)
                    {
                        if (BoardGame.Position[k, j].isEmpty == false)
                        {
                            turn = false;
                            break;
                        }
                    }
                if (i < x)
                    for (int k = i + 1; k <= x - 1; k++)
                    {
                        if (BoardGame.Position[k, j].isEmpty == false)
                        {
                            turn = false;
                            break;
                        }
                    }
                if (BoardGame.Position[i, j].isEmpty == false)
                    if (BoardGame.Position[i, j].Player == this.Player) turn = false;
            }

          
            //Trả về kết quả
            if (turn) return 1;
            else return 0;
        }




    }
}