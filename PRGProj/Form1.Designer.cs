namespace PRGProj
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateAndTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.lblEventID = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmsExplain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.explainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.cmsExplain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceToolStripMenuItem,
            this.dateAndTimeToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.eventTitleToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // priceToolStripMenuItem
            // 
            this.priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            this.priceToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.priceToolStripMenuItem.Text = "Price";
            this.priceToolStripMenuItem.Click += new System.EventHandler(this.PriceToolStripMenuItem_Click);
            // 
            // dateAndTimeToolStripMenuItem
            // 
            this.dateAndTimeToolStripMenuItem.Name = "dateAndTimeToolStripMenuItem";
            this.dateAndTimeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.dateAndTimeToolStripMenuItem.Text = "Date and Time";
            this.dateAndTimeToolStripMenuItem.Click += new System.EventHandler(this.DateAndTimeToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.LocationToolStripMenuItem_Click);
            // 
            // eventTitleToolStripMenuItem
            // 
            this.eventTitleToolStripMenuItem.Name = "eventTitleToolStripMenuItem";
            this.eventTitleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.eventTitleToolStripMenuItem.Text = "Event Title";
            this.eventTitleToolStripMenuItem.Click += new System.EventHandler(this.EventTitleToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(96, 45);
            this.dgvEvents.MultiSelect = false;
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.Size = new System.Drawing.Size(644, 190);
            this.dgvEvents.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(157, 382);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // txtEventID
            // 
            this.txtEventID.Location = new System.Drawing.Point(437, 382);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.Size = new System.Drawing.Size(116, 20);
            this.txtEventID.TabIndex = 3;
            this.txtEventID.Visible = false;
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(647, 400);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(93, 38);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "Submit";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Visible = false;
            this.btnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Location = new System.Drawing.Point(351, 385);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(49, 13);
            this.lblEventID.TabIndex = 5;
            this.lblEventID.Text = "Event ID";
            this.lblEventID.Visible = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(70, 384);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search: ";
            this.lblSearch.Visible = false;
            // 
            // cmsExplain
            // 
            this.cmsExplain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.explainToolStripMenuItem});
            this.cmsExplain.Name = "cmsExplain";
            this.cmsExplain.Size = new System.Drawing.Size(112, 26);
            this.cmsExplain.Opening += new System.ComponentModel.CancelEventHandler(this.CmsExplain_Opening);
            // 
            // explainToolStripMenuItem
            // 
            this.explainToolStripMenuItem.Name = "explainToolStripMenuItem";
            this.explainToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.explainToolStripMenuItem.Text = "Explain";
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(157, 382);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(121, 21);
            this.cbSearch.TabIndex = 7;
            this.cbSearch.Visible = false;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.CbSearch_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.cmsExplain;
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblEventID);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gabriel\'s Ticket System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.cmsExplain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ContextMenuStrip cmsExplain;
        private System.Windows.Forms.ToolStripMenuItem explainToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.ToolStripMenuItem dateAndTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventTitleToolStripMenuItem;
    }
}

