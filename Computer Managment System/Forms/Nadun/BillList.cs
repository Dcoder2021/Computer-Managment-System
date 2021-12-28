using Computer_Managment_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Managment_System
{
    public partial class BillList : Form
    {
        //public static int invoiceId;
       
        public BillList()
        {
            //invoiceId = id;
            InitializeComponent();
        }
        createInvoice d = new createInvoice();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Load data into gridview
            DataTable dt = d.Select();
            billLineUpGRID.DataSource = dt;
        }

        private void BillList_Load(object sender, EventArgs e)
        {
            DataTable dt = d.Select();
            billLineUpGRID.DataSource = dt;
        }

        private void billLineUpGRID_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            
        }

        private void billLineUpGRID_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the id from Grid 
            //Identify the clicked row
            int rowindex = e.RowIndex;
            string Sinid = billLineUpGRID.Rows[rowindex].Cells[0].Value.ToString();
            int id = Convert.ToInt32(Sinid);
            detailBill db = new detailBill(id);
            db.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {
           /* //Refresh item table
            DataTable dt = createInvoice.Select2(invoiceId);
            billLineUpGRID.DataSource = dt;
           */
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {

        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Search textbox
        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = createInvoice.Search(textBoxSearch.Text);
            billLineUpGRID.DataSource = dt;

        }

        private void lbl_Refresh_Click(object sender, EventArgs e)
        {
            //Load data into gridview
            DataTable dt = d.Select();
            billLineUpGRID.DataSource = dt;
        }
    }
}
