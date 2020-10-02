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
    class buildingClass
    {
        //getter setter properties
        //Act as data carier in our application
        public int BuidingId { get; set; }
        public string BuildingName { get; set; }
        public int NoOfFloor { get; set; }
        public int NoOfRooms { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting data from database
        public DataTable Select()
        {
            //Step1:DataBase Connetion
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Step2:writing sql query
                string sql = "SELECT * FROM tbl_building";
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

        //Inserting Data Into Database
        public bool Insert(buildingClass b)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //step1:Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2:writing sql query
                string sql = "INSERT INTO tbl_building(buildingName,floorNo,NoOfRooms) VALUES (@buildingName,@floorNo,@NoOfRooms)";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create a parameters to add data
                cmd.Parameters.AddWithValue("@buildingName", b.BuildingName);
                cmd.Parameters.AddWithValue("@floorNo", b.NoOfFloor);
                cmd.Parameters.AddWithValue("@NoOfRooms", b.NoOfRooms);

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

        //Method to update data in database from our application.
        public bool Update(buildingClass b)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //step1:Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2:writing sql query
                string sql = "UPDATE tbl_building SET buildingName=@buildingName, floorNo=@floorNo, NoOfRooms=@NoOfRooms WHERE buildingID=@buildingID";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create a parameters to add data
                cmd.Parameters.AddWithValue("@buildingName", b.BuildingName);
                cmd.Parameters.AddWithValue("@floorNo", b.NoOfFloor);
                cmd.Parameters.AddWithValue("@NoOfRooms", b.NoOfRooms);
                cmd.Parameters.AddWithValue("@buildingID", b.BuidingId);

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

        public bool Delete(buildingClass b)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;
            //step1:Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Step2:writing sql query
                string sql = "DELETE FROM tbl_building WHERE buildingID=@buildingID";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create a parameters to add data
                cmd.Parameters.AddWithValue("@buildingID", b.BuidingId);

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
