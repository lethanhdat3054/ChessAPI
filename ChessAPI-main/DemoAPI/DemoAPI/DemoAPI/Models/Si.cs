using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    public class Si : MoveModel
    {
        public Si(string id, int x, int y, bool quando)
        {
            this.x = x;
            this.y = y;
            this.id = id;

        }
        public Si() { }
        public override int Move_Test(int i, int j)
        {
            bool turn = false;
            if ((i >= 0 && i <= 2 && j >= 3 && j <= 5) || (i >= 7 && i <= 9 && j >= 3 && j <= 5))
                if ((i == x + 1 && j == y + 1) || (i == x + 1 && j == y - 1) || (i == x - 1 && j == y - 1) || (i == x - 1 && j == y + 1))
                {
                    if (BoardGame.Position[i, j].isEmpty == true) turn = true;
                    if (BoardGame.Position[i, j].isEmpty == false)
                    if (BoardGame.Position[i, j].Player != this.Player) turn = true;
                }

           
            //Trả về kết quả
            if (turn) return 1;
            else return 0;
        }
    }
}