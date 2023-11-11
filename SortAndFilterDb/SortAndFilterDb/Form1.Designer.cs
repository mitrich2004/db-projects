namespace SortAndFilterDb
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
			this.dataSet1 = new SortAndFilterDb.DataSet1();
			this.заказчикTableAdapter = new SortAndFilterDb.DataSet1TableAdapters.заказчикTableAdapter();
			this.searchButton = new System.Windows.Forms.Button();
			this.advancedSearchButton = new System.Windows.Forms.Button();
			this.filterButton = new System.Windows.Forms.Button();
			this.dropFilterButton = new System.Windows.Forms.Button();
			this.sortButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.заказчикBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
			this.dataGridView1.Size = new System.Drawing.Size(647, 220);
			this.dataGridView1.TabIndex = 0;
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
			this.заказчикBindingSource.DataSource = this.dataSet1;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// заказчикTableAdapter
			// 
			this.заказчикTableAdapter.ClearBeforeFill = true;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(36, 252);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 1;
			this.searchButton.Text = "Поиск";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// advancedSearchButton
			// 
			this.advancedSearchButton.Location = new System.Drawing.Point(148, 254);
			this.advancedSearchButton.Name = "advancedSearchButton";
			this.advancedSearchButton.Size = new System.Drawing.Size(120, 23);
			this.advancedSearchButton.TabIndex = 2;
			this.advancedSearchButton.Text = "Расширенный поиск";
			this.advancedSearchButton.UseVisualStyleBackColor = true;
			this.advancedSearchButton.Click += new System.EventHandler(this.AdvancedSearchButton_Click);
			// 
			// filterButton
			// 
			this.filterButton.Location = new System.Drawing.Point(312, 254);
			this.filterButton.Name = "filterButton";
			this.filterButton.Size = new System.Drawing.Size(75, 23);
			this.filterButton.TabIndex = 3;
			this.filterButton.Text = "Фильтр";
			this.filterButton.UseVisualStyleBackColor = true;
			this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
			// 
			// dropFilterButton
			// 
			this.dropFilterButton.Location = new System.Drawing.Point(556, 254);
			this.dropFilterButton.Name = "dropFilterButton";
			this.dropFilterButton.Size = new System.Drawing.Size(75, 23);
			this.dropFilterButton.TabIndex = 4;
			this.dropFilterButton.Text = "Сбросить";
			this.dropFilterButton.UseVisualStyleBackColor = true;
			this.dropFilterButton.Click += new System.EventHandler(this.dropFilterButton_Click);
			// 
			// sortButton
			// 
			this.sortButton.Location = new System.Drawing.Point(432, 254);
			this.sortButton.Name = "sortButton";
			this.sortButton.Size = new System.Drawing.Size(83, 23);
			this.sortButton.TabIndex = 5;
			this.sortButton.Text = "Сортировать";
			this.sortButton.UseVisualStyleBackColor = true;
			this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 289);
			this.Controls.Add(this.sortButton);
			this.Controls.Add(this.dropFilterButton);
			this.Controls.Add(this.filterButton);
			this.Controls.Add(this.advancedSearchButton);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Заказчики";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.заказчикBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.DataGridView dataGridView1;
		internal DataSet1 dataSet1;
		private System.Windows.Forms.BindingSource заказчикBindingSource;
		private DataSet1TableAdapters.заказчикTableAdapter заказчикTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idЗаказчикDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Button advancedSearchButton;
		private System.Windows.Forms.Button filterButton;
		private System.Windows.Forms.Button dropFilterButton;
		private System.Windows.Forms.Button sortButton;
	}
}

