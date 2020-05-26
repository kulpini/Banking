namespace Banking
{
    partial class StatementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CardNameLabel = new System.Windows.Forms.Label();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.StatementDataGrid = new System.Windows.Forms.DataGridView();
            this.SaveResultsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PaymentReportButton = new System.Windows.Forms.Button();
            this.StatusReportButton = new System.Windows.Forms.Button();
            this.OperationReportButton = new System.Windows.Forms.Button();
            this.ReportLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StatementDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клiєнт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер картки: ";
            // 
            // CardNameLabel
            // 
            this.CardNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNameLabel.Location = new System.Drawing.Point(225, 62);
            this.CardNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CardNameLabel.Name = "CardNameLabel";
            this.CardNameLabel.Size = new System.Drawing.Size(553, 25);
            this.CardNameLabel.TabIndex = 2;
            this.CardNameLabel.Text = "label3";
            this.CardNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientNameLabel.Location = new System.Drawing.Point(225, 25);
            this.ClientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(553, 25);
            this.ClientNameLabel.TabIndex = 3;
            this.ClientNameLabel.Text = "label3";
            this.ClientNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatementDataGrid
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StatementDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StatementDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatementDataGrid.Location = new System.Drawing.Point(16, 314);
            this.StatementDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatementDataGrid.Name = "StatementDataGrid";
            this.StatementDataGrid.RowHeadersVisible = false;
            this.StatementDataGrid.RowHeadersWidth = 51;
            this.StatementDataGrid.Size = new System.Drawing.Size(763, 401);
            this.StatementDataGrid.TabIndex = 4;
            // 
            // SaveResultsButton
            // 
            this.SaveResultsButton.Enabled = false;
            this.SaveResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveResultsButton.Location = new System.Drawing.Point(531, 135);
            this.SaveResultsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveResultsButton.Name = "SaveResultsButton";
            this.SaveResultsButton.Size = new System.Drawing.Size(248, 42);
            this.SaveResultsButton.TabIndex = 5;
            this.SaveResultsButton.Text = "Зберегти в файл...";
            this.SaveResultsButton.UseVisualStyleBackColor = true;
            this.SaveResultsButton.Click += new System.EventHandler(this.SaveResultsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OperationReportButton);
            this.groupBox1.Controls.Add(this.StatusReportButton);
            this.groupBox1.Controls.Add(this.PaymentReportButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(40, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 136);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Зробити виписку";
            // 
            // PaymentReportButton
            // 
            this.PaymentReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentReportButton.Location = new System.Drawing.Point(7, 27);
            this.PaymentReportButton.Margin = new System.Windows.Forms.Padding(4);
            this.PaymentReportButton.Name = "PaymentReportButton";
            this.PaymentReportButton.Size = new System.Drawing.Size(212, 42);
            this.PaymentReportButton.TabIndex = 6;
            this.PaymentReportButton.Text = "Перекази з картки...";
            this.PaymentReportButton.UseVisualStyleBackColor = true;
            this.PaymentReportButton.Click += new System.EventHandler(this.PaymentReportButton_Click);
            // 
            // StatusReportButton
            // 
            this.StatusReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusReportButton.Location = new System.Drawing.Point(131, 77);
            this.StatusReportButton.Margin = new System.Windows.Forms.Padding(4);
            this.StatusReportButton.Name = "StatusReportButton";
            this.StatusReportButton.Size = new System.Drawing.Size(206, 42);
            this.StatusReportButton.TabIndex = 7;
            this.StatusReportButton.Text = "Статус карт...";
            this.StatusReportButton.UseVisualStyleBackColor = true;
            this.StatusReportButton.Click += new System.EventHandler(this.StatusReportButton_Click);
            // 
            // OperationReportButton
            // 
            this.OperationReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OperationReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperationReportButton.Location = new System.Drawing.Point(232, 27);
            this.OperationReportButton.Margin = new System.Windows.Forms.Padding(4);
            this.OperationReportButton.Name = "OperationReportButton";
            this.OperationReportButton.Size = new System.Drawing.Size(212, 42);
            this.OperationReportButton.TabIndex = 8;
            this.OperationReportButton.Text = "Операцiї по картцi...";
            this.OperationReportButton.UseVisualStyleBackColor = true;
            this.OperationReportButton.Click += new System.EventHandler(this.OperationReportButton_Click);
            // 
            // ReportLabel
            // 
            this.ReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportLabel.Location = new System.Drawing.Point(16, 264);
            this.ReportLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportLabel.Name = "ReportLabel";
            this.ReportLabel.Size = new System.Drawing.Size(762, 25);
            this.ReportLabel.TabIndex = 7;
            this.ReportLabel.Text = "Звiт";
            this.ReportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 730);
            this.Controls.Add(this.ReportLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveResultsButton);
            this.Controls.Add(this.StatementDataGrid);
            this.Controls.Add(this.ClientNameLabel);
            this.Controls.Add(this.CardNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iсторiя операцiй по обранiй картцi";
            ((System.ComponentModel.ISupportInitialize)(this.StatementDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label CardNameLabel;
        public System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.DataGridView StatementDataGrid;
        private System.Windows.Forms.Button SaveResultsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StatusReportButton;
        private System.Windows.Forms.Button PaymentReportButton;
        private System.Windows.Forms.Button OperationReportButton;
        public System.Windows.Forms.Label ReportLabel;
    }
}