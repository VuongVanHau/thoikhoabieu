using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace DoAn1
{
    public partial class XepThoiKhoaBieu : Form
    {
        BALayer bl = new BALayer();
        public List<GV_MH> GVMHTable = new List<GV_MH>();
        public List<Lop_Phong> LPTable = new List<Lop_Phong>();
        public List<Lop_MH> Lop_Monhoc = new List<Lop_MH>();
        public List<GV_Lop> GiaoVien_LopHoc = new List<GV_Lop>();
        public List<Lop_Tiet_MH> Lop_T_MH = new List<Lop_Tiet_MH>();
        public List<ThoiKhoaBieu> tkb = new List<ThoiKhoaBieu>();
        public int xet = 0;
        public int g = 0;
        public int m = 0;
        public int l = 0;
        public int p = 0;
        public List<GiaoVien> givi = new List<GiaoVien>();
        public List<MonHoc> moho = new List<MonHoc>();
        public List<Lop> loho = new List<Lop>();
        public List<PhongHoc> phho = new List<PhongHoc>();
        public List<Chon> chon;

        public void XThoiKhoaBieu()
        {
            try
            {
                XepThoiKhoaBieuEntities xl = new XepThoiKhoaBieuEntities();

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
                    GiaoVien gv = new GiaoVien();
                    gv.MaGV = gt.MaGV;
                    gv.TenGV = gt.TenGV;
                    gv.MaBM = gt.MaBM;
                    givi.Add(gv);
                    g++;
                }

                foreach (var gt in monhoc)
                {
                    MonHoc MH = new MonHoc();
                    MH.MaMH = gt.MaMH;
                    MH.TenMH = gt.TenMH;
                    MH.MaBM = gt.MaBM;
                    moho.Add(MH);
                    m++;
                }

                foreach (var gt in lop)
                {
                    Lop LOP = new Lop();
                    LOP.MaLop = gt.MaLop;
                    LOP.TenLop = gt.TenLop;
                    loho.Add(LOP);
                    l++;
                }

                foreach (var gt in phong)
                {
                    PhongHoc PH = new PhongHoc();
                    PH.MaPH = gt.MaPH;
                    PH.TenPH = gt.TenPH;
                    phho.Add(PH);
                    p++;
                }

                int dem;
                dem = 1;

                //Giáo viên nào dạy môn nào
                for (int i = 0; i < g; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        int cv;
                        if (givi[i].MaBM == moho[j].MaBM)
                        {
                            GV_MH gvmh = new GV_MH();
                            gvmh.stt = dem;
                            gvmh.MaGV = givi[i].MaGV;
                            gvmh.MaMH = moho[j].MaMH;
                            cv = SoSanh(Int32.Parse(givi[i].MaGV.ToString()));
                            switch (cv)
                            {
                                case 0:
                                    {
                                        gvmh.Sotiet = 18;
                                        break;
                                    }
                                case 1:
                                    {
                                        gvmh.Sotiet = 2;
                                        break;
                                    }
                                case 2:
                                    {
                                        gvmh.Sotiet = 4;
                                        break;
                                    }
                                case 3:
                                    {
                                        gvmh.Sotiet = 15;
                                        break;
                                    }
                                case 4:
                                    {
                                        gvmh.Sotiet = 17;
                                        break;
                                    }
                                case 5:
                                    {
                                        gvmh.Sotiet = 9;
                                        break;
                                    }
                                case 6:
                                    {
                                        gvmh.Sotiet = 0;
                                        break;
                                    }
                            }
                            GVMHTable.Add(gvmh);
                            dem++;
                        }
                    }
                }
                int ph = 0;
                //Lớp nào học phòng nào
                dem = 1;
                int check = 0;
                for (int i = 0; i < l; i++)
                {
                    if (Compare(loho[i].TenLop.ToString(), "12") == true
                        || (Compare(loho[i].TenLop.ToString(), "11") == true && loho[i].MaBan == 1))
                    {
                        Lop_Phong lopphong = new Lop_Phong();
                        lopphong.stt = dem;
                        lopphong.MaLop = loho[i].MaLop;
                        lopphong.MaPH = phho[ph].MaPH;
                        lopphong.Buoi = "Sáng";
                        dem++;
                        LPTable.Add(lopphong);
                        check++;
                    }
                    else
                    {
                        Lop_Phong lopphong = new Lop_Phong();
                        lopphong.stt = dem;
                        lopphong.MaLop = loho[i].MaLop;
                        lopphong.MaPH = phho[ph].MaPH;
                        lopphong.Buoi = "Chiều";
                        dem++;
                        LPTable.Add(lopphong);
                        check++;
                    }
                    if (check >= 2)
                    {
                        ph++;
                        check = 0;
                    }
                }
                //Lớp nào học môn nào
                dem = 1;
                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Lop_MH lopmh = new Lop_MH();
                        lopmh.stt = dem;
                        lopmh.MaLop = loho[i].MaLop;
                        lopmh.MaMH = moho[j].MaMH;
                        if (loho[i].MaLop <= 11) //Lớp 10
                        {
                            if (lopmh.MaMH == 1)//toán
                            {
                                lopmh.sotiet = 5;
                            }
                            else if (lopmh.MaMH == 5)//văn
                            {
                                lopmh.sotiet = 4;
                            }
                            else if (lopmh.MaMH == 3 || lopmh.MaMH == 6)//hóa, anh
                            {
                                lopmh.sotiet = 3;
                            }
                            else if (lopmh.MaMH == 2 || lopmh.MaMH == 4 || lopmh.MaMH == 8 || lopmh.MaMH == 11 || lopmh.MaMH == 12 || lopmh.MaMH == 13)//lý, địa, sinh, tin,TD,QP
                            {
                                lopmh.sotiet = 2;
                            }
                            else if (lopmh.MaMH != 14) //các môn còn lại khác tiếng pháp
                            {
                                lopmh.sotiet = 1;
                            }
                        }
                        else if (loho[i].MaLop > 11 && loho[i].MaLop <= 21)//lớp 11
                        {
                            if (lopmh.MaMH == 1)
                            {
                                lopmh.sotiet = 5;
                            }
                            else if (lopmh.MaMH == 5 || lopmh.MaMH == 6)//Anh, Văn
                            {
                                lopmh.sotiet = 4;
                            }
                            else if (lopmh.MaMH == 2 || lopmh.MaMH == 3)//Lý, Hóa
                            {
                                lopmh.sotiet = 3;
                            }
                            else if (lopmh.MaMH == 4 || lopmh.MaMH == 12 || lopmh.MaMH == 13)// Sinh, TD,QP
                            {
                                lopmh.sotiet = 2;
                            }
                            else if (lopmh.MaMH != 14)//các môn còn lại khác tiếng pháp
                            {
                                lopmh.sotiet = 1;
                            }
                        }
                        else //lớp 12
                        {
                            if (lopmh.MaMH == 1) //Toán
                            {
                                lopmh.sotiet = 4;
                            }
                            else if (lopmh.MaMH == 6)//Anh
                            {
                                lopmh.sotiet = 3;
                            }
                            else if (lopmh.MaMH == 2 || lopmh.MaMH == 3 || lopmh.MaMH == 4 || lopmh.MaMH == 5)//lý, hóa, sinh, văn
                            {
                                lopmh.sotiet = 3;
                            }
                            else if (lopmh.MaMH == 7 || lopmh.MaMH == 11 || lopmh.MaMH == 12 || lopmh.MaMH == 13)//sử, tin,TD,QP
                            {
                                lopmh.sotiet = 2;
                            }
                            else if (lopmh.MaMH != 14)//các môn còn lại khác tiếng pháp
                            {
                                lopmh.sotiet = 1;
                            }
                        }
                        Lop_Monhoc.Add(lopmh);
                        dem++;
                    }
                }

                //Giáo viên nào dạy lớp nào
                dem = 1;
                Random ra = new Random();
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        GV_Lop gvl = new GV_Lop();
                        gvl.stt = dem;
                        gvl.MaLop = loho[j].MaLop;
                        gvl.MaMh = moho[i].MaMH;
                        chon = new List<Chon>();
                        int nchon = 0;
                        for (int l = 0; l < GVMHTable.Count - 1; l++)
                        {

                            if (GVMHTable[l].MaMH == gvl.MaMh)
                            {
                                Chon ch = new Chon();
                                ch.stt = nchon;
                                ch.MAGV = GVMHTable[l].MaGV;
                                chon.Add(ch);
                                nchon++;
                            }
                        }
                        
                        int a;
                        if (nchon > 1) a = ra.Next(nchon);
                        else a = 0;
                        int magv = chon[a].MAGV;
                        gvl.MaGV = magv;
                        for (int l = 0; l < LPTable.Count - 1; l++)
                        {
                            if (LPTable[l].MaLop == loho[j].MaLop)
                            {
                                gvl.MaPH = LPTable[l].MaPH;
                                break;
                            }
                        }
                        GiaoVien_LopHoc.Add(gvl);
                        dem++;
                    }

                }
                
                int tiet = 0;
                dem = 1;
                Random rd = new Random();
                Random rd1 = new Random();

                for (int it = 0; it < l; it++)
                {
                    List<int> chonMh = new List<int>();
                    int sotiet = 0;
                    for (int i = 0; i < moho.Count-1; i++) ////bỏ thể dục + quốc phòng
                    {
                        sotiet = 0;
                        if (moho[i].MaMH != 12 && moho[i].MaMH != 13)
                        {
                            for (int j = 0; j < Lop_Monhoc.Count - 1; j++)
                            {
                                if (Lop_Monhoc[j].MaMH == moho[i].MaMH && Lop_Monhoc[j].MaLop == loho[it].MaLop)
                                {
                                    sotiet = Lop_Monhoc[j].sotiet;
                                    break;
                                }
                            }
                            for (int j = 0; j < sotiet; j++) //Số lần xuất hiện môn học trong List chonMh
                            {
                                chonMh.Add(Lop_Monhoc[i].MaMH);
                            }
                        }

                    }

                    if (Compare(loho[it].TenLop.ToString(), "12") == true
                        || (Compare(loho[it].TenLop.ToString(), "11") == true && loho[it].MaBan == 1))
                    {
                        for (int th = 0; th < 6; th++)
                        {
                            for (int i = 1; i <= 5; i++)//lớp buổi sáng
                            {
                                Lop_Tiet_MH lgvmh = new Lop_Tiet_MH();
                                tiet = i + 10 * th;
                                if (tiet == 1)
                                {

                                }
                                else if(tiet == 29 || tiet == 30 || tiet == 45)
                                {

                                }
                                else
                                {
                                    int vt;
                                    if (chonMh.Count > 1) vt = rd.Next(chonMh.Count-1);
                                    else vt = 0;
                                    lgvmh.stt = dem;
                                    lgvmh.MaLop = loho[it].MaLop;
                                    lgvmh.MaMH = chonMh[vt];
                                    lgvmh.MaTiet = tiet;
                                    if (chonMh.Count > 1) chonMh.RemoveAt(vt);
                                    Lop_T_MH.Add(lgvmh);
                                    dem++;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int th = 0; th < 6; th++)
                        {
                            
                            for (int i = 6; i <= 10; i++)//lớp buổi chieu
                            {
                                Lop_Tiet_MH lgvmh = new Lop_Tiet_MH();
                                tiet = i + 10 * th;
                                if (tiet == 10)
                                {

                                }
                                else if (tiet==59 || tiet == 60 || tiet == 50)
                                {

                                }
                                else
                                {
                                    int vt;
                                    if (chonMh.Count > 1) vt = rd1.Next(chonMh.Count-1);
                                    else vt = 0;
                                    lgvmh.stt = dem;
                                    lgvmh.MaLop = loho[it].MaLop;
                                    lgvmh.MaMH = chonMh[vt];
                                    lgvmh.MaTiet = tiet;
                                    if (chonMh.Count > 1) chonMh.RemoveAt(vt);
                                    Lop_T_MH.Add(lgvmh);
                                    dem++;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi! " +ex.Message );
            }
        }

        int SoSanh(int s1)
        {
            if (s1 == 59) return 1;
            if (s1 == 31 || s1 == 42 || s1 == 43) return 2;
            if (s1 == 1 || s1 == 7 || s1 == 17|| s1 == 29 || s1 == 51 || s1 == 57 || s1 == 72 || s1 == 78 || s1 == 82) return 3;
            if (s1 == 2 || s1 == 8 || s1 == 18 || s1 == 30 || s1 == 45 || s1 == 52 || s1 == 58 || s1 == 73 || s1 == 79 || s1 == 83) return 4;
            if (s1 == 5 || s1 == 27 || s1 == 86 ) return 5;
            if (s1 == 9) return 6;
            return 0;
        }

        bool Compare(string s1, string s2)
        {
            return s1.Contains(s2);
        }

        public XepThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void lblBack_MouseHover(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Red;
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Black;
        }

        private void lblBack_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
            frmTongQuanLy tql = new frmTongQuanLy();
            tql.ShowDialog();
        }

        private void btnXepTKB_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (btnXepTKB.Enabled == true)
                {
                    XepTKB();
                    btnXepTKB.Enabled = false;
                    btnXemTKB.Hide();
                    btnXemTKB.Enabled = true;
                    lblChonLop.Show();
                    cmbChonlop.Show();
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xếp lỗi! " + ex.Message);
            }
        }

        public void XepTKB()
        {
            XepThoiKhoaBieuEntities xl = new XepThoiKhoaBieuEntities();
            int them = 1;
            for(int i=0;i<GiaoVien_LopHoc.Count-1;i++)
            {
                for(int j=0;j<Lop_T_MH.Count-1;j++)
                {
                    if (GiaoVien_LopHoc[i].MaLop==Lop_T_MH[j].MaLop && GiaoVien_LopHoc[i].MaMh==Lop_T_MH[j].MaMH)
                    {
                        
                        ThoiKhoaBieu tkb1 = new ThoiKhoaBieu();
                        tkb1.MaGV = GiaoVien_LopHoc[i].MaGV;
                        tkb1.MaLop = GiaoVien_LopHoc[i].MaLop;
                        tkb1.MaMH = GiaoVien_LopHoc[i].MaMh;
                        tkb1.MaTiet = Lop_T_MH[j].MaTiet;
                        tkb1.MaPH = GiaoVien_LopHoc[i].MaPH;
                        tkb.Add(tkb1);
                        //xl.Entry(tkb1).State = EntityState.Added;
                        //xl.SaveChanges();
                        them++;
                    }
                }
            }
            MessageBox.Show("Da xep xong " + them + " tiet hoc!");

            //DataTable dt = new DataTable();
            //dt = bl.ExecuteQueryDataSet("select * from ThoiKhoaBieu", CommandType.Text);
            //dgvRangBuoc.DataSource = dt;

            try
            {
                dgvRangBuoc.Show();
                foreach (DataGridViewRow r in dgvRangBuoc.Rows)
                {
                    dgvRangBuoc.Rows.Clear();
                }
                int i = 0;
                for (int k =0;k< tkb.Count-1; k++)
                {
                    dgvRangBuoc.Rows.Add();
                    dgvRangBuoc.Rows[i].Cells[0].Value = tkb[k].MaGV;
                    dgvRangBuoc.Rows[i].Cells[1].Value = tkb[k].MaLop;
                    dgvRangBuoc.Rows[i].Cells[2].Value = tkb[k].MaMH;
                    dgvRangBuoc.Rows[i].Cells[3].Value = tkb[k].MaPH;
                    dgvRangBuoc.Rows[i].Cells[4].Value = tkb[k].MaTiet;
                    i++;
                    xet = 6;
                    lbl2.Text = "Tên Lớp";
                    lbl3.Text = "Tên MH";
                    dgvRangBuoc.Columns[0].HeaderText = "Mã GV";
                    dgvRangBuoc.Columns[1].HeaderText = "Mã Lớp";
                    dgvRangBuoc.Columns[2].HeaderText = "Mã MH";
                    dgvRangBuoc.Columns[3].HeaderText = "Mã PH";
                    dgvRangBuoc.Columns[4].HeaderText = "Mã Tiết";
                }
                var lop =
                    from d in xl.Lops
                    select d;
                foreach (var lo in lop)
                {
                    cmbChonlop.Items.Add(lo.TenLop);
                }
                lbl1.Hide();
                lbl2.Hide();
                lbl3.Hide();
                lbl4.Hide();
                lbl5.Hide();
                txt1.Hide();
                txt2.Hide();
                txt3.Hide();
                txt4.Hide();
                txt5.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi! " + ex.Message);
            }
        }

        private void lblGV_MH_MouseHover(object sender, EventArgs e)
        {
            lblGV_MH.ForeColor = Color.Red;
        }

        private void lblGV_MH_MouseLeave(object sender, EventArgs e)
        {
            lblGV_MH.ForeColor = Color.Black;
        }

        private void lblGV_MH_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                dgvRangBuoc.Show();

                foreach (DataGridViewRow r in dgvRangBuoc.Rows)
                {
                    dgvRangBuoc.Rows.Clear();
                }
                int i = 0;
                foreach (GV_MH a in GVMHTable)
                {
                    dgvRangBuoc.Rows.Add();
                    dgvRangBuoc.Rows[i].Cells[0].Value = a.stt;
                    dgvRangBuoc.Rows[i].Cells[1].Value = a.MaGV;
                    dgvRangBuoc.Rows[i].Cells[2].Value = a.MaMH;
                    dgvRangBuoc.Rows[i].Cells[3].Value = a.Sotiet;
                    i++;
                    xet = 1;
                    lbl2.Text = "Tên GV";
                    lbl3.Text = "Tên MH";
                    lbl4.Text = "Số Tiết";
                    dgvRangBuoc.Columns[0].HeaderText = "STT";
                    dgvRangBuoc.Columns[1].HeaderText = "Mã GV";
                    dgvRangBuoc.Columns[2].HeaderText = "Mã MH";
                    dgvRangBuoc.Columns[3].HeaderText = "Số tiết";
                }
                lbl1.Hide();
                lbl2.Hide();
                lbl3.Hide();
                lbl4.Hide();
                txt1.Hide();
                txt2.Hide();
                txt3.Hide();
                txt4.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi! " + ex.Message);
            }
        }

        private void lblPhongLop_MouseHover(object sender, EventArgs e)
        {
            lblPhongLop.ForeColor = Color.Red;
        }

        private void lblPhongLop_MouseLeave(object sender, EventArgs e)
        {
            lblPhongLop.ForeColor = Color.Black;
        }

        private void lblPhongLop_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                dgvRangBuoc.Show();
                foreach (DataGridViewRow r in dgvRangBuoc.Rows)
                {
                    dgvRangBuoc.Rows.Clear();
                }
                int i = 0;
                foreach (Lop_Phong a in LPTable)
                {
                    dgvRangBuoc.Rows.Add();
                    dgvRangBuoc.Rows[i].Cells[0].Value = a.stt;
                    dgvRangBuoc.Rows[i].Cells[1].Value = a.MaLop;
                    dgvRangBuoc.Rows[i].Cells[2].Value = a.MaPH;
                    i++;
                    xet = 2;
                    lbl2.Text = "Tên Lớp";
                    lbl3.Text = "Tên Phòng";
                    dgvRangBuoc.Columns[0].HeaderText = "STT";
                    dgvRangBuoc.Columns[1].HeaderText = "Mã Lớp";
                    dgvRangBuoc.Columns[2].HeaderText = "Mã PH";
                    dgvRangBuoc.Columns[3].HeaderText = "";
                }
                lbl1.Hide();
                lbl2.Hide();
                lbl3.Hide();
                lbl4.Hide();
                txt1.Hide();
                txt2.Hide();
                txt3.Hide();
                txt4.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi! " + ex.Message);
            }
        }

        private void lblLopMH_MouseHover(object sender, EventArgs e)
        {
            lblLopMH.ForeColor = Color.Red;
        }

        private void lblLopMH_MouseLeave(object sender, EventArgs e)
        {
            lblLopMH.ForeColor = Color.Black;
        }

        private void lblLopMH_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                dgvRangBuoc.Show();
                foreach (DataGridViewRow r in dgvRangBuoc.Rows)
                {
                    dgvRangBuoc.Rows.Clear();
                }
                int i = 0;
                foreach (Lop_MH a in Lop_Monhoc)
                {
                    dgvRangBuoc.Rows.Add();
                    dgvRangBuoc.Rows[i].Cells[0].Value = a.stt;
                    dgvRangBuoc.Rows[i].Cells[1].Value = a.MaLop;
                    dgvRangBuoc.Rows[i].Cells[2].Value = a.MaMH;
                    dgvRangBuoc.Rows[i].Cells[3].Value = a.sotiet;
                    i++;
                    xet = 3;
                    lbl2.Text = "Tên Lớp";
                    lbl3.Text = "Tên MH";
                    lbl4.Text = "Số Tiết";
                    dgvRangBuoc.Columns[0].HeaderText = "STT";
                    dgvRangBuoc.Columns[1].HeaderText = "Mã Lớp";
                    dgvRangBuoc.Columns[2].HeaderText = "Mã MH";
                    dgvRangBuoc.Columns[3].HeaderText = "Số Tiết";
                }
                lbl1.Hide();
                lbl2.Hide();
                lbl3.Hide();
                lbl4.Hide();
                txt1.Hide();
                txt2.Hide();
                txt3.Hide();
                txt4.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi! " + ex.Message);
            }
        }

        private void XepThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            try
            {
                XThoiKhoaBieu();
                lbl1.Hide();
                lbl2.Hide();
                lbl3.Hide();
                lbl4.Hide();
                lbl5.Hide();
                lblChonLop.Hide();
                cmbChonlop.Hide();
                btnXuatTKB.Hide();
                txt1.Hide();
                txt2.Hide();
                txt3.Hide();
                txt4.Hide();
                txt5.Hide();
                dgvRangBuoc.Hide();
                btnXemTKB.Enabled = false;
                btnXemTKB.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvRangBuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            XepThoiKhoaBieuEntities xl = new XepThoiKhoaBieuEntities();
            int r = dgvRangBuoc.CurrentCell.RowIndex;
            if (r >= 0 && r < dgvRangBuoc.RowCount)
            {
                switch(xet)
                {
                    case 1:
                        {
                            txt1.Text = dgvRangBuoc.Rows[r].Cells[0].Value.ToString();
                            string tenGV = null;
                            string TenMH = null;
                            int magv = Int32.Parse(dgvRangBuoc.Rows[r].Cells[1].Value.ToString());
                            int mamh = Int32.Parse(dgvRangBuoc.Rows[r].Cells[2].Value.ToString());
                            var teng =
                                from d in xl.GiaoViens
                                where d.MaGV == magv
                                select d;
                            var tenm =
                                from d in xl.MonHocs
                                where d.MaMH == mamh
                                select d;
                            foreach(var gv in teng)
                            {
                                tenGV = gv.TenGV;
                            }
                            foreach (var mh in tenm)
                            {
                                TenMH = mh.TenMH;
                            }
                            txt2.Text = tenGV;
                            txt3.Text = TenMH;
                            txt4.Text = dgvRangBuoc.Rows[r].Cells[3].Value.ToString();
                            txt4.Show();
                            lbl4.Show();
                            txt5.Hide();
                            lbl5.Hide();
                            break;
                        }
                    case 2:
                        {
                            txt1.Text = dgvRangBuoc.Rows[r].Cells[0].Value.ToString();
                            string tenLop = null;
                            string TenPhong = null;
                            int malop = Int32.Parse(dgvRangBuoc.Rows[r].Cells[1].Value.ToString());
                            int maphong = Int32.Parse(dgvRangBuoc.Rows[r].Cells[2].Value.ToString());
                            var tenl =
                                from d in xl.Lops
                                where d.MaLop == malop
                                select d;
                            var tenp =
                                from d in xl.PhongHocs
                                where d.MaPH == maphong
                                select d;
                            foreach (var lh in tenl)
                            {
                                tenLop = lh.TenLop;
                            }
                            foreach (var ph in tenp)
                            {
                                TenPhong = ph.TenPH;
                            }
                            txt2.Text = tenLop;
                            txt3.Text = TenPhong;
                            txt4.Hide();
                            lbl4.Hide();
                            txt5.Hide();
                            lbl5.Hide();
                            break;
                        }
                    case 3:
                        {
                            txt1.Text = dgvRangBuoc.Rows[r].Cells[0].Value.ToString();
                            string TenLop = null;
                            string TenMH = null;
                            int malop = Int32.Parse(dgvRangBuoc.Rows[r].Cells[1].Value.ToString());
                            int mamh = Int32.Parse(dgvRangBuoc.Rows[r].Cells[2].Value.ToString());
                            var tenl =
                                from d in xl.Lops
                                where d.MaLop == malop
                                select d;
                            var tenm =
                                from d in xl.MonHocs
                                where d.MaMH == mamh
                                select d;
                            foreach (var lh in tenl)
                            {
                                TenLop = lh.TenLop;
                            }
                            foreach (var mh in tenm)
                            {
                                TenMH = mh.TenMH;
                            }
                            txt2.Text = TenLop;
                            txt3.Text = TenMH;
                            txt4.Text = dgvRangBuoc.Rows[r].Cells[3].Value.ToString();
                            txt4.Show();
                            lbl4.Show();
                            txt5.Hide();
                            lbl5.Hide();
                            break;
                        }
                    case 4:
                        {
                            txt1.Text = dgvRangBuoc.Rows[r].Cells[0].Value.ToString();
                            string TenLop = null;
                            string TenMH = null;
                            string TenGV = null;
                            string TenPH = null;
                            int magv = Int32.Parse(dgvRangBuoc.Rows[r].Cells[1].Value.ToString());
                            int malop = Int32.Parse(dgvRangBuoc.Rows[r].Cells[2].Value.ToString());
                            int mamh = Int32.Parse(dgvRangBuoc.Rows[r].Cells[3].Value.ToString());
                            int maph = Int32.Parse(dgvRangBuoc.Rows[r].Cells[4].Value.ToString());

                            var tenl =
                                from d in xl.Lops
                                where d.MaLop == malop
                                select d;
                            var tenm =
                                from d in xl.MonHocs
                                where d.MaMH == mamh
                                select d;
                            var tengv =
                                from d in xl.GiaoViens
                                where d.MaGV == magv
                                select d;
                            var tenph =
                                from d in xl.PhongHocs
                                where d.MaPH == maph
                                select d;
                            foreach (var lh in tenl)
                            {
                                TenLop = lh.TenLop;
                            }
                            foreach (var mh in tenm)
                            {
                                TenMH = mh.TenMH;
                            }
                            foreach (var gv in tengv)
                            {
                                TenGV = gv.TenGV;
                            }
                            foreach (var ph in tenph)
                            {
                                TenPH = ph.TenPH;
                            }
                            txt2.Text = TenGV;
                            txt3.Text = TenLop;
                            txt4.Text = TenMH;
                            txt5.Text = TenPH;
                            txt4.Show();
                            txt5.Show();
                            lbl4.Show();
                            lbl5.Show();
                            break;
                        }
                    case 5:
                        {
                            txt1.Text = dgvRangBuoc.Rows[r].Cells[0].Value.ToString();
                            string TenLop = null;
                            string TenMH = null;
                            int malop = Int32.Parse(dgvRangBuoc.Rows[r].Cells[1].Value.ToString());
                            int mamh = Int32.Parse(dgvRangBuoc.Rows[r].Cells[2].Value.ToString());
                            var tenl =
                                from d in xl.Lops
                                where d.MaLop == malop
                                select d;
                            var tenm =
                                from d in xl.MonHocs
                                where d.MaMH == mamh
                                select d;
                            foreach (var lh in tenl)
                            {
                                TenLop = lh.TenLop;
                            }
                            foreach (var mh in tenm)
                            {
                                TenMH = mh.TenMH;
                            }
                            txt2.Text = TenLop;
                            txt3.Text = TenMH;
                            txt4.Text = dgvRangBuoc.Rows[r].Cells[3].Value.ToString();
                            txt4.Show();
                            lbl4.Show();
                            txt5.Hide();
                            lbl5.Hide();
                            break;
                        }
                    case 6:
                        {
                            txt1.Text = dgvRangBuoc.Rows[r].Cells[0].Value.ToString();
                            string TenLop = null;
                            string TenMH = null;
                            string TenGV = null;
                            string TenPH = null;
                            string Time = null;
                            int malop = Int32.Parse(dgvRangBuoc.Rows[r].Cells[1].Value.ToString());
                            int mamh = Int32.Parse(dgvRangBuoc.Rows[r].Cells[2].Value.ToString());
                            int magv = Int32.Parse(dgvRangBuoc.Rows[r].Cells[0].Value.ToString());
                            int maph = Int32.Parse(dgvRangBuoc.Rows[r].Cells[3].Value.ToString());
                            int matiet = Int32.Parse(dgvRangBuoc.Rows[r].Cells[4].Value.ToString());
                            var tenl =
                                from d in xl.Lops
                                where d.MaLop == malop
                                select d;
                            var tenm =
                                from d in xl.MonHocs
                                where d.MaMH == mamh
                                select d;
                            var tengv =
                                from d in xl.GiaoViens
                                where d.MaGV == magv
                                select d;
                            var tenph =
                                from d in xl.PhongHocs
                                where d.MaPH == maph
                                select d;
                            var time =
                                from d in xl.Tiets
                                where d.STT == matiet
                                select d;
                            foreach (var gv in tengv)
                            {
                                TenGV = gv.TenGV;
                            }
                            foreach (var lh in tenl)
                            {
                                TenLop = lh.TenLop;
                            }
                            foreach (var mh in tenm)
                            {
                                TenMH = mh.TenMH;
                            }
                            foreach (var ph in tenph)
                            {
                                TenPH = ph.TenPH;
                            }
                            foreach (var t in time)
                            {
                                Time = t.Time;
                            }
                            txt1.Text = TenGV;
                            txt2.Text = TenLop;
                            txt3.Text = TenMH;
                            txt4.Text = TenPH;
                            txt5.Text = Time;
                            txt4.Show();
                            lbl4.Show();
                            txt5.Show();
                            lbl5.Show();
                            lbl1.Text = "Tên GV";
                            lbl2.Text = "Tên Lớp";
                            lbl3.Text = "Tên MH";
                            lbl4.Text = "Tên PH";
                            lbl5.Text = "Time";
                            break;
                        }

                }
                lbl1.Show();
                lbl2.Show();
                lbl3.Show();
                txt1.Show();
                txt2.Show();
                txt3.Show();
            }
        }

        private void lblTiet_MH_MouseHover(object sender, EventArgs e)
        {
            lblTiet_MH.ForeColor = Color.Red;
        }

        private void lblTiet_MH_MouseLeave(object sender, EventArgs e)
        {
            lblTiet_MH.ForeColor = Color.Black;
        }

        private void lblTiet_MH_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                dgvRangBuoc.Show();
                foreach (DataGridViewRow r in dgvRangBuoc.Rows)
                {
                    dgvRangBuoc.Rows.Clear();
                }
                int i = 0;
                foreach (Lop_Tiet_MH a in Lop_T_MH)
                {
                    dgvRangBuoc.Rows.Add();
                    dgvRangBuoc.Rows[i].Cells[0].Value = a.stt;
                    dgvRangBuoc.Rows[i].Cells[1].Value = a.MaLop;
                    dgvRangBuoc.Rows[i].Cells[2].Value = a.MaMH;
                    dgvRangBuoc.Rows[i].Cells[3].Value = a.MaTiet;
                    i++;
                    xet = 5;
                    lbl2.Text = "Tên Lớp";
                    lbl3.Text = "Tên MH";
                    lbl4.Text = "Mã Tiết";
                    dgvRangBuoc.Columns[0].HeaderText = "STT";
                    dgvRangBuoc.Columns[1].HeaderText = "Mã Lớp";
                    dgvRangBuoc.Columns[2].HeaderText = "Mã MH";
                    dgvRangBuoc.Columns[3].HeaderText = "Mã Tiết";
                }
                lbl1.Hide();
                lbl2.Hide();
                lbl3.Hide();
                lbl4.Hide();
                txt1.Hide();
                txt2.Hide();
                txt3.Hide();
                txt4.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi! " + ex.Message);
            }
        }

        private void lblGV_Lop_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                dgvRangBuoc.Show();
                foreach (DataGridViewRow r in dgvRangBuoc.Rows)
                {
                    dgvRangBuoc.Rows.Clear();
                }
                int i = 0;
                foreach (GV_Lop a in GiaoVien_LopHoc)
                {
                    dgvRangBuoc.Rows.Add();
                    dgvRangBuoc.Rows[i].Cells[0].Value = a.stt;
                    dgvRangBuoc.Rows[i].Cells[1].Value = a.MaGV;
                    dgvRangBuoc.Rows[i].Cells[2].Value = a.MaLop;
                    dgvRangBuoc.Rows[i].Cells[3].Value = a.MaMh;
                    dgvRangBuoc.Rows[i].Cells[4].Value = a.MaPH;
                    i++;
                    xet = 4;
                    lbl2.Text = "Tên GV";
                    lbl3.Text = "Tên Lớp";
                    lbl4.Text = "Tên MH";
                    lbl5.Text = "Tên PH";
                    dgvRangBuoc.Columns[0].HeaderText = "STT";
                    dgvRangBuoc.Columns[1].HeaderText = "Mã GV";
                    dgvRangBuoc.Columns[2].HeaderText = "Mã Lớp";
                    dgvRangBuoc.Columns[3].HeaderText = "Mã MH";
                    dgvRangBuoc.Columns[4].HeaderText = "Mã PH";
                }
                lbl1.Hide();
                lbl2.Hide();
                lbl3.Hide();
                lbl4.Hide();
                lbl5.Hide();
                txt1.Hide();
                txt2.Hide();
                txt3.Hide();
                txt4.Hide();
                txt5.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi! " + ex.Message);
            }
        }

        private void lblGV_Lop_MouseHover(object sender, EventArgs e)
        {
            lblGV_Lop.ForeColor = Color.Red;
        }

        private void lblGV_Lop_MouseLeave(object sender, EventArgs e)
        {
            lblGV_Lop.ForeColor = Color.Black;
        }

        private void btnXemTKB_Click(object sender, EventArgs e)
        {
            if (btnXemTKB.Enabled == true)
            {
                XemTKB xtkb = new XemTKB();
                XepThoiKhoaBieuEntities xl = new XepThoiKhoaBieuEntities();
                for (int ni = 0; ni < 6; ni++)
                {
                    xtkb.dgvTKB.Rows.Add();
                    if (ni == 0) xtkb.dgvTKB.Rows[ni].Cells[0].Value = "Thứ 2";
                    if (ni == 1) xtkb.dgvTKB.Rows[ni].Cells[0].Value = "Thứ 3";
                    if (ni == 2) xtkb.dgvTKB.Rows[ni].Cells[0].Value = "Thứ 4";
                    if (ni == 3) xtkb.dgvTKB.Rows[ni].Cells[0].Value = "Thứ 5";
                    if (ni == 4) xtkb.dgvTKB.Rows[ni].Cells[0].Value = "Thứ 6";
                    if (ni == 5) xtkb.dgvTKB.Rows[ni].Cells[0].Value = "Thứ 7";
                }
                var tenl =
                  from d in xl.Lops
                  select d;
                int cel = 1;
                foreach (var lh in tenl)
                {
                    xtkb.dgvTKB.Columns[cel].HeaderText = lh.TenLop;
                    string t2 = null;
                    string t3 = null;
                    string t4 = null;
                    string t5 = null;
                    string t6 = null;
                    string t7 = null;
                    int dem2 = 1;
                    int dem3 = 1;
                    int dem4 = 1;
                    int dem5 = 1;
                    int dem6 = 1;
                    int dem7 = 1;
                    var ttkb =
                        from d in tkb
                        where d.MaLop == lh.MaLop
                        orderby d.MaTiet
                        select d;
                    foreach (var t in ttkb)
                    {
                        if (t.MaTiet>=1 && t.MaTiet <= 10)
                        {
                            var tenm =
                                    from d in xl.MonHocs
                                    where d.MaMH == t.MaMH
                                    select d;
                            foreach (var gv in tenm)
                            {
                                if (dem2 < 4) t2 += gv.TenMH + ", ";
                                else t2 += gv.TenMH;
                                dem2++;
                            }
                            if (Compare(lh.TenLop.ToString(), "12") == true
                                || (Compare(lh.TenLop.ToString(), "11") == true && lh.MaBan == 1))
                            {
                                if(dem2==5) t2 = "Chào cờ, " + t2;  
                            }
                            else
                            {
                                if(dem2==5) t2 += ", Chào cờ";
                            }
                            xtkb.dgvTKB.Rows[0].Cells[cel].Value = t2;
                        }
                        else if (t.MaTiet > 10 && t.MaTiet <= 20)
                        {
                            var tenm =
                                    from d in xl.MonHocs
                                    where d.MaMH == t.MaMH
                                    select d;
                            foreach (var gv in tenm)
                            {
                                if (dem3 < 5) t3 += gv.TenMH + ", ";
                                else t3 += gv.TenMH;
                                dem3++;
                            }
                            xtkb.dgvTKB.Rows[1].Cells[cel].Value = t3;
                        }
                        else if (t.MaTiet > 20 && t.MaTiet <= 30)
                        {
                            var tenm =
                                    from d in xl.MonHocs
                                    where d.MaMH == t.MaMH
                                    select d;
                            foreach (var gv in tenm)
                            {
                                if (dem4 < 5) t4 += gv.TenMH + ", ";
                                else t4 += gv.TenMH;
                                dem4++;
                            }
                            xtkb.dgvTKB.Rows[2].Cells[cel].Value = t4;
                        }
                        else if (t.MaTiet > 30 && t.MaTiet <= 40)
                        {
                            var tenm =
                                    from d in xl.MonHocs
                                    where d.MaMH == t.MaMH
                                    select d;
                            foreach (var gv in tenm)
                            {
                                if (dem5 < 5) t5 += gv.TenMH + ", ";
                                else t5 += gv.TenMH;
                                dem5++;
                            }
                            xtkb.dgvTKB.Rows[3].Cells[cel].Value = t5;
                        }
                        else if (t.MaTiet > 40 && t.MaTiet <= 50)
                        {
                            var tenm =
                                    from d in xl.MonHocs
                                    where d.MaMH == t.MaMH
                                    select d;
                            foreach (var gv in tenm)
                            {
                                if (dem6 < 4) t6 += gv.TenMH + ", ";
                                else t6 += gv.TenMH;
                                dem6++;
                            }
                            xtkb.dgvTKB.Rows[4].Cells[cel].Value = t6;
                        }
                        else if (t.MaTiet > 50 && t.MaTiet <= 60)
                        {
                            var tenm =
                                    from d in xl.MonHocs
                                    where d.MaMH == t.MaMH
                                    select d;
                            foreach (var gv in tenm)
                            {
                                if (dem7 < 4)  t7 += gv.TenMH + ", ";
                                dem7++;
                            }
                            
                            xtkb.dgvTKB.Rows[5].Cells[cel].Value = t7 + "Hoạt động, Sinh hoạt";
                        }
                    }
                    cel++;
                }
                xtkb.ShowDialog();
            }
        }

        private string tenLop = null;

        private int malop = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tenLop = cmbChonlop.Text;
            malop = cmbChonlop.SelectedIndex + 1;
            MessageBox.Show(malop.ToString());
            btnXuatTKB.Show();
        }

        private void btnXuatTKB_Click(object sender, EventArgs e)
        {
            XuatExcel(dgvRangBuoc, tenLop, "THỜI KHÓA BIỂU");
        }
        private void XuatExcel(DataGridView dt, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            app oExcel = new app();
            Workbooks oBooks;
            Sheets oSheets;
            Workbook oBook;
            Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            // Tạo phần đầu

            Range head = oSheet.get_Range("A1", "F1");
            Range thu2 = oSheet.get_Range("F4", "F7");
            Range thu3 = oSheet.get_Range("F8", "F12");
            Range thu4 = oSheet.get_Range("F13", "F17");
            Range thu5 = oSheet.get_Range("F18", "F22");
            Range thu6 = oSheet.get_Range("F23", "F26");
            Range thu7 = oSheet.get_Range("F27", "F29");

            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = XlHAlign.xlHAlignCenterAcrossSelection;

            thu2.MergeCells = true;
            thu2.Value2 = "Thứ 2";
            thu2.Font.Bold = false;
            thu2.Font.Name = "Tahoma";
            thu2.Font.Size = "14";
            thu2.HorizontalAlignment = XlHAlign.xlHAlignCenterAcrossSelection;

            thu3.MergeCells = true;
            thu3.Value2 = "Thứ 3";
            thu3.Font.Bold = false;
            thu3.Font.Name = "Tahoma";
            thu3.Font.Size = "14";
            thu3.HorizontalAlignment = XlHAlign.xlHAlignCenterAcrossSelection;

            thu4.MergeCells = true;
            thu4.Value2 = "Thứ 4";
            thu4.Font.Bold = false;
            thu4.Font.Name = "Tahoma";
            thu4.Font.Size = "14";
            thu4.HorizontalAlignment = XlHAlign.xlHAlignCenterAcrossSelection;

            thu5.MergeCells = true;
            thu5.Value2 = "Thứ 5";
            thu5.Font.Bold = false;
            thu5.Font.Name = "Tahoma";
            thu5.Font.Size = "14";
            thu5.HorizontalAlignment = XlHAlign.xlHAlignCenterAcrossSelection;

            thu6.MergeCells = true;
            thu6.Value2 = "Thứ 6";
            thu6.Font.Bold = false;
            thu6.Font.Name = "Tahoma";
            thu6.Font.Size = "14";
            thu6.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            thu7.MergeCells = true;
            thu7.Value2 = "Thứ 7";
            thu7.Font.Bold = false;
            thu7.Font.Name = "Tahoma";
            thu7.Font.Size = "14";
            thu7.HorizontalAlignment = XlHAlign.xlHAlignCenterAcrossSelection;

            List<Range> cl = new List<Range>();
            // Tạo tiêu đề cột
            Range cli;

            cli = oSheet.get_Range("A3", "A3");
            cli.Value2 = "Tên Giáo Viên";
            cli.ColumnWidth = 20.0;
            cl.Add(cli);

            cli = oSheet.get_Range("B3", "B3");
            cli.Value2 = "Tên Lớp";
            cli.ColumnWidth = 20.0;
            cl.Add(cli);

            cli = oSheet.get_Range("C3", "C3");
            cli.Value2 = "Tên Môn Học";
            cli.ColumnWidth = 20.0;
            cl.Add(cli);

            cli = oSheet.get_Range("D3", "D3");
            cli.Value2 = "Tên Phòng Học";
            cli.ColumnWidth = 20.0;
            cl.Add(cli);

            cli = oSheet.get_Range("E3", "E3");
            cli.Value2 = "Thời Gian";
            cli.ColumnWidth = 20.0;
            cl.Add(cli);

            cli = oSheet.get_Range("F3", "F3");
            cli.Value2 = "Ngày Học";
            cli.ColumnWidth = 20.0;
            cl.Add(cli);

            var thoikb =
                  from d in tkb
                  where d.MaLop == malop
                  orderby d.MaTiet
                  select d;

            Range rowHead = oSheet.get_Range("A3", "F3");

            rowHead.Font.Bold = true;
            // Kẻ viền

            rowHead.Borders.LineStyle = Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = XlHAlign.xlHAlignCenter;


            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[30,5];

            //Chuyển dữ liệu từ Datagridview vào mảng đối tượng
            int r = 0;
            foreach (var lh in thoikb)
            {
                XepThoiKhoaBieuEntities xl = new XepThoiKhoaBieuEntities();
                string TenMH = null;
                string TenGV = null;
                string TenPH = null;
                string Time = null;
                int mamh = lh.MaMH;
                int magv = lh.MaGV;
                int maph = lh.MaPH;
                int matiet = lh.MaTiet;
                var tenm =
                    from d in xl.MonHocs
                    where d.MaMH == mamh
                    select d;
                var tengv =
                    from d in xl.GiaoViens
                    where d.MaGV == magv
                    select d;
                var tenph =
                    from d in xl.PhongHocs
                    where d.MaPH == maph
                    select d;
                var time =
                    from d in xl.Tiets
                    where d.STT == matiet
                    select d;
                foreach (var gv in tengv)
                {
                    TenGV = gv.TenGV;
                }
                foreach (var mh in tenm)
                {
                    TenMH = mh.TenMH;
                }
                foreach (var ph in tenph)
                {
                    TenPH = ph.TenPH;
                }
                foreach (var t in time)
                {
                    Time = t.Time;
                }
                arr[r, 0] = TenGV;
                arr[r, 1] = tenLop;
                arr[r, 2] = TenMH;
                arr[r, 3] = TenPH;
                arr[r, 4] = Time;
                r++;
            }
            
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + 25;
            int columnEnd = 5;

            // Ô bắt đầu điền dữ liệu

            Range c1 = (Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Range c2 = (Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Constants.xlSolid;

            // Căn giữa cột Thứ

            Range c3 = (Range)oSheet.Cells[rowEnd, columnStart];

            Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = XlHAlign.xlHAlignCenter;
        }

        private void xuatfileExcel_Click(object sender, EventArgs e)
        {
            try
            {
                XuatExcel(dgvRangBuoc, tenLop, "THỜI KHÓA BIỂU");
                MessageBox.Show("Xuất xong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi! " + ex.Message);
            }
        }
    }
    
}
