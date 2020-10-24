namespace PRGProj
{
    partial class frmTick
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
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvCustomerInfo = new System.Windows.Forms.DataGridView();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeOfCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmByCustomerIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmByNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmByNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmByIDNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCC = new System.Windows.Forms.Label();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.lblTicks = new System.Windows.Forms.Label();
            this.lblCusID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(55, 415);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(75, 23);
            this.btnPurchase.TabIndex = 0;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Visible = false;
            this.btnPurchase.Click += new System.EventHandler(this.BtnPurchase_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(678, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // dgvCustomerInfo
            // 
            this.dgvCustomerInfo.AllowUserToAddRows = false;
            this.dgvCustomerInfo.AllowUserToDeleteRows = false;
            this.dgvCustomerInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvCustomerInfo.Location = new System.Drawing.Point(27, 58);
            this.dgvCustomerInfo.Name = "dgvCustomerInfo";
            this.dgvCustomerInfo.ReadOnly = true;
            this.dgvCustomerInfo.Size = new System.Drawing.Size(741, 49);
            this.dgvCustomerInfo.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(143, 215);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeOfCustomerToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // typeOfCustomerToolStripMenuItem
            // 
            this.typeOfCustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.returningToolStripMenuItem});
            this.typeOfCustomerToolStripMenuItem.Name = "typeOfCustomerToolStripMenuItem";
            this.typeOfCustomerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.typeOfCustomerToolStripMenuItem.Text = "Type of Customer";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // returningToolStripMenuItem
            // 
            this.returningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confirmByCustomerIDToolStripMenuItem,
            this.confirmByNameToolStripMenuItem1});
            this.returningToolStripMenuItem.Name = "returningToolStripMenuItem";
            this.returningToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.returningToolStripMenuItem.Text = "Returning";
            // 
            // confirmByCustomerIDToolStripMenuItem
            // 
            this.confirmByCustomerIDToolStripMenuItem.Name = "confirmByCustomerIDToolStripMenuItem";
            this.confirmByCustomerIDToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.confirmByCustomerIDToolStripMenuItem.Text = "Confirm by Customer ID";
            this.confirmByCustomerIDToolStripMenuItem.Click += new System.EventHandler(this.ConfirmByCustomerIDToolStripMenuItem_Click);
            // 
            // confirmByNameToolStripMenuItem1
            // 
            this.confirmByNameToolStripMenuItem1.Name = "confirmByNameToolStripMenuItem1";
            this.confirmByNameToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.confirmByNameToolStripMenuItem1.Text = "Confirm by Name";
            this.confirmByNameToolStripMenuItem1.Click += new System.EventHandler(this.ConfirmByNameToolStripMenuItem1_Click);
            // 
            // confirmByNameToolStripMenuItem
            // 
            this.confirmByNameToolStripMenuItem.Name = "confirmByNameToolStripMenuItem";
            this.confirmByNameToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.confirmByNameToolStripMenuItem.Text = "Confirm by name";
            // 
            // confirmByIDNumberToolStripMenuItem
            // 
            this.confirmByIDNumberToolStripMenuItem.Name = "confirmByIDNumberToolStripMenuItem";
            this.confirmByIDNumberToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.confirmByIDNumberToolStripMenuItem.Text = "Confirm by ID number";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(331, 215);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(82, 218);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(267, 218);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(143, 272);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.Visible = false;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(331, 272);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(100, 20);
            this.txtCC.TabIndex = 9;
            this.txtCC.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(82, 275);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(48, 13);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone #";
            this.lblPhone.Visible = false;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(266, 275);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(59, 13);
            this.lblCC.TabIndex = 11;
            this.lblCC.Text = "Credit Card";
            this.lblCC.Visible = false;
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(143, 322);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(100, 20);
            this.txtTickets.TabIndex = 12;
            this.txtTickets.Visible = false;
            // 
            // lblTicks
            // 
            this.lblTicks.AutoSize = true;
            this.lblTicks.Location = new System.Drawing.Point(73, 325);
            this.lblTicks.Name = "lblTicks";
            this.lblTicks.Size = new System.Drawing.Size(64, 13);
            this.lblTicks.TabIndex = 13;
            this.lblTicks.Text = "# of Tickets";
            this.lblTicks.Visible = false;
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Location = new System.Drawing.Point(71, 275);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(65, 13);
            this.lblCusID.TabIndex = 14;
            this.lblCusID.Text = "Customer ID";
            this.lblCusID.Visible = false;
            // 
            // frmTick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCusID);
            this.Controls.Add(this.lblTicks);
            this.Controls.Add(this.txtTickets);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.dgvCustomerInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTick";
            this.Text = "Ticket Purchases";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvCustomerInfo;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeOfCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmByNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmByIDNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmByCustomerIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmByNameToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.Label lblTicks;
        private System.Windows.Forms.Label lblCusID;
    }
}