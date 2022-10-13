using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    public class Tinh : MoveModel
    {
        public Tinh(string id, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.id = id;

        }
        public Tinh() { }


        public override int Move_Test(int i, int j)
        {
            bool turn = false;
            if (Player == 0)
            {
                if (i >= 0 && i <= 4 && j >= 0 && j <= 8)
                    if ((i == x + 2 && j == y + 2 ) || (i == x - 2 && j == y + 2 ) || (i == x + 2 && j == y - 2 ) || (i == x - 2 && j == y - 2))
                    {
                        if (BoardGame.Position[i, j].isEmpty == true) turn = true;
                        if (BoardGame.Position[i, j].isEmpty == false)
                            if (BoardGame.Position[i, j].Player != this.Player) turn = true;
                    }
            }
            if (Player == 1)
            {
                if (i >= 5 && i <= 9 && j >= 0 && j <= 8)
                    if ((i == x - 2 && j == y - 2 ) || (i == x - 2 && j == y + 2 ) || (i == x + 2 && j == y - 2 ) || (i == x + 2 && j == y + 2 ))
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