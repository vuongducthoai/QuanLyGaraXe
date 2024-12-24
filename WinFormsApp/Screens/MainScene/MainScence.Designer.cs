namespace WinFormsApp.Screens.MainScene
{
    partial class MainScence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScence));
            panel1 = new System.Windows.Forms.Panel();
            panel11 = new System.Windows.Forms.Panel();
            btnBCT = new System.Windows.Forms.Button();
            panel10 = new System.Windows.Forms.Panel();
            btnBCDS = new System.Windows.Forms.Button();
            panel8 = new System.Windows.Forms.Panel();
            bnOption = new System.Windows.Forms.Button();
            panel7 = new System.Windows.Forms.Panel();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            bnMainExit = new System.Windows.Forms.Button();
            panel6 = new System.Windows.Forms.Panel();
            bnStatistic = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            bnStaff = new System.Windows.Forms.Button();
            panel5 = new System.Windows.Forms.Panel();
            bnInventory = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            bnService = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            panel9 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            bnHome = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.SlateGray;
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(bnMainExit);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(195, 801);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnBCT);
            panel11.Location = new System.Drawing.Point(6, 578);
            panel11.Name = "panel11";
            panel11.Size = new System.Drawing.Size(189, 52);
            panel11.TabIndex = 9;
            // 
            // btnBCT
            // 
            btnBCT.Location = new System.Drawing.Point(43, 16);
            btnBCT.Name = "btnBCT";
            btnBCT.Size = new System.Drawing.Size(92, 33);
            btnBCT.TabIndex = 0;
            btnBCT.Text = "BCT";
            btnBCT.UseVisualStyleBackColor = true;
            btnBCT.Click += btnBCT_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnBCDS);
            panel10.Location = new System.Drawing.Point(4, 520);
            panel10.Name = "panel10";
            panel10.Size = new System.Drawing.Size(189, 52);
            panel10.TabIndex = 8;
            // 
            // btnBCDS
            // 
            btnBCDS.Location = new System.Drawing.Point(45, 12);
            btnBCDS.Name = "btnBCDS";
            btnBCDS.Size = new System.Drawing.Size(94, 37);
            btnBCDS.TabIndex = 0;
            btnBCDS.Text = "BCDS";
            btnBCDS.UseVisualStyleBackColor = true;
            btnBCDS.Click += btnBCDS_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(bnOption);
            panel8.Location = new System.Drawing.Point(4, 462);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(189, 52);
            panel8.TabIndex = 7;
            // 
            // bnOption
            // 
            bnOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            bnOption.Location = new System.Drawing.Point(45, 20);
            bnOption.Name = "bnOption";
            bnOption.Size = new System.Drawing.Size(94, 29);
            bnOption.TabIndex = 0;
            bnOption.Text = "Option";
            bnOption.UseVisualStyleBackColor = true;
            bnOption.Click += bnOption_Click;
            // 
            // panel7
            // 
            panel7.BackColor = System.Drawing.Color.Azure;
            panel7.Controls.Add(menuStrip1);
            panel7.Location = new System.Drawing.Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(237, 28);
            panel7.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { adminToolStripMenuItem, profileToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(237, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { logOutToolStripMenuItem });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // bnMainExit
            // 
            bnMainExit.BackColor = System.Drawing.Color.DeepSkyBlue;
            bnMainExit.Location = new System.Drawing.Point(21, 689);
            bnMainExit.Name = "bnMainExit";
            bnMainExit.Size = new System.Drawing.Size(112, 30);
            bnMainExit.TabIndex = 5;
            bnMainExit.Text = "Exit";
            bnMainExit.UseVisualStyleBackColor = false;
            bnMainExit.Click += bnMainExit_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(bnStatistic);
            panel6.Location = new System.Drawing.Point(4, 404);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(189, 52);
            panel6.TabIndex = 4;
            // 
            // bnStatistic
            // 
            bnStatistic.Anchor = System.Windows.Forms.AnchorStyles.None;
            bnStatistic.Location = new System.Drawing.Point(45, 20);
            bnStatistic.Name = "bnStatistic";
            bnStatistic.Size = new System.Drawing.Size(94, 29);
            bnStatistic.TabIndex = 0;
            bnStatistic.Text = "Statistic";
            bnStatistic.UseVisualStyleBackColor = true;
            bnStatistic.Click += bnStatistic_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(bnStaff);
            panel4.Location = new System.Drawing.Point(4, 346);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(189, 52);
            panel4.TabIndex = 3;
            // 
            // bnStaff
            // 
            bnStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            bnStaff.Location = new System.Drawing.Point(45, 20);
            bnStaff.Name = "bnStaff";
            bnStaff.Size = new System.Drawing.Size(94, 29);
            bnStaff.TabIndex = 0;
            bnStaff.Text = "Staff";
            bnStaff.UseVisualStyleBackColor = true;
            bnStaff.Click += bnStaff_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(bnInventory);
            panel5.Location = new System.Drawing.Point(4, 288);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(189, 52);
            panel5.TabIndex = 2;
            // 
            // bnInventory
            // 
            bnInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            bnInventory.Location = new System.Drawing.Point(45, 20);
            bnInventory.Name = "bnInventory";
            bnInventory.Size = new System.Drawing.Size(94, 29);
            bnInventory.TabIndex = 0;
            bnInventory.Text = "Inventory";
            bnInventory.UseVisualStyleBackColor = true;
            bnInventory.Click += bnInventory_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(bnService);
            panel3.Location = new System.Drawing.Point(4, 230);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(189, 52);
            panel3.TabIndex = 1;
            // 
            // bnService
            // 
            bnService.Anchor = System.Windows.Forms.AnchorStyles.None;
            bnService.Location = new System.Drawing.Point(45, 20);
            bnService.Name = "bnService";
            bnService.Size = new System.Drawing.Size(94, 29);
            bnService.TabIndex = 0;
            bnService.Text = "Service";
            bnService.UseVisualStyleBackColor = true;
            bnService.Click += bnService_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(bnHome);
            panel2.Location = new System.Drawing.Point(4, 172);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(189, 52);
            panel2.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(button1);
            panel9.Location = new System.Drawing.Point(8, 8);
            panel9.Name = "panel9";
            panel9.Size = new System.Drawing.Size(189, 52);
            panel9.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            button1.Location = new System.Drawing.Point(45, 20);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // bnHome
            // 
            bnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            bnHome.Location = new System.Drawing.Point(45, 20);
            bnHome.Name = "bnHome";
            bnHome.Size = new System.Drawing.Size(94, 29);
            bnHome.TabIndex = 0;
            bnHome.Text = "Home";
            bnHome.UseVisualStyleBackColor = true;
            bnHome.Click += bnHome_Click;
            // 
            // MainScence
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1509, 801);
            Controls.Add(panel1);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "AdmissionGaraOto";
            Load += MainScence_Load;
            panel1.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnBCDS;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnBCT;

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button1;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Panel panel3;
        private Button bnService;
        private Button bnHome;
        private Panel panel4;
        private Button bnStaff;
        private Panel panel5;
        private Button bnInventory;
        private Panel panel6;
        private Button bnStatistic;
        private System.Windows.Forms.Button bnMainExit;
        private Panel panel7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel8;
        private Button bnOption;
    }
}