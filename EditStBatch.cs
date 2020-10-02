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
    public partial class EditStBatch : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-MUATFI8;Initial Catalog=Timetable;Integrated Security=True;");

        public EditStBatch()
        {
            InitializeComponent();
        }

        private void EditStBatch_Load(object sender, EventArgs e)
        {
            GridFill();
            fillCombo();
        }

        private void fillCombo()
        {
            comboProg.Items.Clear();

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

        private void buttonSaveUpdate_Click(object sender, EventArgs e)
        {
            if (comboProg.Text.Length == 0 || comboYear.Text.Length == 0 || comboSem.Text.Length == 0 || textBoxGroupNum.Text.Length == 0)
            {
                MessageBox.Show("Fields are Empty!");
            }
            else
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    String Query = "Insert into studentBatch (year, semester, programmecode, groupno) values (@year, @semester, @code, @groupno)";
                    SqlCommand sqlCmd = new SqlCommand(Query, sqlCon);

                    sqlCmd.Parameters.AddWithValue("@year", comboYear.SelectedItem.ToString());
                    sqlCmd.Parameters.AddWithValue("@semester", Int32.Parse(comboSem.SelectedItem.ToString()));
                    sqlCmd.Parameters.AddWithValue("@code", comboProg.SelectedItem.ToString());
                    sqlCmd.Parameters.AddWithValue("@groupno", Int32.Parse(textBoxGroupNum.Text));

                    int rows = sqlCmd.ExecuteNonQuery();

                    if (rows >= 1)
                    {
                        MessageBox.Show("Successfully Added!");
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
                this.textBoxGroupNum.Text = "";
                this.comboProg.SelectedIndex = -1;
                this.comboYear.SelectedIndex = -1;
                this.comboSem.SelectedIndex = -1;

            }
        }

        private void GridFill()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            string Query = "select year, semester, programmecode, groupno from studentbatch";

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
            }


            sqlCon.Close();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }


            String Query = "Select * from studentBatch where (year like '%" + textBoxSearch.Text + "%' or programmecode like '%" + textBoxSearch.Text + "%' or semester like '%" + textBoxSearch.Text + "%')";
            SqlCommand sqlCmd = new SqlCommand(Query, sqlCon);


            SqlDataAdapter sqladpt = new SqlDataAdapter(Query, sqlCon);



            DataTable dataTable = new DataTable();
            sqladpt.Fill(dataTable);


            dataGridView1.Rows.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
            }

            sqlCon.Close();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBoxGroupNum.Text = "";
            this.comboProg.SelectedIndex = -1;
            this.comboYear.SelectedIndex = -1;
            this.comboSem.SelectedIndex = -1;
            this.textBoxSearch.Text = "";
            dataGridView1.DataSource = null;

        }

        private void textBoxGroupNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (comboProg.Text.Length == 0 || comboYear.Text.Length == 0 || comboSem.Text.Length == 0 || textBoxGroupNum.Text.Length == 0)
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
                    String Query = "Delete from studentBatch where programmecode = @code and year = @year and semester = @sem and groupno = @no";
                    SqlCommand sqlCmd = new SqlCommand(Query, sqlCon);


                    sqlCmd.Parameters.AddWithValue("@year", comboYear.SelectedItem.ToString());
                    sqlCmd.Parameters.AddWithValue("@sem", Int32.Parse(comboSem.SelectedItem.ToString()));
                    sqlCmd.Parameters.AddWithValue("@code", comboProg.SelectedItem.ToString());
                    sqlCmd.Parameters.AddWithValue("@groupno", Int32.Parse(textBoxGroupNum.Text));

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



            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
