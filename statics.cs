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
    public partial class statics : Form
    {
        public statics()
        {
            InitializeComponent();
        }

        static string connstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void buttonLecture_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sdad = new SqlDataAdapter("Select LevelLecture,COUNT(*) as Total from table_lecturer group by LevelLecture", conn);
            DataTable DTT = new DataTable();
            sdad.Fill(DTT);
            chart1.Series["Total"].XValueMember = "LevelLecture";
            chart1.Series["Total"].YValueMembers = "Total";
            chart2.Series["Total"].XValueMember = "LevelLecture";
            chart2.Series["Total"].YValueMembers = "Total";
            chart1.DataSource = DTT;
            chart1.DataBind();
            chart2.DataSource = DTT;
            chart2.DataBind();
            topicLable.Text = "TOTAL LECTURERS ACCORDING TO RANK";
            label2Pie.Text = "PIE CHART FOR LECTURERS";
            label3Bar.Text = "BAR GRAPH FOR LECTURERS";
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sdad = new SqlDataAdapter("Select OfferedYear,COUNT(*) as TotalSubject From table_subject group by OfferedYear", conn);
            DataTable DTT = new DataTable();
            sdad.Fill(DTT);
            chart1.Series["Total"].XValueMember = "OfferedYear";
            chart1.Series["Total"].YValueMembers = "TotalSubject";
            chart2.Series["Total"].XValueMember = "OfferedYear";
            chart2.Series["Total"].YValueMembers = "TotalSubject";
            chart1.DataSource = DTT;
            chart1.DataBind();
            chart2.DataSource = DTT;
            chart2.DataBind();
            topicLable.Text = "TOTAL SUBJECT ACCORDING TO OFFERED YEAR";
            label2Pie.Text = "PIE CHART FOR SUBJECT";
            label3Bar.Text = "BAR GRAPH FOR SUBJECT";
        }

        private void button1Room_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sdad = new SqlDataAdapter("select t.range as [capacity range], count(*) as [number of Rooms] from(select case  when capacity between 0 and 51 then ' 0- 50' when capacity between 51 and 101 then '51-100' when capacity between 101 and 151 then ' 101- 150' when capacity between 151 and 201 then '151-200' when capacity between 201 and 251 then ' 201- 250' when capacity between 251 and 301 then '251-300' else '301-1000' end as range from tbl_room) t group by t.range", conn);
            DataTable DTT = new DataTable();
            sdad.Fill(DTT);
            chart1.Series["Total"].XValueMember = "capacity range";
            chart1.Series["Total"].YValueMembers = "number of Rooms";
            chart2.Series["Total"].XValueMember = "capacity range";
            chart2.Series["Total"].YValueMembers = "number of Rooms";
            chart1.DataSource = DTT;
            chart1.DataBind();
            chart2.DataSource = DTT;
            chart2.DataBind();
            topicLable.Text = "TOTAL ROOMS ACCORDING TO CAPACITY RANGE";
            label2Pie.Text = "PIE CHART FOR ROOMS";
            label3Bar.Text = "BAR GRAPH FOR ROOMS";
        }

        private void statics_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstrng);
            SqlDataAdapter sdad = new SqlDataAdapter("Select LevelLecture,COUNT(*) as Total from table_lecturer group by LevelLecture", conn);
            DataTable DTT = new DataTable();
            sdad.Fill(DTT);
            chart1.Series["Total"].XValueMember = "LevelLecture";
            chart1.Series["Total"].YValueMembers = "Total";
            chart2.Series["Total"].XValueMember = "LevelLecture";
            chart2.Series["Total"].YValueMembers = "Total";
            chart1.DataSource = DTT;
            chart1.DataBind();
            chart2.DataSource = DTT;
            chart2.DataBind();
            topicLable.Text = "TOTAL LECTURERS ACCORDING TO RANK";
            label2Pie.Text = "PIE CHART FOR LECTURERS";
            label3Bar.Text = "BAR GRAPH FOR LECTURERS";
        }
    }
}
