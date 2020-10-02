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
    public partial class CreateEditDeleteTag : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-MUATFI8;Initial Catalog=Timetable;Integrated Security=True;");

        public CreateEditDeleteTag()
        {
            InitializeComponent();
        }

        private void buttonSaveUpdate_Click(object sender, EventArgs e)
        {
            if (buttonSaveUpdate.Text == "Enter")
            {
                if (textBoxTagName.Text.Length == 0)
                {
                    MessageBox.Show("Fill The Field!");
                }
                else
                {
                    try
                    {
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        String Query = "Insert into tags (tagname) values (@name)";
                        SqlCommand sqlCmd = new SqlCommand(Query, sqlCon);

                        sqlCmd.Parameters.AddWithValue("@name", textBoxTagName.Text.Trim());

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

                    this.textBoxTagName.Text = "";
                }
            }
            else
            {
                if (textBoxTagName.Text.Length == 0)
                {
                    MessageBox.Show("Fill The Field!");
                }
                else
                {
                    try
                    {
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        String Query = "Update tags set tagname = @name where tagname = @name";
                        SqlCommand sqlCmd = new SqlCommand(Query, sqlCon);

                        sqlCmd.Parameters.AddWithValue("@name", textBoxTagName.Text.Trim());



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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error!");
                    }
                    finally
                    {
                        sqlCon.Close();
                    }

                    GridFill();

                    this.textBoxTagName.Text = "";
                    buttonSaveUpdate.Text = "Enter";

                }
            }
        }

        private void textBoxTagName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void GridFill()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            string Query = "select * from tags";

            SqlDataAdapter adpt = new SqlDataAdapter(Query, sqlCon);
            DataTable dataTable = new DataTable();
            adpt.Fill(dataTable);


            dataGridView1.Rows.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
            }


            sqlCon.Close();

        }

        private void CreateEditDeleteTag_Load(object sender, EventArgs e)
        {
            GridFill();

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            textBoxTagName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            buttonSaveUpdate.Text = "Update";

        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (textBoxTagName.Text.Length == 0)
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
                    String Query = "Delete from tags where tagname = @name";
                    SqlCommand sqlCmd = new SqlCommand(Query, sqlCon);

                    sqlCmd.Parameters.AddWithValue("@name", textBoxTagName.Text.Trim());

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

                this.textBoxTagName.Text = "";
                buttonSaveUpdate.Text = "Enter";

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBoxTagName.Text = "";
            buttonSaveUpdate.Text = "Enter";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            String Query = "Select * from tags where (tagname like '%" + textBoxSearch.Text + "%')";
            SqlDataAdapter sqladpt = new SqlDataAdapter(Query, sqlCon);


            DataTable dataTable = new DataTable();
            sqladpt.Fill(dataTable);


            dataGridView1.Rows.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
            }

            sqlCon.Close();


        }
    }
}
