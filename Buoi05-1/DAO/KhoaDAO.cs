using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi05_1.DAO
{
    class KhoaDAO

    {

        SqlConnection conn = null;

        SqlCommand cmd = null;
        SqlDataAdapter apt = null;

        DataProvider kn = new DataProvider();



        public DataTable getList()

        {

            conn = kn.getConnect();
            string sql = "SELECT * FROM Khoa";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }

    }
}

