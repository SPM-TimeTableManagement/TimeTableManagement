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
    class roomClass
    {
        public int RoomId { get; set; }
        public string BuildingName { get; set; }
        public int FloorNo { get; set; }
        public int Capacity { get; set; }
        public string RoomName { get; set; }
        public string Types { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable Select()
        {
            //Step1:DataBase Connetion
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Step2:writing sql query
                string sql = "SELECT * FROM tbl_room";
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

        public bool Insert(roomClass r)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //step1:Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2:writing sql query
                string sql = "INSERT INTO tbl_room(buildingName,roomName,floorNo,capacity,type) VALUES (@buildingName,@roomName,@floorNo,@capacity,@type)";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create a parameters to add data
                cmd.Parameters.AddWithValue("@buildingName", r.BuildingName);
                cmd.Parameters.AddWithValue("@roomName", r.RoomName);
                cmd.Parameters.AddWithValue("@floorNo", r.FloorNo);
                cmd.Parameters.AddWithValue("@capacity", r.Capacity);
                cmd.Parameters.AddWithValue("@type", r.Types);


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

        public bool Update(roomClass r)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //step1:Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2:writing sql query
                string sql = "UPDATE tbl_room SET buildingName=@buildingName, roomName=@roomName, floorNo=@floorNo, capacity=@capacity, type=@type WHERE roomID=@roomID";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create a parameters to add data
                cmd.Parameters.AddWithValue("@buildingName", r.BuildingName);
                cmd.Parameters.AddWithValue("@roomName", r.RoomName);
                cmd.Parameters.AddWithValue("@floorNo", r.FloorNo);
                cmd.Parameters.AddWithValue("@capacity", r.Capacity);
                cmd.Parameters.AddWithValue("@type", r.Types);
                cmd.Parameters.AddWithValue("@roomID", r.RoomId);

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

        public bool Delete(roomClass r)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //step1:Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2:writing sql query
                string sql = "DELETE FROM tbl_room WHERE roomID=@roomID";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create a parameters to add data
                cmd.Parameters.AddWithValue("@roomID", r.RoomId);

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
