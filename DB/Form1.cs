using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                String function = null;                                                 //creating a null string variable

                String animal = animalInput.Text;                                       //storing user input in the variable
                String id = idInput.Text;

                if (id == "") function = searchByAnimal(animal);                        //if the user hasnt entered an ID //store this method call to the variable
                else function = searchByAnimal(animal, Int32.Parse(id));                //else use this function call

                string strDSN = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Manesh\OneDrive - Wintec\EPPLIKASON DEV\DB\FarmInfomation.accdb'";
                OleDbConnection myCon = new OleDbConnection(strDSN);                    //connectin string
                OleDbCommand myComm = new OleDbCommand(function, myCon);                //command string which takes the actual command as well as the function
                myCon.Open();                                                           //opening the function
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(myComm);            //creating a new data adapter which takes in the command
                DataTable animalsTable = new DataTable();                               //creating an empty table that will later on store the table
                dataAdapter.Fill(animalsTable);                                         //fill the data adapter with the table
                dataGridView1.DataSource = animalsTable;                                //take the table and display it in the datagrid
                myCon.Close();                                                          //close the connection
            }
            catch (Exception error)
            {
                MessageBox.Show("" + error);                                            //displaying the errors in a message box
            }

        }

        private String searchByAnimal(String animal)                                   //the command that actually retrieves data
        {
            string strSQL = "SELECT * FROM " + animal;
            return strSQL;
        }
        private String searchByAnimal(String animal, int id)
        {
            string strSQL = "SELECT * FROM " + animal + " WHERE ID = " + id;
            return strSQL;
        }
    }
}
