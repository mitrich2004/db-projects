using System;
using System.Windows.Forms;

namespace CRUD_DB
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			add_button.Click += add_button_click;
			delete_button.Click += delete_button_click;
			update_button.Click += update_button_click;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'testDataSet.заказчик' table. You can move, or remove it, as needed.
            this.заказчикTableAdapter.Fill(this.testDataSet.заказчик);

        }

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void add_button_click(object sender, EventArgs e)
		{
			var ownedAddForm = new Add_entry();
			this.AddOwnedForm(ownedAddForm);
			OwnedForms[0].Show();
		}
		
		private void delete_button_click(object sender, EventArgs e)
		{
			if (this.dataGridView1.SelectedRows.Count > 0)
			{
				var ownedDeleteForm = new Delete_entry();
				this.AddOwnedForm(ownedDeleteForm);
				OwnedForms[0].Show();
			}
		}

		private void update_button_click(object sender, EventArgs e)
		{
			if (this.dataGridView1.SelectedRows.Count > 0)
			{
				var ownedUpdateForm = new Update_entry();
				this.AddOwnedForm(ownedUpdateForm);
				OwnedForms[0].Show();
			}
		}
	}
}
