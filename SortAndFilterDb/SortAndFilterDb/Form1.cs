using System;
using System.Data;
using System.Windows.Forms;

namespace SortAndFilterDb
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			searchButton.Click += searchButton_Click;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'dataSet1.заказчик' table. You can move, or remove it, as needed.
            this.заказчикTableAdapter.Fill(this.dataSet1.заказчик);

        }

		private void searchButton_Click(object sender, EventArgs e)
		{
			AddOwnedForm(new SearchForm());
			OwnedForms[0].Show();
		}

		private void AdvancedSearchButton_Click(object sender, EventArgs e)
		{
			AddOwnedForm(new AdvancedSearchForm());
			OwnedForms[0].Show();
		}

		private void filterButton_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedCells.Count > 0)
			{
				AddOwnedForm(new FilterForm());
				OwnedForms[0].Show();
			}
		}

		private void dropFilterButton_Click(object sender, EventArgs e)
		{
			DataView myDataView = new DataView(dataSet1.заказчик);
			dataGridView1.DataSource = myDataView;
		}

		private void sortButton_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedCells.Count > 0)
			{
				string sortingProperty = dataGridView1.Columns[dataGridView1.SelectedCells[0].ColumnIndex].HeaderText;
				DataView myDataView = new DataView(dataSet1.заказчик);
				myDataView.Sort = sortingProperty;
				dataGridView1.DataSource = myDataView;
			}
		}
	}
}
