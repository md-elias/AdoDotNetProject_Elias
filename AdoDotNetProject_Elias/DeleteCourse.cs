﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
namespace AdoDotNetProject_Elias
{
    class DeleteCourse
    {
        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;


        public void DeleteCourseData(string query)
        {
            using (con = new SqlConnection(cs))
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
    }
}
