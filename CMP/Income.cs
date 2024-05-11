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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CMP
{
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
        }

      

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Clear()
        {
            IncName.Text = "";
            Amount.Text = "";
            CategoryCombo.SelectedIndex = 0;
            Description.Text = "";
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QRORMR1\SQLEXPRESS;Initial Catalog=CMP;Integrated Security=True");
        private void SaveIncome_Click(object sender, EventArgs e)
        {
            try
            {
                if (IncName.Text == "" || Amount.Text == "" || CategoryCombo.SelectedIndex == -1 || Description.Text == "")
                {
                    MessageBox.Show("Te dhenat nuk duhen boshe!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QRORMR1\SQLEXPRESS;Initial Catalog=CMP;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("insert into IncomeTbl(Income_Name, Income_Amount, Income_Cat,Income_Date,Income_Desc,Income_User) values (@Income_Name, @Income_Amount, @Income_Cat, @Income_Date,@Income_Desc,@Income_User)", con))
                        {
                            cmd.Parameters.AddWithValue("@Income_Name", IncName.Text);
                            cmd.Parameters.AddWithValue("@Income_Amount", Amount.Text);
                            cmd.Parameters.AddWithValue("@Income_Cat", CategoryCombo.SelectedIndex);
                            cmd.Parameters.AddWithValue("@Income_Date", Date.Value.Date);
                            cmd.Parameters.AddWithValue("@Income_Desc", Description.Text);
                            cmd.Parameters.AddWithValue("@Income_User", Login.User);


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Te ardhurat u shtuan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        private void dashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj=new Dashboard();
            obj.Show();
            this.Close();
        }

        private void teardhur_Click(object sender, EventArgs e)
        {
            Income obj=new Income();
            obj.Show();
            this.Close();
        }

        private void expenses_Click(object sender, EventArgs e)
        {
            Expense obj=new Expense();
            obj.Show();
            this.Close();
        }

        private void watchexpenses_Click(object sender, EventArgs e)
        {
            View_Expenses obj=new View_Expenses();
            obj.Show(); 
            this.Close();
        }

        private void shikoincome_Click(object sender, EventArgs e)
        {
            Income_View obj=new Income_View();
            obj.Show();
            this.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Jeni i sigurte qe doni te dilni?", "Konfirmim", MessageBoxButtons.YesNo);
            if(res==DialogResult.Yes)
            {
               Login obj=new Login();
                obj.Show();
                this.Close();
            }
            else
            {
               //! QENDRO NE APP
            }
            
        }
    }
    }

