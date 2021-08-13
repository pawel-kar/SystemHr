
namespace SystemHR.UserInterface.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.btnPositions = new System.Windows.Forms.Button();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.btnSalaries = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnOrganizationalStructure = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnContracts = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDataBase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.pMain = new System.Windows.Forms.Panel();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tcMain.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpGeneral);
            this.tcMain.Controls.Add(this.tpConfiguration);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(872, 75);
            this.tcMain.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.btnPositions);
            this.tpGeneral.Controls.Add(this.splitter5);
            this.tpGeneral.Controls.Add(this.btnDepartments);
            this.tpGeneral.Controls.Add(this.splitter4);
            this.tpGeneral.Controls.Add(this.btnSalaries);
            this.tpGeneral.Controls.Add(this.splitter3);
            this.tpGeneral.Controls.Add(this.btnOrganizationalStructure);
            this.tpGeneral.Controls.Add(this.splitter2);
            this.tpGeneral.Controls.Add(this.btnContracts);
            this.tpGeneral.Controls.Add(this.splitter1);
            this.tpGeneral.Controls.Add(this.btnEmployees);
            this.tpGeneral.Location = new System.Drawing.Point(4, 32);
            this.tpGeneral.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpGeneral.Size = new System.Drawing.Size(864, 39);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Ogólne";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // btnPositions
            // 
            this.btnPositions.BackColor = System.Drawing.Color.White;
            this.btnPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPositions.Image = ((System.Drawing.Image)(resources.GetObject("btnPositions.Image")));
            this.btnPositions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPositions.Location = new System.Drawing.Point(697, 3);
            this.btnPositions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPositions.Name = "btnPositions";
            this.btnPositions.Size = new System.Drawing.Size(165, 33);
            this.btnPositions.TabIndex = 10;
            this.btnPositions.Text = "Stanowiska";
            this.btnPositions.UseVisualStyleBackColor = false;
            // 
            // splitter5
            // 
            this.splitter5.Location = new System.Drawing.Point(692, 3);
            this.splitter5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(5, 33);
            this.splitter5.TabIndex = 9;
            this.splitter5.TabStop = false;
            // 
            // btnDepartments
            // 
            this.btnDepartments.BackColor = System.Drawing.Color.White;
            this.btnDepartments.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDepartments.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartments.Image")));
            this.btnDepartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartments.Location = new System.Drawing.Point(602, 3);
            this.btnDepartments.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(90, 33);
            this.btnDepartments.TabIndex = 8;
            this.btnDepartments.Text = "Działy";
            this.btnDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepartments.UseVisualStyleBackColor = false;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(597, 3);
            this.splitter4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(5, 33);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // btnSalaries
            // 
            this.btnSalaries.BackColor = System.Drawing.Color.White;
            this.btnSalaries.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalaries.Image = ((System.Drawing.Image)(resources.GetObject("btnSalaries.Image")));
            this.btnSalaries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaries.Location = new System.Drawing.Point(457, 3);
            this.btnSalaries.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalaries.Name = "btnSalaries";
            this.btnSalaries.Size = new System.Drawing.Size(140, 33);
            this.btnSalaries.TabIndex = 6;
            this.btnSalaries.Text = "Wynagrodzenia";
            this.btnSalaries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalaries.UseVisualStyleBackColor = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(452, 3);
            this.splitter3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(5, 33);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // btnOrganizationalStructure
            // 
            this.btnOrganizationalStructure.BackColor = System.Drawing.Color.White;
            this.btnOrganizationalStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrganizationalStructure.Image = ((System.Drawing.Image)(resources.GetObject("btnOrganizationalStructure.Image")));
            this.btnOrganizationalStructure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganizationalStructure.Location = new System.Drawing.Point(252, 3);
            this.btnOrganizationalStructure.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOrganizationalStructure.Name = "btnOrganizationalStructure";
            this.btnOrganizationalStructure.Size = new System.Drawing.Size(200, 33);
            this.btnOrganizationalStructure.TabIndex = 4;
            this.btnOrganizationalStructure.Text = "Struktura organizacyjna";
            this.btnOrganizationalStructure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrganizationalStructure.UseVisualStyleBackColor = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(247, 3);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 33);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // btnContracts
            // 
            this.btnContracts.BackColor = System.Drawing.Color.White;
            this.btnContracts.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnContracts.Image = ((System.Drawing.Image)(resources.GetObject("btnContracts.Image")));
            this.btnContracts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContracts.Location = new System.Drawing.Point(127, 3);
            this.btnContracts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(120, 33);
            this.btnContracts.TabIndex = 2;
            this.btnContracts.Text = "Umowy";
            this.btnContracts.UseVisualStyleBackColor = false;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(122, 3);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 33);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.White;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(2, 3);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(120, 33);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "Pracownicy";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Location = new System.Drawing.Point(4, 32);
            this.tpConfiguration.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpConfiguration.Size = new System.Drawing.Size(864, 39);
            this.tpConfiguration.TabIndex = 1;
            this.tpConfiguration.Text = "Konfiguracja";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslDataBase,
            this.tsslUser});
            this.ssMain.Location = new System.Drawing.Point(0, 527);
            this.ssMain.Name = "ssMain";
            this.ssMain.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.ssMain.Size = new System.Drawing.Size(872, 26);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(98, 20);
            this.tsslVersion.Text = "Wersja 1.0.0.0";
            // 
            // tsslDataBase
            // 
            this.tsslDataBase.Image = ((System.Drawing.Image)(resources.GetObject("tsslDataBase.Image")));
            this.tsslDataBase.Name = "tsslDataBase";
            this.tsslDataBase.Size = new System.Drawing.Size(176, 20);
            this.tsslDataBase.Text = "Baza: HumanResource";
            // 
            // tsslUser
            // 
            this.tsslUser.Image = ((System.Drawing.Image)(resources.GetObject("tsslUser.Image")));
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(184, 20);
            this.tsslUser.Text = "Użytkownik: Bruta Pawa";
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.Controls.Add(this.tcTabs);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 75);
            this.pMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(872, 452);
            this.pMain.TabIndex = 2;
            // 
            // tcTabs
            // 
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcTabs.Location = new System.Drawing.Point(0, 0);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(872, 452);
            this.tcTabs.TabIndex = 0;
            this.tcTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcTabs_DrawItem);
            this.tcTabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tcTabs_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 553);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemHR";
            this.tcMain.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.Button btnPositions;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button btnSalaries;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnOrganizationalStructure;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslDataBase;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.TabControl tcTabs;
    }
}