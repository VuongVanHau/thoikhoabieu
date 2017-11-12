using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class DAL
    {
        SqlConnection conn; //tình trạng kết nối
        SqlCommand comm;    //Lưu câu lệnh truy xuất
        public DAL() //hàm kết nối sql
        {
            conn = new SqlConnection(GetConnectionstring()); //tạo kết nối
            comm = conn.CreateCommand(); // Tạo mới đơn vị lưu câu lệnh sql
            conn.Open(); //mở kết nối
        }
        public string GetConnectionstring() //hàm xây dựng chuỗi kết nối
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();//xây dựng chuỗi kết nối mới
            builder.DataSource = "192.168.43.8"; //địa chỉ ip của máy chủ
            builder.InitialCatalog = "XepThoiKhoaBieu"; //tên Database
            builder.IntegratedSecurity = true;
            return builder.ConnectionString; //trả về chuỗi kết nối
        }
    }
}
