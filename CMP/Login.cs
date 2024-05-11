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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CMP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Text = "CMP";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QRORMR1\SQLEXPRESS;Initial Catalog=CMP;Integrated Security=True");
        public static string User;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QRORMR1\SQLEXPRESS;Initial Catalog=CMP;Integrated Security=True"))
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM UserTbl WHERE UserName=@Username AND User_Password=@Password";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username.Text);
                        cmd.Parameters.AddWithValue("@Password", Password.Text);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            User = Username.Text;
                            Dashboard Obj = new Dashboard();
                            Obj.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or Password!");
                            Username.Text = "";
                            Password.Text = "";
                        }
                    }
                }
            }
        }

    }
}
