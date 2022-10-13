using DemoAPI.Models;
using Lib.Entities;
using Lib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DemoAPI.Models.MoveModel;

namespace DemoAPI.Controllers.api
{
    public class ChessController: Controller
    {

        public int x;
        public int y;
        public string Name;
        public int Player;   //Phe=0 || Phe=1 
        public string Order = "";//VD: quân mã phía trái, phải
        public int Status;  // Status = 1: quân cờ còn sống, Status = 0: quân cờ đã chết hoặc bị ăn.

        public bool isLocked = false;

        public ChessController()
        {
            x = 10;
            y = 9;
            Name = "";
            Player = 2;
            Order = "";
            Status = 0;
            isLocked = true;

        }

        //Khởi tạo quân cờ
        public void Initialize(int phe, string name, int stt, bool khoa, int hang, int cot)
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





        public MoveModel[,] board = new MoveModel[10, 9];
            public void Init()
            {
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        for (int j = 0; j <= 9; j++)
                        {
                            board[i, j] = new MoveModel(i, j);
                            board[i, j].x = i;
                            board[i, j].y = j;
                            board[i, j].NguoiChoi = 0;

                        }
                    }

                    board[3, 0] = new Tot("totden1", 3, 0, false);
                    board[3, 2] = new Tot("totden2", 3, 2, false);
                    board[3, 4] = new Tot("totden3", 3, 4, false);
                    board[3, 6] = new Tot("totden4", 3, 6, false);
                    board[3, 8] = new Tot("totden5", 3, 8, false);
                    board[6, 0] = new Tot("totdo1", 6, 0, true);
                    board[6, 2] = new Tot("totdo2", 6, 2, true);
                    board[6, 4] = new Tot("totdo3", 6, 4, true);
                    board[6, 6] = new Tot("totdo4", 6, 6, true);
                    board[6, 8] = new Tot("totdo5", 6, 8, true);




                    board[2, 1] = new Phao("phaoden2", 2, 1, false);
                    board[2, 7] = new Phao("phaoden1", 2, 7, false);
                    board[7, 1] = new Phao("phaodo1", 7, 1, true);
                    board[7, 7] = new Phao("phaodo2", 7, 7, true);




                    board[0, 1] = new Ma("maden1", 0, 1, false);
                    board[0, 7] = new Ma("maden2", 0, 7, false);
                    board[9, 1] = new Ma("mado1", 9, 1, true);
                    board[9, 7] = new Ma("mado2", 9, 7, true);




                    board[0, 2] = new Tinh("tinhden1", 0, 2);
                    board[0, 6] = new Tinh("tinhden2", 0, 6);
                    board[9, 2] = new Tinh("tinhdo1", 9, 2);
                    board[9, 6] = new Tinh("tinhdo2", 9, 6);


                    board[0, 3] = new Si("siden1", 0, 3, false);
                    board[0, 5] = new Si("siden2", 0, 5, false);
                    board[9, 3] = new Si("sido1", 9, 3, true);
                    board[9, 5] = new Si("sido2", 9, 5, true);

                   

                    board[0, 0] = new Xe("xeden1", 0, 0);
                    board[0, 8] = new Xe("xeden2", 0, 8);
                    board[9, 0] = new Xe("xedo1", 9, 0);
                    board[9, 8] = new Xe("xedo2", 9, 8);


                    board[0, 4] = new Tuong("tuongden", 0, 4, false);
                    board[9, 4] = new Tuong("tuongdo", 9, 4, true);


                }

            }

            public void ResetBoard_Game()
            {
                for (int i = 0; i <= 10; i++)
                {
                    for (int j = 0; j <= 9; j++)
                    {
                        board[i, j].x = i;
                        board[i, j].y = j;
                        board[i, j].isEmpty = true;
                        board[i, j].Player = 0;
                    }
                }
            }

        

       


        ChessService chessService = new ChessService();
        
        [Route("api/chess/insertroom")]
        [HttpPost]
        public ActionResult insertroom(RoomModel rmodel)
        {
            Room r = new Room();
            r.Id = Guid.NewGuid();
            r.Name = rmodel.RoomName;
            chessService.insertRoom(r);
            return
            Json(new
            {
                message = "success",
               // data = stList //_dbContext.Student.OrderBy(s=>s.Id).Skip(2).Take(3).ToList() //Where(s=>s.Id == Guid.Parse(id)).FirstOrDefault()
            }, JsonRequestBehavior.AllowGet);
        }
        [Route("api/chess/getrooms")]
        [HttpGet]
        public ActionResult getallroom()
        {
            List<Room> roomList = chessService.getAllRoom();
            return
            Json(new
            {
                message = "success",
                data = roomList //_dbContext.Student.OrderBy(s=>s.Id).Skip(2).Take(3).ToList() //Where(s=>s.Id == Guid.Parse(id)).FirstOrDefault()
            }, JsonRequestBehavior.AllowGet);
        }
        [Route("api/chess/getchessnode")]
        [HttpPost]
        public ActionResult getAllNode(List<MoveModel> movelist)
        {
            string chessJson = System.IO.File.ReadAllText(Server.MapPath("/Data/ChessJson.txt"));
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            List<ChessNode> chessnode = js.Deserialize<List<ChessNode>>(chessJson);
            return Json(new
            {
                message = "success",
                chessnode = chessnode
            }, JsonRequestBehavior.AllowGet);
        }
        [Route("api/chess/movenode")]
        [HttpPost]
        public ActionResult getMoveNode(List<MoveModel> movelist)
        {
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            Requestlog.PostToClient(js.Serialize(movelist));
            return Json(new
            {
                message = "success"

            }, JsonRequestBehavior.AllowGet);
        }
    }
}