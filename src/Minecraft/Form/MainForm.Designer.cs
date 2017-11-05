namespace Minecraft
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.余额ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.商店ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.历史记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.建设ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.仓库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.交通ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.明细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账户ToolStripMenuItem,
            this.商店ToolStripMenuItem,
            this.建设ToolStripMenuItem,
            this.仓库ToolStripMenuItem,
            this.交通ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
			this.menuStrip1.Size = new System.Drawing.Size(984, 27);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 账户ToolStripMenuItem
			// 
			this.账户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.余额ToolStripMenuItem,
            this.明细ToolStripMenuItem});
			this.账户ToolStripMenuItem.Name = "账户ToolStripMenuItem";
			this.账户ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.账户ToolStripMenuItem.Text = "账户";
			// 
			// 余额ToolStripMenuItem
			// 
			this.余额ToolStripMenuItem.Name = "余额ToolStripMenuItem";
			this.余额ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.余额ToolStripMenuItem.Text = "余额";
			this.余额ToolStripMenuItem.Click += new System.EventHandler(this.余额ToolStripMenuItem_Click);
			// 
			// 商店ToolStripMenuItem
			// 
			this.商店ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.列表ToolStripMenuItem,
            this.历史记录ToolStripMenuItem});
			this.商店ToolStripMenuItem.Name = "商店ToolStripMenuItem";
			this.商店ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.商店ToolStripMenuItem.Text = "商店";
			// 
			// 列表ToolStripMenuItem
			// 
			this.列表ToolStripMenuItem.Name = "列表ToolStripMenuItem";
			this.列表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.列表ToolStripMenuItem.Text = "列表";
			this.列表ToolStripMenuItem.Click += new System.EventHandler(this.列表ToolStripMenuItem_Click);
			// 
			// 历史记录ToolStripMenuItem
			// 
			this.历史记录ToolStripMenuItem.Name = "历史记录ToolStripMenuItem";
			this.历史记录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.历史记录ToolStripMenuItem.Text = "历史记录";
			this.历史记录ToolStripMenuItem.Click += new System.EventHandler(this.历史记录ToolStripMenuItem_Click);
			// 
			// 建设ToolStripMenuItem
			// 
			this.建设ToolStripMenuItem.Name = "建设ToolStripMenuItem";
			this.建设ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.建设ToolStripMenuItem.Text = "建设";
			// 
			// 仓库ToolStripMenuItem
			// 
			this.仓库ToolStripMenuItem.Name = "仓库ToolStripMenuItem";
			this.仓库ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.仓库ToolStripMenuItem.Text = "仓库";
			// 
			// 交通ToolStripMenuItem
			// 
			this.交通ToolStripMenuItem.Name = "交通ToolStripMenuItem";
			this.交通ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.交通ToolStripMenuItem.Text = "交通";
			// 
			// 明细ToolStripMenuItem
			// 
			this.明细ToolStripMenuItem.Name = "明细ToolStripMenuItem";
			this.明细ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.明细ToolStripMenuItem.Text = "明细";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 741);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "我的世界";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 账户ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 余额ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 商店ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 列表ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 仓库ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 交通ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 建设ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 历史记录ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 明细ToolStripMenuItem;
	}
}