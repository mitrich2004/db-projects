using System;
using System.Data;
using System.Windows.Forms;

namespace CRUD_DB
{
	public partial class Delete_entry : Form
	{
		public Delete_entry()
		{
			InitializeComponent();
			delete_button.Click += delete_button_Click;
			cancel_button.Click += cancel_button_Click;
		}

		private void delete_button_Click(object sender, EventArgs e)
		{
			Form1 main = this.Owner as Form1;
			if (main != null)
			{
				foreach (DataGridViewRow rowView in main.dataGridView1.SelectedRows)
				{
					DataRow row = ((DataRowView)rowView.DataBoundItem).Row;
					row.Delete();
				}

				main.заказчикTableAdapter.Update(main.testDataSet.заказчик);
				main.testDataSet.Tables[0].AcceptChanges();
				main.dataGridView1.Refresh();

				this.Close();
			}
		}

		private void cancel_button_Click(object sender, EventArgs e)
		{ 
			this.Close();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
