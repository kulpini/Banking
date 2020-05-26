namespace Banking
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.CardsDataGrid = new System.Windows.Forms.DataGridView();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BlockCardButton = new System.Windows.Forms.Button();
            this.OperationButton = new System.Windows.Forms.Button();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EurLabel = new System.Windows.Forms.Label();
            this.UsdLabel = new System.Windows.Forms.Label();
            this.UahLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CardStateLabel = new System.Windows.Forms.Label();
            this.ChatPanel = new System.Windows.Forms.Panel();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.ChatButton = new System.Windows.Forms.Button();
            this.ChatListBox = new System.Windows.Forms.ListBox();
            this.CloseChatPictureBox = new System.Windows.Forms.PictureBox();
            this.ChatPicture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CardsDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ChatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseChatPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CardsDataGrid
            // 
            this.CardsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CardsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CardsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CardsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.CardsDataGrid.Location = new System.Drawing.Point(11, 94);
            this.CardsDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.CardsDataGrid.Name = "CardsDataGrid";
            this.CardsDataGrid.RowHeadersVisible = false;
            this.CardsDataGrid.RowHeadersWidth = 51;
            this.CardsDataGrid.RowTemplate.Height = 24;
            this.CardsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CardsDataGrid.Size = new System.Drawing.Size(250, 490);
            this.CardsDataGrid.TabIndex = 0;
            this.CardsDataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CardsDataGrid_CellEnter);
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ClientNameLabel.Location = new System.Drawing.Point(30, 15);
            this.ClientNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(220, 26);
            this.ClientNameLabel.TabIndex = 1;
            this.ClientNameLabel.Text = "Ласкаво просимо, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Перелiк робочих карток клiента:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BlockCardButton);
            this.groupBox1.Controls.Add(this.OperationButton);
            this.groupBox1.Controls.Add(this.PaymentButton);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(282, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 187);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операцiї з карткою";
            // 
            // BlockCardButton
            // 
            this.BlockCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlockCardButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlockCardButton.Location = new System.Drawing.Point(25, 133);
            this.BlockCardButton.Name = "BlockCardButton";
            this.BlockCardButton.Size = new System.Drawing.Size(228, 30);
            this.BlockCardButton.TabIndex = 6;
            this.BlockCardButton.Text = "Блокувати / разблокувати...";
            this.BlockCardButton.UseVisualStyleBackColor = true;
            this.BlockCardButton.Click += new System.EventHandler(this.BlockCardButton_Click);
            // 
            // OperationButton
            // 
            this.OperationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OperationButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperationButton.Location = new System.Drawing.Point(25, 85);
            this.OperationButton.Name = "OperationButton";
            this.OperationButton.Size = new System.Drawing.Size(228, 30);
            this.OperationButton.TabIndex = 5;
            this.OperationButton.Text = "Переглянути iсторiю...";
            this.OperationButton.UseVisualStyleBackColor = true;
            this.OperationButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // PaymentButton
            // 
            this.PaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentButton.Location = new System.Drawing.Point(25, 36);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(228, 30);
            this.PaymentButton.TabIndex = 4;
            this.PaymentButton.Text = "Зробити переказ...";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.EurLabel);
            this.groupBox2.Controls.Add(this.UsdLabel);
            this.groupBox2.Controls.Add(this.UahLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox2.Location = new System.Drawing.Point(282, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 108);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поточний баланс";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(381, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "* еквiвалент по курсу НБУ на поточний час";
            // 
            // EurLabel
            // 
            this.EurLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EurLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.EurLabel.Location = new System.Drawing.Point(425, 39);
            this.EurLabel.Name = "EurLabel";
            this.EurLabel.Size = new System.Drawing.Size(152, 21);
            this.EurLabel.TabIndex = 15;
            this.EurLabel.Text = "0";
            this.EurLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UsdLabel
            // 
            this.UsdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsdLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsdLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.UsdLabel.Location = new System.Drawing.Point(215, 39);
            this.UsdLabel.Name = "UsdLabel";
            this.UsdLabel.Size = new System.Drawing.Size(149, 21);
            this.UsdLabel.TabIndex = 14;
            this.UsdLabel.Text = "0";
            this.UsdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UahLabel
            // 
            this.UahLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UahLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.UahLabel.Location = new System.Drawing.Point(6, 39);
            this.UahLabel.Name = "UahLabel";
            this.UahLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UahLabel.Size = new System.Drawing.Size(152, 21);
            this.UahLabel.TabIndex = 13;
            this.UahLabel.Text = "0";
            this.UahLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(370, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "USD |  *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(583, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "EUR *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(164, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "UAH |  ";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddressLabel.Location = new System.Drawing.Point(30, 41);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(220, 26);
            this.AddressLabel.TabIndex = 11;
            this.AddressLabel.Text = "Ласкаво просимо, ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CardStateLabel);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox3.Location = new System.Drawing.Point(282, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(647, 72);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Статус картки";
            // 
            // CardStateLabel
            // 
            this.CardStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardStateLabel.AutoSize = true;
            this.CardStateLabel.Font = new System.Drawing.Font("Tahoma", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardStateLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.CardStateLabel.Location = new System.Drawing.Point(21, 28);
            this.CardStateLabel.Name = "CardStateLabel";
            this.CardStateLabel.Size = new System.Drawing.Size(21, 21);
            this.CardStateLabel.TabIndex = 13;
            this.CardStateLabel.Text = "0";
            this.CardStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChatPanel
            // 
            this.ChatPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ChatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatPanel.Controls.Add(this.label2);
            this.ChatPanel.Controls.Add(this.MessageTextBox);
            this.ChatPanel.Controls.Add(this.ChatButton);
            this.ChatPanel.Controls.Add(this.ChatListBox);
            this.ChatPanel.Controls.Add(this.CloseChatPictureBox);
            this.ChatPanel.Controls.Add(this.ChatPicture);
            this.ChatPanel.Location = new System.Drawing.Point(925, 564);
            this.ChatPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(272, 32);
            this.ChatPanel.TabIndex = 13;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(4, 322);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageTextBox.Size = new System.Drawing.Size(204, 53);
            this.MessageTextBox.TabIndex = 6;
            // 
            // ChatButton
            // 
            this.ChatButton.Image = ((System.Drawing.Image)(resources.GetObject("ChatButton.Image")));
            this.ChatButton.Location = new System.Drawing.Point(213, 322);
            this.ChatButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChatButton.Name = "ChatButton";
            this.ChatButton.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.ChatButton.Size = new System.Drawing.Size(47, 53);
            this.ChatButton.TabIndex = 5;
            this.ChatButton.UseVisualStyleBackColor = true;
            this.ChatButton.Click += new System.EventHandler(this.ChatButton_Click);
            // 
            // ChatListBox
            // 
            this.ChatListBox.FormattingEnabled = true;
            this.ChatListBox.HorizontalScrollbar = true;
            this.ChatListBox.Items.AddRange(new object[] {
            "Оператор Наталiя приєдналась до чату",
            "..............................",
            "Оператор:",
            "Задайте, будь ласка, Ваше питання"});
            this.ChatListBox.Location = new System.Drawing.Point(4, 34);
            this.ChatListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChatListBox.Name = "ChatListBox";
            this.ChatListBox.ScrollAlwaysVisible = true;
            this.ChatListBox.Size = new System.Drawing.Size(256, 277);
            this.ChatListBox.TabIndex = 3;
            // 
            // CloseChatPictureBox
            // 
            this.CloseChatPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseChatPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CloseChatPictureBox.Image")));
            this.CloseChatPictureBox.Location = new System.Drawing.Point(227, 2);
            this.CloseChatPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.CloseChatPictureBox.Name = "CloseChatPictureBox";
            this.CloseChatPictureBox.Size = new System.Drawing.Size(27, 24);
            this.CloseChatPictureBox.TabIndex = 1;
            this.CloseChatPictureBox.TabStop = false;
            this.CloseChatPictureBox.Visible = false;
            this.CloseChatPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseChatPictureBox_MouseClick);
            // 
            // ChatPicture
            // 
            this.ChatPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChatPicture.Image = ((System.Drawing.Image)(resources.GetObject("ChatPicture.Image")));
            this.ChatPicture.Location = new System.Drawing.Point(4, 2);
            this.ChatPicture.Margin = new System.Windows.Forms.Padding(2);
            this.ChatPicture.Name = "ChatPicture";
            this.ChatPicture.Size = new System.Drawing.Size(27, 24);
            this.ChatPicture.TabIndex = 0;
            this.ChatPicture.TabStop = false;
            this.ChatPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChatPicture_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(55, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Служба пiдтримки";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1197, 595);
            this.Controls.Add(this.ChatPanel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientNameLabel);
            this.Controls.Add(this.CardsDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "===== Система підтримки клієнтських карткових операцій =====";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CardsDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ChatPanel.ResumeLayout(false);
            this.ChatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseChatPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CardsDataGrid;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BlockCardButton;
        private System.Windows.Forms.Button OperationButton;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label EurLabel;
        private System.Windows.Forms.Label UsdLabel;
        private System.Windows.Forms.Label UahLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label CardStateLabel;
        private System.Windows.Forms.Panel ChatPanel;
        private System.Windows.Forms.PictureBox ChatPicture;
        private System.Windows.Forms.PictureBox CloseChatPictureBox;
        private System.Windows.Forms.Button ChatButton;
        private System.Windows.Forms.ListBox ChatListBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label label2;
    }
}

