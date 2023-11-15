﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    internal class Database
    {
        private static string connStr = "Data Source=DESKTOP-KB3GR2O\\LAMLYLE;Initial Catalog=QuanLyHocSinh;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(connStr);

        public static void Execute(string sql, Dictionary<string, object> parameters = null)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (parameters != null)
            {
                foreach (string key in parameters.Keys)
                {
                    cmd.Parameters.Add(new SqlParameter(key, parameters[key]));
                }
            }
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable Query(string sql, Dictionary<string, object> parameters = null)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (parameters != null)
            {
                foreach (string key in parameters.Keys)
                {
                    cmd.Parameters.Add(new SqlParameter(key, parameters[key]));
                }
            }
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapt.Fill(table);
            conn.Close();
            return table;
        }
    }
}
