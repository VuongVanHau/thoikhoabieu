using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DoAn1
{
    struct GV_MH
    {
        string MaGV;
        string TenGV;
        string MaMH;
        string TenMH;
    }

    public class GV_MH_Table
    {
        private static List<GV_MH> gvmh = new List<GV_MH>();
    }
    public class GiaoVien_MonHoc
    {
        public GiaoVien_MonHoc()
        {
            XepThoiKhoaBieuEntities xl = new XepThoiKhoaBieuEntities();
            List<GiaoVien> givi = new List<GiaoVien>();
            List<MonHoc> moho = new List<MonHoc>();
            List<BoMon> bomo = new List<BoMon>();
            GV_MH_Table mh_gv = new GV_MH_Table();
            var giaovien =
                from d in xl.GiaoViens
                select d;
            var monhoc =
                from d in xl.MonHocs
                select d;
            var bomon =
                from d in xl.BoMons
                select d;
            int i = 0;
            foreach(var gt in giaovien)
            {
                givi[i].MaGV = gt.MaGV;
                givi[i].TenGV = gt.TenGV;
                givi[i].MaBM = gt.MaBM;
            }
            i = 0;
            foreach (var gt in monhoc)
            {
                moho[i].MaMH = gt.MaMH;
                moho[i].TenMH = gt.TenMH;
            }
            i = 0;
            foreach (var gt in bomon)
            {
                bomo[i].MaBM = gt.MaBM;
                bomo[i].TenBM = gt.TenBM;
                bomo[i].GiaoViens = gt.GiaoViens;
            }
        }
    }
}
