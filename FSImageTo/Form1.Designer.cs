
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
			this.labelFileCount = new System.Windows.Forms.Label();
			this.labelCount = new System.Windows.Forms.Label();
			this.labelDirsCount = new System.Windows.Forms.Label();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.labelMimeName = new System.Windows.Forms.Label();
			this.labelRelation = new System.Windows.Forms.Label();
			this.labelMediumSize = new System.Windows.Forms.Label();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
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
			this.dataGridView1.Location = new System.Drawing.Point(12, 132);
			this.dataGridView1.MinimumSize = new System.Drawing.Size(300, 300);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(741, 343);
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
			this.SaveMenuItem.Size = new System.Drawing.Size(133, 22);
			this.SaveMenuItem.Text = "Сохранить";
			this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
			// 
			// ScanBtn
			// 
			this.ScanBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ScanBtn.Location = new System.Drawing.Point(114, 30);
			this.ScanBtn.Name = "ScanBtn";
			this.ScanBtn.Size = new System.Drawing.Size(150, 60);
			this.ScanBtn.TabIndex = 0;
			this.ScanBtn.Text = "Просканировать";
			this.ScanBtn.UseVisualStyleBackColor = true;
			this.ScanBtn.Click += new System.EventHandler(this.ScanBtn_Click);
			// 
			// labelFileCount
			// 
			this.labelFileCount.AutoSize = true;
			this.labelFileCount.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelFileCount.Location = new System.Drawing.Point(270, 67);
			this.labelFileCount.Name = "labelFileCount";
			this.labelFileCount.Size = new System.Drawing.Size(119, 23);
			this.labelFileCount.TabIndex = 4;
			this.labelFileCount.Text = "Файлов - 0";
			// 
			// labelCount
			// 
			this.labelCount.AutoSize = true;
			this.labelCount.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelCount.Location = new System.Drawing.Point(270, 24);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(100, 23);
			this.labelCount.TabIndex = 5;
			this.labelCount.Text = "Всего - 0";
			// 
			// labelDirsCount
			// 
			this.labelDirsCount.AutoSize = true;
			this.labelDirsCount.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelDirsCount.Location = new System.Drawing.Point(270, 47);
			this.labelDirsCount.Name = "labelDirsCount";
			this.labelDirsCount.Size = new System.Drawing.Size(119, 23);
			this.labelDirsCount.TabIndex = 6;
			this.labelDirsCount.Text = "Файлов - 0";
			// 
			// comboBox
			// 
			this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Location = new System.Drawing.Point(13, 95);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(740, 24);
			this.comboBox.Sorted = true;
			this.comboBox.TabIndex = 7;
			this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
			// 
			// labelMimeName
			// 
			this.labelMimeName.AutoEllipsis = true;
			this.labelMimeName.AutoSize = true;
			this.labelMimeName.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelMimeName.Location = new System.Drawing.Point(437, 24);
			this.labelMimeName.Name = "labelMimeName";
			this.labelMimeName.Size = new System.Drawing.Size(124, 23);
			this.labelMimeName.TabIndex = 8;
			this.labelMimeName.Text = "Mime тип - ";
			// 
			// labelRelation
			// 
			this.labelRelation.AutoSize = true;
			this.labelRelation.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelRelation.Location = new System.Drawing.Point(437, 47);
			this.labelRelation.Name = "labelRelation";
			this.labelRelation.Size = new System.Drawing.Size(147, 23);
			this.labelRelation.TabIndex = 9;
			this.labelRelation.Text = "Количество - ";
			// 
			// labelMediumSize
			// 
			this.labelMediumSize.AutoSize = true;
			this.labelMediumSize.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelMediumSize.Location = new System.Drawing.Point(437, 67);
			this.labelMediumSize.Name = "labelMediumSize";
			this.labelMediumSize.Size = new System.Drawing.Size(193, 23);
			this.labelMediumSize.TabIndex = 10;
			this.labelMediumSize.Text = "Средний размер - ";
			// 
			// buttonOpen
			// 
			this.buttonOpen.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonOpen.Location = new System.Drawing.Point(13, 30);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(95, 60);
			this.buttonOpen.TabIndex = 11;
			this.buttonOpen.Text = "Открыть";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 487);
			this.Controls.Add(this.buttonOpen);
			this.Controls.Add(this.labelMediumSize);
			this.Controls.Add(this.labelRelation);
			this.Controls.Add(this.labelMimeName);
			this.Controls.Add(this.comboBox);
			this.Controls.Add(this.labelDirsCount);
			this.Controls.Add(this.labelCount);
			this.Controls.Add(this.labelFileCount);
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
		private System.Windows.Forms.Label labelFileCount;
		private System.Windows.Forms.Label labelCount;
		private System.Windows.Forms.Label labelDirsCount;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.Label labelMimeName;
		private System.Windows.Forms.Label labelRelation;
		private System.Windows.Forms.Label labelMediumSize;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}

