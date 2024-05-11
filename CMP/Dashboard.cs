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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Show_TotalIncome();
            Show_TotalExpenses();
            Show_Bilanc();
        }


        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void te_ardhurat_Click(object sender, EventArgs e)
        {
            Income obj = new Income();
            obj.Show();
            this.Close();
        }

        private void shpenzimet_Click(object sender, EventArgs e)
        {
            Expense obj = new Expense();
            obj.Show();
            this.Close();
        }

        private void shif_shpenzime_Click(object sender, EventArgs e)
        {
            View_Expenses obj = new View_Expenses();
            obj.Show();
            this.Close();
        }

        private void shif_teardhurat_Click(object sender, EventArgs e)
        {
            Income_View obj = new Income_View();
            obj.Show();
            this.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Jeni i sigurte qe doni te dilni?", "Konfirmim", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Login obj = new Login();
                obj.Show();
                this.Close();
            }
            else
            {
                //! QENDRO NE APP
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QRORMR1\SQLEXPRESS;Initial Catalog=CMP;Integrated Security=True");

        private void Show_TotalIncome()
        {
            try
            {
                con.Open();
                string userLogin = Login.User;
                string Query = "Select sum(Income_Amount) FROM IncomeTbl WHERE Income_User=@LoginUser";
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@LoginUser", userLogin);
                    object res = cmd.ExecuteScalar();
                    if (res != null)
                    {
                        total_income.Text = res.ToString();
                    }
                    else if (res == null)
                    {
                        total_income.Text = "0";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            finally { con.Close(); }

        }

        private void Show_TotalExpenses()
        {
            try
            {
                con.Open();
                string userLogin = Login.User;
                string Query = "Select sum(ExpAmt) FROM ExpenseTbl WHERE ExpUser=@LoginUser";
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@LoginUser", userLogin);
                    object res = cmd.ExecuteScalar();
                    if (res != null)
                    {
                        total_expenses.Text = res.ToString();
                    }
                    else { if (res == null) { total_expenses.Text = "0"; } }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally { con.Close(); }
        }
        private void Show_Bilanc()
        {
            if (total_expenses != null && total_income != null)
            {

                if (int.TryParse(total_expenses.Text, out int total_expenses_bilanc) &&
                    int.TryParse(total_income.Text, out int total_income_bilanc))
                {
                    int balanci_v = total_income_bilanc - total_expenses_bilanc;
                    balanci.Text = balanci_v.ToString();
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("Add");
            }
        }


        private void bilanc_show_Click(object sender, EventArgs e)
        {
            string balanci_v_str = balanci.Text;
            if (int.TryParse(balanci_v_str, out int balanci_v))
            {
                if (balanci_v < 0)
                {
                    MessageBox.Show("Bilanci juaj nuk eshte i mire", "balanc jo mire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (balanci_v > 0)
                {
                    MessageBox.Show("Bilanci juaj eshte i mire/ok", "balanci ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (balanci_v == 0)
                {
                    MessageBox.Show("Ju lutem shtoni disa shpenzime dhe te ardhura", "Shtoni shpenzime/ardhura", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
