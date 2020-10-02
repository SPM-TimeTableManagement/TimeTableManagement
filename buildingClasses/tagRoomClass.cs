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
    class tagRoomClass
    {
        //getter setter properties
        //Act as data carier in our application
        public int tagRoomId { get; set; }
        public string TagName { get; set; }
        public string RoomName { get; set; }
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
                string sql = "SELECT * FROM tbl_tagRoom";
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

        public bool Insert(tagRoomClass tr)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //step1:Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2:writing sql query
                string sql = "INSERT INTO tbl_tagRoom(tagname,roomName,type,capacity) VALUES (@tagname,@roomName,@type,@capacity)";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create a parameters to add data
                cmd.Parameters.AddWithValue("@tagname", tr.TagName);
                cmd.Parameters.AddWithValue("@roomName", tr.RoomName);
                cmd.Parameters.AddWithValue("@type", tr.Types);
                cmd.Parameters.AddWithValue("@capacity", tr.Capacity);
               


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

        public bool Update(tagRoomClass tr)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //step1:Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2:writing sql query
                string sql = "UPDATE tbl_tagRoom SET tagname=@tagname, roomName=@roomName, type=@type, capacity=@capacity  WHERE tagRoomID=@tagRoomID";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create a parameters to add data
                cmd.Parameters.AddWithValue("@tagname", tr.TagName);
                cmd.Parameters.AddWithValue("@roomName", tr.RoomName);
                cmd.Parameters.AddWithValue("@type", tr.Types);
                cmd.Parameters.AddWithValue("@capacity", tr.Capacity);
                cmd.Parameters.AddWithValue("@tagRoomID", tr.tagRoomId);

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

        public bool Delete(tagRoomClass tr)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //step1:Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2:writing sql query
                string sql = "DELETE FROM tbl_tagRoom WHERE tagRoomID=@tagRoomID";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create a parameters to add data
                cmd.Parameters.AddWithValue("@tagRoomID", tr.tagRoomId);

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
