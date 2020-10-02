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
    public partial class subjectForm : Form
    {
        public subjectForm()
        {
            InitializeComponent();
        }
        subjectClass s = new subjectClass();

        private void buttonAddsubject_Click(object sender, EventArgs e)
        {
            if (textBoxSubjectCode.Text == "")
                MessageBox.Show("Subject Code is required !");
            else if (textBoxSubjectName.Text == "")
                MessageBox.Show("Subject name is required !");
            else if (textBoxYear.Text == "")
                MessageBox.Show("Year is required !");
            else if (textBoxYear.Text.Length != 4)
                MessageBox.Show("Enter valid year !");
            else if (comboBoxSemester.Text == "")
                MessageBox.Show(" Semester is required !");

            else
            {
                s.SubjectCode = textBoxSubjectCode.Text;
                s.SubjectName = textBoxSubjectName.Text;
                s.OfferedYear = textBoxYear.Text;
                s.OfferedSemester = comboBoxSemester.Text;
                s.LectureHours = numericUpDownLecture.Text;
                s.TuteHours = numericUpDownTute.Text;
                s.LabHours = numericUpDownLab.Text;
                s.EvolutionHours = numericUpDownEvolution.Text;

                bool success = s.Insert(s);
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
                DataTable dt = s.Select();
                dataGridViewSubject.DataSource = dt;

            }

        }



        private void subjectForm_Load(object sender, EventArgs e)
        {
            //Load data to datagridView
            DataTable dt = s.Select();
            dataGridViewSubject.DataSource = dt;

        }

        public void Clear()
        {
            textBoxNosubject.Text = "";
            textBoxSubjectCode.Text = "";
            textBoxSubjectName.Text = "";
            textBoxYear.Text = "";
            comboBoxSemester.Text = "";
            numericUpDownLecture.Text = "";
            numericUpDownTute.Text = "";
            numericUpDownLab.Text = "";
            numericUpDownEvolution.Text = "";


        }

        private void buttonUpdatesubject_Click(object sender, EventArgs e)
        {
            //get the data from textboxes
            s.No = int.Parse(textBoxNosubject.Text);
            s.SubjectCode = textBoxSubjectCode.Text;
            s.SubjectName = textBoxSubjectName.Text;
            s.OfferedYear = textBoxYear.Text;
            s.OfferedSemester = comboBoxSemester.Text;
            s.LectureHours = numericUpDownLecture.Text;
            s.TuteHours = numericUpDownTute.Text;
            s.LabHours = numericUpDownLab.Text;
            s.EvolutionHours = numericUpDownEvolution.Text;


            //update data in database
            bool success = s.Update(s);
            if (success == true)
            {
                MessageBox.Show("Record has been successfully Updated");
                //load data in gridView
                DataTable dt = s.Select();
                dataGridViewSubject.DataSource = dt;
                Clear();

            }
            else
            {
                MessageBox.Show("Failed to Update.Try again");
            }
        }

        private void dataGridViewSubject_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxNosubject.Text = dataGridViewSubject.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxSubjectCode.Text = dataGridViewSubject.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxSubjectName.Text = dataGridViewSubject.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxYear.Text = dataGridViewSubject.Rows[rowIndex].Cells[3].Value.ToString();
            comboBoxSemester.Text = dataGridViewSubject.Rows[rowIndex].Cells[4].Value.ToString();
            numericUpDownLecture.Text = dataGridViewSubject.Rows[rowIndex].Cells[5].Value.ToString();
            numericUpDownTute.Text = dataGridViewSubject.Rows[rowIndex].Cells[6].Value.ToString();
            numericUpDownLab.Text = dataGridViewSubject.Rows[rowIndex].Cells[7].Value.ToString();
            numericUpDownEvolution.Text = dataGridViewSubject.Rows[rowIndex].Cells[8].Value.ToString();
        }

        private void buttonClearsubject_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonDeletesubject_Click(object sender, EventArgs e)
        {
            //get data from textboxes
            s.No = Convert.ToInt32(textBoxNosubject.Text);
            bool success = s.Delete(s);
            if (success == true)
            {
                MessageBox.Show("Record successfully Deleted");
                //load data in gridView
                DataTable dt = s.Select();
                dataGridViewSubject.DataSource = dt;
                Clear();

            }
            else
            {
                MessageBox.Show("Failed to Delete.Try again");
            }
        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void textBoxSearchSubject_TextChanged(object sender, EventArgs e)
        {
            //get the value from textboxes
            string keyword = textBoxSearchSubject.Text;

            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM table_subject WHERE SubjectName LIKE '%" + keyword + "%' OR SubjectCode LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewSubject.DataSource = dt;
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
