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
    public partial class StudentList : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-MUATFI8;Initial Catalog=Timetable;Integrated Security=True;");


        String yearV, semV, progCodeV;

        public StudentList()
        {
            InitializeComponent();
            label4.Hide();
            label5.Hide();
            txtGrpNo.Hide();
            textGrpID.Hide();
            btnUpdate.Hide();
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

        private void StudentList_Load(object sender, EventArgs e)
        {
            fillCombo();
            GridFill();
        }

        private void buttonSaveUpdate_Click(object sender, EventArgs e)
        {


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


                String Query = "Select groupno, groupid, year, semester, programmecode from studentBatch where (year like '%" + comboYear.SelectedItem.ToString() + "%' and programmecode like '%" + comboProg.SelectedItem.ToString() + "%' and semester like '%" + comboSem.SelectedItem.ToString() + "%')";
                SqlCommand sqlCmd = new SqlCommand(Query, sqlCon);


                SqlDataAdapter sqladpt = new SqlDataAdapter(Query, sqlCon);



                DataTable dataTable = new DataTable();
                if (sqladpt.Fill(dataTable) != 0)
                {

                    foreach (DataRow item in dataTable.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                    }

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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtGrpNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textGrpID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            yearV = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            semV = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            progCodeV = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            label4.Show();
            label5.Show();
            txtGrpNo.Show();
            textGrpID.Show();
            btnUpdate.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            label4.Hide();
            label5.Hide();
            txtGrpNo.Hide();
            textGrpID.Hide();
            btnUpdate.Hide();

            this.comboProg.SelectedIndex = -1;
            this.comboYear.SelectedIndex = -1;
            this.comboSem.SelectedIndex = -1;

            textGrpID.Text = "";
            txtGrpNo.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtGrpNo.Text.Length == 0 || textGrpID.Text.Length == 0)
            {
                MessageBox.Show("Nothing to delete!!");
            }
            else if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    String Query = "Update studentBatch set groupid = null where year = @year and semester = @semester and programmecode = @code and groupno = @no";
                    SqlCommand sqlCmd = new SqlCommand(Query, sqlCon);


                    // sqlCmd.Parameters.AddWithValue("@id", textGrpID.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@no", txtGrpNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@year", yearV);
                    sqlCmd.Parameters.AddWithValue("@semester", Convert.ToInt32(semV));
                    sqlCmd.Parameters.AddWithValue("@code", progCodeV);
                    // sqlCmd.Parameters.AddWithValue("@groupno", txtGrpNo.Text.Trim());

                    int rows = sqlCmd.ExecuteNonQuery();

                    if (rows >= 1)
                    {
                        MessageBox.Show("Successfully Deleted!");
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                }
                finally
                {
                    sqlCon.Close();
                }

                GridFill();



            }
        }

        void GridFill()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            string Query = "Select groupno, groupid, year, semester, programmecode from studentBatch";

            SqlDataAdapter adpt = new SqlDataAdapter(Query, sqlCon);
            DataTable dataTable = new DataTable();
            adpt.Fill(dataTable);


            dataGridView1.Rows.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
            }


            sqlCon.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGrpNo.Text.Length == 0 || textGrpID.Text.Length == 0)
                {
                    MessageBox.Show("Fill The Field!");
                }
                else
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    String Query = "Update studentBatch set groupid = @id, groupno = @no where year = @year and semester = @semester and programmecode = @code";
                    SqlCommand sqlCmd = new SqlCommand(Query, sqlCon);

                    sqlCmd.Parameters.AddWithValue("@id", textGrpID.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@no", txtGrpNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@year", yearV);
                    sqlCmd.Parameters.AddWithValue("@semester", Convert.ToInt32(semV));
                    sqlCmd.Parameters.AddWithValue("@code", progCodeV);
                    sqlCmd.Parameters.AddWithValue("@groupno", txtGrpNo.Text.Trim());

                    int rows = sqlCmd.ExecuteNonQuery();
                    if (rows >= 1)
                    {
                        MessageBox.Show("Successfully Updated!");
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            finally
            {
                sqlCon.Close();

            }

            this.textGrpID.Text = "";
            this.txtGrpNo.Text = "";

            label4.Hide();
            label5.Hide();
            txtGrpNo.Hide();
            textGrpID.Hide();
            btnUpdate.Hide();


        }
    }
}
