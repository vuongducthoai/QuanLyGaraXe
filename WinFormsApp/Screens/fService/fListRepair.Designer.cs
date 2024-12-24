namespace WinFormsApp.Screens.Service.ListRepair
{
    partial class fListRepair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fListRepair));
            panel1 = new Panel();
            dtgvRepairList = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            txtSearch = new TextBox();
            panel3 = new Panel();
            btnRefresh = new Button();
            dtpSearchByDate = new DateTimePicker();
            btnSearch = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRepairList).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvRepairList);
            panel1.Location = new Point(12, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 453);
            panel1.TabIndex = 0;
            // 
            // dtgvRepairList
            // 
            dtgvRepairList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRepairList.Dock = DockStyle.Fill;
            dtgvRepairList.Location = new Point(0, 0);
            dtgvRepairList.Name = "dtgvRepairList";
            dtgvRepairList.RowHeadersWidth = 51;
            dtgvRepairList.Size = new Size(1046, 453);
            dtgvRepairList.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1073, 66);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 9);
            label1.Name = "label1";
            label1.Size = new Size(527, 50);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH PHIẾU SỬA CHỮA";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.HighlightText;
            txtSearch.Location = new Point(268, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(527, 27);
            txtSearch.TabIndex = 2;
            txtSearch.Text = "Nhập biển số xe";
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(dtpSearchByDate);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(12, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(1046, 81);
            panel3.TabIndex = 3;
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
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dtpSearchByDate
            // 
            dtpSearchByDate.Format = DateTimePickerFormat.Short;
            dtpSearchByDate.Location = new Point(393, 43);
            dtpSearchByDate.Name = "dtpSearchByDate";
            dtpSearchByDate.Size = new Size(250, 27);
            dtpSearchByDate.TabIndex = 2;
            dtpSearchByDate.Leave += btnRefresh_Leave;
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
            btnSearch.Click += btnSearch_Click;
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
            // fListRepair
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 622);
            Controls.Add(txtSearch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "fListRepair";
            StartPosition = FormStartPosition.CenterParent;
            Text = "fListRepair";
            Load += fListRepair_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvRepairList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dtgvRepairList;
        private Panel panel2;
        private Label label1;
        private TextBox txtSearch;
        private Panel panel3;
        private Button btnSearch;
        private Label label2;
        private Button btnRefresh;
        private DateTimePicker dtpSearchByDate;
    }
}