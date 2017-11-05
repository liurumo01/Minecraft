namespace Minecraft
{
	partial class LoginForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.labelSelectWorld = new System.Windows.Forms.Label();
			this.comboBoxSelectWorld = new System.Windows.Forms.ComboBox();
			this.buttonCreateWorld = new System.Windows.Forms.Button();
			this.comboBoxSelectPlayer = new System.Windows.Forms.ComboBox();
			this.labelSelectPlayer = new System.Windows.Forms.Label();
			this.buttonCreatePlayer = new System.Windows.Forms.Button();
			this.buttonEnterWorld = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelSelectWorld
			// 
			this.labelSelectWorld.AutoSize = true;
			this.labelSelectWorld.Location = new System.Drawing.Point(32, 125);
			this.labelSelectWorld.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelSelectWorld.Name = "labelSelectWorld";
			this.labelSelectWorld.Size = new System.Drawing.Size(72, 16);
			this.labelSelectWorld.TabIndex = 0;
			this.labelSelectWorld.Text = "选择世界";
			// 
			// comboBoxSelectWorld
			// 
			this.comboBoxSelectWorld.FormattingEnabled = true;
			this.comboBoxSelectWorld.Location = new System.Drawing.Point(124, 122);
			this.comboBoxSelectWorld.Name = "comboBoxSelectWorld";
			this.comboBoxSelectWorld.Size = new System.Drawing.Size(121, 24);
			this.comboBoxSelectWorld.TabIndex = 1;
			// 
			// buttonCreateWorld
			// 
			this.buttonCreateWorld.Location = new System.Drawing.Point(264, 125);
			this.buttonCreateWorld.Name = "buttonCreateWorld";
			this.buttonCreateWorld.Size = new System.Drawing.Size(85, 23);
			this.buttonCreateWorld.TabIndex = 5;
			this.buttonCreateWorld.Text = "创建世界";
			this.buttonCreateWorld.UseVisualStyleBackColor = true;
			this.buttonCreateWorld.Click += new System.EventHandler(this.ButtonCreateWorld_Click);
			// 
			// comboBoxSelectPlayer
			// 
			this.comboBoxSelectPlayer.FormattingEnabled = true;
			this.comboBoxSelectPlayer.Location = new System.Drawing.Point(124, 50);
			this.comboBoxSelectPlayer.Name = "comboBoxSelectPlayer";
			this.comboBoxSelectPlayer.Size = new System.Drawing.Size(121, 24);
			this.comboBoxSelectPlayer.TabIndex = 7;
			// 
			// labelSelectPlayer
			// 
			this.labelSelectPlayer.AutoSize = true;
			this.labelSelectPlayer.Location = new System.Drawing.Point(32, 53);
			this.labelSelectPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelSelectPlayer.Name = "labelSelectPlayer";
			this.labelSelectPlayer.Size = new System.Drawing.Size(72, 16);
			this.labelSelectPlayer.TabIndex = 6;
			this.labelSelectPlayer.Text = "选择玩家";
			// 
			// buttonCreatePlayer
			// 
			this.buttonCreatePlayer.Location = new System.Drawing.Point(264, 53);
			this.buttonCreatePlayer.Name = "buttonCreatePlayer";
			this.buttonCreatePlayer.Size = new System.Drawing.Size(85, 23);
			this.buttonCreatePlayer.TabIndex = 8;
			this.buttonCreatePlayer.Text = "创建玩家";
			this.buttonCreatePlayer.UseVisualStyleBackColor = true;
			this.buttonCreatePlayer.Click += new System.EventHandler(this.ButtonCreatePlayer_Click);
			// 
			// buttonEnterWorld
			// 
			this.buttonEnterWorld.Location = new System.Drawing.Point(124, 189);
			this.buttonEnterWorld.Name = "buttonEnterWorld";
			this.buttonEnterWorld.Size = new System.Drawing.Size(121, 35);
			this.buttonEnterWorld.TabIndex = 9;
			this.buttonEnterWorld.Text = "登录";
			this.buttonEnterWorld.UseVisualStyleBackColor = true;
			this.buttonEnterWorld.Click += new System.EventHandler(this.ButtonEnterWorld_Click);
			// 
			// LoginForm
			// 
			this.AcceptButton = this.buttonEnterWorld;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 261);
			this.Controls.Add(this.buttonEnterWorld);
			this.Controls.Add(this.buttonCreatePlayer);
			this.Controls.Add(this.comboBoxSelectPlayer);
			this.Controls.Add(this.labelSelectPlayer);
			this.Controls.Add(this.buttonCreateWorld);
			this.Controls.Add(this.comboBoxSelectWorld);
			this.Controls.Add(this.labelSelectWorld);
			this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "我的世界 用户登录";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelSelectWorld;
		private System.Windows.Forms.ComboBox comboBoxSelectWorld;
		private System.Windows.Forms.Button buttonCreateWorld;
		private System.Windows.Forms.ComboBox comboBoxSelectPlayer;
		private System.Windows.Forms.Label labelSelectPlayer;
		private System.Windows.Forms.Button buttonCreatePlayer;
		private System.Windows.Forms.Button buttonEnterWorld;
	}
}

