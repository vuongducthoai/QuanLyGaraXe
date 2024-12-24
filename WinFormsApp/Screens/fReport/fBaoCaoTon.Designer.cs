using System.ComponentModel;

namespace WinFormsApp.Screens.fReport;

partial class fBaoCaoTon
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
        numericYear = new System.Windows.Forms.NumericUpDown();
        numericMonth = new System.Windows.Forms.NumericUpDown();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        btnShowBCTK = new System.Windows.Forms.Button();
        groupBox2 = new System.Windows.Forms.GroupBox();
        tableBCTK = new System.Windows.Forms.DataGridView();
        MaVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
        TenVTPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
        TonDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
        SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
        SoLuongSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
        btnExit = new System.Windows.Forms.Button();
        TonCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericYear).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericMonth).BeginInit();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tableBCTK).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
        label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        label1.ForeColor = System.Drawing.SystemColors.Window;
        label1.Location = new System.Drawing.Point(-2, -3);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(1409, 96);
        label1.TabIndex = 0;
        label1.Text = "BÁO CÁO TỒN KHO";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(numericYear);
        groupBox1.Controls.Add(numericMonth);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(btnShowBCTK);
        groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
        groupBox1.Location = new System.Drawing.Point(12, 96);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(1384, 149);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "Báo cáo tồn kho";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // numericYear
        // 
        numericYear.Location = new System.Drawing.Point(532, 61);
        numericYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
        numericYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
        numericYear.Name = "numericYear";
        numericYear.Size = new System.Drawing.Size(178, 39);
        numericYear.TabIndex = 4;
        numericYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
        // 
        // numericMonth
        // 
        numericMonth.Location = new System.Drawing.Point(175, 61);
        numericMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
        numericMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericMonth.Name = "numericMonth";
        numericMonth.Size = new System.Drawing.Size(156, 39);
        numericMonth.TabIndex = 3;
        numericMonth.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(426, 63);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 36);
        label3.TabIndex = 2;
        label3.Text = "Năm:";
        label3.Click += label3_Click;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(69, 61);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 36);
        label2.TabIndex = 1;
        label2.Text = "Tháng:";
        // 
        // btnShowBCTK
        // 
        btnShowBCTK.Location = new System.Drawing.Point(896, 31);
        btnShowBCTK.Name = "btnShowBCTK";
        btnShowBCTK.Size = new System.Drawing.Size(278, 92);
        btnShowBCTK.TabIndex = 0;
        btnShowBCTK.Text = "Hiện báo cáo";
        btnShowBCTK.UseVisualStyleBackColor = true;
        btnShowBCTK.Click += btnShowBCTK_Click;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(tableBCTK);
        groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
        groupBox2.Location = new System.Drawing.Point(12, 251);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(1384, 498);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "Chi tiết báo cáo";
        // 
        // tableBCTK
        // 
        tableBCTK.AllowUserToAddRows = false;
        tableBCTK.AllowUserToDeleteRows = false;
        tableBCTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableBCTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { MaVTPT, TenVTPT, TonDau, SoLuongNhap, SoLuongSuDung, TonCuoi });
        tableBCTK.Location = new System.Drawing.Point(6, 38);
        tableBCTK.Name = "tableBCTK";
        tableBCTK.RowHeadersWidth = 62;
        tableBCTK.Size = new System.Drawing.Size(1372, 454);
        tableBCTK.TabIndex = 1;
        // 
        // MaVTPT
        // 
        MaVTPT.HeaderText = "Mã VTPT";
        MaVTPT.MinimumWidth = 8;
        MaVTPT.Name = "MaVTPT";
        MaVTPT.Width = 220;
        // 
        // TenVTPT
        // 
        TenVTPT.HeaderText = "Tên VTPT";
        TenVTPT.MinimumWidth = 8;
        TenVTPT.Name = "TenVTPT";
        TenVTPT.Width = 220;
        // 
        // TonDau
        // 
        TonDau.HeaderText = "Tồn Đầu";
        TonDau.MinimumWidth = 8;
        TonDau.Name = "TonDau";
        TonDau.Width = 217;
        // 
        // SoLuongNhap
        // 
        SoLuongNhap.HeaderText = "Số Lượng Nhập";
        SoLuongNhap.MinimumWidth = 8;
        SoLuongNhap.Name = "SoLuongNhap";
        SoLuongNhap.Width = 217;
        // 
        // SoLuongSuDung
        // 
        SoLuongSuDung.HeaderText = "SoLuongSuDung";
        SoLuongSuDung.MinimumWidth = 8;
        SoLuongSuDung.Name = "SoLuongSuDung";
        SoLuongSuDung.Width = 217;
        // 
        // btnExit
        // 
        btnExit.Location = new System.Drawing.Point(1243, 770);
        btnExit.Name = "btnExit";
        btnExit.Size = new System.Drawing.Size(91, 39);
        btnExit.TabIndex = 3;
        btnExit.Text = "Thoát";
        btnExit.UseVisualStyleBackColor = true;
        // 
        // TonCuoi
        // 
        TonCuoi.HeaderText = "Tồn Cuối";
        TonCuoi.MinimumWidth = 8;
        TonCuoi.Name = "TonCuoi";
        TonCuoi.Width = 217;
        // 
        // fBaoCaoTon
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1408, 821);
        Controls.Add(btnExit);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        Text = "fBaoCaoTon";
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericYear).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericMonth).EndInit();
        groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)tableBCTK).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridViewTextBoxColumn MaVTPT;
    private System.Windows.Forms.DataGridViewTextBoxColumn TenVTPT;
    private System.Windows.Forms.DataGridViewTextBoxColumn TonDau;
    private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
    private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSuDung;
    private System.Windows.Forms.DataGridViewTextBoxColumn TonCuoi;

    private System.Windows.Forms.DataGridView tableBCTK;

    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button btnShowBCTK;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown numericMonth;
    private System.Windows.Forms.NumericUpDown numericYear;

    private System.Windows.Forms.GroupBox groupBox2;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Label label1;

    #endregion
}