using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PasswordDrawer
{
    public partial class Form3 : Form
    {

        public int count;
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;

        public Form3()
        {
            InitializeComponent();
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;Password=Password987");
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_conn.Open();
                sqlite_cmd.CommandText = "Select Count(*) from passphrase where passphrase = ?;";
                sqlite_cmd.Parameters.AddWithValue("param11", textEnterPassphrase.Text);
                count = Convert.ToInt32(sqlite_cmd.ExecuteScalar());
                if (count > 0)
                {
                    
                    
                    this.Visible = false;
                    this.Close();
                    Form1.vaultCount = 1;
                    Form1.showVault();
                }
                else
                {
                    DialogResult response = MessageBox.Show("Invalid passphrase entered", "Invalid Passphrase", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (response == DialogResult.Retry)
                    {
                        textEnterPassphrase.Clear();
                        textEnterPassphrase.Focus();
                    }
                    else
                    {
                        this.Hide();
                        this.Visible = false;
                    }
                }
               
            }
            catch (SQLiteException exception)
            {
                MessageBox.Show(exception.ToString(), "Invalid Passphrase", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textEnterPassphrase.UseSystemPasswordChar = false;
            }
            else
            {
                textEnterPassphrase.UseSystemPasswordChar = true; 
            }
        }
        

       
    }
}
