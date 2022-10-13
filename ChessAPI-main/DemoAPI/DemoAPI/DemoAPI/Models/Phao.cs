using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    public class Phao : MoveModel
    {
        public Phao(string id, int x, int y, bool quando)
        {
            this.x = x;
            this.y = y;
            this.id = id;
  
        }
        public Phao() { }




        public override int Move_Test(int i, int j)
        {
            bool turn = true;
            int count = 0;

            if (i < 0 || i > 10 || j < 0 || j > 9) turn = false;
            if (i != x && j != y) turn = false;
            if (i >= 0 && i <= 10 && j >= 0 && j <= 9 && (i == x || j == y))
            {
                if (BoardGame.Position[i, j].isEmpty == true)
                {
                    if (i == x && j >= 0 && j <= 9)
                    {
                        if (j > y)
                            for (int k = y + 1; k <= j; k++)
                            {
                                if (BoardGame.Position[i, k].isEmpty == false)
                                {
                                    turn = false;
                                    break;
                                }
                            }
                        if (j < y)
                            for (int k = j; k <= y - 1; k++)
                            {
                                if (BoardGame.Position[i, k].isEmpty == false)
                                {
                                    turn = false;
                                    break;
                                }
                            }
                    }
                    if (j == y && i >= 0 && i <= 10)
                    {
                        if (i > x)
                            for (int k = x + 1; k <= i; k++)
                            {
                                if (BoardGame.Position[k, j].isEmpty == false)
                                {
                                    turn = false;
                                    break;
                                }
                            }
                        if (i < x)
                            for (int k = i; k <= x - 1; k++)
                            {
                                if (BoardGame.Position[k, j].isEmpty == false)
                                {
                                    turn = false;
                                    break;
                                }
                            }
                    }
                }
                if (BoardGame.Position[i, j].isEmpty == false)
                {
                    if (BoardGame.Position[i, j].Player != this.Player)
                    {
                        if (i == x && j >= 0 && j <= 9)
                        {
                            if (j > y)
                                for (int k = y + 1; k < j; k++)
                                {
                                    if (BoardGame.Position[i, k].isEmpty == false) count++;

                                }
                            if (j < y)
                                for (int k = j + 1; k <= y - 1; k++)
                                {
                                    if (BoardGame.Position[i, k].isEmpty == false) count++;
                                }
                        }
                        if (j == y && i >= 0 && i <= 10)
                        {
                            if (i > x)
                                for (int k = x + 1; k < i; k++)
                                {
                                    if (BoardGame.Position[k, j].isEmpty == false) count++;

                                }
                            if (i < x)
                                for (int k = i + 1; k <= x - 1; k++)
                                {
                                    if (BoardGame.Position[k, j].isEmpty == false) count++;
                                }
                        }
                        if (count != 1) turn = false;
                    }
                    if (BoardGame.Position[i, j].Player == this.Player) turn = false;
                }
            }

            
            //Trả về kết quả
            if (turn) return 1;
            else return 0;
        }



    }
}