using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM.Classes
{
    class lecturerClass
    {
        public int No { get; set; }
        public int EmployeeID { get; set; }
        public string LecturerName { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public string Center { get; set; }
        public string Building { get; set; }
        public string LevelLecture { get; set; }
        public string RankLecture { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //selecting data from database
        public DataTable Select()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //writing sql query
                string sql = "SELECT * FROM table_lecturer ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return dt;

        }

        //Insert
        public bool Insert(lecturerClass l)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //writing sql query
                //string sql = "INSERT INTO tbl_lecturer (EmployeeID, LecturerName, Faculty, Department, Center, Building, LevelLecture, RankLecturer) VALUES(@EmployeeID, @LecturerName, @Faculty, @Department, @Center, @Building, @LevelLecture, @RankLecturer)";
                string sql = "INSERT INTO table_lecturer (EmployeeID, LecturerName, Faculty, Department, Center, Building, LevelLecture, RankLecturer) VALUES(@EmployeeID, @LecturerName, @Faculty, @Department, @Center, @Building, @LevelLecture, '" + this.LevelLecture + "." + this.EmployeeID + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", l.EmployeeID);
                cmd.Parameters.AddWithValue("@LecturerName", l.LecturerName);
                cmd.Parameters.AddWithValue("@Faculty", l.Faculty);
                cmd.Parameters.AddWithValue("@Department", l.Department);
                cmd.Parameters.AddWithValue("@Center", l.Center);
                cmd.Parameters.AddWithValue("@Building", l.Building);
                cmd.Parameters.AddWithValue("@LevelLecture", l.LevelLecture);
                cmd.Parameters.AddWithValue("@RankLecturer", l.RankLecture);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }

            return isSuccess;


        }

        //update
        public bool Update(lecturerClass l)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //writing sql query
                //string sql = "UPDATE table_lecturer SET EmployeeID=@EmployeeID, LecturerName=@LecturerName, Faculty=@Faculty, Department=@Department, Center=@Center, Building=@Building, LevelLecture=@LevelLecture, RankLecturer=@RankLecturer WHERE No=@No";
                string sql = "UPDATE table_lecturer SET EmployeeID=@EmployeeID, LecturerName=@LecturerName, Faculty=@Faculty, Department=@Department, Center=@Center, Building=@Building, LevelLecture=@LevelLecture, RankLecturer='" + this.LevelLecture + "." + this.EmployeeID + "' WHERE No=@No";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@EmployeeID", l.EmployeeID);
                cmd.Parameters.AddWithValue("@LecturerName", l.LecturerName);
                cmd.Parameters.AddWithValue("@Faculty", l.Faculty);
                cmd.Parameters.AddWithValue("@Department", l.Department);
                cmd.Parameters.AddWithValue("@Center", l.Center);
                cmd.Parameters.AddWithValue("@Building", l.Building);
                cmd.Parameters.AddWithValue("@LevelLecture", l.LevelLecture);
                cmd.Parameters.AddWithValue("@RankLecturer", l.RankLecture);
                cmd.Parameters.AddWithValue("@No", l.No);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }


            return isSuccess;
        }

        //delete
        public bool Delete(lecturerClass l)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //writing sql query
                string sql = "DELETE FROM table_lecturer WHERE No=@No";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@No", l.No);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }


            return isSuccess;

        }
    }
}
