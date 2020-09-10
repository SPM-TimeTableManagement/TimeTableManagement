using Location.buildingClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Location
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
            //Get the value from the input fields
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
            //Get the value from the input fields
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

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyWord = textBoxSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_building where buildingName LIKE '%"+keyWord+"%' OR floorNo LIKE '%"+ keyWord+"%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewBuildingView.DataSource = dt; 
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Show();
        }
    }
}
