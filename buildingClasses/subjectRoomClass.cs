using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM.buildingClasses
{
    class subjectRoomClass
    {

        //getter setter properties
        //Act as data carier in our application
        public int subjectRoomId { get; set; }
        public string SubjectName { get; set; }
        public string TagName { get; set; }
        public string RoomName { get; set; }
        public string BuildingName { get; set; }
        public string Types { get; set; }
        public int Capacity { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable Select()
        {
            //Step1:DataBase Connetion
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Step2:writing sql query
                string sql = "SELECT * FROM tbl_subRoom";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating SQL DataAdapter using cmd
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


        public bool Insert(subjectRoomClass sr)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //step1:Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2:writing sql query
                string sql = "INSERT INTO tbl_subRoom(SubjectName,tagname,roomName,buildingName,type,capacity) VALUES (@SubjectName,@tagname,@roomName,@buildingName,@type,@capacity)";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create a parameters to add data
                cmd.Parameters.AddWithValue("@SubjectName", sr.SubjectName);
                cmd.Parameters.AddWithValue("@tagname", sr.TagName);
                cmd.Parameters.AddWithValue("@roomName", sr.RoomName);
                cmd.Parameters.AddWithValue("@buildingName", sr.BuildingName);
                cmd.Parameters.AddWithValue("@type", sr.Types);
                cmd.Parameters.AddWithValue("@capacity", sr.Capacity);



                //onnection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query run success rows>0
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

        public bool Update(subjectRoomClass sr)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //step1:Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2:writing sql query
                string sql = "UPDATE tbl_subRoom SET SubjectName=@SubjectName, tagname=@tagname, roomName=@roomName, buildingName=@buildingName, type=@type, capacity=@capacity  WHERE subjRoomID=@subjRoomID";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create a parameters to add data
                cmd.Parameters.AddWithValue("@SubjectName", sr.SubjectName);
                cmd.Parameters.AddWithValue("@tagname", sr.TagName);
                cmd.Parameters.AddWithValue("@roomName", sr.RoomName);
                cmd.Parameters.AddWithValue("@buildingName", sr.BuildingName);
                cmd.Parameters.AddWithValue("@type", sr.Types);
                cmd.Parameters.AddWithValue("@capacity", sr.Capacity);
                cmd.Parameters.AddWithValue("@subjRoomID", sr.subjectRoomId);

                //onnection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query run success rows>0
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

        public bool Delete(subjectRoomClass sr)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //step1:Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2:writing sql query
                string sql = "DELETE FROM tbl_subRoom WHERE subjRoomID=@subjRoomID";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create a parameters to add data
                cmd.Parameters.AddWithValue("@subjRoomID", sr.subjectRoomId);

                //onnection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query run success rows>0
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
