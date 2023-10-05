using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThueXe.Class
{
    internal class ThongTinCaNhan
    {
        private string hoVaTen, cMND, sDT;

        public ThongTinCaNhan()
        {
        }

        public ThongTinCaNhan(string hoVaTen, string cMND, string sDT)
        {
            this.hoVaTen = hoVaTen;
            this.cMND = cMND;
            this.sDT = sDT;
        }

        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string SDT { get => sDT; set => sDT = value; }
    }
}
