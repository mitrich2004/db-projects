namespace SortAndFilterDb
{
	partial class FilterForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.propertyLabel = new System.Windows.Forms.Label();
			this.tbFilter = new System.Windows.Forms.TextBox();
			this.filterButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbFilter);
			this.groupBox1.Controls.Add(this.propertyLabel);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(344, 65);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Фильтр";
			// 
			// propertyLabel
			// 
			this.propertyLabel.AutoSize = true;
			this.propertyLabel.Location = new System.Drawing.Point(7, 30);
			this.propertyLabel.Name = "propertyLabel";
			this.propertyLabel.Size = new System.Drawing.Size(59, 13);
			this.propertyLabel.TabIndex = 0;
			this.propertyLabel.Text = "Фамилия:";
			// 
			// tbFilter
			// 
			this.tbFilter.Location = new System.Drawing.Point(72, 27);
			this.tbFilter.Name = "tbFilter";
			this.tbFilter.Size = new System.Drawing.Size(265, 20);
			this.tbFilter.TabIndex = 1;
			// 
			// filterButton
			// 
			this.filterButton.Location = new System.Drawing.Point(64, 88);
			this.filterButton.Name = "filterButton";
			this.filterButton.Size = new System.Drawing.Size(75, 23);
			this.filterButton.TabIndex = 1;
			this.filterButton.Text = "Показать";
			this.filterButton.UseVisualStyleBackColor = true;
			this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(204, 87);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 2;
			this.closeButton.Text = "Закрыть";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// FilterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 123);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.filterButton);
			this.Controls.Add(this.groupBox1);
			this.Name = "FilterForm";
			this.Text = "Фильтр";
			this.Load += new System.EventHandler(this.FilterForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbFilter;
		private System.Windows.Forms.Label propertyLabel;
		private System.Windows.Forms.Button filterButton;
		private System.Windows.Forms.Button closeButton;
	}
}