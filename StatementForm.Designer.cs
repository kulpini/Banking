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
            ((System.ComponentModel.ISupportInitialize)(this.StatementDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клiєнт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер картки: ";
            // 
            // CardNameLabel
            // 
            this.CardNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNameLabel.Location = new System.Drawing.Point(169, 50);
            this.CardNameLabel.Name = "CardNameLabel";
            this.CardNameLabel.Size = new System.Drawing.Size(415, 20);
            this.CardNameLabel.TabIndex = 2;
            this.CardNameLabel.Text = "label3";
            this.CardNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientNameLabel.Location = new System.Drawing.Point(169, 20);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(415, 20);
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
            this.StatementDataGrid.Location = new System.Drawing.Point(12, 127);
            this.StatementDataGrid.Name = "StatementDataGrid";
            this.StatementDataGrid.RowHeadersVisible = false;
            this.StatementDataGrid.Size = new System.Drawing.Size(572, 454);
            this.StatementDataGrid.TabIndex = 4;
            // 
            // SaveResultsButton
            // 
            this.SaveResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveResultsButton.Location = new System.Drawing.Point(398, 87);
            this.SaveResultsButton.Name = "SaveResultsButton";
            this.SaveResultsButton.Size = new System.Drawing.Size(186, 34);
            this.SaveResultsButton.TabIndex = 5;
            this.SaveResultsButton.Text = "Зберегти в файл...";
            this.SaveResultsButton.UseVisualStyleBackColor = true;
            this.SaveResultsButton.Click += new System.EventHandler(this.SaveResultsButton_Click);
            // 
            // StatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 593);
            this.Controls.Add(this.SaveResultsButton);
            this.Controls.Add(this.StatementDataGrid);
            this.Controls.Add(this.ClientNameLabel);
            this.Controls.Add(this.CardNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iсторiя операцiй по обранiй картцi";
            this.Load += new System.EventHandler(this.StatementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatementDataGrid)).EndInit();
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
    }
}