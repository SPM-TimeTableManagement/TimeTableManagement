using SPM.buildingClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPM
{
    public partial class AssignRoomForTag : Form
    {
        public AssignRoomForTag()
        {
            InitializeComponent();
        }

        tagRoomClass tr = new tagRoomClass();
        static string connstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void textBoxCapacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            string keyWord = comboBoxTagName.Text;
            string keyWord2 = comboBoxRoomName.Text;
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_tagRoom where tagname='" + keyWord + "' and roomName='" + keyWord2 + "'", conn);
            DataTable DTs = new DataTable();
            sda.Fill(DTs);

            if (comboBoxTagName.Text == "")
            {
                MessageBox.Show("Please Select Tag name !");
            }
            else if (comboBoxRoomName.Text == "")
            {
                MessageBox.Show("Please Select Room Name !");
            }
            else if (DTs.Rows.Count != 0)
            {
                MessageBox.Show("Room is already Assigned for this Tag, Please use another Room !");
            }
            else
            {
                tr.TagName = comboBoxTagName.Text;
                tr.RoomName = comboBoxRoomName.Text;
                tr.Types = textBoxRoomType.Text;
                tr.Capacity = int.Parse(textBoxCapacity.Text);


                //Insert data into data base using Insert method
                bool success = tr.Insert(tr);
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
                DataTable dt = tr.Select();
                dataGridViewTagRoom.DataSource = dt;
            }
        }

        public void clear()
        {
            comboBoxTagName.Text = "";
            comboBoxRoomName.Text = "";
            textBoxRoomType.Text = "";
            textBoxCapacity.Text = "";
            textBoxID.Text = "";
        }

        private void AssignRoomForTag_Load(object sender, EventArgs e)
        {
            //Load data on datagrid
            DataTable dt = tr.Select();
            dataGridViewTagRoom.DataSource = dt;
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sdad = new SqlDataAdapter("Select distinct tagName from tags", conn);
            DataTable DTT = new DataTable();
            sdad.Fill(DTT);
            SqlDataAdapter sda = new SqlDataAdapter("Select distinct roomName from tbl_room", conn);
            DataTable DTs = new DataTable();
            sda.Fill(DTs);
            comboBoxTagName.Items.Clear();
            comboBoxRoomName.Items.Clear();
            //comboBoxBuildingName.Items.Add("---SELECT---");
            foreach (DataRow row in DTT.Rows)
            {
                comboBoxTagName.Items.Add(row["tagName"].ToString());
            }

            foreach (DataRow row in DTs.Rows)
            {
                comboBoxRoomName.Items.Add(row["roomName"].ToString());
            }
        }

        private void dataGridViewTagRoom_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxID.Text = dataGridViewTagRoom.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxTagName.Text = dataGridViewTagRoom.Rows[rowIndex].Cells[1].Value.ToString();
            comboBoxRoomName.Text = dataGridViewTagRoom.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxRoomType.Text = dataGridViewTagRoom.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxCapacity.Text = dataGridViewTagRoom.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void button1Change_Click(object sender, EventArgs e)
        {
            string keyWord = comboBoxTagName.Text;
            string keyWord2 = comboBoxRoomName.Text;
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_tagRoom where tagname='" + keyWord + "' and roomName='" + keyWord2 + "'", conn);
            DataTable DTs = new DataTable();
            sda.Fill(DTs);

            if (comboBoxTagName.Text == "")
            {
                MessageBox.Show("Please Select Tag name !");
            }
            else if (comboBoxRoomName.Text == "")
            {
                MessageBox.Show("Please Select Room Name !");
            }
            else if (DTs.Rows.Count != 0)
            {
                MessageBox.Show("Room is already Assigned for this Tag, Please use another Room !");
            }
            else
            {
                //Get the value from the input fields
                tr.tagRoomId = int.Parse(textBoxID.Text);
                tr.TagName = comboBoxTagName.Text;
                tr.RoomName = comboBoxRoomName.Text;
                tr.Types = textBoxRoomType.Text;
                tr.Capacity = int.Parse(textBoxCapacity.Text);
                

                //Insert data into data base using Insert method
                bool success = tr.Update(tr);
                if (success == true)
                {
                    MessageBox.Show("Assigned Room Successfully Changed");
                    DataTable dt = tr.Select();
                    dataGridViewTagRoom.DataSource = dt;
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

        private void button1Reomove_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Please Select Assigned Room before Remove!!");
            }
            else if((MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                tr.tagRoomId = Convert.ToInt32(textBoxID.Text);
                bool success = tr.Delete(tr);
                if (success == true)
                {
                    MessageBox.Show("Assigned Room Successfully Removed");
                    DataTable dt = tr.Select();
                    dataGridViewTagRoom.DataSource = dt;
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to Remove Assigned Room, Try again!!");
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyWord = textBoxSearch.Text;
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_tagRoom where tagname LIKE '%" + keyWord + "%' OR roomName LIKE '%" + keyWord + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewTagRoom.DataSource = dt;
        }

        private void comboBoxRoomName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sda = new SqlDataAdapter("Select distinct type from tbl_room where roomName='" + comboBoxRoomName.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBoxRoomType.Clear();

            SqlDataAdapter sdad = new SqlDataAdapter("Select distinct capacity from tbl_room where roomName='" + comboBoxRoomName.Text + "'", conn);
            DataTable dtt = new DataTable();
            sdad.Fill(dtt);
            textBoxCapacity.Clear();
            foreach (DataRow row in dt.Rows)
            {
                textBoxRoomType.Text = (row["type"].ToString());
            }

            foreach (DataRow row in dtt.Rows)
            {
                textBoxCapacity.Text=(row["capacity"].ToString());
            }

        }
    }
}
