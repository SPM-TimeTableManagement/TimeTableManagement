using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPM
{
    public partial class GenerateGroups : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-MUATFI8;Initial Catalog=Timetable;Integrated Security=True;");

        String yearV, semV, progCodeV, grpNoV;

        public GenerateGroups()
        {
            InitializeComponent();
        }

        private void fillCombo()
        {

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            String Query = "Select programmename from programme";
            SqlDataAdapter sqladpt = new SqlDataAdapter(Query, sqlCon);


            DataTable dataTable = new DataTable();
            sqladpt.Fill(dataTable);



            foreach (DataRow item in dataTable.Rows)
            {
                comboProg.Items.Add(item["programmename"]).ToString();
            }

            sqlCon.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void GenerateGroups_Load(object sender, EventArgs e)
        {
            fillCombo();
        }

        private void buttonSaveUpdate_Click(object sender, EventArgs e)
        {
            this.comboGroupNo.Items.Clear();

            if (comboProg.Text.Length == 0 || comboYear.Text.Length == 0 || comboSem.Text.Length == 0)
            {
                MessageBox.Show("Fields are Empty!");
            }
            else
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }


                String Query = "Select groupno from studentBatch where (year like '%" + comboYear.SelectedItem.ToString() + "%' and programmecode like '%" + comboProg.SelectedItem.ToString() + "%' and semester like '%" + comboSem.SelectedItem.ToString() + "%')";
                SqlCommand sqlCmd = new SqlCommand(Query, sqlCon);


                SqlDataAdapter sqladpt = new SqlDataAdapter(Query, sqlCon);



                DataTable dataTable = new DataTable();
                if (sqladpt.Fill(dataTable) != 0)
                {

                    foreach (DataRow item in dataTable.Rows)
                    {
                        comboGroupNo.Items.Add(item["groupno"]).ToString();
                    }



                    MessageBox.Show("Success!");

                    yearV = comboYear.SelectedItem.ToString();
                    semV = comboSem.SelectedItem.ToString();
                    progCodeV = comboProg.SelectedItem.ToString();

                    sqlCon.Close();

                }
                else
                {
                    MessageBox.Show("No records were found!");

                }
            }

            this.comboProg.SelectedIndex = -1;
            this.comboYear.SelectedIndex = -1;
            this.comboSem.SelectedIndex = -1;
        }

        private void btnGenGrp_Click(object sender, EventArgs e)
        {
            if (textBoxGroupCode.Text.Split('.').Length < 4 || textBoxGroupCode.Text.Length > 12 || textBoxGroupCode.Text.Split('.').Length > 4 || textBoxGroupCode.Text.Length < 10)
            {
                MessageBox.Show("Enter Correct Format (Ex: Y1.S1.IT.01) ");
            }
            else
            {
                if (textBoxGroupCode.Text.Length == 0 || comboGroupNo.Text.Length == 0)
                {
                    MessageBox.Show("Fields are Empty!");
                }
                else
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    String Query = "Update studentBatch set groupid = @groupids where year = @year and semester = @semester and programmecode = @code and groupno = @groupno";
                    SqlCommand sqlCmd = new SqlCommand(Query, sqlCon);

                    sqlCmd.Parameters.AddWithValue("@year", yearV);
                    sqlCmd.Parameters.AddWithValue("@semester", Int32.Parse(semV));
                    sqlCmd.Parameters.AddWithValue("@code", progCodeV);
                    sqlCmd.Parameters.AddWithValue("@groupno", comboGroupNo.SelectedItem.ToString());
                    sqlCmd.Parameters.AddWithValue("@groupids", textBoxGroupCode.Text.Trim());

                    int rows = sqlCmd.ExecuteNonQuery();

                    if (rows >= 1)
                    {
                        MessageBox.Show("Successfully Added!");
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }




                    sqlCon.Close();


                    this.textBoxGroupCode.Text = "";
                    this.comboProg.SelectedIndex = -1;
                    this.comboYear.SelectedIndex = -1;
                    this.comboSem.SelectedIndex = -1;
                    this.comboGroupNo.SelectedIndex = -1;


                }

                yearV = "";
                semV = "";
                progCodeV = "";
                grpNoV = "";
            }
        }
    }
}
