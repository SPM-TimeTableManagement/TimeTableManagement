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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPM
{
    public partial class AssignRoomForLecturer : Form
    {
        public AssignRoomForLecturer()
        {
            InitializeComponent();
        }
        lectureRoomClass lr = new lectureRoomClass();
        static string connstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void AssignRoomForLecturer_Load(object sender, EventArgs e)
        {
            //Load data on datagrid
            DataTable dt = lr.Select();
            dataGridView1LecRoom.DataSource = dt;
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sdad = new SqlDataAdapter("Select distinct LecturerName from table_lecturer", conn);
            DataTable DTT = new DataTable();
            sdad.Fill(DTT);
            SqlDataAdapter sda = new SqlDataAdapter("Select distinct roomName from tbl_room", conn);
            DataTable DTs = new DataTable();
            sda.Fill(DTs);
            comboBoxLECT.Items.Clear();
            comboBox1Room.Items.Clear();
            //comboBoxBuildingName.Items.Add("---SELECT---");
            foreach (DataRow row in DTT.Rows)
            {
                comboBoxLECT.Items.Add(row["LecturerName"].ToString());
            }

            foreach (DataRow row in DTs.Rows)
            {
                comboBox1Room.Items.Add(row["roomName"].ToString());
            }
        }

        private void button2Assign_Click(object sender, EventArgs e)
        {
            string keyWord = comboBoxLECT.Text;
            string keyWord2 = comboBox1Room.Text;
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_lecRoom where LecturerName='" + keyWord + "' and roomName='" + keyWord2 + "'", conn);
            DataTable DTs = new DataTable();
            sda.Fill(DTs);

            if (comboBoxLECT.Text == "")
            {
                MessageBox.Show("Please Select Lecturer name !");
            }
            else if (comboBox1Room.Text == "")
            {
                MessageBox.Show("Please Select Room Name !");
            }
            else if (DTs.Rows.Count != 0)
            {
                MessageBox.Show("Room is already Assigned for this Lecturer, Please use another Room !");
            }
            else
            {
                lr.LectureName = comboBoxLECT.Text;
                lr.RoomName = comboBox1Room.Text;
                lr.BuildingName = textBox2Building.Text;
                lr.Types = textBox2Type.Text;
                lr.Capacity = int.Parse(textBox2Capacity.Text);


                //Insert data into data base using Insert method
                bool success = lr.Insert(lr);
                if (success == true)
                {
                    MessageBox.Show("Room Successfully Assigned");
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to Assign Room, Try again!!");
                }
                //Load data on datagrid
                DataTable dt = lr.Select();
                dataGridView1LecRoom.DataSource = dt;
            }
        }

        public void clear()
        {
                comboBoxLECT.Text = "";
                comboBox1Room.Text = "";
                textBox2Building.Text = "";
                textBox2Type.Text = "";
                textBox2Capacity.Text = "";
                textBox1.Text = "";
        }

        private void dataGridView1LecRoom_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBox1.Text = dataGridView1LecRoom.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxLECT.Text = dataGridView1LecRoom.Rows[rowIndex].Cells[1].Value.ToString();
            comboBox1Room.Text = dataGridView1LecRoom.Rows[rowIndex].Cells[2].Value.ToString();
            textBox2Building.Text = dataGridView1LecRoom.Rows[rowIndex].Cells[3].Value.ToString();
            textBox2Type.Text = dataGridView1LecRoom.Rows[rowIndex].Cells[4].Value.ToString();
            textBox2Capacity.Text = dataGridView1LecRoom.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void button3Update_Click(object sender, EventArgs e)
        {
            string keyWord = comboBoxLECT.Text;
            string keyWord2 = comboBox1Room.Text;
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_lecRoom where LecturerName='" + keyWord + "' and roomName='" + keyWord2 + "'", conn);
            DataTable DTs = new DataTable();
            sda.Fill(DTs);

            if (comboBoxLECT.Text == "")
            {
                MessageBox.Show("Please Select Lecturer name !");
            }
            else if (comboBox1Room.Text == "")
            {
                MessageBox.Show("Please Select Room Name !");
            }
            else if (DTs.Rows.Count != 0)
            {
                MessageBox.Show("Room is already Assigned for this Lecturer, Please use another Room !");
            }
            else
            {
                //Get the value from the input fields
                lr.lectureRoomId = int.Parse(textBox1.Text);
                lr.LectureName = comboBoxLECT.Text;
                lr.RoomName = comboBox1Room.Text;
                lr.BuildingName = textBox2Building.Text;
                lr.Types = textBox2Type.Text;
                lr.Capacity = int.Parse(textBox2Capacity.Text);


                //Insert data into data base using Insert method
                bool success = lr.Update(lr);
                if (success == true)
                {
                    MessageBox.Show("Assigned Room Successfully Changed");
                    DataTable dt = lr.Select();
                    dataGridView1LecRoom.DataSource = dt;
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to change Assigned Room, Try again!!");
                }
            }
        }

        private void button1Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button4Remove_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Select Assigned Room before Remove!!");
            }
            else if ((MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                lr.lectureRoomId = Convert.ToInt32(textBox1.Text);
                bool success = lr.Delete(lr);
                if (success == true)
                {
                    MessageBox.Show("Assigned Room Successfully Removed");
                    DataTable dt = lr.Select();
                    dataGridView1LecRoom.DataSource = dt;
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to Remove Assigned Room, Try again!!");
                }
            }
        }

        private void textBox2Search_TextChanged(object sender, EventArgs e)
        {
            string keyWord = textBox2Search.Text;
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_lecRoom where LecturerName LIKE '%" + keyWord + "%' OR roomName LIKE '%" + keyWord + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1LecRoom.DataSource = dt;
        }

        private void comboBox1Room_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sdada = new SqlDataAdapter("Select distinct buildingName from tbl_room where roomName='" + comboBox1Room.Text + "'", conn);
            DataTable dttt = new DataTable();
            sdada.Fill(dttt);
            textBox2Building.Clear();

            SqlDataAdapter sda = new SqlDataAdapter("Select distinct type from tbl_room where roomName='" + comboBox1Room.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBox2Type.Clear();

            SqlDataAdapter sdad = new SqlDataAdapter("Select distinct capacity from tbl_room where roomName='" + comboBox1Room.Text + "'", conn);
            DataTable dtt = new DataTable();
            sdad.Fill(dtt);
            textBox2Capacity.Clear();

            foreach (DataRow row in dttt.Rows)
            {
                textBox2Building.Text = (row["buildingName"].ToString());
            }

            foreach (DataRow row in dt.Rows)
            {
                textBox2Type.Text = (row["type"].ToString());
            }

            foreach (DataRow row in dtt.Rows)
            {
                textBox2Capacity.Text = (row["capacity"].ToString());
            }
        }
    }
}
