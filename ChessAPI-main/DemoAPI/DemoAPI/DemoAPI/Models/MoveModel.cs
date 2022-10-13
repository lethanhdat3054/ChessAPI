using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    public class MoveModel
    {
        public string Name;
  
        public int Status;  // Status = 1: quân cờ còn sống, Status = 0: quân cờ đã chết hoặc bị ăn.

        public bool isLocked = false;
        public string id { get; set; }
        public int top { get; set; }
        public int left { get; set; }
        public bool visible { get; set; }

        public bool isEmpty;
        public bool quando { get; set; }

        public int Player;

        public int NguoiChoi;
        public int step { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public int buocdi { get; set; }

        public bool canMove = false;
        public MoveModel() 
        {

        }
        public MoveModel(int x, int y)
        {
            this.quando = false;
            this.id = "0";
            this.top = 0;
            this.left = 0;
            this.visible = true;
          
            this.x = x;
            this.y = y;
          
            this.step = 0;
        }






        public MoveModel getId(MoveModel movemodel, MoveModel[,] board)
        {

            Phao phao = new Phao();
            Tinh tinh = new Tinh();
            Tot tot = new Tot();
            Xe xe = new Xe();
            Ma ma = new Ma();
            Tuong tuong = new Tuong();
            Si si = new Si();


            movemodel.canMove = false;
            return movemodel;
            
        }

        public virtual int Move_Test(int i, int j)
        {
            return 0;
        }


        public class BoardGame
        {
            public struct FlagPoint
            {
                public int x;
                public int y;
                public bool isEmpty;
                public string Name;
                public int Player;

            }
            public static FlagPoint[,] Position = new FlagPoint[10, 9];
            static BoardGame()
            {
                for (int i = 0; i <= 10; i++)
                {
                    for (int j = 0; j <= 9; j++)
                    {
                        Position[i, j].x = i;
                        Position[i, j].y = j;
                        Position[i, j].isEmpty = true;
                        Position[i, j].Name = "";
                        Position[i, j].Player = 0;

                    }
                }
            }
            public static void ResetCanMove()
            {
                for (int i = 0; i <= 10; i++)
                {
                    for (int j = 0; j <= 9; j++)
                    {

                    }
                }
            }
            public static void ResetBoard_Game()
            {
                for (int i = 0; i <= 10; i++)
                {
                    for (int j = 0; j <= 9; j++)
                    {
                        Position[i, j].x = i;
                        Position[i, j].y = j;
                        Position[i, j].isEmpty = true;
                        Position[i, j].Name = "";
                        Position[i, j].Player = 0;

                    }
                }
            }

        }

        //Khởi tạo quân cờ
        public void Initialize(int phe, string name, string v, int stt, bool khoa, int hang, int cot)
        {
            x = cot;
            y = hang;
            Name = name;
            Status = stt;
            Player = phe;
            isLocked = khoa;
            BoardGame.Position[x, y].x = cot;
            BoardGame.Position[x, y].y = hang;
            BoardGame.Position[x, y].Name = name;
            BoardGame.Position[x, y].Player = phe;
            BoardGame.Position[x, y].isEmpty = false;
        }

        //Tinh bước đi quân cờ
        public int Quancodichuyen(int dichuyen)
        {
            int buocdi = dichuyen / 70;
            return 1;
        }

    }
}