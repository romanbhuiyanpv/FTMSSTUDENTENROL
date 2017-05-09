using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FTMS_STUDENT_ENROLL_SYSTEM
{
    class DataAccessLayer
    {
        public SqlConnection Constr = null;
        public SqlConnection connectring()
        {
            //string Conn = @"Data source=E-TECH-PC;Initial Catalog=Billing;Connect Timeout=1000;Integrated Security=true";
            string Conn = @"Data source=WINCTRL-MF9ENN9\SQLEXPRESS;Initial Catalog=UniversityMannagement;Connect Timeout=100;Integrated Security=true";
            Constr = new SqlConnection(Conn);
            return Constr;
        }
        public DataTable GetData(string sql)
        {
            DataTable DT = new DataTable();
            SqlConnection dbcon = null;
            try
            {
                dbcon = connectring();
                dbcon.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(sql, dbcon);
                SDA.Fill(DT);
            }
            catch (Exception ex)
            {
                string Mess = ex.Message;

            }
            finally
            {
                dbcon.Close();
            }
            return DT;

        }
        public string Executable(string sql)
        {
            string rtt = "";
            SqlConnection dbcon = null;
            try
            {
                dbcon = connectring();
                dbcon.Open();
                SqlCommand sqlcmd = new SqlCommand(sql, dbcon);
                sqlcmd.ExecuteNonQuery();
                rtt = "Succeded";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbcon.Close();
            }
            return rtt;
        }
    }
}
