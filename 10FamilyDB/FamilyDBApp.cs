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
//Name: Alex Peterson
//Date: October 30, 2018
namespace _10FamilyDB
{
    public partial class FamilyDBApp : Form
    {
        //all private data fields/variables in FamilyDBApp
        private SqlCommand sqlcommd = new SqlCommand();
        private SqlConnection dbConnect;
        private string stringConn;
        private string sql;

        
        public FamilyDBApp()
        {
            InitializeComponent();
        }

        private void familyTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.familyTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ap0843532DataSet);

        }

        private void FamilyDBApp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ap0843532DataSet.familyTable' table. You can move, or remove it, as needed.
            this.familyTableTableAdapter.Fill(this.ap0843532DataSet.familyTable);

        }

       

        private void toolStripButtonSearch_Click_1(object sender, EventArgs e)
        {
            //code that executes and is used for an sql connection to familyTable in my database,
            try
            //a try that occurs when the code does execute properly.
            {
                lblMessage.Visible = true;
                lblMessage.Text = "When you click the search button left click and highlight the entire very first column including the column with a black arrow in it to see all the search info based on hometown";
                //code that sets and is uses an sql connection to familyTable in my database
                stringConn = "Data Source=stusql-fa18cis151-rr.cimq4ah3jd04.us-east-2.rds.amazonaws.com,1433; " +
                    "Initial Catalog=ap0843532; " + "User Id=ap0843532;" + "Password=843532";
                dbConnect = new SqlConnection(stringConn);
                //opens a connection to my familyTable in my Database
                dbConnect.Open();
                //sets the sql string that selects everything from my familyTable Where the hometown value is set to the search bar text box value.
                sql = "SELECT * FROM familyTable Where (HomeTown = @HomeTown)" + "ORDER BY LastName ASC, FirstName ASC;";
                //intanstiates a SQL command
                sqlcommd = new SqlCommand();
                //sets up an sql command equal to the sql formatted string
                sqlcommd.CommandText = sql;
                //sets sql commands connection to the dbConnect variable value.
                sqlcommd.Connection = dbConnect;
                //sets the sql search parameters to look for the HomeTown value of the table in the search bar text box.
                sqlcommd.Parameters.AddWithValue("HomeTown",txtSearch.Text);
                //instantiates a new data table 
                DataTable dtbl = new DataTable();
                //sets up the sql data adapter as the sql command.
                SqlDataAdapter sAdpt = new SqlDataAdapter(sqlcommd);
                //code that uses the sql data adapter command fill to fill in the new data table "dtbl".
                sAdpt.Fill(dtbl);
                //finally the new data table "dtbl" is set with the data source in familyTableDataGridView.
                familyTableDataGridView.DataSource = dtbl;
                //code that changes grid color, background color, and forecolor to white and green when you click the search button.
                familyTableDataGridView.BackgroundColor = Color.Green;
                familyTableDataGridView.ForeColor = Color.White;
                familyTableDataGridView.GridColor = Color.Green;
                

            }
            catch(System.Exception exc)
            //catch that throws an exception when the code does not execute properly.
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
