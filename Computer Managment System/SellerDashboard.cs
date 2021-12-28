using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Computer_Managment_System.Classes;

namespace Computer_Managment_System
{
    public partial class SellerDashboard : Form
    {



        public static string UserName;




        //Bhashitha
        Customer cus = new Customer();

        //Nadun
        createInvoice c = new createInvoice();

        public SellerDashboard(string uname)
        {
            UserName = uname;
            InitializeComponent();
        }

       

        private void Dashboard_Load(object sender, EventArgs e)
        {

            txt_username.Text = UserName;

            //add items to the Brand combo Box
            DataTable dt = QuotationDBUtil.SelectBrand();
            foreach (DataRow dr in dt.Rows)
            {
                cmbBox_brandQ.Items.Add(dr["Brand"].ToString());
            }


            


        }

        



        /*-----------------------------------------------------------------Page Navigation---------------------------------------------------------*/

        

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            SellerDashboardPages.SetPage("Home");
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            SellerDashboardPages.SetPage("Billing");
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            SellerDashboardPages.SetPage("Quotations");
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            SellerDashboardPages.SetPage("Service");
        }




        /*------------------------------------------------------------------------------------------------------------------------------------------------------/
        /*-------------------------------------------------------------- Bhashitha - IT20117764 -----------------------------------------------------------*/
        public void QuationClear()
        {
            QItemsGrid.DataSource = "";
            cmbBox_brandQ.Text = "";
            cmbBox_categoryQ.Text = "";
            txtBox_qtyQ.Text = "";
            cmbBox_itemNameQ.Text = "";
            Qtotalamount.Text = "";
        }

        private void cmbBox_brandQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            string brand = cmbBox_brandQ.Text.ToString();
            DataTable dt = QuotationDBUtil.SelectCategory(brand);

            //clear Category combo Box
            cmbBox_categoryQ.Items.Clear();


            foreach (DataRow dr in dt.Rows)
            {
                cmbBox_categoryQ.Items.Add(dr["Catogery"].ToString());

            }
        }


        public static int total;
        public static int amount;

        private void btn_addItemQ_Click(object sender, EventArgs e)
        {
            int n = QItemsGrid.Rows.Add();

            string brand = cmbBox_brandQ.Text.ToString();
            string category = cmbBox_categoryQ.Text.ToString();
            string itemName = cmbBox_itemNameQ.Text.ToString();
            string serial;
            string unitPrice;



            DataTable dt = QuotationDBUtil.SelectItemDetails(brand, category, itemName);

            foreach (DataRow dr in dt.Rows)
            {
                serial = dr["SerialNumber"].ToString();
                unitPrice = dr["UnitPrice"].ToString();

                QItemsGrid.Rows[n].Cells[0].Value = serial;
                QItemsGrid.Rows[n].Cells[3].Value = unitPrice;
            }

            QItemsGrid.Rows[n].Cells[1].Value = cmbBox_itemNameQ.Text;
            QItemsGrid.Rows[n].Cells[2].Value = txtBox_qtyQ.Text;
            try
            {
                string Qty = QItemsGrid.Rows[n].Cells[2].Value.ToString();
                string UnitPrice = QItemsGrid.Rows[n].Cells[3].Value.ToString();

                int total = 0;
                int qty = Convert.ToInt32(Qty);
                int uPrice = Convert.ToInt32(UnitPrice);
                total = uPrice * qty;

                string totalPrice = Convert.ToString(total);

                QItemsGrid.Rows[n].Cells[4].Value = totalPrice;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please enter the value again");
            }
            //calcualate total
            amount = 0;

            try
            {
                for (int rows = 0; rows < QItemsGrid.Rows.Count; rows++)
                {
                    string sQty = QItemsGrid.Rows[rows].Cells[2].Value.ToString();
                    string sUnitPrice = QItemsGrid.Rows[rows].Cells[3].Value.ToString();

                    int Tqty = Convert.ToInt32(sQty);
                    int UPrice = Convert.ToInt32(sUnitPrice);

                    amount = amount + (UPrice * Tqty);
                }

                Qtotalamount.Text = Convert.ToString(amount);
                cus.TotalAmount = Convert.ToString(amount);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter the value again");
                QItemsGrid.Rows.RemoveAt(n);
            }

            cmbBox_itemNameQ.Text = "";
            txtBox_qtyQ.Text = "";
        }

        private void cmbBox_categoryQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            string brand = cmbBox_brandQ.Text.ToString();
            string category = cmbBox_categoryQ.Text.ToString();

            DataTable dt = QuotationDBUtil.SelectItems(brand, category);

            //clear combobox
            cmbBox_itemNameQ.Items.Clear();

            //add items for the combobox
            foreach (DataRow dr in dt.Rows)
            {
                cmbBox_itemNameQ.Items.Add(dr["ItemName"].ToString());

            }
        }

        private void bunifuButton26AddCustomer_Click(object sender, EventArgs e)
        {
            CustomerDetailQ customerDetailQ = new CustomerDetailQ(cus.TotalAmount);
            customerDetailQ.Show();
        }

        private void bunifuButton26viewQ_Click(object sender, EventArgs e)
        {
            ViewQuotationList viewQuotationList = new ViewQuotationList();
            viewQuotationList.Show();
        }


        Quotation q = new Quotation();
        public static string totalPrice;

        private void btn_CreateQuotation_Click(object sender, EventArgs e)
        {
            q.BrandQ = cmbBox_brandQ.Text;
            q.CatergoryQ = cmbBox_categoryQ.Text;
            q.ItemnameQ = cmbBox_itemNameQ.Text;
            q.Total = totalPrice;




            //Save data grid into a DataTable
            DataTable dt = new DataTable();
            for (int i = 0; i < QItemsGrid.Columns.Count; i++)
            {
                dt.Columns.Add("column" + i.ToString());
            }

            foreach (DataGridViewRow row in QItemsGrid.Rows)
            {
                DataRow dr = dt.NewRow();

                for (int j = 0; j < QItemsGrid.Columns.Count; j++)
                {
                    dr["column" + j.ToString()] = row.Cells[j].Value.ToString();
                }

                dt.Rows.Add(dr);

            }

            q.dataTable = dt;

            
            int qid = QuotationDBUtil.getQID();

            bool success = QuotationDBUtil.insertQuotationItems(dt, qid);

            if (success == true)
            {
                MessageBox.Show("Quotation has successfully Created");
                QuationClear();

                ViewQuotation viewQuotation = new ViewQuotation(qid);
                viewQuotation.Show();


            }
            else
            {
                MessageBox.Show("Failed to insert the data");
            }
        }









        /*------------------------------------------------------------------------------------------------------------------------------------------------------/
        /*-------------------------------------------------------------- Nadun - IT20117764 -----------------------------------------------------------*/

        public static float tot;
        public static float totDisc;




        public void invoiceClear()
        {
            cusNameTB.Text = "";
            addSerialTB.Text = "";
            cusMobileTB.Text = "";
            discountTB.Text = "";
            qtyTB.Text = "";
            itemListGrid.DataSource = "";
            totDiscValueLB.Text = "0";
            totValueLB.Text = "0";
            recivedAmountTB.Text = "0";
            changeAmountLB.Text = "0";

        }



        private void cusMobileTB_TextChanged(object sender, EventArgs e)
        {
            string no = cusMobileTB.Text;
            Regex regex = new Regex(@"^(^[0][1-9]\d{8}$)+$");
            Match match = regex.Match(no);



            if (match.Success)
            {



                lbl_error.Text = "";
            }
            else
            {
                lbl_error.ForeColor = Color.Red;
                lbl_error.Text = "Incorrect";



            }
        }



        private void addBTN_Click(object sender, EventArgs e)
        {
            int n = itemListGrid.Rows.Add();
            string SerialNumber = addSerialTB.Text;
            string ItemName;
            int SellingPrice;
            int Warranty;


            DataTable dt = createInvoice.SelectRow(SerialNumber);

            foreach (DataRow dr in dt.Rows)
            {

                SellingPrice = Convert.ToInt32(dr["SellingPrice"].ToString());
                ItemName = dr["ItemName"].ToString();
                Warranty = Convert.ToInt32(dr["Warranty"].ToString());

                //calculate subtotal
                float subTotal = 0;
                string sdis = discountTB.Text.ToString();
                float dis = float.Parse(sdis);

                string sqty = qtyTB.Text.ToString();
                int qty = Convert.ToInt32(sqty);

                subTotal = (SellingPrice - dis) * qty;

                itemListGrid.Rows[n].Cells[1].Value = ItemName;
                itemListGrid.Rows[n].Cells[2].Value = SellingPrice;
                itemListGrid.Rows[n].Cells[6].Value = Warranty;
                itemListGrid.Rows[n].Cells[5].Value = subTotal;
            }

            itemListGrid.Rows[n].Cells[0].Value = addSerialTB.Text;
            itemListGrid.Rows[n].Cells[3].Value = discountTB.Text;
            itemListGrid.Rows[n].Cells[4].Value = qtyTB.Text;


            //calcualate total discount and final total
            tot = 0;
            totDisc = 0;
            try
            {
                for (int rows = 0; rows < itemListGrid.Rows.Count; rows++)
                {
                    string sQty = itemListGrid.Rows[rows].Cells[4].Value.ToString();
                    string sUnitPrice = itemListGrid.Rows[rows].Cells[2].Value.ToString();
                    string sDiscount = itemListGrid.Rows[rows].Cells[3].Value.ToString();

                    int qty = Convert.ToInt32(sQty);
                    float uPrice = float.Parse(sUnitPrice);
                    float dis = float.Parse(sDiscount);

                    tot = tot + ((uPrice - dis) * qty);
                    totDisc = totDisc + (dis * qty);
                }

                totValueLB.Text = Convert.ToString(tot);
                totDiscValueLB.Text = Convert.ToString(totDisc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter the value again");
                itemListGrid.Rows.RemoveAt(n);
            }

            /*qtyTB.Text = "";
            discountTB.Text = "";*/
            addSerialTB.Text = "";
        }

        public static int change;

        private void recivedAmountTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //c.Receive = float.Parse(recivedAmountTB.Text);
                change = 0;
                string sRecieve = recivedAmountTB.Text.ToString();
                int recieve = Convert.ToInt32(sRecieve);

                string sTot1 = totValueLB.Text.ToString();
                int tot1 = Convert.ToInt32(sTot1);

                change = (recieve - tot1);

                changeAmountLB.Text = change.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter the value again");
            }
        }

        private void printBTN_Click(object sender, EventArgs e)
        {
            //save data grid in to a data table
            DataTable dt = new DataTable();
            for (int i = 0; i < itemListGrid.Columns.Count; i++)
            {
                dt.Columns.Add("column" + i.ToString());
            }

            foreach (DataGridViewRow row in itemListGrid.Rows)
            {
                DataRow dr = dt.NewRow();

                for (int j = 0; j < itemListGrid.Columns.Count; j++)
                {
                    dr["column" + j.ToString()] = row.Cells[j].Value.ToString();
                }

                dt.Rows.Add(dr);
            }

            //****************************************invoice table*******************************************************
            //get the value from the input fields
            c.CusName = cusNameTB.Text;
            c.CusMobile = Convert.ToInt32(cusMobileTB.Text);
            c.Total = float.Parse(totValueLB.Text);
            c.Receive = float.Parse(recivedAmountTB.Text);
            c.Change = float.Parse(changeAmountLB.Text);
            c.TotalDiscount = float.Parse(totDiscValueLB.Text);
            c.Receive = float.Parse(recivedAmountTB.Text);
            c.TotalDiscount = float.Parse(totDiscValueLB.Text);
            c.date = pickDate.Text;

            //inserting data
            bool success = c.Insert(c);
            if (success == true)
            {
                //suxxessfull Inserted
                int invoiceID = createInvoice.getInvoiceId();
                success = createInvoice.insertOrderItems(dt, invoiceID);
                if (success == true)
                {
                    MessageBox.Show("Inserted successfully");
                    invoiceClear();
                }
                else
                {
                    MessageBox.Show("Insert Failed");
                }
            }
            else
            {
                MessageBox.Show("Insert Failed");
            }
        }

        private void btn_previousBills_Click(object sender, EventArgs e)
        {
            BillList bills = new BillList();
            bills.Show();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }






        /*------------------------------------------------------------------------------------------------------------------------------------------------------/
        /*-------------------------------------------------------------- Anuththara - IT20117764 -----------------------------------------------------------*/



        private void btn_newRepair_Click(object sender, EventArgs e)
        {
            ServiceRepair_NewRepair Service_Repair = new ServiceRepair_NewRepair();
            //this.Hide();
            Service_Repair.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // ServiceRepair_NewRepaireView Service_Repair = new ServiceRepair_NewRepaireView();
            //this.Hide();
         //   Service_Repair.Show();
        }

        private void btn_EditStatus_Click(object sender, EventArgs e)
        {
            ServiceRepair_StatusEdit Service_Repair = new ServiceRepair_StatusEdit();
            //this.Hide();
            Service_Repair.Show();
        }

        private void btn_ViewStatus_Click(object sender, EventArgs e)
        {
         //   ServiceRepair_Statusview Service_Repair = new ServiceRepair_Statusview();
            //this.hide();
         //   Service_Repair.Show();
        }

        private void btn_printDetails_Click(object sender, EventArgs e)
        {
            ServiceRepair_Print Service_Repair = new ServiceRepair_Print();
            //this.hide()
            Service_Repair.Show();
        }

        private void btn_checkWarrenty_Click(object sender, EventArgs e)
        {
          //  ServiceRepair_warrenty Service_Repair = new ServiceRepair_warrenty();
            //this.Hide();
         //   Service_Repair.Show();
        }


        




        private void lbl_Clear_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
