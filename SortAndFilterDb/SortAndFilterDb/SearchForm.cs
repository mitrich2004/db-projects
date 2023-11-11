using System;
using System.Windows.Forms;

namespace SortAndFilterDb
{
	public partial class SearchForm : Form
	{
		public SearchForm()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			Form1 main = this.Owner as Form1;
			if (main != null)
			{
				for (int i = 0; i < main.dataGridView1.RowCount; i++)
				{
					main.dataGridView1.Rows[i].Selected = false;
					for (int j = 0; j < main.dataGridView1.ColumnCount; j++)
					{
						if (main.dataGridView1.Rows[i].Cells[j].Value != null)
						{
							if (main.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(tbSearch.Text))
							{
								main.dataGridView1.Rows[i].Selected = true;
								break;
							}
						}
					}
				}
			}
			Close();
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
