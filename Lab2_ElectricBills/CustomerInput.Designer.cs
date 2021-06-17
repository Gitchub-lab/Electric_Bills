
namespace Lab2_ElectricBills
{
    partial class FrmCustomerInput
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtTextFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtTextLastName = new System.Windows.Forms.TextBox();
            this.txtTextkWh = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblkWh = new System.Windows.Forms.Label();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lblTextAccntNo = new System.Windows.Forms.Label();
            this.MnuCustomerInput = new System.Windows.Forms.MenuStrip();
            this.MnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.lblkwhValidate = new System.Windows.Forms.Label();
            this.lblLastValidate = new System.Windows.Forms.Label();
            this.lblFnamevalidate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.lstClientInfo = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotBillAmtText = new System.Windows.Forms.Label();
            this.lblNumkwhText = new System.Windows.Forms.Label();
            this.lblTotBillAmt = new System.Windows.Forms.Label();
            this.lblNumkwh = new System.Windows.Forms.Label();
            this.lblNumCustText = new System.Windows.Forms.Label();
            this.lblNumcust = new System.Windows.Forms.Label();
            this.lblHeadingText = new System.Windows.Forms.Label();
            this.MnuCustomerInput.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtTextFirstName
            // 
            this.TxtTextFirstName.Location = new System.Drawing.Point(164, 68);
            this.TxtTextFirstName.Name = "TxtTextFirstName";
            this.TxtTextFirstName.Size = new System.Drawing.Size(278, 23);
            this.TxtTextFirstName.TabIndex = 0;
            this.TxtTextFirstName.DoubleClick += new System.EventHandler(this.TxtTextFirstName_DoubleClick);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(43, 68);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(105, 23);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtTextLastName
            // 
            this.txtTextLastName.Location = new System.Drawing.Point(164, 121);
            this.txtTextLastName.Name = "txtTextLastName";
            this.txtTextLastName.Size = new System.Drawing.Size(278, 23);
            this.txtTextLastName.TabIndex = 1;
            // 
            // txtTextkWh
            // 
            this.txtTextkWh.Location = new System.Drawing.Point(165, 174);
            this.txtTextkWh.Name = "txtTextkWh";
            this.txtTextkWh.Size = new System.Drawing.Size(106, 23);
            this.txtTextkWh.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(43, 121);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(105, 23);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblkWh
            // 
            this.lblkWh.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblkWh.Location = new System.Drawing.Point(44, 174);
            this.lblkWh.Name = "lblkWh";
            this.lblkWh.Size = new System.Drawing.Size(105, 23);
            this.lblkWh.TabIndex = 1;
            this.lblkWh.Text = "kWh:";
            this.lblkWh.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccountNo.Location = new System.Drawing.Point(43, 30);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(105, 23);
            this.lblAccountNo.TabIndex = 1;
            this.lblAccountNo.Text = "Account No.:";
            this.lblAccountNo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblTextAccntNo
            // 
            this.lblTextAccntNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTextAccntNo.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextAccntNo.Location = new System.Drawing.Point(164, 30);
            this.lblTextAccntNo.Name = "lblTextAccntNo";
            this.lblTextAccntNo.Size = new System.Drawing.Size(141, 23);
            this.lblTextAccntNo.TabIndex = 2;
            this.lblTextAccntNo.Text = "0";
            this.lblTextAccntNo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // MnuCustomerInput
            // 
            this.MnuCustomerInput.AutoSize = false;
            this.MnuCustomerInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MnuCustomerInput.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MnuCustomerInput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAdd,
            this.MnuDisplay,
            this.MnuExit});
            this.MnuCustomerInput.Location = new System.Drawing.Point(0, 0);
            this.MnuCustomerInput.Name = "MnuCustomerInput";
            this.MnuCustomerInput.ShowItemToolTips = true;
            this.MnuCustomerInput.Size = new System.Drawing.Size(1229, 24);
            this.MnuCustomerInput.TabIndex = 0;
            this.MnuCustomerInput.Text = "menuStrip1";
            // 
            // MnuAdd
            // 
            this.MnuAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MnuAdd.Name = "MnuAdd";
            this.MnuAdd.Size = new System.Drawing.Size(48, 20);
            this.MnuAdd.Text = "&Add";
            this.MnuAdd.ToolTipText = "Add Client info";
            this.MnuAdd.Click += new System.EventHandler(this.MnuAdd_Click);
            // 
            // MnuDisplay
            // 
            this.MnuDisplay.Name = "MnuDisplay";
            this.MnuDisplay.Size = new System.Drawing.Size(73, 20);
            this.MnuDisplay.Text = "Dis&play";
            this.MnuDisplay.ToolTipText = "Display Info";
            this.MnuDisplay.Click += new System.EventHandler(this.MnuDisplay_Click);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(48, 20);
            this.MnuExit.Text = "E&xit";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAdd.Controls.Add(this.lblkwhValidate);
            this.pnlAdd.Controls.Add(this.lblLastValidate);
            this.pnlAdd.Controls.Add(this.lblFnamevalidate);
            this.pnlAdd.Controls.Add(this.btnAdd);
            this.pnlAdd.Controls.Add(this.lblTextAccntNo);
            this.pnlAdd.Controls.Add(this.lblkWh);
            this.pnlAdd.Controls.Add(this.lblLastName);
            this.pnlAdd.Controls.Add(this.lblAccountNo);
            this.pnlAdd.Controls.Add(this.lblFirstName);
            this.pnlAdd.Controls.Add(this.txtTextkWh);
            this.pnlAdd.Controls.Add(this.txtTextLastName);
            this.pnlAdd.Controls.Add(this.TxtTextFirstName);
            this.pnlAdd.Location = new System.Drawing.Point(734, 111);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(506, 282);
            this.pnlAdd.TabIndex = 7;
            this.pnlAdd.Visible = false;
            // 
            // lblkwhValidate
            // 
            this.lblkwhValidate.BackColor = System.Drawing.Color.DarkGray;
            this.lblkwhValidate.ForeColor = System.Drawing.Color.Red;
            this.lblkwhValidate.Location = new System.Drawing.Point(166, 200);
            this.lblkwhValidate.Name = "lblkwhValidate";
            this.lblkwhValidate.Size = new System.Drawing.Size(275, 24);
            this.lblkwhValidate.TabIndex = 10;
            this.lblkwhValidate.Visible = false;
            // 
            // lblLastValidate
            // 
            this.lblLastValidate.BackColor = System.Drawing.Color.DarkGray;
            this.lblLastValidate.ForeColor = System.Drawing.Color.Red;
            this.lblLastValidate.Location = new System.Drawing.Point(165, 147);
            this.lblLastValidate.Name = "lblLastValidate";
            this.lblLastValidate.Size = new System.Drawing.Size(275, 24);
            this.lblLastValidate.TabIndex = 9;
            this.lblLastValidate.Visible = false;
            // 
            // lblFnamevalidate
            // 
            this.lblFnamevalidate.BackColor = System.Drawing.Color.DarkGray;
            this.lblFnamevalidate.ForeColor = System.Drawing.Color.Red;
            this.lblFnamevalidate.Location = new System.Drawing.Point(166, 94);
            this.lblFnamevalidate.Name = "lblFnamevalidate";
            this.lblFnamevalidate.Size = new System.Drawing.Size(275, 24);
            this.lblFnamevalidate.TabIndex = 7;
            this.lblFnamevalidate.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(230, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "&Add";
            this.toolStripMenuItem1.ToolTipText = "Add Client info";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem2.Text = "&Edit";
            this.toolStripMenuItem2.ToolTipText = "Edit/Update Client info";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(68, 20);
            this.toolStripMenuItem3.Text = "&Delete";
            this.toolStripMenuItem3.ToolTipText = "Delete Client info";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(73, 20);
            this.toolStripMenuItem4.Text = "Dis&play";
            this.toolStripMenuItem4.ToolTipText = "Display Statistics";
            // 
            // lstClientInfo
            // 
            this.lstClientInfo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstClientInfo.FormattingEnabled = true;
            this.lstClientInfo.ItemHeight = 15;
            this.lstClientInfo.Location = new System.Drawing.Point(29, 69);
            this.lstClientInfo.Name = "lstClientInfo";
            this.lstClientInfo.Size = new System.Drawing.Size(670, 304);
            this.lstClientInfo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblTotBillAmtText);
            this.panel1.Controls.Add(this.lblNumkwhText);
            this.panel1.Controls.Add(this.lblTotBillAmt);
            this.panel1.Controls.Add(this.lblNumkwh);
            this.panel1.Controls.Add(this.lblNumCustText);
            this.panel1.Controls.Add(this.lblNumcust);
            this.panel1.Location = new System.Drawing.Point(146, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 160);
            this.panel1.TabIndex = 8;
            // 
            // lblTotBillAmtText
            // 
            this.lblTotBillAmtText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotBillAmtText.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotBillAmtText.Location = new System.Drawing.Point(210, 110);
            this.lblTotBillAmtText.Name = "lblTotBillAmtText";
            this.lblTotBillAmtText.Size = new System.Drawing.Size(175, 24);
            this.lblTotBillAmtText.TabIndex = 1;
            this.lblTotBillAmtText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumkwhText
            // 
            this.lblNumkwhText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumkwhText.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumkwhText.Location = new System.Drawing.Point(210, 64);
            this.lblNumkwhText.Name = "lblNumkwhText";
            this.lblNumkwhText.Size = new System.Drawing.Size(175, 24);
            this.lblNumkwhText.TabIndex = 1;
            this.lblNumkwhText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotBillAmt
            // 
            this.lblTotBillAmt.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotBillAmt.Location = new System.Drawing.Point(13, 110);
            this.lblTotBillAmt.Name = "lblTotBillAmt";
            this.lblTotBillAmt.Size = new System.Drawing.Size(189, 24);
            this.lblTotBillAmt.TabIndex = 0;
            this.lblTotBillAmt.Text = "Average Bill Amount:";
            this.lblTotBillAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumkwh
            // 
            this.lblNumkwh.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumkwh.Location = new System.Drawing.Point(13, 64);
            this.lblNumkwh.Name = "lblNumkwh";
            this.lblNumkwh.Size = new System.Drawing.Size(189, 24);
            this.lblNumkwh.TabIndex = 0;
            this.lblNumkwh.Text = "Total No. of kWh used:";
            this.lblNumkwh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumCustText
            // 
            this.lblNumCustText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumCustText.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumCustText.Location = new System.Drawing.Point(212, 22);
            this.lblNumCustText.Name = "lblNumCustText";
            this.lblNumCustText.Size = new System.Drawing.Size(175, 24);
            this.lblNumCustText.TabIndex = 1;
            this.lblNumCustText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumcust
            // 
            this.lblNumcust.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumcust.Location = new System.Drawing.Point(15, 22);
            this.lblNumcust.Name = "lblNumcust";
            this.lblNumcust.Size = new System.Drawing.Size(189, 24);
            this.lblNumcust.TabIndex = 0;
            this.lblNumcust.Text = "Number of customers(s):";
            this.lblNumcust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeadingText
            // 
            this.lblHeadingText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeadingText.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblHeadingText.Location = new System.Drawing.Point(32, 47);
            this.lblHeadingText.Name = "lblHeadingText";
            this.lblHeadingText.Size = new System.Drawing.Size(662, 24);
            this.lblHeadingText.TabIndex = 8;
            // 
            // FrmCustomerInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1259, 624);
            this.Controls.Add(this.lblHeadingText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstClientInfo);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.MnuCustomerInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.MnuCustomerInput;
            this.Name = "FrmCustomerInput";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 30, 30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Electric Bills";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmCustomerInput_Load);
            this.MnuCustomerInput.ResumeLayout(false);
            this.MnuCustomerInput.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTextFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtTextLastName;
        private System.Windows.Forms.TextBox txtTextkWh;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblkWh;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lblTextAccntNo;
        private System.Windows.Forms.MenuStrip MnuCustomerInput;
        private System.Windows.Forms.ToolStripMenuItem MnuAdd;
        private System.Windows.Forms.ToolStripMenuItem MnuDisplay;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ListBox lstClientInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumCustText;
        private System.Windows.Forms.Label lblNumcust;
        private System.Windows.Forms.Label lblTotBillAmtText;
        private System.Windows.Forms.Label lblNumkwhText;
        private System.Windows.Forms.Label lblTotBillAmt;
        private System.Windows.Forms.Label lblNumkwh;
        private System.Windows.Forms.Label lblHeadingText;
        private System.Windows.Forms.Label lblkwhValidate;
        private System.Windows.Forms.Label lblLastValidate;
        private System.Windows.Forms.Label lblFnamevalidate;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
    }
}

