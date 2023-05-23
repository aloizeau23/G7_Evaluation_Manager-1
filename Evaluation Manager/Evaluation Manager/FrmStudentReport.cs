using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmStudentReport : Form
    {
        public FrmStudentReport()
        {
            InitializeComponent();
        }

        private void FrmStudentReport_Load(object sender, EventArgs e)
        {
            var students = StudentRepository.GetStudents();
            List<StudentReportView> studentReportViews = new List<StudentReportView>();
            foreach (var student in students)
            {
                studentReportViews.Add(new StudentReportView(student));
            }
            dgvReports.DataSource = studentReportViews;
        }
    }
}
