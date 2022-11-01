using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Data;

namespace ReceiptGenerator
{
    class DB
    {
        MySqlConnection sqlConnection = null;

        public DB()
        {
            try
            {
                this.sqlConnection = new MySqlConnection("server=localhost;user=root;database=GamakaAI;password=root");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public bool login(string username, string password) {
            try
            {
                this.sqlConnection.Open();
                string sql = "SELECT * FROM Login where username='" + username + "' and password='" + password + "';";
                var cmd = new MySqlCommand(sql, this.sqlConnection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally {
                this.sqlConnection.Close();
            }

            return false;
        }

        public bool insertintoStudentDetails(ArrayList studentData) {
            try
            {
                this.sqlConnection.Open();   
                string query = "insert into StudentDetails(id, name, address, skills, class_reference, qualification, year_of_passing, mode_of_class, pri_contact_number, another_contact_number, emailid, isAdmitted, work_experience, year_of_exprience, course, time_preference, todayDate) values(@val1,@val2,@val3,@val4,@val5,@val6,@val7,@val8,@val9,@val10,@val11,@val12,@val13,@val14,@val15,@val16,@val17)";

                var cmd = new MySqlCommand(query, this.sqlConnection);
                
                cmd.Parameters.AddWithValue("@val1", studentData[0]);
                cmd.Parameters.AddWithValue("@val2", studentData[1]);
                cmd.Parameters.AddWithValue("@val3", studentData[2]);
                cmd.Parameters.AddWithValue("@val4", studentData[3]);
                cmd.Parameters.AddWithValue("@val5", studentData[4]);
                cmd.Parameters.AddWithValue("@val6", studentData[5]);
                cmd.Parameters.AddWithValue("@val7", studentData[6]);
                cmd.Parameters.AddWithValue("@val8", studentData[7]);
                cmd.Parameters.AddWithValue("@val9", studentData[8]);
                cmd.Parameters.AddWithValue("@val10", studentData[9]);
                cmd.Parameters.AddWithValue("@val11", studentData[10]);
                cmd.Parameters.AddWithValue("@val12", studentData[11]);
                cmd.Parameters.AddWithValue("@val13", studentData[12]);
                cmd.Parameters.AddWithValue("@val14", studentData[13]);
                cmd.Parameters.AddWithValue("@val15", studentData[14]);
                cmd.Parameters.AddWithValue("@val16", studentData[15]);
                cmd.Parameters.AddWithValue("@val17", studentData[16]);
                cmd.Prepare();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally {
                this.sqlConnection.Close();
            }

            return false;
        }

        public AutoCompleteStringCollection namesofStudents()
        {
            AutoCompleteStringCollection names = new AutoCompleteStringCollection();
            try
            {
                this.sqlConnection.Open();
                string sql = "select name from StudentDetails";
                var cmd = new MySqlCommand(sql, this.sqlConnection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    names.Add(rdr["name"].ToString());
                    Console.WriteLine(rdr["name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.sqlConnection.Close();
            }

            return names;
        }

        public long readLastValuefromStudetDetails() {
            try
            {
                this.sqlConnection.Open();
                string sql = "select id from StudentDetails order by id DESC limit 1";
                var cmd = new MySqlCommand(sql, this.sqlConnection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    return Convert.ToInt64(rdr["id"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                this.sqlConnection.Close();
            }
            return 0;
        }

        public long generateID() {
            long prev_id = this.readLastValuefromStudetDetails();
            if (prev_id > 0)
            {
                prev_id++;
            }
            else {
                string year = DateTime.Now.ToString("yy");
                string month = DateTime.Now.Month.ToString();
                string day = DateTime.Now.Day.ToString();
                int number = 1111;

                return Convert.ToInt64(year + month + day + number.ToString());
            }


            return prev_id;
        }

        public DataTable getAllStudentData() {
            DataTable studentData = new DataTable();
            try
            {
                this.sqlConnection.Open();
                string sql = "select * from StudentDetails";
                var cmd = new MySqlCommand(sql, this.sqlConnection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                studentData.Load(rdr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.sqlConnection.Close();
            }

            return studentData;
        }

        ~DB() {
            try
            {
                this.sqlConnection.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
