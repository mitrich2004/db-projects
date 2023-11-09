using System;
using System.Data;
using System.Windows.Forms;

namespace CRUD_DB
{
	public partial class Update_entry : Form
	{
		public Update_entry()
		{
			InitializeComponent();
			close_button.Click += close_button_click;
			update_button.Click += update_button_click;
			Shown += new EventHandler(Show);
		}

		private void tbSurname_TextChanged(object sender, EventArgs e)
		{

		}

		private void Show(object sender, EventArgs e)
		{
			Form1 main = this.Owner as Form1;

			if (main != null)
			{
				DataGridViewRow rowView = main.dataGridView1.SelectedRows[0];
				DataRow row = ((DataRowView)rowView.DataBoundItem).Row;

				string surname = row.Field<string>(1);
				string name = row.Field<string>(2);
				string father = row.Field<string>(3);
				string address = row.Field<string>(4);
				int phone = row.Field<int>(5);

				tbSurname.Text = surname;
				tbName.Text = name;
				tbFather.Text = father;
				tbAddress.Text = address;
				tbPhone.Text = phone.ToString();
			}
		}

		private void update_button_click(object sender, EventArgs e)
		{
			Form1 main = this.Owner as Form1;
			if (main != null)
			{ 

				DataGridViewRow rowView = main.dataGridView1.SelectedRows[0];
				DataRow row = ((DataRowView)rowView.DataBoundItem).Row;

				row[1] = tbSurname.Text;
				row[2] = tbName.Text;
				row[3] = tbFather.Text;
				row[4] = tbAddress.Text;
				row[5] = tbPhone.Text;

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
	}
}
