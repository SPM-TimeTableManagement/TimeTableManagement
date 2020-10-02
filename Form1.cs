using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLecturer_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();
            lecturerForm lectureform = new lecturerForm();
            lectureform.TopLevel = false;
            panelform1.Controls.Add(lectureform);
            lectureform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            lectureform.Dock = DockStyle.Fill;
            lectureform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSubject_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();
            subjectForm subjectform = new subjectForm();
            subjectform.TopLevel = false;
            panelform1.Controls.Add(subjectform);
            subjectform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            subjectform.Dock = DockStyle.Fill;
            subjectform.Show();
        }

        private void buttonSession_Click(object sender, EventArgs e)
        {


        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonWorking_Click(object sender, EventArgs e)
        {
            //Add_WorkingHours_And_WorkingDays.Form2 frm = new Add_WorkingHours_And_WorkingDays.Form2();
            //DialogResult selectButton = frm.ShowDialog();
            panelform1.Controls.Clear();
            //lecturerForm lectureform = new lecturerForm();
            Form2 frm = new Form2();
            frm.TopLevel = false;
            panelform1.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void buttonAddBuilding_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();
            //lecturerForm lectureform = new lecturerForm();
            //Add_WorkingHours_And_WorkingDays.Form2 frm = new Add_WorkingHours_And_WorkingDays.Form2();
            Building build = new Building();
            build.TopLevel = false;
            panelform1.Controls.Add(build);
            build.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            build.Dock = DockStyle.Fill;
            build.Show();

        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();
            //lecturerForm lectureform = new lecturerForm();
            //Add_WorkingHours_And_WorkingDays.Form2 frm = new Add_WorkingHours_And_WorkingDays.Form2();
            Room rm = new Room();
            rm.TopLevel = false;
            panelform1.Controls.Add(rm);
            rm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rm.Dock = DockStyle.Fill;
            rm.Show();
        }

        private void buttonStudentBatch_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();

            EditStBatch std = new EditStBatch();
            std.TopLevel = false;
            panelform1.Controls.Add(std);
            std.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            std.Dock = DockStyle.Fill;
            std.Show();

        }

        private void buttonProgramme_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();

            Programme prgrm = new Programme();
            prgrm.TopLevel = false;
            panelform1.Controls.Add(prgrm);
            prgrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            prgrm.Dock = DockStyle.Fill;
            prgrm.Show();

        }

        private void buttonGenarateID_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();

            GenerateGroups gengrp = new GenerateGroups();
            gengrp.TopLevel = false;
            panelform1.Controls.Add(gengrp);
            gengrp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gengrp.Dock = DockStyle.Fill;
            gengrp.Show();
        }

        private void buttonStudentList_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();

            StudentList stdList = new StudentList();
            stdList.TopLevel = false;
            panelform1.Controls.Add(stdList);
            stdList.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            stdList.Dock = DockStyle.Fill;
            stdList.Show();
        }

        private void buttonTags_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();

            CreateEditDeleteTag tags = new CreateEditDeleteTag();
            tags.TopLevel = false;
            panelform1.Controls.Add(tags);
            tags.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tags.Dock = DockStyle.Fill;
            tags.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();
            //lecturerForm lectureform = new lecturerForm();
            //Add_WorkingHours_And_WorkingDays.Form2 frm = new Add_WorkingHours_And_WorkingDays.Form2();
            AssignRoomForTag rt = new AssignRoomForTag();
            rt.TopLevel = false;
            panelform1.Controls.Add(rt);
            rt.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rt.Dock = DockStyle.Fill;
            rt.Show();
        }

        private void button2AssignRoomLect_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();
            //lecturerForm lectureform = new lecturerForm();
            //Add_WorkingHours_And_WorkingDays.Form2 frm = new Add_WorkingHours_And_WorkingDays.Form2();
            AssignRoomForLecturer rt = new AssignRoomForLecturer();
            rt.TopLevel = false;
            panelform1.Controls.Add(rt);
            rt.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rt.Dock = DockStyle.Fill;
            rt.Show();
        }

        private void button2subRoom_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();
            //lecturerForm lectureform = new lecturerForm();
            //Add_WorkingHours_And_WorkingDays.Form2 frm = new Add_WorkingHours_And_WorkingDays.Form2();
            AssignRoomForSubject rs = new AssignRoomForSubject();
            rs.TopLevel = false;
            panelform1.Controls.Add(rs);
            rs.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rs.Dock = DockStyle.Fill;
            rs.Show();
        }

        private void button2statics_Click(object sender, EventArgs e)
        {
            panelform1.Controls.Clear();
            //lecturerForm lectureform = new lecturerForm();
            //Add_WorkingHours_And_WorkingDays.Form2 frm = new Add_WorkingHours_And_WorkingDays.Form2();
            statics st = new statics();
            st.TopLevel = false;
            panelform1.Controls.Add(st);
            st.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            st.Dock = DockStyle.Fill;
            st.Show();
        }
    }
}
