
namespace FSImageTo
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSyze = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnMime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.MenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ScanBtn = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnType,
            this.ColumnName,
            this.ColumnSyze,
            this.ColumnMime});
			this.dataGridView1.Location = new System.Drawing.Point(169, 24);
			this.dataGridView1.MinimumSize = new System.Drawing.Size(300, 300);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(584, 451);
			this.dataGridView1.TabIndex = 2;
			// 
			// ColumnType
			// 
			this.ColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColumnType.HeaderText = "Тип";
			this.ColumnType.MinimumWidth = 50;
			this.ColumnType.Name = "ColumnType";
			this.ColumnType.ReadOnly = true;
			this.ColumnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// ColumnName
			// 
			this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColumnName.HeaderText = "Название";
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			// 
			// ColumnSyze
			// 
			this.ColumnSyze.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColumnSyze.HeaderText = "Размер";
			this.ColumnSyze.Name = "ColumnSyze";
			this.ColumnSyze.ReadOnly = true;
			// 
			// ColumnMime
			// 
			this.ColumnMime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColumnMime.HeaderText = "MIMEType(если файл)";
			this.ColumnMime.Name = "ColumnMime";
			this.ColumnMime.ReadOnly = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(765, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// MenuItem
			// 
			this.MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMenuItem});
			this.MenuItem.Name = "MenuItem";
			this.MenuItem.Size = new System.Drawing.Size(48, 20);
			this.MenuItem.Text = "Файл";
			// 
			// SaveMenuItem
			// 
			this.SaveMenuItem.Name = "SaveMenuItem";
			this.SaveMenuItem.Size = new System.Drawing.Size(180, 22);
			this.SaveMenuItem.Text = "Сохранить";
			this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
			// 
			// ScanBtn
			// 
			this.ScanBtn.Location = new System.Drawing.Point(12, 24);
			this.ScanBtn.Name = "ScanBtn";
			this.ScanBtn.Size = new System.Drawing.Size(151, 109);
			this.ScanBtn.TabIndex = 0;
			this.ScanBtn.Text = "Просканировать";
			this.ScanBtn.UseVisualStyleBackColor = true;
			this.ScanBtn.Click += new System.EventHandler(this.ScanBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 487);
			this.Controls.Add(this.ScanBtn);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "Form1";
			this.Text = "FSImageTo";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem MenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
		private System.Windows.Forms.Button ScanBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSyze;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMime;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

