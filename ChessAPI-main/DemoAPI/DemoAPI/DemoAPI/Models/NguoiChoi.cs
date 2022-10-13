using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    public class NguoiChoi : MoveModel
    {

        public Tuong qTuong = new Tuong();        // quân tướng 
        public Si[] qSi = new Si[2];        //2 quân sĩ
        public Tinh[] qTinh = new Tinh[2];      // 2 quân tượng
        public Xe[] qXe = new Xe[2];         //2 quân xe
        public Phao[] qPhao = new Phao[2];        // 2 quân pháo
        public Ma[] qMa = new Ma[2];           // 2 quân mã
        public Tot[] qChot = new Tot[5];     // 5 quân tốt

        public NguoiChoi(int x) //Khởi tạo cho người chơi
        {

            if (x == 0)
            {
                qSi[0] = new Si();
                qSi[1] = new Si();
                qTinh[0] = new Tinh();
                qTinh[1] = new Tinh();
                qXe[0] = new Xe();
                qXe[1] = new Xe();
                qPhao[0] = new Phao();
                qPhao[1] = new Phao();
                qMa[0] = new Ma();
                qMa[1] = new Ma();
                qChot[0] = new Tot();
                qChot[1] = new Tot();
                qChot[2] = new Tot();
                qChot[3] = new Tot();
                qChot[4] = new Tot();

                Player = 0;
                qTuong.Initialize(0, "tuong", "0", 1, false, 0, 4);
                qSi[0].Initialize(0, "si", "0", 1, false, 0, 3);
                qSi[1].Initialize(0, "si", "1", 1, false, 0, 5);
                qTinh[0].Initialize(0, "tinh", "0", 1, false, 0, 2);
                qTinh[1].Initialize(0, "tinh", "1", 1, false, 0, 6);
                qXe[0].Initialize(0, "xe", "0", 1, false, 0, 0);
                qXe[1].Initialize(0, "xe", "1", 1, false, 0, 8);
                qPhao[0].Initialize(0, "phao", "0", 1, false, 2, 1);
                qPhao[1].Initialize(0, "phao", "1", 1, false, 2, 7);
                qMa[0].Initialize(0, "ma", "0", 1, false, 0, 1);
                qMa[1].Initialize(0, "ma", "1", 1, false, 0, 7);
                qChot[0].Initialize(0, "chot", "0", 1, false, 3, 0);
                qChot[1].Initialize(0, "chot", "1", 1, false, 3, 2);
                qChot[2].Initialize(0, "chot", "2", 1, false, 3, 4);
                qChot[3].Initialize(0, "chot", "3", 1, false, 3, 6);
                qChot[4].Initialize(0, "chot", "4", 1, false, 3, 8);

            }
            else
            {

                qSi[0] = new Si();
                qSi[1] = new Si();
                qTinh[0] = new Tinh();
                qTinh[1] = new Tinh();
                qXe[0] = new Xe();
                qXe[1] = new Xe();
                qPhao[0] = new Phao();
                qPhao[1] = new Phao();
                qMa[0] = new Ma();
                qMa[1] = new Ma();
                qChot[0] = new Tot();
                qChot[1] = new Tot();
                qChot[2] = new Tot();
                qChot[3] = new Tot();
                qChot[4] = new Tot();

                Player = 1;
                qTuong.Initialize(1, "tuong", "0", 1, true, 9, 4);
                qSi[0].Initialize(1, "si", "0", 1, true, 9, 3);
                qSi[1].Initialize(1, "si", "1", 1, true, 9, 5);
                qTinh[0].Initialize(1, "tinh", "0", 1, true, 9, 2);
                qTinh[1].Initialize(1, "tinh", "1", 1, true, 9, 6);
                qXe[0].Initialize(1, "xe", "0", 1, true, 9, 0);
                qXe[1].Initialize(1, "xe", "1", 1, true, 9, 8);
                qPhao[0].Initialize(1, "phao", "0", 1, true, 7, 1);
                qPhao[1].Initialize(1, "phao", "1", 1, true, 7, 7);
                qMa[0].Initialize(1, "ma", "0", 1, true, 9, 1);
                qMa[1].Initialize(1, "ma", "1", 1, true, 9, 7);
                qChot[0].Initialize(1, "chot", "0", 1, true, 6, 0);
                qChot[1].Initialize(1, "chot", "1", 1, true, 6, 2);
                qChot[2].Initialize(1, "chot", "2", 1, true, 6, 4);
                qChot[3].Initialize(1, "chot", "3", 1, true, 6, 6);
                qChot[4].Initialize(1, "chot", "4", 1, true, 6, 8);

            }
        }
    }
}