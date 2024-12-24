using System.ComponentModel;

namespace WinFormsApp.Screens.fReport;

partial class fBaoCaoDS
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        label1 = new System.Windows.Forms.Label();
        groupBox1 = new System.Windows.Forms.GroupBox();
        numericMonth = new System.Windows.Forms.NumericUpDown();
        btnShowBCDS = new System.Windows.Forms.Button();
        numericYear = new System.Windows.Forms.NumericUpDown();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        tb_TongDTHU = new System.Windows.Forms.TextBox();
        tableBCDS = new System.Windows.Forms.DataGridView();
        HieuXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
        SoLuotSua = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
        TiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
        btnExit = new System.Windows.Forms.Button();
        groupBox2 = new System.Windows.Forms.GroupBox();
        MaVTPT = new System.Windows.Forms.DataGridViewColumn();
        TenVTPT = new System.Windows.Forms.DataGridViewColumn();
        TonDau = new System.Windows.Forms.DataGridViewColumn();
        PhatSinh = new System.Windows.Forms.DataGridViewColumn();
        SuDung = new System.Windows.Forms.DataGridViewColumn();
        TonCuoi = new System.Windows.Forms.DataGridViewColumn();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericMonth).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericYear).BeginInit();
        ((System.ComponentModel.ISupportInitialize)tableBCDS).BeginInit();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
        label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        label1.ForeColor = System.Drawing.SystemColors.Window;
        label1.Location = new System.Drawing.Point(-2, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(1420, 91);
        label1.TabIndex = 4;
        label1.Text = "BÁO CÁO DOANH SỐ";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        label1.Click += label1_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(numericMonth);
        groupBox1.Controls.Add(btnShowBCDS);
        groupBox1.Controls.Add(numericYear);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
        groupBox1.Location = new System.Drawing.Point(12, 94);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(1394, 132);
        groupBox1.TabIndex = 5;
        groupBox1.TabStop = false;
        groupBox1.Text = "Báo cáo doanh số";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // numericMonth
        // 
        numericMonth.Location = new System.Drawing.Point(152, 56);
        numericMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
        numericMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericMonth.Name = "numericMonth";
        numericMonth.Size = new System.Drawing.Size(131, 39);
        numericMonth.TabIndex = 5;
        numericMonth.Value = new decimal(new int[] { 1, 0, 0, 0 });
        numericMonth.ValueChanged += numericMonth_ValueChanged;
        // 
        // btnShowBCDS
        // 
        btnShowBCDS.Location = new System.Drawing.Point(925, 20);
        btnShowBCDS.Name = "btnShowBCDS";
        btnShowBCDS.Size = new System.Drawing.Size(282, 101);
        btnShowBCDS.TabIndex = 4;
        btnShowBCDS.Text = "Hiện Báo Cáo";
        btnShowBCDS.UseVisualStyleBackColor = true;
        btnShowBCDS.Click += btnShowBCDS_Click;
        // 
        // numericYear
        // 
        numericYear.Location = new System.Drawing.Point(444, 56);
        numericYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
        numericYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
        numericYear.Name = "numericYear";
        numericYear.Size = new System.Drawing.Size(153, 39);
        numericYear.TabIndex = 3;
        numericYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
        numericYear.ValueChanged += numericYear_ValueChanged;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 14F);
        label3.Location = new System.Drawing.Point(336, 53);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(102, 40);
        label3.TabIndex = 2;
        label3.Text = "Năm: ";
        label3.Click += label3_Click;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 14F);
        label2.Location = new System.Drawing.Point(44, 53);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(102, 40);
        label2.TabIndex = 0;
        label2.Text = "Tháng:";
        label2.Click += label2_Click;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 14F);
        label4.Location = new System.Drawing.Point(392, 812);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(252, 40);
        label4.TabIndex = 5;
        label4.Text = "Tổng Doanh Thu:";
        label4.Click += label4_Click;
        // 
        // tb_TongDTHU
        // 
        tb_TongDTHU.Location = new System.Drawing.Point(634, 820);
        tb_TongDTHU.Name = "tb_TongDTHU";
        tb_TongDTHU.Size = new System.Drawing.Size(410, 31);
        tb_TongDTHU.TabIndex = 7;
        tb_TongDTHU.TextChanged += textBox1_TextChanged;
        // 
        // tableBCDS
        // 
        tableBCDS.AllowUserToAddRows = false;
        tableBCDS.AllowUserToDeleteRows = false;
        tableBCDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableBCDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { HieuXe, SoLuotSua, ThanhTien, TiLe });
        tableBCDS.Location = new System.Drawing.Point(6, 38);
        tableBCDS.Name = "tableBCDS";
        tableBCDS.ReadOnly = true;
        tableBCDS.RowHeadersWidth = 62;
        tableBCDS.RowTemplate.Height = 29;
        tableBCDS.Size = new System.Drawing.Size(1382, 533);
        tableBCDS.TabIndex = 1;
        // 
        // HieuXe
        // 
        HieuXe.HeaderText = "Hiệu Xe";
        HieuXe.MinimumWidth = 8;
        HieuXe.Name = "HieuXe";
        HieuXe.ReadOnly = true;
        HieuXe.Width = 329;
        // 
        // SoLuotSua
        // 
        SoLuotSua.HeaderText = "Số Lượt Sửa";
        SoLuotSua.MinimumWidth = 8;
        SoLuotSua.Name = "SoLuotSua";
        SoLuotSua.ReadOnly = true;
        SoLuotSua.Width = 329;
        // 
        // ThanhTien
        // 
        ThanhTien.HeaderText = "Thành Tiền";
        ThanhTien.MinimumWidth = 8;
        ThanhTien.Name = "ThanhTien";
        ThanhTien.ReadOnly = true;
        ThanhTien.Width = 330;
        // 
        // TiLe
        // 
        TiLe.HeaderText = "Tỉ Lệ";
        TiLe.MinimumWidth = 8;
        TiLe.Name = "TiLe";
        TiLe.ReadOnly = true;
        TiLe.Width = 330;
        // 
        // btnExit
        // 
        btnExit.Location = new System.Drawing.Point(1208, 820);
        btnExit.Name = "btnExit";
        btnExit.Size = new System.Drawing.Size(101, 30);
        btnExit.TabIndex = 9;
        btnExit.Text = "Thoát";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(tableBCDS);
        groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
        groupBox2.Location = new System.Drawing.Point(12, 232);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(1394, 577);
        groupBox2.TabIndex = 10;
        groupBox2.TabStop = false;
        groupBox2.Text = "Chi tiết báo cáo";
        // 
        // MaVTPT
        // 
        MaVTPT.HeaderText = "Mã VTPT";
        MaVTPT.MinimumWidth = 8;
        MaVTPT.Name = "MaVTPT";
        MaVTPT.ReadOnly = true;
        MaVTPT.Width = 150;
        // 
        // TenVTPT
        // 
        TenVTPT.HeaderText = "Tên VTPT";
        TenVTPT.MinimumWidth = 8;
        TenVTPT.Name = "TenVTPT";
        TenVTPT.ReadOnly = true;
        TenVTPT.Width = 150;
        // 
        // TonDau
        // 
        TonDau.HeaderText = "Tồn Đầu";
        TonDau.MinimumWidth = 8;
        TonDau.Name = "TonDau";
        TonDau.ReadOnly = true;
        TonDau.Width = 150;
        // 
        // PhatSinh
        // 
        PhatSinh.HeaderText = "Phát Sinh";
        PhatSinh.MinimumWidth = 8;
        PhatSinh.Name = "PhatSinh";
        PhatSinh.ReadOnly = true;
        PhatSinh.Width = 150;
        // 
        // SuDung
        // 
        SuDung.HeaderText = "Sử Dụng";
        SuDung.MinimumWidth = 8;
        SuDung.Name = "SuDung";
        SuDung.ReadOnly = true;
        SuDung.Width = 150;
        // 
        // TonCuoi
        // 
        TonCuoi.HeaderText = "Tồn Cuối";
        TonCuoi.MinimumWidth = 8;
        TonCuoi.Name = "TonCuoi";
        TonCuoi.ReadOnly = true;
        TonCuoi.Width = 150;
        // 
        // fBaoCaoDS
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(1418, 873);
        Controls.Add(groupBox2);
        Controls.Add(btnExit);
        Controls.Add(tb_TongDTHU);
        Controls.Add(label4);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        Text = "fBaoCaoDS";
        Load += fBaoCaoDS_Load;
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericMonth).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericYear).EndInit();
        ((System.ComponentModel.ISupportInitialize)tableBCDS).EndInit();
        groupBox2.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.DataGridViewColumn TonDau;
    private System.Windows.Forms.DataGridViewColumn PhatSinh;
    private System.Windows.Forms.DataGridViewColumn SuDung;

    private System.Windows.Forms.DataGridViewColumn TonCuoi;

    private System.Windows.Forms.DataGridViewColumn MaVTPT;
    private System.Windows.Forms.DataGridViewColumn TenVTPT;

    private System.Windows.Forms.GroupBox groupBox2;

    private System.Windows.Forms.DataGridViewTextBoxColumn SoLuotSua;
    private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    private System.Windows.Forms.DataGridViewTextBoxColumn TiLe;

    private System.Windows.Forms.DataGridViewTextBoxColumn HieuXe;

    private System.Windows.Forms.Button btnExit;

    private System.Windows.Forms.DataGridView tableBCDS;

    private System.Windows.Forms.NumericUpDown numericMonth;

    private System.Windows.Forms.TextBox tb_TongDTHU;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Button btnShowBCDS;

    private System.Windows.Forms.NumericUpDown numericYear;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Label label1;

    #endregion
}