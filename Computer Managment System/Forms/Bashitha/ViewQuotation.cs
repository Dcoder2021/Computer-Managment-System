using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Computer_Managment_System.Classes;

namespace Computer_Managment_System
{
    public partial class ViewQuotation : Form
    {

        public static int oid;
        Customer c = new Customer();
        Quotation q = new Quotation();


        public ViewQuotation(int qid)
        {
            c.QID = qid;
            InitializeComponent();
        }

        private void view_Order_Load(object sender, EventArgs e)
        {
            DataTable QuotationItemDT = new DataTable();
            DataTable CustomerDT = new DataTable();

            QuotationDBUtil.SelectQuotation(ref QuotationItemDT, ref CustomerDT, c.QID);

            foreach(DataRow dr in CustomerDT.Rows)
            {
                c.Name = dr["CustomerName"].ToString();
                c.Date = dr["Date"].ToString();
                c.No = dr["TeleNo"].ToString();
                c.Email = dr["Email"].ToString();
                c.Address = dr["Address"].ToString();
                c.TotalAmount= (dr["TotalAmount"].ToString());

                MessageBox.Show(dr["TotalAmount"].ToString());
                
            }

            lbl_nameCustomer.Text = c.Name;
            lbl_qid.Text = c.QID.ToString();
            lbl_TeleNo.Text = c.No;
            lbl_Email.Text = c.Email;
            lbl_address.Text = c.Address;
            lbl_date.Text = c.Date;
            lbl_totAmount.Text = c.TotalAmount;


            QuotationItemGrid.DataSource = QuotationItemDT;
            QuotationItemGrid.Columns[0].ReadOnly = true;
            QuotationItemGrid.Columns[1].ReadOnly = true;






        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public static int total;
        public static int amount;
        private void btn_UpdateQ_Click(object sender, EventArgs e)
        {
            //Save data grid into a DataTable
            DataTable dt = new DataTable();
            for (int i = 0; i < QuotationItemGrid.Columns.Count; i++)
            {
                dt.Columns.Add("column" + i.ToString());
            }

            foreach (DataGridViewRow row in QuotationItemGrid.Rows)
            {
                DataRow dr = dt.NewRow();

                for (int j = 0; j < QuotationItemGrid.Columns.Count; j++)
                {
                    dr["column" + j.ToString()] = row.Cells[j].Value.ToString();
                }

                dt.Rows.Add(dr);

            }

            q.dataTable = dt;

            //update 
            

            

            //calcualate total
           /* try
            {
                int n = QuotationItemGrid.Rows.Add();

                string Qty = QuotationItemGrid.Rows[n].Cells[4].Value.ToString();
                string UnitPrice = QuotationItemGrid.Rows[n].Cells[5].Value.ToString();

                int total = 0;
                int qty = Convert.ToInt32(Qty);
                int uPrice = Convert.ToInt32(UnitPrice);
                total = uPrice * qty;

                string totalPrice = Convert.ToString(total);

                QuotationItemGrid.Rows[n].Cells[6].Value = totalPrice;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please enter the value again");
            }*/
            //calcualate total
            amount = 0;

            try
            {
                for (int rows = 0; rows < QuotationItemGrid.Rows.Count; rows++)
                {
                    string sQty = QuotationItemGrid.Rows[rows].Cells[3].Value.ToString();
                    string sUnitPrice = QuotationItemGrid.Rows[rows].Cells[4].Value.ToString();

                    int Tqty = Convert.ToInt32(sQty);
                    int UPrice = Convert.ToInt32(sUnitPrice);

                    amount = amount + (UPrice * Tqty);
                }

                //Qtotalamount.Text = Convert.ToString(amount);
                c.TotalAmount = Convert.ToString(amount);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please enter the value again");
            }
            bool success = QuotationDBUtil.UpdateQuotationItems(q);



            if (success == true)
            {
                MessageBox.Show("Data has successfully updated");

            }
            else
            {
                MessageBox.Show("Failed to insert the data");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void QuotationItemGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuotationItemGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btn_deleteQ_Click(object sender, EventArgs e)
        {
            bool isSuccess = QuotationDBUtil.Delete(c.QID);

            if(isSuccess == true)
            {
                MessageBox.Show("Quation has successfully deleted");
                this.Close();
            } else
            {
                MessageBox.Show("Failed to delete the quoation");
            }
        }
    }
}
