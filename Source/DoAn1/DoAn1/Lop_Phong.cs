using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DoAn1
{
    public class Lop_Phong
    {
        public Lop_Phong()
        {
            XepThoiKhoaBieuEntities xl = new XepThoiKhoaBieuEntities();
            List<Lop> lop = new List<Lop>();
            List<PhongHoc> phong = new List<PhongHoc>();
            var Dlop =
                from d in xl.Lops
                select d;
            var Dphong =
                from d in xl.PhongHocs
                select d;
            
            DataTable dt = new DataTable();
        }
    }
}
