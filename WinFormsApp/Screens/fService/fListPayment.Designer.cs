namespace WinFormsApp.Screens.Service.ListPayment
{
    partial class fListPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fListPayment));
            txtSearch = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            dtgvPaymentList = new DataGridView();
            panel3 = new Panel();
            btnRefresh = new Button();
            dtpSearchByDate = new DateTimePicker();
            btnSearch = new Button();
            label2 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPaymentList).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.HighlightText;
            txtSearch.Location = new Point(272, 87);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(527, 27);
            txtSearch.TabIndex = 6;
            txtSearch.Text = "Nhập biển số xe";
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1073, 66);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(283, 9);
            label1.Name = "label1";
            label1.Size = new Size(504, 50);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH PHIẾU THU TIỀN";
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvPaymentList);
            panel1.Location = new Point(14, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 453);
            panel1.TabIndex = 4;
            // 
            // dtgvPaymentList
            // 
            dtgvPaymentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPaymentList.Dock = DockStyle.Fill;
            dtgvPaymentList.Location = new Point(0, 0);
            dtgvPaymentList.Name = "dtgvPaymentList";
            dtgvPaymentList.RowHeadersWidth = 51;
            dtgvPaymentList.Size = new Size(1046, 453);
            dtgvPaymentList.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(dtpSearchByDate);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(14, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(1046, 81);
            panel3.TabIndex = 7;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.GradientActiveCaption;
            btnRefresh.Location = new Point(910, 24);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(89, 54);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dtpSearchByDate
            // 
            dtpSearchByDate.Format = DateTimePickerFormat.Short;
            dtpSearchByDate.Location = new Point(393, 43);
            dtpSearchByDate.Name = "dtpSearchByDate";
            dtpSearchByDate.Size = new Size(250, 27);
            dtpSearchByDate.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Info;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(789, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 9);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 0;
            label2.Text = "Tìm kiếm:";
            // 
            // fListPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 617);
            Controls.Add(txtSearch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "fListPayment";
            Text = "fListPayment";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvPaymentList).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private DataGridView dtgvPaymentList;
        private Panel panel3;
        private Button btnRefresh;
        private DateTimePicker dtpSearchByDate;
        private Button btnSearch;
        private Label label2;
    }
}