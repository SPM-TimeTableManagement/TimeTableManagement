using SPM.buildingClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPM
{
    public partial class Building : Form
    {
        public Building()
        {
            InitializeComponent();
        }


        buildingClass b = new buildingClass();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string keyWord = textBoxName.Text;
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_building where buildingName LIKE '%" + keyWord + "%'", conn);
            DataTable DTs = new DataTable();
            sda.Fill(DTs);

            Regex regex = new Regex(@"^[0-9]+$");

            //Get the value from the input fields
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Bulding name is required !");
            }
            else if (DTs.Rows.Count != 0)
            {
                MessageBox.Show("Bulding name is already used, Please use another name !");
            }
            else if (textBoxFloors.Text == "")
            {
                MessageBox.Show("No of Floors are required !");
            }
            else if (!regex.IsMatch(textBoxFloors.Text))
            {
                MessageBox.Show("No of Floors fields must only numeric value!");
            }

            else if (textBoxRooms.Text == "")
            {
                MessageBox.Show("No of Rooms are required !");
            }
            else if (!regex.IsMatch(textBoxRooms.Text))
            {
                MessageBox.Show("No of Rooms fields must only numeric value!");
            }
            else
            {
                b.BuildingName = textBoxName.Text;
                b.NoOfFloor = int.Parse(textBoxFloors.Text);
                b.NoOfRooms = int.Parse(textBoxRooms.Text);

                //Insert data into data base using Insert method
                bool success = b.Insert(b);
                if (success == true)
                {
                    MessageBox.Show("New Building Successfully Added");
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to add building, Try again!!");
                }
                //Load data on datagrid
                DataTable dt = b.Select();
                dataGridViewBuildingView.DataSource = dt;
            }
        }

        public void clear()
        {
            textBoxBuildingID.Text = "";
            textBoxName.Text = "";
            textBoxFloors.Text = "";
            textBoxRooms.Text = "";
        }

        private void Building_Load(object sender, EventArgs e)
        {
            //Load data on datagrid
            DataTable dt = b.Select();
            dataGridViewBuildingView.DataSource = dt;
        }

        private void dataGridViewBuildingView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxBuildingID.Text = dataGridViewBuildingView.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewBuildingView.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxFloors.Text = dataGridViewBuildingView.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxRooms.Text = dataGridViewBuildingView.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string keyWord = textBoxName.Text;
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_building where buildingName LIKE '%" + keyWord + "%'", conn);
            DataTable DTs = new DataTable();
            sda.Fill(DTs);

            Regex regex = new Regex(@"^[0-9]+$");

            //Get the value from the input fields
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Bulding name is required !");
            }
            else if (DTs.Rows.Count != 0)
            {
                MessageBox.Show("Bulding name is already used, Please use another name !");
            }
            else if (textBoxFloors.Text == "")
            {
                MessageBox.Show("No of Floors are required !");
            }
            else if (!regex.IsMatch(textBoxFloors.Text))
            {
                MessageBox.Show("No of Floors fields must only numeric value!");
            }

            else if (textBoxRooms.Text == "")
            {
                MessageBox.Show("No of Rooms are required !");
            }
            else if (!regex.IsMatch(textBoxRooms.Text))
            {
                MessageBox.Show("No of Rooms fields must only numeric value!");
            }
            //Get the value from the input fields
            else
            {
                b.BuidingId = int.Parse(textBoxBuildingID.Text);
                b.BuildingName = textBoxName.Text;
                b.NoOfFloor = int.Parse(textBoxFloors.Text);
                b.NoOfRooms = int.Parse(textBoxRooms.Text);

                //Insert data into data base using Insert method
                bool success = b.Update(b);
                if (success == true)
                {
                    MessageBox.Show("New Building Successfully Updated");
                    DataTable dt = b.Select();
                    dataGridViewBuildingView.DataSource = dt;
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to update building, Try again!!");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            b.BuidingId = Convert.ToInt32(textBoxBuildingID.Text);
            bool success = b.Delete(b);
            if (success == true)
            {
                MessageBox.Show("New Building Successfully Deleted");
                DataTable dt = b.Select();
                dataGridViewBuildingView.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete building, Try again!!");
            }

        }

        static string connstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyWord = textBoxSearch.Text;
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_building where buildingName LIKE '%" + keyWord + "%' OR floorNo LIKE '%" + keyWord + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewBuildingView.DataSource = dt;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {

        }
    }
}
