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

namespace PrintPage
{
    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\DB_Server1.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FamilyTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [MyTable] (Username,Email,Password,Confirm_Password,Name,Family,Phone,Mobile,Birth_Date,Birth_Place) values ('" + UsernameTextBox.Text + "','" + EmailTextBox.Text + "','" + PasswordTextBox.Text + "','" + ConfirmPassTextBox.Text + "','" + NameTextBox.Text + "','" + FamilyTextbox.Text + "','" + PhoneTextbox.Text + "','" + MobileTextBox.Text + "','" + BirthDateTextbox.Text + "','" + BirthPlaceTextbox.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            UsernameTextBox.Text = "";
            EmailTextBox.Text = "";
            PasswordTextBox.Text = "";
            ConfirmPassTextBox.Text = "";
            NameTextBox.Text = "";
            FamilyTextbox.Text = "";
            PhoneTextbox.Text = "";
            MobileTextBox.Text = "";
            BirthDateTextbox.Text = "";
            BirthPlaceTextbox.Text = "";
            //SearchTB.Text = "";
            //display_data();
            MessageBox.Show("Data Added Successfully");
        }
    }
}
