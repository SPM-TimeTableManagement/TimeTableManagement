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
    class lectureRoomClass
    {
        //getter setter properties
        //Act as data carier in our application
        public int lectureRoomId { get; set; }
        public string LectureName { get; set; }
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
                string sql = "SELECT * FROM tbl_lecRoom";
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

        public bool Insert(lectureRoomClass lr)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //step1:Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2:writing sql query
                string sql = "INSERT INTO tbl_lecRoom(LecturerName,roomName,buildingName,type,capacity) VALUES (@LecturerName,@roomName,@buildingName,@type,@capacity)";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create a parameters to add data
                cmd.Parameters.AddWithValue("@LecturerName", lr.LectureName);
                cmd.Parameters.AddWithValue("@roomName", lr.RoomName);
                cmd.Parameters.AddWithValue("@buildingName", lr.BuildingName);
                cmd.Parameters.AddWithValue("@type", lr.Types);
                cmd.Parameters.AddWithValue("@capacity", lr.Capacity);



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

        public bool Update(lectureRoomClass lr)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //step1:Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2:writing sql query
                string sql = "UPDATE tbl_lecRoom SET LecturerName=@LecturerName, roomName=@roomName, buildingName=@buildingName, type=@type, capacity=@capacity  WHERE lecRoomID=@lecRoomID";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create a parameters to add data
                cmd.Parameters.AddWithValue("@LecturerName", lr.LectureName);
                cmd.Parameters.AddWithValue("@roomName", lr.RoomName);
                cmd.Parameters.AddWithValue("@buildingName", lr.BuildingName);
                cmd.Parameters.AddWithValue("@type", lr.Types);
                cmd.Parameters.AddWithValue("@capacity", lr.Capacity);
                cmd.Parameters.AddWithValue("@lecRoomID", lr.lectureRoomId);

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

        public bool Delete(lectureRoomClass lr)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //step1:Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2:writing sql query
                string sql = "DELETE FROM tbl_lecRoom WHERE lecRoomID=@lecRoomID";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create a parameters to add data
                cmd.Parameters.AddWithValue("@lecRoomID", lr.lectureRoomId);

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
