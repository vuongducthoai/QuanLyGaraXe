namespace WinFormsApp.Screens.fInventory
{
    partial class ct_history
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
            dgvCTPN = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtMaPN = new TextBox();
            label2 = new Label();
            datetimepiker = new DateTimePicker();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCTPN).BeginInit();
            SuspendLayout();
            // 
            // dgvCTPN
            // 
            dgvCTPN.AllowUserToAddRows = false;
            dgvCTPN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTPN.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvCTPN.Location = new Point(15, 68);
            dgvCTPN.Name = "dgvCTPN";
            dgvCTPN.RowHeadersWidth = 51;
            dgvCTPN.Size = new Size(1013, 443);
            dgvCTPN.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã VTPT";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên VTPT";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Đơn giá nhập";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 21);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 1;
            label1.Text = "Mã phiếu nhập:";
            // 
            // txtMaPN
            // 
            txtMaPN.Location = new Point(261, 22);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.Size = new Size(229, 27);
            txtMaPN.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(540, 24);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 3;
            label2.Text = "Ngày nhập:";
            // 
            // datetimepiker
            // 
            datetimepiker.Location = new Point(681, 24);
            datetimepiker.Name = "datetimepiker";
            datetimepiker.Size = new Size(276, 27);
            datetimepiker.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(883, 529);
            button1.Name = "button1";
            button1.Size = new Size(122, 37);
            button1.TabIndex = 5;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            // 
            // ct_history
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 578);
            Controls.Add(button1);
            Controls.Add(datetimepiker);
            Controls.Add(label2);
            Controls.Add(txtMaPN);
            Controls.Add(label1);
            Controls.Add(dgvCTPN);
            Name = "ct_history";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu nhập vật tư phụ tụng";
            Load += ct_history_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCTPN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCTPN;
        private Label label1;
        private TextBox txtMaPN;
        private Label label2;
        private DateTimePicker datetimepiker;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}