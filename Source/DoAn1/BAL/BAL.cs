﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALayer;
using System.Data;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Entity;
namespace BAL
{
    public class BALayer
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter da;
        DAL db = null;
        public BALayer()
        {
            db = new DAL();
            conn = new SqlConnection(db.GetConnectionstring());
            comm = conn.CreateCommand();
        }
        public DataTable ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open) conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open) conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public bool ThemTKB(ref string err, int MaGV, int MaLop, int MaMH, int MaTiet, int MaPH )
        {
            bool f = false;
            if (conn.State == ConnectionState.Open) conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = "insert into ThoiKhoaBieu value"+MaGV+","+MaLop + ","+MaMH + ","+MaTiet + "," + MaPH;
            comm.CommandType = CommandType.Text;
            try
            {
                f = MyExecuteNonQuery(comm.CommandText, comm.CommandType, ref err);
            }
            catch (SqlException ex)
            {
                err = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
    }
}
