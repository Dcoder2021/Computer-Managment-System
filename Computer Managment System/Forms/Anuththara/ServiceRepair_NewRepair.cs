using Computer_Managment_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Managment_System
{
    public partial class ServiceRepair_NewRepair : Form
    {
        public ServiceRepair_NewRepair()
        {
            InitializeComponent();
        }

        newrepairClass c = new newrepairClass();

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_addNewrepair_Click(object sender, EventArgs e)
        {
            //Get the values from the input fields
            c.ClientName = txt_ClientName.Text;
            c.ClientAddress = txt_ClientAddress.Text;
            c.ContactNo = txt_ContactNo.Text;
            c.TechnicalNote = txt_TechnicalNote.Text;
            

            //Inserting the Data into Database using the method we create in the java class
            bool success = c.Insert(c);
            if (success == true)
            {
                //Successfully Inserted 
                MessageBox.Show("New Contact Successfully Inserted");
                //call the Clear method 
                Clear();
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Failed to add new Contact,Try Again!");
            }
            //Load Data on Data GridView
            DataTable dt = c.Select(); //Method that in java class
            dgv_newrepair.DataSource = dt; //Laod new data inserted
            
        }

        private void ServiceRepair_NewRepair_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select(); //Method that in java class
            dgv_newrepair.DataSource = dt; //Laod new data inserted
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_ClientName.Text = "";
            txt_ClientAddress.Text = "";
            txt_ContactNo.Text = "";
            txt_TechnicalNote.Text = "";
        }

        //Clear all the Feilds
        public void Clear()
        {
            txt_JobID.Text = "";
            txt_ClientName.Text = "";
            txt_ClientAddress.Text = "";
            txt_ContactNo.Text = "";
            txt_TechnicalNote.Text = "";
        }

        private void dgv_newrepair_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the Data from data grid View and laod it to the textboxes respectively
            //Identify the row on which mouse id click
            int rowIndex = e.RowIndex;

            txt_JobID.Text = dgv_newrepair.Rows[rowIndex].Cells[0].Value.ToString();
            txt_ClientName.Text = dgv_newrepair.Rows[rowIndex].Cells[1].Value.ToString();
            txt_ClientAddress.Text = dgv_newrepair.Rows[rowIndex].Cells[2].Value.ToString();
            txt_ContactNo.Text = dgv_newrepair.Rows[rowIndex].Cells[3].Value.ToString();
            txt_TechnicalNote.Text = dgv_newrepair.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            c.JobID = Convert.ToInt32(txt_JobID.Text);
            c.ClientName = txt_ClientName.Text;
            c.ClientAddress = txt_ClientAddress.Text;
            c.ContactNo = txt_ContactNo.Text;
            c.TechnicalNote = txt_TechnicalNote.Text;

            //Update Data in Database
            bool success = c.Update(c);
            if (success == true)
            {
                //Successfully Inserted 
                MessageBox.Show("Details Successfully Updated");
                //call the Clear method 
                Clear();
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Failed to update Details ,Try Again!");
            }
            //Load Data on Data GridView
            DataTable dt = c.Select(); //Method that in java class
            dgv_newrepair.DataSource = dt; //Laod new data inserted
            
        }

        private void btn_newrepairDelete_Click(object sender, EventArgs e)
        {
            //Get the ServiceID from the Application
            c.JobID = Convert.ToInt32(txt_JobID.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                //Successfully Inserted 
                MessageBox.Show("New Contact Successfully Deleted");
                //call the Clear method 
                Clear();
                //Refresh Data on Data GridView
                DataTable dt = c.Select(); //Method that in java class
               dgv_newrepair.DataSource = dt; //Laod new data inserted 
               // dgv_test.DataSource = dt; //Laod new data inserted

            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Failed to Delete  Contact,Try Again!");
            }
        }
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void btn_SearchNewRepair_TextChanged(object sender, EventArgs e)
        {
            //Get the value from text box 
            string keyword = txt_SearchAddnewrepair.Text;

            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_newrepair WHERE JobID LIKE '%"+keyword+ "%' OR ClientName LIKE '%" + keyword + "%' OR ClientAddress LIKE '%" + keyword + "%' OR ContactNo LIKE '%" + keyword + "%' OR TechnicalNote LIKE '%" + keyword + "%'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_newrepair.DataSource = dt;
        }

        

        private void bunifuDataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get the Data from data grid View and laod it to the textboxes respectively
            //Identify the row on which mouse id click
            int rowIndex = e.RowIndex;

            txt_JobID.Text = dgv_newrepair.Rows[rowIndex].Cells[0].Value.ToString();
            txt_ClientName.Text = dgv_newrepair.Rows[rowIndex].Cells[1].Value.ToString();
            txt_ClientAddress.Text = dgv_newrepair.Rows[rowIndex].Cells[2].Value.ToString();
            txt_ContactNo.Text = dgv_newrepair.Rows[rowIndex].Cells[3].Value.ToString();
            txt_TechnicalNote.Text = dgv_newrepair.Rows[rowIndex].Cells[4].Value.ToString();
        }


        
    }
}
