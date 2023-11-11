using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAndFilterDb
{
	public partial class AdvancedSearchForm : Form
	{
		public AdvancedSearchForm()
		{
			InitializeComponent();
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			Form1 main = this.Owner as Form1;
			if (main != null)
			{
				for (int i = 0; i < main.dataGridView1.RowCount; i++)
				{
					DataGridViewRow row = main.dataGridView1.Rows[i];
					row.Selected = false;
					bool match = true;

					List<TextBox> inputs = new List<TextBox> { tbSurname, tbName, tbFather, tbAddress, tbPhone };

					for (int j = 1; j < main.dataGridView1.ColumnCount; j++)
					{
						if (row.Cells[j].Value != null)
						{
							if (inputs[j - 1].Text != null && !row.Cells[j].Value.ToString().Contains(inputs[j - 1].Text))
							{
								match = false;	
								break;
							}
						}
					}

					if (match)
					{
						main.dataGridView1.Rows[i].Selected = true;
						break;
					}
				}
			}
			Close();
		}
	}
}
