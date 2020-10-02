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
    class subjectClass
    {
        public int No { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string OfferedYear { get; set; }
        public string OfferedSemester { get; set; }
        public string LectureHours { get; set; }
        public string TuteHours { get; set; }
        public string LabHours { get; set; }
        public string EvolutionHours { get; set; }

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
                string sql = "SELECT * FROM table_subject ";
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
        public bool Insert(subjectClass s)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //writing sql query
                string sql = "INSERT INTO table_subject (SubjectCode, SubjectName, OfferedYear, OfferedSemester, LectureHours, TuteHours, LabHours, EvolutionHours) VALUES(@SubjectCode, @SubjectName, @OfferedYear, @OfferedSemester, @LectureHours, @TuteHours, @LabHours, @EvolutionHours)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SubjectCode", s.SubjectCode);
                cmd.Parameters.AddWithValue("@SubjectName", s.SubjectName);
                cmd.Parameters.AddWithValue("@OfferedYear", s.OfferedYear);
                cmd.Parameters.AddWithValue("@OfferedSemester", s.OfferedSemester);
                cmd.Parameters.AddWithValue("@LectureHours", s.LectureHours);
                cmd.Parameters.AddWithValue("@TuteHours", s.TuteHours);
                cmd.Parameters.AddWithValue("@LabHours", s.LabHours);
                cmd.Parameters.AddWithValue("@EvolutionHours", s.EvolutionHours);

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
        public bool Update(subjectClass s)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //writing sql query
                string sql = "UPDATE table_subject SET SubjectCode=@SubjectCode, SubjectName=@SubjectName, OfferedYear=@OfferedYear, OfferedSemester=@OfferedSemester, LectureHours=@LectureHours, TuteHours=@TuteHours, LabHours=@LabHours, EvolutionHours=@EvolutionHours WHERE No=@No";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@SubjectCode", s.SubjectCode);
                cmd.Parameters.AddWithValue("@SubjectName", s.SubjectName);
                cmd.Parameters.AddWithValue("@OfferedYear", s.OfferedYear);
                cmd.Parameters.AddWithValue("@OfferedSemester", s.OfferedSemester);
                cmd.Parameters.AddWithValue("@LectureHours", s.LectureHours);
                cmd.Parameters.AddWithValue("@TuteHours", s.TuteHours);
                cmd.Parameters.AddWithValue("@LabHours", s.LabHours);
                cmd.Parameters.AddWithValue("@EvolutionHours", s.EvolutionHours);
                cmd.Parameters.AddWithValue("@No", s.No);

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
        public bool Delete(subjectClass s)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //writing sql query
                string sql = "DELETE FROM table_subject WHERE No=@No";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@No", s.No);

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
