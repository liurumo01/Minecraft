namespace Minecraft
{
	partial class ShopItemForm
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
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.listBoxShopItems = new System.Windows.Forms.ListBox();
			this.textBoxShopItemInfo = new System.Windows.Forms.TextBox();
			this.buttonBuy = new System.Windows.Forms.Button();
			this.buttonSell = new System.Windows.Forms.Button();
			this.textBoxAmount = new System.Windows.Forms.TextBox();
			this.comboBoxAmount = new System.Windows.Forms.ComboBox();
			this.labelAmount = new System.Windows.Forms.Label();
			this.labelPlayerMoney = new System.Windows.Forms.Label();
			this.textBoxPlayerMoney = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(58, 66);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(208, 26);
			this.textBoxSearch.TabIndex = 0;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(282, 66);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 26);
			this.buttonSearch.TabIndex = 1;
			this.buttonSearch.Text = "搜索";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
			// 
			// listBoxShopItems
			// 
			this.listBoxShopItems.FormattingEnabled = true;
			this.listBoxShopItems.ItemHeight = 16;
			this.listBoxShopItems.Location = new System.Drawing.Point(58, 139);
			this.listBoxShopItems.Name = "listBoxShopItems";
			this.listBoxShopItems.Size = new System.Drawing.Size(300, 372);
			this.listBoxShopItems.TabIndex = 2;
			this.listBoxShopItems.SelectedIndexChanged += new System.EventHandler(this.ListBoxShopItems_SelectedIndexChanged);
			// 
			// textBoxShopItemInfo
			// 
			this.textBoxShopItemInfo.Location = new System.Drawing.Point(435, 66);
			this.textBoxShopItemInfo.Multiline = true;
			this.textBoxShopItemInfo.Name = "textBoxShopItemInfo";
			this.textBoxShopItemInfo.ReadOnly = true;
			this.textBoxShopItemInfo.Size = new System.Drawing.Size(300, 284);
			this.textBoxShopItemInfo.TabIndex = 3;
			// 
			// buttonBuy
			// 
			this.buttonBuy.Location = new System.Drawing.Point(435, 471);
			this.buttonBuy.Name = "buttonBuy";
			this.buttonBuy.Size = new System.Drawing.Size(135, 40);
			this.buttonBuy.TabIndex = 4;
			this.buttonBuy.Text = "购买";
			this.buttonBuy.UseVisualStyleBackColor = true;
			this.buttonBuy.Click += new System.EventHandler(this.ButtonBuy_Click);
			// 
			// buttonSell
			// 
			this.buttonSell.Location = new System.Drawing.Point(600, 471);
			this.buttonSell.Name = "buttonSell";
			this.buttonSell.Size = new System.Drawing.Size(135, 40);
			this.buttonSell.TabIndex = 5;
			this.buttonSell.Text = "出售";
			this.buttonSell.UseVisualStyleBackColor = true;
			this.buttonSell.Click += new System.EventHandler(this.ButtonSell_Click);
			// 
			// textBoxAmount
			// 
			this.textBoxAmount.Location = new System.Drawing.Point(519, 418);
			this.textBoxAmount.Name = "textBoxAmount";
			this.textBoxAmount.Size = new System.Drawing.Size(132, 26);
			this.textBoxAmount.TabIndex = 6;
			// 
			// comboBoxAmount
			// 
			this.comboBoxAmount.FormattingEnabled = true;
			this.comboBoxAmount.Location = new System.Drawing.Point(668, 418);
			this.comboBoxAmount.Name = "comboBoxAmount";
			this.comboBoxAmount.Size = new System.Drawing.Size(67, 24);
			this.comboBoxAmount.TabIndex = 7;
			// 
			// labelAmount
			// 
			this.labelAmount.AutoSize = true;
			this.labelAmount.Location = new System.Drawing.Point(432, 423);
			this.labelAmount.Name = "labelAmount";
			this.labelAmount.Size = new System.Drawing.Size(72, 16);
			this.labelAmount.TabIndex = 8;
			this.labelAmount.Text = "操作数量";
			// 
			// labelPlayerMoney
			// 
			this.labelPlayerMoney.AutoSize = true;
			this.labelPlayerMoney.Location = new System.Drawing.Point(432, 378);
			this.labelPlayerMoney.Name = "labelPlayerMoney";
			this.labelPlayerMoney.Size = new System.Drawing.Size(72, 16);
			this.labelPlayerMoney.TabIndex = 9;
			this.labelPlayerMoney.Text = "账户余额";
			// 
			// textBoxPlayerMoney
			// 
			this.textBoxPlayerMoney.Location = new System.Drawing.Point(519, 375);
			this.textBoxPlayerMoney.Name = "textBoxPlayerMoney";
			this.textBoxPlayerMoney.ReadOnly = true;
			this.textBoxPlayerMoney.Size = new System.Drawing.Size(216, 26);
			this.textBoxPlayerMoney.TabIndex = 10;
			// 
			// ShopItemForm
			// 
			this.AcceptButton = this.buttonSearch;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.textBoxPlayerMoney);
			this.Controls.Add(this.labelPlayerMoney);
			this.Controls.Add(this.labelAmount);
			this.Controls.Add(this.comboBoxAmount);
			this.Controls.Add(this.textBoxAmount);
			this.Controls.Add(this.buttonSell);
			this.Controls.Add(this.buttonBuy);
			this.Controls.Add(this.textBoxShopItemInfo);
			this.Controls.Add(this.listBoxShopItems);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBoxSearch);
			this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "ShopItemForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "我的世界 商品列表";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.ListBox listBoxShopItems;
		private System.Windows.Forms.TextBox textBoxShopItemInfo;
		private System.Windows.Forms.Button buttonBuy;
		private System.Windows.Forms.Button buttonSell;
		private System.Windows.Forms.TextBox textBoxAmount;
		private System.Windows.Forms.ComboBox comboBoxAmount;
		private System.Windows.Forms.Label labelAmount;
		private System.Windows.Forms.Label labelPlayerMoney;
		private System.Windows.Forms.TextBox textBoxPlayerMoney;
	}
}