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

namespace IdentityCard
{
    public partial class Form1 : Form
    {
        public static SqlConnection sqlConnect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\casper\Documents\Visual Studio 2019\Projects\IdentityCard\DB\ContactDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();

        }

        private void trIdentityNo_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
            if (String.IsNullOrEmpty(trIdentityNo.Text))
            {
                trIdentityNo.Text = " trIdentityNo is not be EMPTY ";
            }
            else
            {

            }
        }

        private void surname_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
            if (String.IsNullOrEmpty(surname.Text))
            {
                surname.Text = "Surname is not be EMPTY ";
            }
            else
            {
                string word;
                word = surname.Text;
                surname.Text = word.ToUpper();
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
            if (String.IsNullOrEmpty(name.Text)){
                name.Text = " Name is not be EMPTY ";
            }
            else
            {
                string word;
                word = name.Text;
                name.Text = word.ToUpper();
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void documentNo_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
            if (String.IsNullOrEmpty(documentNo.Text))
            {
                documentNo.Text = " Document No is not be EMPTY ";
            }
            else
            {

            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nationality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {


            try
            {
                if (sqlConnect.State == ConnectionState.Closed) ;
                    sqlConnect.Open();
                SqlCommand sqlCmd = new SqlCommand("ContactAdd" , sqlConnect);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Insert");
                sqlCmd.Parameters.AddWithValue("@ContactId", 0);
                sqlCmd.Parameters.AddWithValue("@IdentityId", 0);
                sqlCmd.Parameters.AddWithValue("@SurName", surname.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@SurName", name.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@BirthDate", "Insert");
                sqlCmd.Parameters.AddWithValue("@DocumentNo", documentNo.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@ValidUntil", "Insert");
                sqlCmd.Parameters.AddWithValue("@Gender", gender.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Naltionality", nationality.Text.Trim());

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "Error");
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void trIdentityNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       
    }
}
