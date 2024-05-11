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
    public partial class View_Expenses : Form
    {
        public View_Expenses()
        {
            InitializeComponent();
            DisplayExpenses();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Close();
        }

        private void income_Click(object sender, EventArgs e)
        {
            Income obj = new Income();
            obj.Show();
            this.Close();
        }

        private void expenses_Click(object sender, EventArgs e)
        {
            Expense obj = new Expense();
            obj.Show();
            this.Close();
        }

        private void shiko_ex_Click(object sender, EventArgs e)
        {
            View_Expenses obj = new View_Expenses();
            obj.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
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



        private void DisplayExpenses()
        {
            con.Open();
            string userLogin = Login.User;

            string Query = "SELECT ExName [Emri],ExpAmt[Sasia],ExpCat[Kategoria],ExpDate[Data],ExpDesc[Pershkrimi] FROM ExpenseTbl WHERE ExpUser = @UserLogin";  // ? Si mund te shfaq kategorit jo me index por me emer?
            using (SqlCommand cmd = new SqlCommand(Query, con))
            {
                cmd.Parameters.AddWithValue("@UserLogin", userLogin);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                foreach(DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.Resizable = DataGridViewTriState.False;
                }
                dataGridView1.Columns[dataGridView1.Columns.Count-1].AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
            }

            con.Close();
        }

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QRORMR1\SQLEXPRESS;Initial Catalog=CMP;Integrated Security=True");
    }
}
