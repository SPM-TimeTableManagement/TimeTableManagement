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
    public partial class AssignRoomForSubject : Form
    {
        public AssignRoomForSubject()
        {
            InitializeComponent();
        }

        subjectRoomClass sr = new subjectRoomClass();
        static string connstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AssignRoomForSubject_Load(object sender, EventArgs e)
        {
            DataTable dt = sr.Select();
            dataGridView1RoomSubject.DataSource = dt;
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sdad = new SqlDataAdapter("Select distinct SubjectName from table_subject", conn);
            DataTable DTT = new DataTable();
            sdad.Fill(DTT);
            SqlDataAdapter sda = new SqlDataAdapter("Select distinct tagname from tags", conn);
            DataTable DTs = new DataTable();
            sda.Fill(DTs);
            SqlDataAdapter sd = new SqlDataAdapter("Select distinct roomName from tbl_room", conn);
            DataTable DT = new DataTable();
            sd.Fill(DT);

            comboBox1Subject.Items.Clear();
            comboBox2Tag.Items.Clear();
            comboBox3Room.Items.Clear();
            comboBox1FilterSub.Items.Clear();
            comboBox2FilterTag.Items.Clear();
            //comboBoxBuildingName.Items.Add("---SELECT---");
            foreach (DataRow row in DTT.Rows)
            {
                comboBox1Subject.Items.Add(row["SubjectName"].ToString());
                comboBox1FilterSub.Items.Add(row["SubjectName"].ToString());

            }

            foreach (DataRow row in DTs.Rows)
            {
                comboBox2Tag.Items.Add(row["tagname"].ToString());
                comboBox2FilterTag.Items.Add(row["tagname"].ToString());
            }

            foreach (DataRow row in DT.Rows)
            {
                comboBox3Room.Items.Add(row["roomName"].ToString());
                
            }

        }

        private void button1Assign_Click(object sender, EventArgs e)
        {
            string keyWord = comboBox1Subject.Text;
            string keyWord2 = comboBox2Tag.Text;
            string keyWord3 = comboBox3Room.Text;
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_subRoom where SubjectName='" + keyWord + "' and tagname='" + keyWord2 + "' and roomName='"+keyWord3+"'", conn);
            DataTable DTs = new DataTable();
            sda.Fill(DTs);

            if (comboBox1Subject.Text == "")
            {
                MessageBox.Show("Please Select Subject name !");
            }
            else if (comboBox2Tag.Text == "")
            {
                MessageBox.Show("Please Select Tag Name !");
            }
            else if (comboBox3Room.Text == "")
            {
                MessageBox.Show("Please Select Room Name !");
            }
            else if (DTs.Rows.Count != 0)
            {
                MessageBox.Show("Room is already Assigned for this Subject and Tag, Please use another Room !");
            }
            else
            {
                sr.SubjectName = comboBox1Subject.Text;
                sr.TagName = comboBox2Tag.Text;
                sr.RoomName = comboBox3Room.Text;
                sr.BuildingName = textBox1BuildingName.Text;
                sr.Types = textBox1Type.Text;
                sr.Capacity = int.Parse(textBox1Capacity.Text);


                //Insert data into data base using Insert method
                bool success = sr.Insert(sr);
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
                DataTable dt = sr.Select();
                dataGridView1RoomSubject.DataSource = dt;
            }
        }

        public void clear()
        {
            comboBox1Subject.Text = "";
            comboBox2Tag.Text = "";
            comboBox3Room.Text = "";
            textBox1BuildingName.Text = "";
            textBox1Type.Text = "";
            textBox1Capacity.Text = "";
            textBoxID.Text = "";
            comboBox1FilterSub.Text = "";
            comboBox2FilterTag.Text = "";
        }

        private void dataGridView1RoomSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1RoomSubject_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxID.Text = dataGridView1RoomSubject.Rows[rowIndex].Cells[0].Value.ToString();
            comboBox1Subject.Text = dataGridView1RoomSubject.Rows[rowIndex].Cells[1].Value.ToString();
            comboBox2Tag.Text = dataGridView1RoomSubject.Rows[rowIndex].Cells[2].Value.ToString();
            comboBox3Room.Text = dataGridView1RoomSubject.Rows[rowIndex].Cells[3].Value.ToString();
            textBox1BuildingName.Text = dataGridView1RoomSubject.Rows[rowIndex].Cells[4].Value.ToString();
            textBox1Type.Text = dataGridView1RoomSubject.Rows[rowIndex].Cells[5].Value.ToString();
            textBox1Capacity.Text = dataGridView1RoomSubject.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void button1Filter_Click(object sender, EventArgs e)
        {
            string keyWord = comboBox1FilterSub.Text;
            string keyWord2 = comboBox2FilterTag.Text;
            SqlConnection conn = new SqlConnection(connstrng);
            if (keyWord == "" || keyWord2=="")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_subRoom where SubjectName='" + keyWord + "' or tagname='" + keyWord2 + "' ", conn);
                DataTable DTs = new DataTable();
                sda.Fill(DTs);
                dataGridView1RoomSubject.DataSource = DTs;
            }
            else if(keyWord != "" && keyWord2 != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_subRoom where SubjectName='" + keyWord + "' and tagname='" + keyWord2 + "' ", conn);
                DataTable DTs = new DataTable();
                sda.Fill(DTs);
                dataGridView1RoomSubject.DataSource = DTs;
            }
            
        }

        private void button1Change_Click(object sender, EventArgs e)
        {
            string keyWord = comboBox1Subject.Text;
            string keyWord2 = comboBox2Tag.Text;
            string keyWord3 = comboBox3Room.Text;
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbl_subRoom where SubjectName='" + keyWord + "' and tagname='" + keyWord2 + "' and roomName='" + keyWord3 + "'", conn);
            DataTable DTs = new DataTable();
            sda.Fill(DTs);

            if (comboBox1Subject.Text == "")
            {
                MessageBox.Show("Please Select Subject name !");
            }
            else if (comboBox2Tag.Text == "")
            {
                MessageBox.Show("Please Select Tag Name !");
            }
            else if (comboBox3Room.Text == "")
            {
                MessageBox.Show("Please Select Room Name !");
            }
            else if (DTs.Rows.Count != 0)
            {
                MessageBox.Show("Room is already Assigned for this Subject and Tag, Please use another Room !");
            }
            else
            {
                //Get the value from the input fields
                sr.subjectRoomId = int.Parse(textBoxID.Text);
                sr.SubjectName = comboBox1Subject.Text;
                sr.TagName = comboBox2Tag.Text;
                sr.RoomName = comboBox3Room.Text;
                sr.BuildingName = textBox1BuildingName.Text;
                sr.Types = textBox1Type.Text;
                sr.Capacity = int.Parse(textBox1Capacity.Text);


                //Insert data into data base using Insert method
                bool success = sr.Update(sr);
                if (success == true)
                {
                    MessageBox.Show("Assigned Room Successfully Changed");
                    DataTable dt = sr.Select();
                    dataGridView1RoomSubject.DataSource = dt;
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

        private void comboBox3Room_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sdada = new SqlDataAdapter("Select distinct buildingName from tbl_room where roomName='" + comboBox3Room.Text + "'", conn);
            DataTable dttt = new DataTable();
            sdada.Fill(dttt);
            textBox1BuildingName.Clear();

            SqlDataAdapter sda = new SqlDataAdapter("Select distinct type from tbl_room where roomName='" + comboBox3Room.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBox1Type.Clear();

            SqlDataAdapter sdad = new SqlDataAdapter("Select distinct capacity from tbl_room where roomName='" + comboBox3Room.Text + "'", conn);
            DataTable dtt = new DataTable();
            sdad.Fill(dtt);
            textBox1Capacity.Clear();

            foreach (DataRow row in dttt.Rows)
            {
                textBox1BuildingName.Text = (row["buildingName"].ToString());
            }

            foreach (DataRow row in dt.Rows)
            {
                textBox1Type.Text = (row["type"].ToString());
            }

            foreach (DataRow row in dtt.Rows)
            {
                textBox1Capacity.Text = (row["capacity"].ToString());
            }
        }

        private void button1Remove_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Please Select Assigned Room before Remove!!");
            }
            else if ((MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                sr.subjectRoomId = Convert.ToInt32(textBoxID.Text);
                bool success = sr.Delete(sr);
                if (success == true)
                {
                    MessageBox.Show("Assigned Room Successfully Removed");
                    DataTable dt = sr.Select();
                    dataGridView1RoomSubject.DataSource = dt;
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to Remove Assigned Room, Try again!!");
                }
            }
        }
    }
}
