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

        public bool insertCourseDetails(String name, int fees) {
            try
            {
                this.sqlConnection.Open();
                string query = "insert into Courses(name, fees) values(@val1,@val2)";

                var cmd = new MySqlCommand(query, this.sqlConnection);

                cmd.Parameters.AddWithValue("@val1", name);
                cmd.Parameters.AddWithValue("@val2", fees);
                
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
            finally
            {
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

        public String getSpecificNameById(long id) {
            String name= "";
            try
            {
                this.sqlConnection.Open();
                string sql = "select name from StudentDetails where id='" + id + "'";
                var cmd = new MySqlCommand(sql, this.sqlConnection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read()) {
                    name = rdr["name"].ToString();
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

            return name;
        }

        public DataTable getSpecificRow(String name) {
            DataTable studentData = new DataTable();
            try
            {
                this.sqlConnection.Open();
                string sql = "select * from StudentDetails where name='"+name+"'";
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

        public String getSpecificCourseByID(int id) {
            String name = "";
            try
            {
                this.sqlConnection.Open();
                string sql = "select name from Courses where id='" + id + "'";
                var cmd = new MySqlCommand(sql, this.sqlConnection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    name = rdr["name"].ToString();
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

            return name;
        }

        public ArrayList getSpecificCourseDetail(String name) {
            ArrayList course = new ArrayList();
            try
            {
                this.sqlConnection.Open();
                string sql = "select * from Courses where name='" + name + "'";
                var cmd = new MySqlCommand(sql, this.sqlConnection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read()) {
                    course.Add(rdr["id"]);
                    course.Add(rdr["name"]);
                    course.Add(rdr["fees"]);
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

            return course;
        }

        public DataTable getAllCourseDetails() { 
            DataTable coursedetails = new DataTable();
            try
            {
                this.sqlConnection.Open();
                string sql = "select * from Courses";
                var cmd = new MySqlCommand(sql, this.sqlConnection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                coursedetails.Load(rdr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.sqlConnection.Close();
            }

            return coursedetails;
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

        public ArrayList getAllCourses() {
            ArrayList course = new ArrayList();
            try
            {
                this.sqlConnection.Open();
                string sql = "select name from Courses";
                var cmd = new MySqlCommand(sql, this.sqlConnection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    course.Add(rdr["name"]);
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

            return course;
        }



        public void updateCourseDetails(ArrayList coursedetails) {
            try
            {
                this.sqlConnection.Open();
                
                string query = "update Courses set name=@val1, fees=@val2 where id=@val0";
                var cmd = new MySqlCommand(query, this.sqlConnection);

                cmd.Parameters.AddWithValue("@val1", coursedetails[1]);
                cmd.Parameters.AddWithValue("@val2", coursedetails[2]);
                cmd.Parameters.AddWithValue("@val0", coursedetails[0]);

                cmd.Prepare();
                if (cmd.ExecuteNonQuery() > 0)
                {

                    MessageBox.Show("Data Update Successfully of ID:" + coursedetails[0]);
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.sqlConnection.Close();
            }
        }

        public void UpdateStudentRecord(ArrayList studentData) {
            try
            {
                this.sqlConnection.Open();
                string query = "update StudentDetails set id=@val1, name=@val2, address=@val3, skills=@val4, class_reference=@val5, qualification=@val6, year_of_passing=@val7, mode_of_class=@val8, pri_contact_number=@val9, another_contact_number=@val10, emailid=@val11, isAdmitted=@val12, work_experience=@val13, year_of_exprience=@val14, course=@val15, time_preference=@val16, todayDate=@val17 where id=@val18";

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
                cmd.Parameters.AddWithValue("@val18", studentData[0]);
                cmd.Prepare();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data Update Successfully of ID:" + studentData[0]);
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.sqlConnection.Close();
            }
        }

        // remaining work.
        public int getPaymentDetailsbyId(long id) {
            //ArrayList course = new ArrayList();
            int paidfees = 0;
            int remainingfee = 0;
            try
            {
                this.sqlConnection.Open();
                string sql = String.Format("select fees, paidfees from Payments where studentID={0}", id);
                var cmd = new MySqlCommand(sql, this.sqlConnection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                
                while (rdr.Read())
                {
                    paidfees += Convert.ToInt32(rdr["paidfees"]);
                }
                if (rdr.HasRows == true)
                {
                    remainingfee = Convert.ToInt32(rdr["fees"]) - paidfees;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.sqlConnection.Close();
            }

            return remainingfee;
        }

        public bool insertPaymentDetails(ArrayList payment) {
            try
            {
                this.sqlConnection.Open();
                string query = "insert into Payments(studentID, courseID, installment, fees, paidfees, paymentDate) values(@val1,@val2,@val3,@val4,@val5,@val6)";

                var cmd = new MySqlCommand(query, this.sqlConnection);

                cmd.Parameters.AddWithValue("@val1", payment[0]);
                cmd.Parameters.AddWithValue("@val2", payment[1]);
                cmd.Parameters.AddWithValue("@val3", payment[2]);
                cmd.Parameters.AddWithValue("@val4", payment[3]);
                cmd.Parameters.AddWithValue("@val5", payment[4]);
                cmd.Parameters.AddWithValue("@val6", payment[5]);
               
                cmd.Prepare();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
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

            return false;
        }

        public DataTable getSpecificPaymentDetails(long id) { 
            DataTable payments = new DataTable();
            try
            {
                this.sqlConnection.Open();
                string sql = String.Format("select * from Payments where studentID="+id);
                var cmd = new MySqlCommand(sql, this.sqlConnection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                payments.Load(rdr);                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.sqlConnection.Close();
            }

            return payments;
        }

        public DataTable getPaymentData() {
            DataTable payments = new DataTable();
            try
            {
                this.sqlConnection.Open();
                string sql = String.Format("select * from Payments");
                var cmd = new MySqlCommand(sql, this.sqlConnection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                payments.Load(rdr);                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.sqlConnection.Close();
            }

            return payments;
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
