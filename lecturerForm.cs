using SPM.Classes;
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
    public partial class lecturerForm : Form
    {
        public lecturerForm()
        {
            InitializeComponent();
        }
        lecturerClass l = new lecturerClass();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxEmployeeID.Text == "")
                MessageBox.Show("Employee ID is required !");
            else if (textBoxEmployeeID.Text.Length != 6)
                MessageBox.Show("Employee ID must be 6 digit !");
            else if (textBoxLectureName.Text == "")
                MessageBox.Show("Lecturer name is required !");
            else if (comboBoxFaculty.Text == "")
                MessageBox.Show(" Faculty is required !");
            else if (comboBoxDepartment.Text == "")
                MessageBox.Show("Department is required !");
            else if (comboBoxCenter.Text == "")
                MessageBox.Show("Center is required !");
            else if (comboBoxBuilding.Text == "")
                MessageBox.Show("Building is required !");
            else if (comboBoxLevel.Text == "")
                MessageBox.Show("Level is required !");
            else
            {
                l.EmployeeID = int.Parse(textBoxEmployeeID.Text);
                l.LecturerName = textBoxLectureName.Text;
                l.Faculty = comboBoxFaculty.Text;
                l.Department = comboBoxDepartment.Text;
                l.Center = comboBoxCenter.Text;
                l.Building = comboBoxBuilding.Text;
                l.LevelLecture = comboBoxLevel.Text;
                l.RankLecture = textBoxRank.Text;

                bool success = l.Insert(l);
                if (success == true)
                {
                    MessageBox.Show("New record successfully Inserted");
                    Clear();

                }
                else
                {
                    MessageBox.Show("Failed to add New record.Try again");
                }

                //Load data to datagridView
                DataTable dt = l.Select();
                dataGridViewLecturer.DataSource = dt;
            }

        }

        private void lecturerForm_Load(object sender, EventArgs e)
        {
            DataTable dt = l.Select();
            dataGridViewLecturer.DataSource = dt;

        }

        public void Clear()
        {
            textBoxNo.Text = "";
            textBoxEmployeeID.Text = "";
            textBoxLectureName.Text = "";
            comboBoxFaculty.Text = "";
            comboBoxDepartment.Text = "";
            comboBoxCenter.Text = "";
            comboBoxBuilding.Text = "";
            comboBoxLevel.Text = "";
            textBoxRank.Text = "";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //get the data from textboxes
            l.No = int.Parse(textBoxNo.Text);
            l.EmployeeID = int.Parse(textBoxEmployeeID.Text);
            l.LecturerName = textBoxLectureName.Text;
            l.Faculty = comboBoxFaculty.Text;
            l.Department = comboBoxDepartment.Text;
            l.Center = comboBoxCenter.Text;
            l.Building = comboBoxBuilding.Text;
            l.LevelLecture = comboBoxLevel.Text;
            l.RankLecture = textBoxRank.Text;


            //update data in database
            bool success = l.Update(l);
            if (success == true)
            {
                MessageBox.Show("Record has been successfully Updated");
                //load data in gridView
                DataTable dt = l.Select();
                dataGridViewLecturer.DataSource = dt;
                Clear();

            }
            else
            {
                MessageBox.Show("Failed to Update.Try again");
            }
        }

        private void dataGridViewLecturer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxNo.Text = dataGridViewLecturer.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxEmployeeID.Text = dataGridViewLecturer.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxLectureName.Text = dataGridViewLecturer.Rows[rowIndex].Cells[2].Value.ToString();
            comboBoxFaculty.Text = dataGridViewLecturer.Rows[rowIndex].Cells[3].Value.ToString();
            comboBoxDepartment.Text = dataGridViewLecturer.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxCenter.Text = dataGridViewLecturer.Rows[rowIndex].Cells[5].Value.ToString();
            comboBoxBuilding.Text = dataGridViewLecturer.Rows[rowIndex].Cells[6].Value.ToString();
            comboBoxLevel.Text = dataGridViewLecturer.Rows[rowIndex].Cells[7].Value.ToString();
            textBoxRank.Text = dataGridViewLecturer.Rows[rowIndex].Cells[8].Value.ToString();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //get data from textboxes
            l.No = Convert.ToInt32(textBoxNo.Text);
            bool success = l.Delete(l);
            if (success == true)
            {
                MessageBox.Show("Record successfully Deleted");
                //load data in gridView
                DataTable dt = l.Select();
                dataGridViewLecturer.DataSource = dt;
                Clear();

            }
            else
            {
                MessageBox.Show("Failed to Delete.Try again");
            }
        }
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //get the value from textboxes
            string keyword = textBoxSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM table_lecturer WHERE LecturerName LIKE '%" + keyword + "%' OR EmployeeID LIKE '%" + keyword + "%' OR Faculty LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewLecturer.DataSource = dt;
        }

        private void dataGridViewLecturer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRank_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
