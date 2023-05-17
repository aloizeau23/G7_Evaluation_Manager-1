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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public static Teacher LoggedTeacher { get ; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (password.Text == "test" && username.Text == "teacher")
            {
                Application.Run(new FrmStudents());
            }*/
            string username = txtusername.Text;
            string password = txtpassword.Text;

            LoggedTeacher = TeacherRepository.GetTeacher(username);
            if(LoggedTeacher != null && LoggedTeacher.CheckPassword(password))
            {
                FrmStudents frmStudents = new FrmStudents();
                Hide();
                frmStudents.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong crendentials");
            }
            /*if (Username == "teacher" && Password == "test")
            {
                FrmStudents frmStudents = new FrmStudents();
                Hide();
                frmStudents.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong crendentials");
            }*/

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
