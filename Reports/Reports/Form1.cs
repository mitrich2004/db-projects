using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			ToolStripMenuItem fileItem = new ToolStripMenuItem("Файл");

			fileItem.DropDownItems.Add("Создать");
			fileItem.DropDownItems.Add(new ToolStripMenuItem("Сохранить"));

			menuStrip1.Items.Add(fileItem);

			ToolStripMenuItem aboutItem = new ToolStripMenuItem("О программе");
			aboutItem.Click += aboutItem_Click;
			menuStrip1.Items.Add(aboutItem);

		}

		private void Form1_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);
            // TODO: This line of code loads data into the 'dataSet1.продукция' table. You can move, or remove it, as needed.
            this.продукцияTableAdapter.Fill(this.dataSet1.продукция);

            this.reportViewer1.RefreshReport();
        }

		private void reportViewer1_Load(object sender, EventArgs e)
		{

		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		void aboutItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("О программе");
		}

	}
}
