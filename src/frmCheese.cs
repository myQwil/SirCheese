using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SirCheese {
	public partial class frmCheese : Form {
		public frmCheese() {
			InitializeComponent();
		}

		string home = AppDomain.CurrentDomain.BaseDirectory;
		string db = "Data Source=McGuire.db";
		int row = -1;

		private bool canCommit() { return (grdCheese.Rows[row].Cells[0].Value != DBNull.Value); }

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
			Regex rgx = new Regex(@"[^\w\d\-,' ]");
			Dictionary<string, string> cond = new Dictionary<string, string>();
			List<TextBox> texts = new List<TextBox>()
			{ txtID, txtName, txtType, txtRegion, txtRind, txtTaste, txtPair };

			foreach (TextBox tb in texts)
				if (tb.Text != "") cond.Add(tb.Name.Substring(3), rgx.Replace(tb.Text, ""));

			foreach (var item in cond)
				sql += (item.Key == cond.First().Key ? " WHERE " : " AND ") +
						item.Key + "LIKE \"%" + item.Value + "%\"";

			using (SQLiteConnection conn = new SQLiteConnection(db)) 
			using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn))
			{	DataTable dt = new DataTable();
				da.Fill(dt);
				grdCheese.DataSource = dt;
				grdCheese.Columns[1].Visible = false;
				grdCheese.Columns[7].Visible = false;
				grdCheese.Columns[8].Visible = false;   }
			if (grdCheese.CurrentRow != null)
			{	row = grdCheese.CurrentRow.Index;
				btnCommit.Enabled = true;
				ShowDetail();   }
			else btnCommit.Enabled = false;
		}

		private void UpdateCheese() {
			string sql = "SELECT ID FROM Cheese WHERE ID = @old";
			using (SQLiteConnection conn = new SQLiteConnection(db))
			using (SQLiteCommand cmd = new SQLiteCommand(sql, conn)) {
				conn.Open();
				cmd.Parameters.AddWithValue("@old", grdCheese.Rows[row].Cells[1].Value);
				var val = cmd.ExecuteScalar();
				cmd.CommandText = (val != null) ?
					"UPDATE Cheese SET ID = @new, Name = @name, Type = @type, " +
					"Region = @region, Rind = @rind, Taste = @taste, " +
					"Image = @image, Pair = @pair WHERE ID = @old"
					
				  : "INSERT INTO Cheese VALUES " +
					"(@new, @name, @type, @region, @rind, @taste, @image, @pair)";

				cmd.Parameters.AddWithValue("@new", grdCheese.Rows[row].Cells[0].Value);
				cmd.Parameters.AddWithValue("@name", grdCheese.Rows[row].Cells[2].Value);
				cmd.Parameters.AddWithValue("@type", grdCheese.Rows[row].Cells[3].Value);
				cmd.Parameters.AddWithValue("@region", grdCheese.Rows[row].Cells[4].Value);
				cmd.Parameters.AddWithValue("@rind", grdCheese.Rows[row].Cells[5].Value);
				cmd.Parameters.AddWithValue("@taste", grdCheese.Rows[row].Cells[6].Value);
				cmd.Parameters.AddWithValue("@image", txtBrowse.Text);
				cmd.Parameters.AddWithValue("@pair", txtDetail.Text);
				cmd.ExecuteNonQuery();
			}
			grdCheese.Rows[row].Cells[7].Value = txtBrowse.Text;
			grdCheese.Rows[row].Cells[8].Value = txtDetail.Text;
		}

		private void DeleteCheese() {
			string sql = "DELETE FROM Cheese WHERE ID = @id";
			using (SQLiteConnection conn = new SQLiteConnection(db))
			using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
			{	conn.Open();
				cmd.Parameters.AddWithValue("@id", grdCheese.Rows[row].Cells[1].Value);
				cmd.ExecuteNonQuery();   }
		}

		private void ShowDetail() {
			string img = grdCheese.Rows[row].Cells[7].Value.ToString();
			string pair = grdCheese.Rows[row].Cells[8].Value.ToString();
			pbxDetail.ImageLocation = img;
			txtBrowse.Text = img;
			txtDetail.Text = pair;
		}

		private void ClearDetail() {
			pbxDetail.Image = null;
			txtBrowse.Text = null;
			txtDetail.Text = null;
		}

		private void btnCommit_Click(object sender, EventArgs e) {
			var confirm = MessageBox.Show
				("        Commit changes to this row?", "Confirm", MessageBoxButtons.OKCancel);
			if (confirm == DialogResult.OK) UpdateCheese();
		}

		private void btnBrowse_Click(object sender, EventArgs e) {
			if (grdCheese.CurrentCell != null)
			{	int i = txtBrowse.Text.IndexOf('/');
				if (i>0) opnImage.InitialDirectory = home + txtBrowse.Text.Substring(0, i)+"\\";
				if (opnImage.ShowDialog() == DialogResult.OK)
				{	string img = Regex.Replace(opnImage.FileName.Replace("\\", "/"),
						home.Replace("\\", "/"), "", RegexOptions.IgnoreCase);
					txtBrowse.Text = img;
					pbxDetail.ImageLocation = img;   }   }
		}

		private void grdCheese_SelectionChanged(object sender, EventArgs e) {
			if (grdCheese.CurrentRow != null && row != grdCheese.CurrentRow.Index)
			{	row = grdCheese.CurrentRow.Index;
				btnCommit.Enabled = canCommit();
				ShowDetail();   }
		}

		private void grdCheese_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
			grdCheese.ClearSelection();
		}

		private void grdCheese_DataError(object sender, DataGridViewDataErrorEventArgs e) {
			grdCheese.CancelEdit();
		}

		private void grdCheese_Sorted(object sender, EventArgs e) {
			row = grdCheese.CurrentRow.Index;
			if (row != grdCheese.NewRowIndex) ShowDetail();
		}

		private void grdCheese_UserDeletedRow(object sender, DataGridViewRowEventArgs e) {
			row = grdCheese.CurrentRow.Index;
			if (row != grdCheese.NewRowIndex) ShowDetail();
		}

		private void grdCheese_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) {
			if (grdCheese.Rows[e.RowIndex].IsNewRow) { return; }
			if (e.ColumnIndex == 0) {
				if (Regex.IsMatch((string)e.FormattedValue, @"^\d+$"))
				{	string sql = "SELECT ID FROM Cheese WHERE ID = @id";
					using (SQLiteConnection conn = new SQLiteConnection(db))
					using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
					{	conn.Open();
						cmd.Parameters.AddWithValue("@id", e.FormattedValue);
						var val = cmd.ExecuteScalar();
						if (val != null)
						{	if (grdCheese.Rows[e.RowIndex].Cells[1].Value == DBNull.Value
							 || (long)val != (long)grdCheese.Rows[e.RowIndex].Cells[1].Value)
								grdCheese.CancelEdit();
							else btnCommit.Enabled = true;   }
						else btnCommit.Enabled = true;   }   }
				else if ((string)e.FormattedValue == "") btnCommit.Enabled = false;
			}
		}

		private void grdCheese_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
			var confirm = MessageBox.Show
				("	Delete this entry?", "Confirm", MessageBoxButtons.OKCancel);
			if (confirm == DialogResult.OK) DeleteCheese();
			else e.Cancel = true;
		}
	}
}
