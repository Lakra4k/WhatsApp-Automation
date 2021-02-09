using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Xml;
using System.Data.SqlClient;

namespace WhatsApp_Robot
{
    class clsUtility
    {
        public static string CnString = Properties.Settings.Default.App_Conn_string;
        public static DataTable sqlDT = new DataTable();
        public static DataTable sqlDT2 = new DataTable();
        // Initializing Database Connection
        public static bool DBConnectionInitializing()
        {
            bool functionReturnValue = false;
            try
            {
                SqlConnection sqlCon = new SqlConnection();
                sqlCon.ConnectionString = CnString;
                sqlCon.Open();
                functionReturnValue = true;
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                functionReturnValue = false;
                Properties.Settings.Default.App_Default_Conn = false;
                Properties.Settings.Default.Save();
                MessageBox.Show("Error : " + ex.Message, "Erro ao estabelecer a conexão com banco de dados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
            return functionReturnValue;
        }

        public static DataTable ExecuteSQLQuery(string SQLQuery)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(CnString);
                SqlDataAdapter sqlDA = new SqlDataAdapter(SQLQuery, sqlCon);
                SqlCommandBuilder sqlCB = new SqlCommandBuilder(sqlDA);
                sqlDT.Reset();
                sqlDA.Fill(sqlDT);
            }
            catch (Exception ex)
            {
                Properties.Settings.Default.App_Default_Conn = false;
                Properties.Settings.Default.Save();
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sqlDT;
        }


        public static DataTable ExecuteSQLQuery2(string SQLQuery)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(CnString);
                SqlDataAdapter sqlDA = new SqlDataAdapter(SQLQuery, sqlCon);
                SqlCommandBuilder sqlCB = new SqlCommandBuilder(sqlDA);
                sqlDT2.Reset();
                sqlDA.Fill(sqlDT2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sqlDT2;
        }

        public static void FillDataGrid(string sql, DataGridView dgv)
        {
            SqlConnection conn = new SqlConnection(CnString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adp = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adp.SelectCommand = cmd;
                adp.Fill(dt);
                dgv.DataSource = dt;
                adp.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Preencher Combo Box Dinamicamente
        public static void FillComboBox(string sql, string Value_Member, string Display_Member, ComboBox combo)
        {
            DataTable dt = new DataTable();
            using (var connection = new SqlConnection(CnString))
            {
                using (var cmd = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    try
                    {
                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(" Error : " + e.ToString());
                    }
                }
            }
            combo.DataSource = dt;
            combo.ValueMember = Value_Member;
            combo.DisplayMember = Display_Member;
        }

        public static double num_repl(string a)
        {
            double n;
            bool isNumeric = double.TryParse(a, out n);
            return n;
        }

        public static object fltr_combo(ComboBox cmbo)
        {
            if (cmbo.SelectedIndex == -1)
            {
                return 0;
            }
            return cmbo.SelectedValue;
        }

    }
}
