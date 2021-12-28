
namespace Computer_Managment_System
{
    partial class ViewQuotationList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Order = new System.Windows.Forms.Label();
            this.QuotationListGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_Refresh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuotationListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Order
            // 
            this.lbl_Order.AutoSize = true;
            this.lbl_Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.lbl_Order.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order.ForeColor = System.Drawing.Color.White;
            this.lbl_Order.Location = new System.Drawing.Point(540, 39);
            this.lbl_Order.Name = "lbl_Order";
            this.lbl_Order.Size = new System.Drawing.Size(191, 37);
            this.lbl_Order.TabIndex = 2;
            this.lbl_Order.Text = "Quotation List";
            this.lbl_Order.Click += new System.EventHandler(this.lbl_Order_Click);
            // 
            // QuotationListGrid
            // 
            this.QuotationListGrid.AllowCustomTheming = false;
            this.QuotationListGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.QuotationListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.QuotationListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QuotationListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuotationListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.QuotationListGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuotationListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.QuotationListGrid.ColumnHeadersHeight = 40;
            this.QuotationListGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.QuotationListGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.QuotationListGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.QuotationListGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.QuotationListGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.QuotationListGrid.CurrentTheme.BackColor = System.Drawing.Color.DarkSlateGray;
            this.QuotationListGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.QuotationListGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.QuotationListGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.QuotationListGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.QuotationListGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.QuotationListGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.QuotationListGrid.CurrentTheme.Name = null;
            this.QuotationListGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.QuotationListGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.QuotationListGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.QuotationListGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.QuotationListGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QuotationListGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.QuotationListGrid.EnableHeadersVisualStyles = false;
            this.QuotationListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.QuotationListGrid.HeaderBackColor = System.Drawing.Color.DarkSlateGray;
            this.QuotationListGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.QuotationListGrid.HeaderForeColor = System.Drawing.Color.White;
            this.QuotationListGrid.Location = new System.Drawing.Point(48, 103);
            this.QuotationListGrid.Name = "QuotationListGrid";
            this.QuotationListGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuotationListGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.QuotationListGrid.RowHeadersVisible = false;
            this.QuotationListGrid.RowTemplate.Height = 40;
            this.QuotationListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QuotationListGrid.Size = new System.Drawing.Size(1193, 557);
            this.QuotationListGrid.TabIndex = 4;
            this.QuotationListGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            this.QuotationListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QuotationListGrid_CellContentClick);
            this.QuotationListGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QuotationListGrid_CellDoubleClick);
            this.QuotationListGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.orderListGrid_CellMouseDoubleClick);
            this.QuotationListGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.orderListGrid_RowHeaderMouseClick);
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_close.Location = new System.Drawing.Point(1241, 9);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(43, 42);
            this.lbl_close.TabIndex = 20;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // lbl_Refresh
            // 
            this.lbl_Refresh.AutoSize = true;
            this.lbl_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Refresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Refresh.Location = new System.Drawing.Point(1187, 79);
            this.lbl_Refresh.Name = "lbl_Refresh";
            this.lbl_Refresh.Size = new System.Drawing.Size(51, 19);
            this.lbl_Refresh.TabIndex = 21;
            this.lbl_Refresh.Text = "refresh";
            this.lbl_Refresh.Click += new System.EventHandler(this.lbl_Refresh_Click);
            // 
            // ViewQuotationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1296, 705);
            this.Controls.Add(this.lbl_Refresh);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.QuotationListGrid);
            this.Controls.Add(this.lbl_Order);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewQuotationList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Quotation List";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuotationListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Order;
        private Bunifu.UI.WinForms.BunifuDataGridView QuotationListGrid;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_Refresh;
    }
}