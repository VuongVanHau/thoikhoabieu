using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    public class XThoiKhoaBieu
    {
        public List<GV_MH> GVMHTable { get; set; }
        public List<Lop_Phong> LPTable { get; set; }
        public List<Lop_MH> Lop_Monhoc { get; set; }

        public XThoiKhoaBieu()
        {
            XepThoiKhoaBieuEntities xl = new XepThoiKhoaBieuEntities();
            List<GiaoVien> givi = new List<GiaoVien>();
            List<MonHoc> moho = new List<MonHoc>();
            List<Lop> loho = new List<Lop>();
            List<PhongHoc> phho = new List<PhongHoc>();
            GVMHTable = new List<GV_MH>();
            LPTable = new List<Lop_Phong>();
            int g;
            int m;
            int l;
            int p;
            var giaovien =
                from d in xl.GiaoViens
                select d;
            var monhoc =
                from d in xl.MonHocs
                select d;
            var lop =
                from d in xl.Lops
                select d;
            var phong =
                from d in xl.PhongHocs
                select d;
            
            foreach (var gt in giaovien)
            {
                g = 0;
                GiaoVien gv = new GiaoVien();
                gv.MaGV = gt.MaGV;
                gv.TenGV = gt.TenGV;
                gv.MaBM = gt.MaBM;
                givi.Add(gv);
                g++;
            }
            foreach (var gt in monhoc)
            {
                m = 0;
                MonHoc MH = new MonHoc();
                MH.MaMH = gt.MaMH;
                MH.TenMH = gt.TenMH;
                MH.MaBM = gt.MaBM;
                moho.Add(MH);
                m++;
            }
            foreach (var gt in lop)
            {
                l = 0;
                Lop LOP = new Lop();
                LOP.MaLop = gt.MaLop;
                LOP.TenLop = gt.TenLop;
                loho.Add(LOP);
                l++;
            }
            foreach (var gt in phong)
            {
                p = 0;
                PhongHoc PH = new PhongHoc();
                PH.MaPH = gt.MaPH;
                PH.TenPH = gt.TenPH;
                phho.Add(PH);
                p++;
            }
            int dem;
            dem = 0;
            ////Giáo viên nào dạy môn nào
            //for(int i=0;i<g;i++)
            //{
            //    for(int j=0;j<m;j++)
            //    {
            //        if (givi[i].MaBM == moho[j].MaBM)
            //        {
            //            GVMHTable[dem].stt = dem;
            //            GVMHTable[dem].MaGV = givi[i].MaGV;
            //            GVMHTable[dem].MaMH = moho[j].MaMH;
            //            dem++;
            //        }
            //    }
            //}
            //int ph = 0;
            ////Lớp nào học phòng nào
            //for (int i = 0; i < l; i++)
            //{
            //    if (Compare(loho[i].TenLop.ToString(),"12")==true  
            //        || (Compare(loho[i].TenLop.ToString(), "11") == true && loho[i].MaBan == 1))
            //    {
            //        LPTable[dem].stt = dem;
            //        LPTable[dem].MaLop = loho[i].MaLop;
            //        LPTable[dem].MaPH = phho[ph++].MaPH;
            //        LPTable[dem].Buoi = "Sáng";
            //        dem++;
            //    }
            //    else
            //    {
            //        LPTable[dem].stt = dem;
            //        LPTable[dem].MaLop = loho[i].MaLop;
            //        LPTable[dem].MaPH = phho[ph++].MaPH;
            //        LPTable[dem].Buoi = "Chiều";
            //        dem++;
            //    }
            //}
            ////Lớp nào học môn nào
            //dem = 0;
            //for (int i = 0; i < l; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Lop_Monhoc[dem].stt = dem;
            //        Lop_Monhoc[dem].MaLop = loho[i].MaLop;
            //        Lop_Monhoc[dem].MaMH = moho[i].MaMH;
            //        dem++;
            //    }
            //}
        }
        bool Compare(string s1,string s2)
        {
            return s1.Contains(s2);
        }
        public void TKB1Lop(Lop_MH lm, Lop_Phong lp, GV_MH gm,Tiet t)
        {

        }
    }
}
