namespace Minecraft
{
	partial class ShopHistoryForm
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
			this.labelStartTime = new System.Windows.Forms.Label();
			this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
			this.labelEndTime = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.listBoxShopHistory = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// labelStartTime
			// 
			this.labelStartTime.AutoSize = true;
			this.labelStartTime.Location = new System.Drawing.Point(39, 38);
			this.labelStartTime.Name = "labelStartTime";
			this.labelStartTime.Size = new System.Drawing.Size(72, 16);
			this.labelStartTime.TabIndex = 0;
			this.labelStartTime.Text = "起始时间";
			// 
			// dateTimePickerStartTime
			// 
			this.dateTimePickerStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dateTimePickerStartTime.Location = new System.Drawing.Point(117, 31);
			this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
			this.dateTimePickerStartTime.Size = new System.Drawing.Size(200, 26);
			this.dateTimePickerStartTime.TabIndex = 1;
			// 
			// dateTimePickerEndTime
			// 
			this.dateTimePickerEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dateTimePickerEndTime.Location = new System.Drawing.Point(419, 31);
			this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
			this.dateTimePickerEndTime.Size = new System.Drawing.Size(200, 26);
			this.dateTimePickerEndTime.TabIndex = 3;
			// 
			// labelEndTime
			// 
			this.labelEndTime.AutoSize = true;
			this.labelEndTime.Location = new System.Drawing.Point(341, 38);
			this.labelEndTime.Name = "labelEndTime";
			this.labelEndTime.Size = new System.Drawing.Size(72, 16);
			this.labelEndTime.TabIndex = 2;
			this.labelEndTime.Text = "结束时间";
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(648, 31);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(86, 26);
			this.buttonSearch.TabIndex = 4;
			this.buttonSearch.Text = "查询";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
			// 
			// listBoxShopHistory
			// 
			this.listBoxShopHistory.FormattingEnabled = true;
			this.listBoxShopHistory.ItemHeight = 16;
			this.listBoxShopHistory.Location = new System.Drawing.Point(42, 90);
			this.listBoxShopHistory.Name = "listBoxShopHistory";
			this.listBoxShopHistory.Size = new System.Drawing.Size(692, 420);
			this.listBoxShopHistory.TabIndex = 5;
			// 
			// ShopHistoryForm
			// 
			this.AcceptButton = this.buttonSearch;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.listBoxShopHistory);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.dateTimePickerEndTime);
			this.Controls.Add(this.labelEndTime);
			this.Controls.Add(this.dateTimePickerStartTime);
			this.Controls.Add(this.labelStartTime);
			this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "ShopHistoryForm";
			this.Text = "交易历史记录";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelStartTime;
		private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
		private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
		private System.Windows.Forms.Label labelEndTime;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.ListBox listBoxShopHistory;
	}
}