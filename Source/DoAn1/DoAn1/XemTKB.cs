using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace DoAn1
{
    public partial class XemTKB : Form
    {
        public XemTKB()
        {
            InitializeComponent();
        }

        private void XemTKB_Load(object sender, EventArgs e)
        {
            
        }
        bool Compare(string s1, string s2)
        {
            return s1.Contains(s2);
        }

        private void XuatExcel(DataGridView dt, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            app oExcel = new app();

            Workbooks oBooks;

            Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            List<Range> cl = new List<Range>();
            List<string> Cel = new List<string>();
            Cel.Add("A3"); Cel.Add("B3"); Cel.Add("C3");
            Cel.Add("D3"); Cel.Add("E3"); Cel.Add("F3");
            Cel.Add("G3"); Cel.Add("H3"); Cel.Add("I3");
            Cel.Add("J3"); Cel.Add("K3"); Cel.Add("L3");
            Cel.Add("M3"); Cel.Add("N3"); Cel.Add("O3");
            Cel.Add("P3"); Cel.Add("Q3"); Cel.Add("R3");
            Cel.Add("S3"); Cel.Add("T3"); Cel.Add("U3");
            Cel.Add("V3"); Cel.Add("W3"); Cel.Add("X3");
            Cel.Add("Y3"); Cel.Add("Z3");
            Cel.Add("AA3"); Cel.Add("AB3"); Cel.Add("AC3");
            Cel.Add("AD3"); Cel.Add("AE3"); Cel.Add("AF3");
            Cel.Add("AG3"); Cel.Add("AH3"); Cel.Add("AI3");
            Cel.Add("AJ3"); Cel.Add("AK3"); Cel.Add("AL3");
            Cel.Add("AM3"); Cel.Add("AN3"); Cel.Add("AO3");
            Cel.Add("AP3"); Cel.Add("AQ3"); Cel.Add("AR3");
            Cel.Add("AS3"); Cel.Add("AT3"); Cel.Add("AU3");
            Cel.Add("AV3"); Cel.Add("AW3"); Cel.Add("AX3");
            // Tạo tiêu đề cột 
            string end = null;
            Range cli = oSheet.get_Range(Cel[0], Cel[0]);
            cli.Value2 = dt.Columns[0].HeaderText;
            cli.ColumnWidth = 13.0;
            cl.Add(cli);
  
            for (int i = 1; i < dt.ColumnCount; i++)
            {
                cli = oSheet.get_Range(Cel[i], Cel[i]);
                cli.Value2 = dt.Columns[i].HeaderText;
                cli.ColumnWidth = 50.0;
                cl.Add(cli);
                end = Cel[i];
            }

            Range rowHead = oSheet.get_Range("A3", end);

            rowHead.Font.Bold = true;
            // Kẻ viền

            rowHead.Borders.LineStyle = Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[dgvTKB.RowCount, dgvTKB.ColumnCount];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dt.RowCount-1; r++)
            {
                for (int c = 0; c < dt.ColumnCount; c++)
                {
                    arr[r, c] = dt.Rows[r].Cells[c].Value;
                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dt.RowCount - 1;
            int columnEnd = dt.ColumnCount-1;

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
                XuatExcel(dgvTKB, "ThoiKhoaBieu", "THỜI KHÓA BIỂU");
                MessageBox.Show("Xuất xong!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi rồi! "+ex.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
