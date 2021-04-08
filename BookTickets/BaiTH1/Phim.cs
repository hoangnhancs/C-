using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTH1
{
    public class Phim
    {
        private string tenPhim;
        private string theLoai;
        private string linkHinhAnh;
        private string trangThai;
        private List<DateTime>  dateTime;

        public Phim() { }
        public Phim(string ten, string TL, string link, List<DateTime> DT, string TT)
        {
            tenPhim = ten;
            theLoai = TL;
            linkHinhAnh = link;
            dateTime = DT;
            trangThai = TT;
        }
        
        public string getLinkHinhAnh()
        {
            return linkHinhAnh;
        }

        public void setTrangThai(string tt)
        {
            trangThai = tt;
        }

        public string getTrangThai()
        {
            return trangThai;
        }
      
    }
}
