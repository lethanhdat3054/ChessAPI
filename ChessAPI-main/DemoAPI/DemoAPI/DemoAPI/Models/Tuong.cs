using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    public class Tuong : MoveModel
    {
        public Tuong(string id, int x, int y, bool quando)
        {
            this.x = x;
            this.y = y;
            this.id = id;

        }
        public Tuong() { }
    }
}