namespace ReportsDb
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet2 = new ReportsDb.DataSet2();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.продукцияBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.продукцияTableAdapter = new ReportsDb.DataSet2TableAdapters.продукцияTableAdapter();
			this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataTable1TableAdapter = new ReportsDb.DataSet2TableAdapters.DataTable1TableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.продукцияBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// OrderBindingSource
			// 
			this.OrderBindingSource.DataMember = "Order";
			this.OrderBindingSource.DataSource = this.dataSet2;
			// 
			// dataSet2
			// 
			this.dataSet2.DataSetName = "DataSet2";
			this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.dataTable1BindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsDb.Report1.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(12, 12);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(776, 426);
			this.reportViewer1.TabIndex = 0;
			// 
			// продукцияBindingSource
			// 
			this.продукцияBindingSource.DataMember = "продукция";
			this.продукцияBindingSource.DataSource = this.dataSet2;
			// 
			// продукцияTableAdapter
			// 
			this.продукцияTableAdapter.ClearBeforeFill = true;
			// 
			// dataTable1BindingSource
			// 
			this.dataTable1BindingSource.DataMember = "DataTable1";
			this.dataTable1BindingSource.DataSource = this.dataSet2;
			// 
			// dataTable1TableAdapter
			// 
			this.dataTable1TableAdapter.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.reportViewer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.продукцияBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private DataSet2 dataSet2;
		private System.Windows.Forms.BindingSource продукцияBindingSource;
		private DataSet2TableAdapters.продукцияTableAdapter продукцияTableAdapter;
		private System.Windows.Forms.BindingSource OrderBindingSource;
		private System.Windows.Forms.BindingSource dataTable1BindingSource;
	}
}

