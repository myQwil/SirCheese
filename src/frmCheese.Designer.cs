namespace SirCheese {
	partial class frmCheese {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tblAll = new System.Windows.Forms.TableLayoutPanel();
			this.tblUpper = new System.Windows.Forms.TableLayoutPanel();
			this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
			this.pnlImage = new System.Windows.Forms.Panel();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.txtBrowse = new System.Windows.Forms.TextBox();
			this.pBox = new System.Windows.Forms.PictureBox();
			this.pnlPair = new System.Windows.Forms.Panel();
			this.txtDetail = new System.Windows.Forms.RichTextBox();
			this.pnlSearch = new System.Windows.Forms.Panel();
			this.lblID = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblType = new System.Windows.Forms.Label();
			this.lblRegion = new System.Windows.Forms.Label();
			this.lblRind = new System.Windows.Forms.Label();
			this.lblTaste = new System.Windows.Forms.Label();
			this.lblPair = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtType = new System.Windows.Forms.TextBox();
			this.txtRegion = new System.Windows.Forms.TextBox();
			this.txtRind = new System.Windows.Forms.TextBox();
			this.txtTaste = new System.Windows.Forms.TextBox();
			this.txtPair = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnCommit = new System.Windows.Forms.Button();
			this.pnlResults = new System.Windows.Forms.Panel();
			this.grdCheese = new System.Windows.Forms.DataGridView();
			this.opnImage = new System.Windows.Forms.OpenFileDialog();
			this.tblAll.SuspendLayout();
			this.tblUpper.SuspendLayout();
			this.tblDetail.SuspendLayout();
			this.pnlImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
			this.pnlPair.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			this.pnlResults.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdCheese)).BeginInit();
			this.SuspendLayout();
			// 
			// tblAll
			// 
			this.tblAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tblAll.ColumnCount = 1;
			this.tblAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tblAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tblAll.Controls.Add(this.tblUpper, 0, 0);
			this.tblAll.Controls.Add(this.pnlResults, 0, 1);
			this.tblAll.Location = new System.Drawing.Point(9, 9);
			this.tblAll.Margin = new System.Windows.Forms.Padding(0);
			this.tblAll.Name = "tblAll";
			this.tblAll.RowCount = 2;
			this.tblAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.56731F));
			this.tblAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.43269F));
			this.tblAll.Size = new System.Drawing.Size(736, 463);
			this.tblAll.TabIndex = 0;
			// 
			// tblUpper
			// 
			this.tblUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tblUpper.ColumnCount = 2;
			this.tblUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.58394F));
			this.tblUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.41606F));
			this.tblUpper.Controls.Add(this.tblDetail, 1, 0);
			this.tblUpper.Controls.Add(this.pnlSearch, 0, 0);
			this.tblUpper.Location = new System.Drawing.Point(0, 0);
			this.tblUpper.Margin = new System.Windows.Forms.Padding(0);
			this.tblUpper.Name = "tblUpper";
			this.tblUpper.RowCount = 1;
			this.tblUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tblUpper.Size = new System.Drawing.Size(736, 252);
			this.tblUpper.TabIndex = 13;
			// 
			// tblDetail
			// 
			this.tblDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tblDetail.ColumnCount = 2;
			this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tblDetail.Controls.Add(this.pnlImage, 0, 0);
			this.tblDetail.Controls.Add(this.pnlPair, 1, 0);
			this.tblDetail.Location = new System.Drawing.Point(298, 0);
			this.tblDetail.Margin = new System.Windows.Forms.Padding(0);
			this.tblDetail.Name = "tblDetail";
			this.tblDetail.RowCount = 1;
			this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tblDetail.Size = new System.Drawing.Size(438, 252);
			this.tblDetail.TabIndex = 14;
			// 
			// pnlImage
			// 
			this.pnlImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlImage.Controls.Add(this.btnBrowse);
			this.pnlImage.Controls.Add(this.txtBrowse);
			this.pnlImage.Controls.Add(this.pBox);
			this.pnlImage.Location = new System.Drawing.Point(0, 0);
			this.pnlImage.Margin = new System.Windows.Forms.Padding(0);
			this.pnlImage.Name = "pnlImage";
			this.pnlImage.Size = new System.Drawing.Size(219, 252);
			this.pnlImage.TabIndex = 1;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBrowse.Location = new System.Drawing.Point(189, 4);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(27, 23);
			this.btnBrowse.TabIndex = 0;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtBrowse
			// 
			this.txtBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBrowse.Location = new System.Drawing.Point(0, 6);
			this.txtBrowse.Name = "txtBrowse";
			this.txtBrowse.ReadOnly = true;
			this.txtBrowse.Size = new System.Drawing.Size(183, 20);
			this.txtBrowse.TabIndex = 1;
			// 
			// pBox
			// 
			this.pBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pBox.Location = new System.Drawing.Point(0, 31);
			this.pBox.Name = "pBox";
			this.pBox.Size = new System.Drawing.Size(216, 218);
			this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pBox.TabIndex = 12;
			this.pBox.TabStop = false;
			// 
			// pnlPair
			// 
			this.pnlPair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlPair.Controls.Add(this.txtDetail);
			this.pnlPair.Location = new System.Drawing.Point(219, 0);
			this.pnlPair.Margin = new System.Windows.Forms.Padding(0);
			this.pnlPair.Name = "pnlPair";
			this.pnlPair.Size = new System.Drawing.Size(219, 252);
			this.pnlPair.TabIndex = 0;
			// 
			// txtDetail
			// 
			this.txtDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDetail.Location = new System.Drawing.Point(0, 4);
			this.txtDetail.Name = "txtDetail";
			this.txtDetail.Size = new System.Drawing.Size(219, 245);
			this.txtDetail.TabIndex = 0;
			this.txtDetail.Text = "";
			this.txtDetail.Leave += new System.EventHandler(this.txtDetail_Leave);
			// 
			// pnlSearch
			// 
			this.pnlSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.pnlSearch.Controls.Add(this.lblID);
			this.pnlSearch.Controls.Add(this.txtID);
			this.pnlSearch.Controls.Add(this.lblName);
			this.pnlSearch.Controls.Add(this.lblType);
			this.pnlSearch.Controls.Add(this.lblRegion);
			this.pnlSearch.Controls.Add(this.lblRind);
			this.pnlSearch.Controls.Add(this.lblTaste);
			this.pnlSearch.Controls.Add(this.lblPair);
			this.pnlSearch.Controls.Add(this.txtName);
			this.pnlSearch.Controls.Add(this.txtType);
			this.pnlSearch.Controls.Add(this.txtRegion);
			this.pnlSearch.Controls.Add(this.txtRind);
			this.pnlSearch.Controls.Add(this.txtTaste);
			this.pnlSearch.Controls.Add(this.txtPair);
			this.pnlSearch.Controls.Add(this.btnSearch);
			this.pnlSearch.Controls.Add(this.btnCommit);
			this.pnlSearch.Location = new System.Drawing.Point(0, 0);
			this.pnlSearch.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSearch.Name = "pnlSearch";
			this.pnlSearch.Size = new System.Drawing.Size(298, 252);
			this.pnlSearch.TabIndex = 0;
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.Location = new System.Drawing.Point(41, 6);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(33, 20);
			this.lblID.TabIndex = 24;
			this.lblID.Text = "ID:";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(80, 6);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(182, 20);
			this.txtID.TabIndex = 0;
			this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAny_KeyDown);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(14, 38);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(60, 20);
			this.lblName.TabIndex = 16;
			this.lblName.Text = "Name:";
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblType.Location = new System.Drawing.Point(22, 70);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(52, 20);
			this.lblType.TabIndex = 17;
			this.lblType.Text = "Type:";
			// 
			// lblRegion
			// 
			this.lblRegion.AutoSize = true;
			this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRegion.Location = new System.Drawing.Point(3, 102);
			this.lblRegion.Name = "lblRegion";
			this.lblRegion.Size = new System.Drawing.Size(71, 20);
			this.lblRegion.TabIndex = 19;
			this.lblRegion.Text = "Region:";
			// 
			// lblRind
			// 
			this.lblRind.AutoSize = true;
			this.lblRind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRind.Location = new System.Drawing.Point(23, 134);
			this.lblRind.Name = "lblRind";
			this.lblRind.Size = new System.Drawing.Size(51, 20);
			this.lblRind.TabIndex = 20;
			this.lblRind.Text = "Rind:";
			// 
			// lblTaste
			// 
			this.lblTaste.AutoSize = true;
			this.lblTaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTaste.Location = new System.Drawing.Point(15, 166);
			this.lblTaste.Name = "lblTaste";
			this.lblTaste.Size = new System.Drawing.Size(59, 20);
			this.lblTaste.TabIndex = 21;
			this.lblTaste.Text = "Taste:";
			// 
			// lblPair
			// 
			this.lblPair.AutoSize = true;
			this.lblPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPair.Location = new System.Drawing.Point(5, 198);
			this.lblPair.Name = "lblPair";
			this.lblPair.Size = new System.Drawing.Size(69, 20);
			this.lblPair.TabIndex = 22;
			this.lblPair.Text = "Pairing:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(80, 38);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(182, 20);
			this.txtName.TabIndex = 1;
			this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAny_KeyDown);
			// 
			// txtType
			// 
			this.txtType.Location = new System.Drawing.Point(80, 70);
			this.txtType.Name = "txtType";
			this.txtType.Size = new System.Drawing.Size(182, 20);
			this.txtType.TabIndex = 2;
			this.txtType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAny_KeyDown);
			// 
			// txtRegion
			// 
			this.txtRegion.Location = new System.Drawing.Point(80, 102);
			this.txtRegion.Name = "txtRegion";
			this.txtRegion.Size = new System.Drawing.Size(182, 20);
			this.txtRegion.TabIndex = 3;
			this.txtRegion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAny_KeyDown);
			// 
			// txtRind
			// 
			this.txtRind.Location = new System.Drawing.Point(80, 134);
			this.txtRind.Name = "txtRind";
			this.txtRind.Size = new System.Drawing.Size(182, 20);
			this.txtRind.TabIndex = 4;
			this.txtRind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAny_KeyDown);
			// 
			// txtTaste
			// 
			this.txtTaste.Location = new System.Drawing.Point(80, 166);
			this.txtTaste.Name = "txtTaste";
			this.txtTaste.Size = new System.Drawing.Size(182, 20);
			this.txtTaste.TabIndex = 5;
			this.txtTaste.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAny_KeyDown);
			// 
			// txtPair
			// 
			this.txtPair.Location = new System.Drawing.Point(80, 198);
			this.txtPair.Name = "txtPair";
			this.txtPair.Size = new System.Drawing.Size(182, 20);
			this.txtPair.TabIndex = 6;
			this.txtPair.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAny_KeyDown);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(0, 227);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 7;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnCommit
			// 
			this.btnCommit.Enabled = false;
			this.btnCommit.Location = new System.Drawing.Point(187, 227);
			this.btnCommit.Name = "btnCommit";
			this.btnCommit.Size = new System.Drawing.Size(75, 23);
			this.btnCommit.TabIndex = 8;
			this.btnCommit.Text = "Commit";
			this.btnCommit.UseVisualStyleBackColor = true;
			this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
			// 
			// pnlResults
			// 
			this.pnlResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlResults.Controls.Add(this.grdCheese);
			this.pnlResults.Location = new System.Drawing.Point(0, 252);
			this.pnlResults.Margin = new System.Windows.Forms.Padding(0);
			this.pnlResults.Name = "pnlResults";
			this.pnlResults.Size = new System.Drawing.Size(736, 211);
			this.pnlResults.TabIndex = 0;
			// 
			// grdCheese
			// 
			this.grdCheese.AllowUserToResizeRows = false;
			this.grdCheese.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdCheese.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.grdCheese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdCheese.Location = new System.Drawing.Point(0, 0);
			this.grdCheese.Margin = new System.Windows.Forms.Padding(0);
			this.grdCheese.Name = "grdCheese";
			this.grdCheese.Size = new System.Drawing.Size(736, 211);
			this.grdCheese.TabIndex = 0;
			this.grdCheese.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grdCheese_CellValidating);
			this.grdCheese.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdCheese_DataError);
			this.grdCheese.SelectionChanged += new System.EventHandler(this.grdCheese_SelectionChanged);
			this.grdCheese.Sorted += new System.EventHandler(this.grdCheese_Sorted);
			this.grdCheese.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdCheese_UserDeletedRow);
			this.grdCheese.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.grdCheese_UserDeletingRow);
			// 
			// opnImage
			// 
			this.opnImage.Filter = "Image Files (*.jpg *.jpeg *.png) | *.jpg; *.jpeg; *.png";
			this.opnImage.Title = "Select an Image";
			// 
			// frmCheese
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(754, 481);
			this.Controls.Add(this.tblAll);
			this.MinimumSize = new System.Drawing.Size(685, 520);
			this.Name = "frmCheese";
			this.Text = "SirCheese";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCheese_FormClosing);
			this.Load += new System.EventHandler(this.frmCheese_Load);
			this.tblAll.ResumeLayout(false);
			this.tblUpper.ResumeLayout(false);
			this.tblDetail.ResumeLayout(false);
			this.pnlImage.ResumeLayout(false);
			this.pnlImage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
			this.pnlPair.ResumeLayout(false);
			this.pnlSearch.ResumeLayout(false);
			this.pnlSearch.PerformLayout();
			this.pnlResults.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdCheese)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tblAll;
		private System.Windows.Forms.TableLayoutPanel tblUpper;
		private System.Windows.Forms.TableLayoutPanel tblDetail;
		private System.Windows.Forms.Panel pnlSearch;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.Label lblRegion;
		private System.Windows.Forms.Label lblRind;
		private System.Windows.Forms.Label lblTaste;
		private System.Windows.Forms.Label lblPair;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtType;
		private System.Windows.Forms.TextBox txtRegion;
		private System.Windows.Forms.TextBox txtRind;
		private System.Windows.Forms.TextBox txtTaste;
		private System.Windows.Forms.TextBox txtPair;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnCommit;
		private System.Windows.Forms.Panel pnlResults;
		private System.Windows.Forms.DataGridView grdCheese;
		private System.Windows.Forms.Panel pnlImage;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtBrowse;
		private System.Windows.Forms.PictureBox pBox;
		private System.Windows.Forms.Panel pnlPair;
		private System.Windows.Forms.RichTextBox txtDetail;
		private System.Windows.Forms.OpenFileDialog opnImage;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.TextBox txtID;
	}
}

