using Location.buildingClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Location
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        roomClass r = new roomClass();
        private void buttonAddR_Click(object sender, EventArgs e)
        {
            r.BuildingName = comboBoxBuildingName.Text;
            r.RoomName = textBoxname.Text;
            r.FloorNo = int.Parse(comboBoxFloorNo.Text);
            r.Capacity = int.Parse(textBoxcapacity.Text);
            r.Types = comboBoxType.Text;

            //Insert data into data base using Insert method
            bool success = r.Insert(r);
            if (success == true)
            {
                MessageBox.Show("New Room Successfully Added");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to add Room, Try again!!");
            }
            //Load data on datagrid
            DataTable dt = r.Select();
            dataGridViewRoom.DataSource = dt;
        }

        public void clear()
        {
            comboBoxBuildingName.Text = "";
            textBoxname.Text = "";
            comboBoxFloorNo.Text = "";
            textBoxcapacity.Text = "";
            comboBoxType.Text = "";
            textBoxID.Text = "";
        }

        private void Room_Load(object sender, EventArgs e)
        {
            //Load data on datagrid
            DataTable dt = r.Select();
            dataGridViewRoom.DataSource = dt;
        }

        private void dataGridViewRoom_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxID.Text = dataGridViewRoom.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxBuildingName.Text = dataGridViewRoom.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxname.Text = dataGridViewRoom.Rows[rowIndex].Cells[2].Value.ToString();
            comboBoxFloorNo.Text = dataGridViewRoom.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxcapacity.Text = dataGridViewRoom.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxType.Text = dataGridViewRoom.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void button1UpdateR_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            r.RoomId = int.Parse(textBoxID.Text);
            r.BuildingName = comboBoxBuildingName.Text;
            r.Types = comboBoxType.Text;
            r.FloorNo = int.Parse(comboBoxFloorNo.Text);
            r.Capacity = int.Parse(textBoxcapacity.Text);
            r.RoomName = textBoxname.Text;

            //Insert data into data base using Insert method
            bool success = r.Update(r);
            if (success == true)
            {
                MessageBox.Show("New Building Successfully Updated");
                DataTable dt = r.Select();
                dataGridViewRoom.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to update building, Try again!!");
            }
        }

        private void buttonClearR_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void buttonDeleteR_Click(object sender, EventArgs e)
        {
            r.RoomId = Convert.ToInt32(textBoxID.Text);
            bool success = r.Delete(r);
            if (success == true)
            {
                MessageBox.Show("New Building Successfully Deleted");
                DataTable dt = r.Select();
                dataGridViewRoom.DataSource = dt;
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
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_room where buildingName LIKE '%" + keyWord + "%' OR roomName LIKE '%" + keyWord + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewRoom.DataSource = dt;
        }
    }
}
