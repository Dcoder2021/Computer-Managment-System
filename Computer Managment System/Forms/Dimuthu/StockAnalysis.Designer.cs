﻿
namespace Computer_Managment_System.Forms.Dimuthu
{
    partial class StockAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockAnalysis));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.Title1 = new System.Windows.Forms.Label();
            this.ItemTotTbl = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.totalItemCount = new System.Windows.Forms.Label();
            this.countLbl = new System.Windows.Forms.Label();
            this.btn_countTot = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTotTbl)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title1
            // 
            this.Title1.AutoSize = true;
            this.Title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Location = new System.Drawing.Point(542, 55);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(314, 39);
            this.Title1.TabIndex = 0;
            this.Title1.Text = "Analyse Stock Data";
            // 
            // ItemTotTbl
            // 
            this.ItemTotTbl.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ItemTotTbl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemTotTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemTotTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemTotTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemTotTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemTotTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItemTotTbl.ColumnHeadersHeight = 40;
            this.ItemTotTbl.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.ItemTotTbl.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ItemTotTbl.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ItemTotTbl.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ItemTotTbl.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ItemTotTbl.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.ItemTotTbl.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ItemTotTbl.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.ItemTotTbl.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.ItemTotTbl.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ItemTotTbl.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.ItemTotTbl.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ItemTotTbl.CurrentTheme.Name = null;
            this.ItemTotTbl.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemTotTbl.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ItemTotTbl.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ItemTotTbl.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ItemTotTbl.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemTotTbl.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemTotTbl.EnableHeadersVisualStyles = false;
            this.ItemTotTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ItemTotTbl.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.ItemTotTbl.HeaderBgColor = System.Drawing.Color.Empty;
            this.ItemTotTbl.HeaderForeColor = System.Drawing.Color.White;
            this.ItemTotTbl.Location = new System.Drawing.Point(24, 310);
            this.ItemTotTbl.Name = "ItemTotTbl";
            this.ItemTotTbl.RowHeadersVisible = false;
            this.ItemTotTbl.RowHeadersWidth = 51;
            this.ItemTotTbl.RowTemplate.Height = 40;
            this.ItemTotTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemTotTbl.Size = new System.Drawing.Size(1408, 335);
            this.ItemTotTbl.TabIndex = 1;
            this.ItemTotTbl.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.AutoSizeHeight = true;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBox1.BorderRadius = 45;
            this.bunifuTextBox1.BorderThickness = 1;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Lines = new string[0];
            this.bunifuTextBox1.Location = new System.Drawing.Point(23, 219);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties4;
            this.bunifuTextBox1.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox1.PlaceholderText = "search by category";
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(343, 54);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 2;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 3;
            this.bunifuTextBox1.TextMarginTop = 1;
            this.bunifuTextBox1.TextPlaceholder = "search by category";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
            this.bunifuTextBox1.TextChanged += new System.EventHandler(this.bunifuTextBox1_TextChanged);
            // 
            // totalItemCount
            // 
            this.totalItemCount.AutoSize = true;
            this.totalItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemCount.ForeColor = System.Drawing.Color.White;
            this.totalItemCount.Location = new System.Drawing.Point(1141, 212);
            this.totalItemCount.Name = "totalItemCount";
            this.totalItemCount.Size = new System.Drawing.Size(66, 48);
            this.totalItemCount.TabIndex = 3;
            this.totalItemCount.Text = "00";
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLbl.ForeColor = System.Drawing.Color.White;
            this.countLbl.Location = new System.Drawing.Point(706, 223);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(327, 29);
            this.countLbl.TabIndex = 4;
            this.countLbl.Text = "Total Item count By category :";
            // 
            // btn_countTot
            // 
            this.btn_countTot.Location = new System.Drawing.Point(1294, 217);
            this.btn_countTot.Name = "btn_countTot";
            this.btn_countTot.Size = new System.Drawing.Size(137, 40);
            this.btn_countTot.TabIndex = 5;
            this.btn_countTot.Text = "Count";
            this.btn_countTot.UseVisualStyleBackColor = true;
            this.btn_countTot.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(-6, 668);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1483, 45);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(629, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "NewTech Company - SriLanka";
            // 
            // StockAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1468, 713);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_countTot);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.totalItemCount);
            this.Controls.Add(this.bunifuTextBox1);
            this.Controls.Add(this.ItemTotTbl);
            this.Controls.Add(this.Title1);
            this.Name = "StockAnalysis";
            this.Text = "StockAnalysis";
            ((System.ComponentModel.ISupportInitialize)(this.ItemTotTbl)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title1;
        private Bunifu.UI.WinForms.BunifuDataGridView ItemTotTbl;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private System.Windows.Forms.Label totalItemCount;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Button btn_countTot;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}