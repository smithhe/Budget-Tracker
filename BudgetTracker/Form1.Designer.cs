namespace BudgetTracker
{
	partial class frmHome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ltvDisplayReceipts = new System.Windows.Forms.ListView();
			this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.AmountSpent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StoreName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1138, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// ltvDisplayReceipts
			// 
			this.ltvDisplayReceipts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader,
            this.StoreName,
            this.Category,
            this.AmountSpent});
			this.ltvDisplayReceipts.Location = new System.Drawing.Point(12, 60);
			this.ltvDisplayReceipts.Name = "ltvDisplayReceipts";
			this.ltvDisplayReceipts.Size = new System.Drawing.Size(450, 405);
			this.ltvDisplayReceipts.TabIndex = 2;
			this.ltvDisplayReceipts.UseCompatibleStateImageBehavior = false;
			this.ltvDisplayReceipts.View = System.Windows.Forms.View.Details;
			this.ltvDisplayReceipts.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LtvDisplayReceipts_ColumnClick);
			// 
			// columnHeader
			// 
			this.columnHeader.Text = "Store Name";
			this.columnHeader.Width = 0;
			// 
			// Category
			// 
			this.Category.Text = "Category";
			this.Category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Category.Width = 171;
			// 
			// AmountSpent
			// 
			this.AmountSpent.Text = "Amount Spent";
			this.AmountSpent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.AmountSpent.Width = 108;
			// 
			// StoreName
			// 
			this.StoreName.Text = "Store Name";
			this.StoreName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.StoreName.Width = 166;
			// 
			// frmHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1138, 626);
			this.Controls.Add(this.ltvDisplayReceipts);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmHome";
			this.Text = "Budget Tracker";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ListView ltvDisplayReceipts;
		private System.Windows.Forms.ColumnHeader columnHeader;
		private System.Windows.Forms.ColumnHeader Category;
		private System.Windows.Forms.ColumnHeader AmountSpent;
		private System.Windows.Forms.ColumnHeader StoreName;
	}
}

