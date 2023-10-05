using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThueXe.Class
{
    internal class ThongTinDangNhap
    {
        ThongTinCaNhan tTCN = new ThongTinCaNhan();

        private string userName, passWord;

        public ThongTinDangNhap()
        {
        }

        public ThongTinDangNhap(ThongTinCaNhan tTCN, string userName, string passWord)
        {
            this.tTCN = tTCN;
            this.userName = userName;
            this.passWord = passWord;
        }

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        internal ThongTinCaNhan TTCN { get => tTCN; set => tTCN = value; }
    }
}
