using SirCheese.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace SirCheese {
	public partial class frmCheese : Form {
		public frmCheese() {
			InitializeComponent();
			Thread.Sleep(2000);
		}

		string home = AppDomain.CurrentDomain.BaseDirectory;
		string db = "Data Source=McGuire.db";
		int row;

		private void btnSearch_Click(object sender, EventArgs e) {
			SearchCheese();
		}

		private void txtAny_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter)
			{	e.SuppressKeyPress = true;
				SearchCheese();   }
		}

		private void SearchCheese() {
			ClearDetail();
			string sql = "SELECT ID, Cheese.* FROM Cheese";
			Regex rgx = new Regex(@"[^\w\d\-()!&$,' ]");
			Dictionary<string, string> cond = new Dictionary<string, string>();
			List<TextBox> texts = new List<TextBox>()
			{ txtID, txtName, txtType, txtRegion, txtRind, txtTaste, txtPair };

			foreach (TextBox tb in texts)
				if (tb.Text != "") cond.Add(tb.Name.Substring(3), rgx.Replace(tb.Text, ""));

			foreach (var item in cond)
				sql += (item.Key == cond.First().Key ? " WHERE " : " AND ") +
						item.Key + " LIKE \"%" + item.Value + "%\"";

			using (SQLiteConnection conn = new SQLiteConnection(db)) 
			using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn))
			{	DataTable dt = new DataTable();
				da.Fill(dt);
				grdCheese.SelectionChanged -= grdCheese_SelectionChanged;
				grdCheese.CellValidating -= grdCheese_CellValidating;
				grdCheese.DataSource = dt;
				grdCheese.ClearSelection();
				grdCheese.SelectionChanged += grdCheese_SelectionChanged;
				grdCheese.CellValidating += grdCheese_CellValidating;
				grdCheese.Columns[1].Visible = false;
				grdCheese.Columns[7].Visible = false;
				grdCheese.Columns[8].Visible = false;   }
			row = 0;
			if (grdCheese.CurrentRow != null)
			{	btnCommit.Enabled = true;
				ShowDetail();   }
			else btnCommit.Enabled = false;
		}

		private void UpdateCheese() {
			string sql = "SELECT ID FROM Cheese WHERE ID = @old";
			using (SQLiteConnection conn = new SQLiteConnection(db))
			using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
			{	conn.Open();
				cmd.Parameters.AddWithValue("@old", grdCheese.CurrentRow.Cells[1].Value);
				var val = cmd.ExecuteScalar();
				cmd.CommandText = (val != null) ?
					"UPDATE Cheese SET ID = @new, Name = @name, Type = @type, " +
					"Region = @region, Rind = @rind, Taste = @taste, " +
					"Image = @image, Pair = @pair WHERE ID = @old"
					
				  : "INSERT INTO Cheese VALUES " +
					"(@new, @name, @type, @region, @rind, @taste, @image, @pair)";

				cmd.Parameters.AddWithValue("@new", grdCheese.CurrentRow.Cells[0].Value);
				cmd.Parameters.AddWithValue("@name", grdCheese.CurrentRow.Cells[2].Value);
				cmd.Parameters.AddWithValue("@type", grdCheese.CurrentRow.Cells[3].Value);
				cmd.Parameters.AddWithValue("@region", grdCheese.CurrentRow.Cells[4].Value);
				cmd.Parameters.AddWithValue("@rind", grdCheese.CurrentRow.Cells[5].Value);
				cmd.Parameters.AddWithValue("@taste", grdCheese.CurrentRow.Cells[6].Value);
				cmd.Parameters.AddWithValue("@image", txtBrowse.Text);
				cmd.Parameters.AddWithValue("@pair", txtDetail.Text);
				cmd.ExecuteNonQuery();   }
			grdCheese.CurrentRow.Cells[1].Value = grdCheese.CurrentRow.Cells[0].Value;
			grdCheese.CurrentRow.Cells[7].Value = txtBrowse.Text;
			grdCheese.CurrentRow.Cells[8].Value = txtDetail.Text;
		}

		private void DeleteCheese() {
			string sql = "DELETE FROM Cheese WHERE ID = @id";
			using (SQLiteConnection conn = new SQLiteConnection(db))
			using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
			{	conn.Open();
				cmd.Parameters.AddWithValue("@id", grdCheese.CurrentRow.Cells[1].Value);
				cmd.ExecuteNonQuery();   }
		}

		private void ShowDetail() {
			string img = grdCheese.CurrentRow.Cells[7].Value.ToString();
			string pair = grdCheese.CurrentRow.Cells[8].Value.ToString();
			ChangeImage(img);
			txtBrowse.Text = img;
			txtDetail.Text = pair;
		}

		private void ClearDetail() {
			ChangeImage("");
			txtBrowse.Text = null;
			txtDetail.Text = null;
		}

		private void ChangeImage(string img) {
			if (pBox.Image != null) pBox.Image.Dispose();
			pBox.Image = (img != "") ? Image.FromFile(img) : null;
		}

		private void btnBrowse_Click(object sender, EventArgs e) {
			if (grdCheese.RowCount > 0)
			{	int i = txtBrowse.Text.IndexOf('/');
				if (i>0) opnImage.InitialDirectory = home + txtBrowse.Text.Substring(0, i)+"\\";
				if (opnImage.ShowDialog() == DialogResult.OK)
				{	string img = Regex.Replace(opnImage.FileName.Replace("\\", "/"),
						home.Replace("\\", "/"), "", RegexOptions.IgnoreCase);
					txtBrowse.Text = img;
					grdCheese.Rows[(grdCheese.CurrentRow != null ? row : 0)]
						.Cells[7].Value = img;
					ChangeImage(img);   }   }
		}

		private void btnCommit_Click(object sender, EventArgs e) {
			var confirm = MessageBox.Show
				("        Commit changes to this row?", "Confirm", MessageBoxButtons.OKCancel);
			if (confirm == DialogResult.OK) UpdateCheese();
		}

		private void grdCheese_SelectionChanged(object sender, EventArgs e) {
			if (grdCheese.CurrentRow != null && row != grdCheese.CurrentRow.Index)
			{	row = grdCheese.CurrentRow.Index;
				btnCommit.Enabled = (grdCheese.CurrentRow.Cells[0].Value != DBNull.Value);
				ShowDetail();   }
		}

		private void grdCheese_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
			var confirm = MessageBox.Show
				("	Delete this entry?", "Confirm", MessageBoxButtons.OKCancel);
			if (confirm == DialogResult.OK) DeleteCheese();
			else e.Cancel = true;
		}

		private void grdCheese_UserDeletedRow(object sender, DataGridViewRowEventArgs e) {
			if (grdCheese.CurrentRow.Index != grdCheese.NewRowIndex) ShowDetail();
		}

		private void grdCheese_Sorted(object sender, EventArgs e) {
			if (grdCheese.CurrentRow.Index != grdCheese.NewRowIndex) ShowDetail();
		}

		private void grdCheese_DataError(object sender, DataGridViewDataErrorEventArgs e) {
			grdCheese.CancelEdit();
		}

		private void grdCheese_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) {
			if (grdCheese.CurrentRow.IsNewRow || grdCheese.SelectedCells.Count==0) { return; }
			if (e.ColumnIndex == 0)
			{	if (Regex.IsMatch((string)e.FormattedValue, @"^\d+$"))
				{	string sql = "SELECT ID FROM Cheese WHERE ID = @id";
					using (SQLiteConnection conn = new SQLiteConnection(db))
					using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
					{	conn.Open();
						cmd.Parameters.AddWithValue("@id", e.FormattedValue);
						var val = cmd.ExecuteScalar();
						if (val != null)
						{	if (grdCheese.CurrentRow.Cells[1].Value == DBNull.Value
							 || (long)val != (long)grdCheese.CurrentRow.Cells[1].Value)
								grdCheese.CancelEdit();
							else btnCommit.Enabled = true;   }
						else btnCommit.Enabled = true;   }   }
				else if ((string)e.FormattedValue == "") btnCommit.Enabled = false;   }
		}

		private void txtDetail_Leave(object sender, EventArgs e) {
			if (grdCheese.RowCount > 0)
				grdCheese.Rows[(grdCheese.CurrentRow != null ? row : 0)]
					.Cells[8].Value = txtDetail.Text;
		}

		private void frmCheese_Load(object sender, EventArgs e) {
			if (Settings.Default.WindowLocation != null)
				this.Location = Settings.Default.WindowLocation;
		}

		private void frmCheese_FormClosing(object sender, FormClosingEventArgs e) {
			Settings.Default.WindowLocation = this.Location;
			Settings.Default.Save();
		}

	} // class
} // namespace
