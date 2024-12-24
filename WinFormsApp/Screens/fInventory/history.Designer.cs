namespace WinFormsApp.MainScene.fInventory
{
    partial class history
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

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btn_close = new Button();
            a = new Label();
            dgvHistory = new DataGridView();
            txt_code = new TextBox();
            panel2 = new Panel();
            dtpEndDate = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            radiobtncode = new RadioButton();
            radiobtnNgayLap = new RadioButton();
            dtpStartDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.None;
            btn_close.AutoSize = true;
            btn_close.BackColor = SystemColors.GrayText;
            btn_close.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close.ForeColor = Color.White;
            btn_close.Location = new Point(1499, 1068);
            btn_close.Margin = new Padding(3, 4, 3, 4);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(163, 59);
            btn_close.TabIndex = 0;
            btn_close.Text = "Đóng";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a.ForeColor = SystemColors.ButtonHighlight;
            a.Location = new Point(697, 13);
            a.Name = "a";
            a.Size = new Size(365, 54);
            a.TabIndex = 1;
            a.Text = "Lịch sử nhập hàng";
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.Anchor = AnchorStyles.None;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(14, 312);
            dgvHistory.Margin = new Padding(3, 4, 3, 4);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(1690, 736);
            dgvHistory.TabIndex = 2;
            // 
            // txt_code
            // 
            txt_code.Anchor = AnchorStyles.None;
            txt_code.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_code.Location = new Point(172, 129);
            txt_code.Margin = new Padding(3, 4, 3, 4);
            txt_code.Name = "txt_code";
            txt_code.PlaceholderText = "Mã phiếu nhập, tên nhà cung cấp,...";
            txt_code.Size = new Size(667, 34);
            txt_code.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = SystemColors.GrayText;
            panel2.Controls.Add(a);
            panel2.Location = new Point(14, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1690, 89);
            panel2.TabIndex = 5;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor = AnchorStyles.None;
            dtpEndDate.Location = new Point(465, 260);
            dtpEndDate.Margin = new Padding(3, 4, 3, 4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(283, 27);
            dtpEndDate.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = SystemColors.GrayText;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(887, 129);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(129, 51);
            button1.TabIndex = 14;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1274, 129);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(129, 51);
            button2.TabIndex = 15;
            button2.Text = "Xuất";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = SystemColors.Desktop;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1081, 129);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(129, 51);
            button3.TabIndex = 16;
            button3.Text = "Làm mới";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.AutoSize = true;
            button4.BackColor = SystemColors.HotTrack;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1462, 129);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(163, 51);
            button4.TabIndex = 17;
            button4.Text = "Xem chi tiết";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // radiobtncode
            // 
            radiobtncode.AutoSize = true;
            radiobtncode.Checked = true;
            radiobtncode.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiobtncode.Location = new Point(212, 176);
            radiobtncode.Name = "radiobtncode";
            radiobtncode.Size = new Size(333, 27);
            radiobtncode.TabIndex = 18;
            radiobtncode.TabStop = true;
            radiobtncode.Text = "Tìm theo mã phiếu nhập, nhà cung cấp";
            radiobtncode.UseVisualStyleBackColor = true;
            // 
            // radiobtnNgayLap
            // 
            radiobtnNgayLap.AutoSize = true;
            radiobtnNgayLap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radiobtnNgayLap.Location = new Point(594, 176);
            radiobtnNgayLap.Name = "radiobtnNgayLap";
            radiobtnNgayLap.Size = new Size(217, 27);
            radiobtnNgayLap.TabIndex = 19;
            radiobtnNgayLap.Text = "Tìm theo ngày lập phiếu";
            radiobtnNgayLap.UseVisualStyleBackColor = true;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = AnchorStyles.None;
            dtpStartDate.Location = new Point(465, 223);
            dtpStartDate.Margin = new Padding(3, 4, 3, 4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(283, 27);
            dtpStartDate.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 223);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 21;
            label1.Text = "Start Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 265);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 22;
            label2.Text = "End Date:";
            // 
            // history
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1718, 1055);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpStartDate);
            Controls.Add(radiobtnNgayLap);
            Controls.Add(radiobtncode);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtpEndDate);
            Controls.Add(panel2);
            Controls.Add(txt_code);
            Controls.Add(dgvHistory);
            Controls.Add(btn_close);
            Name = "history";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Danh sách phiếu nhập kho vật tư phụ tùng";
            Load += History_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btn_close;
        private Label a;
        private DataGridView dgvHistory;
        private Panel panel2;
        private DateTimePicker dtpEndDate;
        private TextBox txt_code;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private RadioButton radiobtncode;
        private RadioButton radiobtnNgayLap;
        private DateTimePicker dtpStartDate;
        private Label label1;
        private Label label2;
    }
}