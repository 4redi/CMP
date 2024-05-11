using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CMP
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

     

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QRORMR1\SQLEXPRESS;Initial Catalog=CMP;Integrated Security=True");
        private void Clear()
        {
            Email.Text = "";
            Password.Text = "";
            Phone_Num.Text = "";
            Username.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Email.Text == "" || Phone_Num.Text == "" || Username.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Te dhenat nuk duhen boshe!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QRORMR1\SQLEXPRESS;Initial Catalog=CMP;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("insert into UserTbl(User_Email, User_Phone, UserName, User_Password) values (@User_Email, @User_Phone, @UserName, @User_Password)", con))
                        {
                            cmd.Parameters.AddWithValue("@User_Email", Email.Text);
                            cmd.Parameters.AddWithValue("@User_Phone", Phone_Num.Text);
                            cmd.Parameters.AddWithValue("@UserName", Username.Text);
                            cmd.Parameters.AddWithValue("@User_Password", Password.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("User Added!", "Miresevini ne CMP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
