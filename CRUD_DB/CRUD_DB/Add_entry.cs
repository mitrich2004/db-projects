using System;
using System.Data;
using System.Windows.Forms;

namespace CRUD_DB
{
	public partial class Add_entry : Form
	{
		public Add_entry()
		{
			InitializeComponent();
			add_button.Click += new EventHandler(this.add_button_click);
			close_button.Click += new EventHandler(this.close_button_click);
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
		private void add_button_click(object sender, EventArgs e)
		{
			Form1 main = this.Owner as Form1;
			if (main != null)
			{
				int numberOfRows = main.testDataSet.Tables[0].Rows.Count;
				int rc;

				if (numberOfRows == 0)
				{
					rc = 1;
				}
				else
				{
					DataRow lastRow = main.testDataSet.Tables[0].Rows[numberOfRows - 1];
					rc = lastRow.Field<int>(0) + 1;
				}

				DataRow nRow = main.testDataSet.Tables[0].NewRow();
				nRow[0] = rc;
				nRow[1] = tbSurname.Text;
				nRow[2] = tbName.Text;
				nRow[3] = tbFather.Text;
				nRow[4] = tbAddress.Text;
				nRow[5] = tbPhone.Text;

				main.testDataSet.Tables[0].Rows.Add(nRow);
				main.заказчикTableAdapter.Update(main.testDataSet.заказчик);
				main.testDataSet.Tables[0].AcceptChanges();
				main.dataGridView1.Refresh();
				
				tbSurname.Text = "";
				tbName.Text = "";
				tbFather.Text = "";
				tbAddress.Text = "";
				tbPhone.Text = "";
				this.Close();
			}
		}

		private void close_button_click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void Add_entry_Load(object sender, EventArgs e)
		{

		}
	}
}
