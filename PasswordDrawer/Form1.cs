using System;
using System.IO;
using System.Reflection;
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
           
    public partial class Form1 : Form
    {
        SQLiteConnection sqlite_conn;
        SQLiteCommand sqlite_cmd;
        SQLiteDataAdapter sqlite_dataadapter;
        private BindingSource bindingSource1 = new BindingSource();
        static Boolean update = false;
        static String idToBeUpdated = null;
        public static int vaultCount = 0;
        
        public Form1()
        {
            InitializeComponent();          
            checkDatabaseExistence();
              
        }
        
 
        public void checkDatabaseExistence()
        {
                
                establishDatabaseConnection();
           
        }

        public void establishDatabaseConnection()
        {
            
            // open the connection:
            try
            {
                openConnection();
                
                // create a new SQL command:
                sqlite_cmd = sqlite_conn.CreateCommand();

            } catch (SQLiteException e)
            {
                MessageBox.Show(e.ToString(), "Can't open database\n", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        

        public void openConnection()
        {
            try
            {
                sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;Password=Password987");

            } catch (SQLiteException exception)
            {
                MessageBox.Show(exception.ToString(), "Can't open database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void checkDatabaseConnection()
        {
            if (sqlite_conn == null || sqlite_conn.State == ConnectionState.Closed)
            {
                sqlite_conn.Open();
            }
        }

        public void addNewRecord ()
        {
            idToBeUpdated = null;
            clearForm();
            labelStatus.Text = "Adding new record";
            comboType.Enabled = true;
            comboType.SelectedIndex = -1;
            textUserName.Enabled = true;
            textPassword.Enabled = true;
            buttonSave.Enabled = true;
            buttonClear.Enabled = true;
            buttonCancel.Enabled = true;
        }

        public void saveRecord()
        {
            try
            {
                checkDatabaseConnection();

                if (update == false && idToBeUpdated == null)
                {

                    sqlite_cmd.CommandText = "INSERT INTO logindetails (type, account, username, password) VALUES (?,?,?,?);";
                }
                else
                {
                    sqlite_cmd.CommandText = "Update logindetails SET type = ?, account = ?, username = ?, password = ? WHERE id = "+ idToBeUpdated + ";" ;
                }


                int index = comboType.SelectedIndex;
                String selectedType = comboType.Items[index].ToString();
                String accountType;

                if (selectedType.Equals("Other"))
                {
                    accountType = textOther.Text;
                }
                else
                {
                    accountType = selectedType;
                }

                if (accountType == null || accountType == "")
                {
                    MessageBox.Show("Please specify other type of account", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textOther.Focus();
                }

                else
                {
                    sqlite_cmd.Parameters.AddWithValue("param1", selectedType);
                    sqlite_cmd.Parameters.AddWithValue("param2", accountType);
                    sqlite_cmd.Parameters.AddWithValue("param3", textUserName.Text);
                    sqlite_cmd.Parameters.AddWithValue("param4", textPassword.Text);

                    sqlite_cmd.ExecuteNonQuery();

                    if (update == false)
                    { labelStatus.Text = "Record added to database"; }
                    else
                    {
                        labelStatus.Text = "Record updated";
                    }

                    lockForm();
                }
            }
            catch (SQLiteException exception)
            {
                MessageBox.Show(exception.ToString(),"Can't add item to database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void deleteRecord(String recordDeletion)
        {
            try
            {
                if (sqlite_conn == null || sqlite_conn.State == ConnectionState.Closed)
                {
                    sqlite_conn.Open();
                }
                sqlite_cmd.CommandText = "DELETE FROM logindetails WHERE id = ?;";
                sqlite_cmd.Parameters.AddWithValue("param5", recordDeletion);
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd = new SQLiteCommand("Select * from logindetails;", sqlite_conn);
                
                updateDataTable(sqlite_cmd);
                clearForm();
                lockForm();

            } catch (SQLiteException exception)
            {
                MessageBox.Show(exception.ToString(), "Can't delete item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void searchDatabase(String searchString, String searchType)
        {

            String modifiedSearchString = "%"+searchString+"%";

            checkDatabaseConnection();

            if (searchType =="node" && searchString != "All")
            {
                String query = "Select id,type, account,username,password from logindetails where type = '" + searchString + "' ;";
                sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                updateDataTable(sqlite_cmd);
            }

            if (searchString == "" || searchString ==null || searchString=="All")
            {
                String query = "Select * from logindetails;";
                sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                updateDataTable(sqlite_cmd);
            }
            else
            {

                String query = "Select * from logindetails where type like '" + modifiedSearchString + "' OR account like '" + modifiedSearchString + "' OR username like '" + modifiedSearchString + "' ;";
                sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                updateDataTable(sqlite_cmd);
            }
        }
        public void lockForm()
        {
            comboType.Enabled = false;

            if (textOther.Enabled == true)
            {
                textOther.Enabled = false;
            }

            textUserName.Enabled = false;
            textPassword.Enabled = false;
            buttonSave.Enabled = false;
            buttonClear.Enabled = false;
            buttonCancel.Enabled = false;
            idToBeUpdated = null;
            update = false;

            
        }

        public void clearForm()
        {
            comboType.SelectedIndex = -1;
            
            textOther.Clear();
            textOther.Enabled = false;
            textUserName.Clear();
            textPassword.Clear();
            labelStatus.Text = "Idle";
        }

        public void updateDataTable (SQLiteCommand cmd)
        {
            sqlite_dataadapter = new SQLiteDataAdapter();
            sqlite_dataadapter.SelectCommand = cmd;


            DataTable dataTable = new DataTable();
            sqlite_dataadapter.Fill(dataTable);
            BindingSource bSource = new BindingSource();

            bSource.DataSource = dataTable;
            dataGridView1.DataSource = bSource;
            sqlite_dataadapter.Update(dataTable);
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
            }
            
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            clearForm();
            labelStatus.Text = "Adding new record";
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveRecord();
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {
            
            if (vaultCount == 0)
            {
                tabPane.SelectedTab = tabPane.TabPages["tabPage1"];
                Form3 passphraseForm = new Form3();
                passphraseForm.Show();
                passphraseForm.Visible = true;
                                
            }


            treeView1.ExpandAll();

            string query = "SELECT * FROM logindetails;";
           
            if (sqlite_conn == null && sqlite_conn.State == ConnectionState.Closed)
            {
                establishDatabaseConnection();
            }
            try
            {
                sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                updateDataTable(sqlite_cmd);
                
                
            } catch (SQLiteException exception)
            {
                MessageBox.Show(exception.ToString(),"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboType.SelectedIndex ==-1)
            {
                //do nothing
            } 
            else
            {             
                int index = comboType.SelectedIndex;
                String selectedType = comboType.Items[index].ToString();
                if (selectedType.Equals("Other"))
                {
                    textOther.Enabled = true;
                }
                else
                {
                    textOther.Enabled = false;
                    textOther.Text = "";
                }
        }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            addNewRecord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearForm();
            lockForm();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to edit this record?", "Edit Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    idToBeUpdated = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    int index = comboType.FindStringExact(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    comboType.SelectedIndex = index;

                    if (comboType.SelectedItem.ToString() == "Other")
                    {
                        textOther.Enabled = true;
                        textOther.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    }

                    textUserName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    textPassword.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    comboType.Enabled = true;
                   
                    textUserName.Enabled = true;
                    textPassword.Enabled = true;
                    buttonSave.Enabled = true;
                    buttonClear.Enabled = true;
                    buttonCancel.Enabled = true;
                    update = true;
                    tabPane.SelectedTab = tabPane.TabPages["tabPage1"];
                    labelStatus.Text = "Editing exiting record";
                }
            }
        }      

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count == 0 )
            {
                MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {       
                    String idToBeDeleted = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    deleteRecord(idToBeDeleted);
                    
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        { 
            searchDatabase(textSearch.Text,null);
           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            searchDatabase(treeView1.SelectedNode.Text,"node");
        }

        public static void showVault()
        {
            tabPane.SelectedTab = tabPane.TabPages["tabPage2"];
        }
            
        
    }
}  
    