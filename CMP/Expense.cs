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

namespace CMP
{
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj=new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void income_Click(object sender, EventArgs e)
        {
            Income obj=new Income();
            obj.Show();
            this.Hide();
        }

        private void expens_Click(object sender, EventArgs e)
        {
            Expense obj=new Expense();
            obj.Show();
                this.Hide();
        }

        private void view_ex_Click(object sender, EventArgs e)
        {
            View_Expenses obj=new View_Expenses();
            obj.Show();
            this.Hide();
        }

        private void view_inc_Click(object sender, EventArgs e)
        {
            Income_View obj=new Income_View();
            obj.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Jeni te sigurte qe doni te dilni","Konfirmimi",MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Login obj = new Login();
                obj.Show();
                this.Hide();
            }
            else
            {
                //!qendro ne app
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QRORMR1\SQLEXPRESS;Initial Catalog=CMP;Integrated Security=True");

        private void Clear() {
            exp_name.Text = "";
            exp_amount.Text = "";
            exp_cat.SelectedIndex = 0;
            exp_desc.Text = "";
        }
        private void shto_exp_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (exp_name.Text == "" || exp_amount.Text == "" || exp_cat.SelectedIndex == -1 || exp_desc.Text == "")
                {
                    MessageBox.Show("Te dhenat nuk duhen boshe!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QRORMR1\SQLEXPRESS;Initial Catalog=CMP;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("insert into ExpenseTbl(ExName, ExpAmt, ExpCat,ExpDate,ExpDesc,ExpUser) values (@ExName, @ExpAmt, @ExpCat, @ExpDate,@ExpDesc,@ExpUser)", con))
                        {
                            cmd.Parameters.AddWithValue("@ExName", exp_name.Text);
                            cmd.Parameters.AddWithValue("@ExpAmt", exp_amount.Text);
                            cmd.Parameters.AddWithValue("@ExpCat", exp_cat.SelectedIndex);
                            cmd.Parameters.AddWithValue("@ExpDate", exp_date.Value.Date);
                            cmd.Parameters.AddWithValue("@ExpDesc", exp_desc.Text);
                            cmd.Parameters.AddWithValue("@ExpUser", Login.User);


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Shpenzimi juaj u shtua", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
