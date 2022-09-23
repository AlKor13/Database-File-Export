namespace DatabaseFileExport
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
            this.ConnectionStringTextBox = new System.Windows.Forms.TextBox();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.ConnectionStringLabel = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.FileNameLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterTableComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ColumnToUpdateComboBox = new System.Windows.Forms.ComboBox();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.SQLQueryPanel = new System.Windows.Forms.Panel();
            this.DBTableNameTextBox = new System.Windows.Forms.TextBox();
            this.CheckConnectionStringButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SelectDataBaseTableComboBox = new System.Windows.Forms.ComboBox();
            this.DBTablePanel = new System.Windows.Forms.Panel();
            this.SQLQueryPanel.SuspendLayout();
            this.DBTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectionStringTextBox
            // 
            this.ConnectionStringTextBox.Location = new System.Drawing.Point(15, 102);
            this.ConnectionStringTextBox.Name = "ConnectionStringTextBox";
            this.ConnectionStringTextBox.Size = new System.Drawing.Size(203, 20);
            this.ConnectionStringTextBox.TabIndex = 0;
            // 
            // LogoLabel
            // 
            this.LogoLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoLabel.Location = new System.Drawing.Point(9, 9);
            this.LogoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(278, 34);
            this.LogoLabel.TabIndex = 1;
            this.LogoLabel.Text = "DataBaseFileExport";
            this.LogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConnectionStringLabel
            // 
            this.ConnectionStringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectionStringLabel.Location = new System.Drawing.Point(12, 84);
            this.ConnectionStringLabel.Name = "ConnectionStringLabel";
            this.ConnectionStringLabel.Size = new System.Drawing.Size(203, 15);
            this.ConnectionStringLabel.TabIndex = 2;
            this.ConnectionStringLabel.Text = "Введите строку подключения";
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(15, 265);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(118, 29);
            this.InsertButton.TabIndex = 5;
            this.InsertButton.Text = "Экспорт";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Visible = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // FileNameLable
            // 
            this.FileNameLable.Location = new System.Drawing.Point(184, 205);
            this.FileNameLable.Name = "FileNameLable";
            this.FileNameLable.Size = new System.Drawing.Size(458, 23);
            this.FileNameLable.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(268, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(288, 4);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(92, 23);
            this.SelectFileButton.TabIndex = 11;
            this.SelectFileButton.Text = "Выбрать файл";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(386, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "WHERE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "UPDATE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterTableComboBox
            // 
            this.FilterTableComboBox.FormattingEnabled = true;
            this.FilterTableComboBox.Location = new System.Drawing.Point(440, 6);
            this.FilterTableComboBox.Name = "FilterTableComboBox";
            this.FilterTableComboBox.Size = new System.Drawing.Size(82, 21);
            this.FilterTableComboBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(144, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "SET";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(17)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(528, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColumnToUpdateComboBox
            // 
            this.ColumnToUpdateComboBox.FormattingEnabled = true;
            this.ColumnToUpdateComboBox.Location = new System.Drawing.Point(178, 6);
            this.ColumnToUpdateComboBox.Name = "ColumnToUpdateComboBox";
            this.ColumnToUpdateComboBox.Size = new System.Drawing.Size(82, 21);
            this.ColumnToUpdateComboBox.TabIndex = 7;
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(550, 6);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(124, 20);
            this.FilterTextBox.TabIndex = 16;
            // 
            // SQLQueryPanel
            // 
            this.SQLQueryPanel.Controls.Add(this.DBTableNameTextBox);
            this.SQLQueryPanel.Controls.Add(this.FilterTextBox);
            this.SQLQueryPanel.Controls.Add(this.ColumnToUpdateComboBox);
            this.SQLQueryPanel.Controls.Add(this.label5);
            this.SQLQueryPanel.Controls.Add(this.label2);
            this.SQLQueryPanel.Controls.Add(this.FilterTableComboBox);
            this.SQLQueryPanel.Controls.Add(this.label1);
            this.SQLQueryPanel.Controls.Add(this.label4);
            this.SQLQueryPanel.Controls.Add(this.SelectFileButton);
            this.SQLQueryPanel.Controls.Add(this.label3);
            this.SQLQueryPanel.Location = new System.Drawing.Point(15, 195);
            this.SQLQueryPanel.Name = "SQLQueryPanel";
            this.SQLQueryPanel.Size = new System.Drawing.Size(678, 33);
            this.SQLQueryPanel.TabIndex = 18;
            this.SQLQueryPanel.Visible = false;
            // 
            // DBTableNameTextBox
            // 
            this.DBTableNameTextBox.Location = new System.Drawing.Point(61, 7);
            this.DBTableNameTextBox.Name = "DBTableNameTextBox";
            this.DBTableNameTextBox.ReadOnly = true;
            this.DBTableNameTextBox.Size = new System.Drawing.Size(77, 20);
            this.DBTableNameTextBox.TabIndex = 17;
            // 
            // CheckConnectionStringButton
            // 
            this.CheckConnectionStringButton.Location = new System.Drawing.Point(224, 100);
            this.CheckConnectionStringButton.Name = "CheckConnectionStringButton";
            this.CheckConnectionStringButton.Size = new System.Drawing.Size(75, 23);
            this.CheckConnectionStringButton.TabIndex = 19;
            this.CheckConnectionStringButton.Text = "Проверить";
            this.CheckConnectionStringButton.UseVisualStyleBackColor = true;
            this.CheckConnectionStringButton.Click += new System.EventHandler(this.CheckConnectionStringButton_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(0, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Выберете таблицу базы данных";
            // 
            // SelectDataBaseTableComboBox
            // 
            this.SelectDataBaseTableComboBox.FormattingEnabled = true;
            this.SelectDataBaseTableComboBox.Location = new System.Drawing.Point(0, 24);
            this.SelectDataBaseTableComboBox.Name = "SelectDataBaseTableComboBox";
            this.SelectDataBaseTableComboBox.Size = new System.Drawing.Size(203, 21);
            this.SelectDataBaseTableComboBox.TabIndex = 21;
            this.SelectDataBaseTableComboBox.SelectionChangeCommitted += new System.EventHandler(this.SelectDataBaseTableComboBox_SelectionChangeCommitted);
            // 
            // DBTablePanel
            // 
            this.DBTablePanel.Controls.Add(this.label6);
            this.DBTablePanel.Controls.Add(this.SelectDataBaseTableComboBox);
            this.DBTablePanel.Location = new System.Drawing.Point(15, 128);
            this.DBTablePanel.Name = "DBTablePanel";
            this.DBTablePanel.Size = new System.Drawing.Size(231, 48);
            this.DBTablePanel.TabIndex = 22;
            this.DBTablePanel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 302);
            this.Controls.Add(this.DBTablePanel);
            this.Controls.Add(this.CheckConnectionStringButton);
            this.Controls.Add(this.SQLQueryPanel);
            this.Controls.Add(this.FileNameLable);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.ConnectionStringLabel);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.ConnectionStringTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SQLQueryPanel.ResumeLayout(false);
            this.SQLQueryPanel.PerformLayout();
            this.DBTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel DBTablePanel;

        private System.Windows.Forms.TextBox DBTableNameTextBox;

        private System.Windows.Forms.TextBox ConnectionStringTextBox;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Label ConnectionStringLabel;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label FileNameLable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FilterTableComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ColumnToUpdateComboBox;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.Panel SQLQueryPanel;
        private System.Windows.Forms.Button CheckConnectionStringButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SelectDataBaseTableComboBox;

        #endregion
    }
}

