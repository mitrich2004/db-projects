namespace Reports
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.продукцияBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet1 = new Reports.DataSet1();
			this.продукцияTableAdapter = new Reports.DataSet1TableAdapters.продукцияTableAdapter();
			this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.dataTable1TableAdapter = new Reports.DataSet1TableAdapters.DataTable1TableAdapter();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			((System.ComponentModel.ISupportInitialize)(this.продукцияBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			reportDataSource2.Name = "DataSet1";
			reportDataSource2.Value = this.dataTable1BindingSource1;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reports.Report2.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(12, 27);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(776, 411);
			this.reportViewer1.TabIndex = 0;
			this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
			// 
			// продукцияBindingSource
			// 
			this.продукцияBindingSource.DataMember = "продукция";
			this.продукцияBindingSource.DataSource = this.dataSet1;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// продукцияTableAdapter
			// 
			this.продукцияTableAdapter.ClearBeforeFill = true;
			// 
			// DataTable1BindingSource
			// 
			this.DataTable1BindingSource.DataMember = "DataTable1";
			this.DataTable1BindingSource.DataSource = this.dataSet1;
			// 
			// dataTable1BindingSource1
			// 
			this.dataTable1BindingSource1.DataMember = "DataTable1";
			this.dataTable1BindingSource1.DataSource = this.dataSet1;
			// 
			// dataTable1TableAdapter
			// 
			this.dataTable1TableAdapter.ClearBeforeFill = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.reportViewer1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.продукцияBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private DataSet1 dataSet1;
		private System.Windows.Forms.BindingSource продукцияBindingSource;
		private DataSet1TableAdapters.продукцияTableAdapter продукцияTableAdapter;
		private System.Windows.Forms.BindingSource DataTable1BindingSource;
		private System.Windows.Forms.BindingSource dataTable1BindingSource1;
		private DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}

