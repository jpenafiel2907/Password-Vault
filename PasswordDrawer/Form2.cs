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
    public partial class Form2 : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textPassphrase.Text == textPassphrase2.Text && textPassphrase.Text != "")
            {
                try
                { 
                    sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;Password=Password987");
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_conn.Open();
                    sqlite_cmd.CommandText = "CREATE TABLE passphrase (passphrase varchar(30));";
                    sqlite_cmd.ExecuteNonQuery();
                    sqlite_cmd.CommandText = "INSERT INTO passphrase (passphrase) VALUES (?);";
                    sqlite_cmd.Parameters.AddWithValue("param10", textPassphrase.Text);
                    sqlite_cmd.ExecuteNonQuery();   
                    // Let the SQLiteCommand object know our SQL-Query:
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "CREATE TABLE logindetails (id integer primary key asc, type varchar(50), account varchar (50), username varchar(50), password varchar(30));";

                    // Now lets execute the SQL ;D
                        sqlite_cmd.ExecuteNonQuery();
                        Form1 form1 = new Form1();
                        form1.Show();
                        form1.Visible = true;
                        this.Hide();
                        this.Visible = false;
                }
                catch (SQLiteException exception)
                {
                    MessageBox.Show(exception.ToString(), "Can't create database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            else
            {
                DialogResult response =  MessageBox.Show("Passphrase entered do not match", "Passphrase mismtach", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (response == DialogResult.Retry)
                {
                    textPassphrase.Clear();
                    textPassphrase2.Clear();
                    textPassphrase.Focus();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textPassphrase.UseSystemPasswordChar = false;
                textPassphrase2.UseSystemPasswordChar = false;
            }
            else
            {
                textPassphrase.UseSystemPasswordChar = true;
                textPassphrase2.UseSystemPasswordChar = true;
            }
        }
    }
}
