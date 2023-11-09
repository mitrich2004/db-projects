namespace CRUD_DB
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idЗаказчикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.заказчикBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.testDataSet = new CRUD_DB.testDataSet();
			this.заказчикTableAdapter = new CRUD_DB.testDataSetTableAdapters.заказчикTableAdapter();
			this.add_button = new System.Windows.Forms.Button();
			this.delete_button = new System.Windows.Forms.Button();
			this.update_button = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.заказчикBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idЗаказчикDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.заказчикBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(647, 197);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// idЗаказчикDataGridViewTextBoxColumn
			// 
			this.idЗаказчикDataGridViewTextBoxColumn.DataPropertyName = "idЗаказчик";
			this.idЗаказчикDataGridViewTextBoxColumn.HeaderText = "idЗаказчик";
			this.idЗаказчикDataGridViewTextBoxColumn.Name = "idЗаказчикDataGridViewTextBoxColumn";
			// 
			// фамилияDataGridViewTextBoxColumn
			// 
			this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
			this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
			this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
			// 
			// имяDataGridViewTextBoxColumn
			// 
			this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
			this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
			this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
			// 
			// отчествоDataGridViewTextBoxColumn
			// 
			this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
			this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
			this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
			// 
			// адресDataGridViewTextBoxColumn
			// 
			this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
			this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
			this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
			// 
			// телефонDataGridViewTextBoxColumn
			// 
			this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
			this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
			this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
			// 
			// заказчикBindingSource
			// 
			this.заказчикBindingSource.DataMember = "заказчик";
			this.заказчикBindingSource.DataSource = this.testDataSet;
			// 
			// testDataSet
			// 
			this.testDataSet.DataSetName = "testDataSet";
			this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// заказчикTableAdapter
			// 
			this.заказчикTableAdapter.ClearBeforeFill = true;
			// 
			// add_button
			// 
			this.add_button.Location = new System.Drawing.Point(12, 226);
			this.add_button.Name = "add_button";
			this.add_button.Size = new System.Drawing.Size(75, 23);
			this.add_button.TabIndex = 1;
			this.add_button.Text = "Добавить";
			this.add_button.UseVisualStyleBackColor = true;
			// 
			// delete_button
			// 
			this.delete_button.Location = new System.Drawing.Point(583, 226);
			this.delete_button.Name = "delete_button";
			this.delete_button.Size = new System.Drawing.Size(75, 23);
			this.delete_button.TabIndex = 2;
			this.delete_button.Text = "Удалить";
			this.delete_button.UseVisualStyleBackColor = true;
			// 
			// update_button
			// 
			this.update_button.Location = new System.Drawing.Point(302, 226);
			this.update_button.Name = "update_button";
			this.update_button.Size = new System.Drawing.Size(75, 23);
			this.update_button.TabIndex = 3;
			this.update_button.Text = "Изменить";
			this.update_button.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(671, 261);
			this.Controls.Add(this.update_button);
			this.Controls.Add(this.delete_button);
			this.Controls.Add(this.add_button);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.заказчикBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.DataGridView dataGridView1;
		internal testDataSet testDataSet;
		private System.Windows.Forms.BindingSource заказчикBindingSource;
		internal testDataSetTableAdapters.заказчикTableAdapter заказчикTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idЗаказчикDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button add_button;
		private System.Windows.Forms.Button delete_button;
		private System.Windows.Forms.Button update_button;
	}
}

