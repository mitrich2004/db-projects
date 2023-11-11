using System;
using System.Data;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SortAndFilterDb
{
	public partial class FilterForm : Form
	{
		private string filterProperty = "";

		public FilterForm()
		{
			InitializeComponent();
			Shown += new EventHandler(Show);
		}

		private void Show(object sender, EventArgs e)
		{
			Form1 main = this.Owner as Form1;

			if (main != null)
			{
				filterProperty = main.dataGridView1.Columns[main.dataGridView1.SelectedCells[0].ColumnIndex].HeaderText;
				propertyLabel.Text = filterProperty + ":";
			}
		}

		private void FilterForm_Load(object sender, EventArgs e)
		{

		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void filterButton_Click(object sender, EventArgs e)
		{
			Form1 main = this.Owner as Form1;
			DataView myDataView = new DataView(main.dataSet1.заказчик);
			myDataView.RowFilter = $"{filterProperty} = '{tbFilter.Text}'"; 
			main.dataGridView1.DataSource = myDataView;
			Close();
		}
	}
}
