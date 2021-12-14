namespace MediaApp
{
    partial class frmHome
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
            this.grpAccInfo = new System.Windows.Forms.GroupBox();
            this.lblAccInfo = new System.Windows.Forms.Label();
            this.grpAccountManipulation = new System.Windows.Forms.GroupBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpAccInfo.SuspendLayout();
            this.grpAccountManipulation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccInfo
            // 
            this.grpAccInfo.Controls.Add(this.lblAccInfo);
            this.grpAccInfo.Location = new System.Drawing.Point(263, 55);
            this.grpAccInfo.Name = "grpAccInfo";
            this.grpAccInfo.Size = new System.Drawing.Size(236, 280);
            this.grpAccInfo.TabIndex = 13;
            this.grpAccInfo.TabStop = false;
            this.grpAccInfo.Text = "Account Information";
            // 
            // lblAccInfo
            // 
            this.lblAccInfo.AutoSize = true;
            this.lblAccInfo.Location = new System.Drawing.Point(7, 22);
            this.lblAccInfo.Name = "lblAccInfo";
            this.lblAccInfo.Size = new System.Drawing.Size(16, 13);
            this.lblAccInfo.TabIndex = 0;
            this.lblAccInfo.Text = "...";
            // 
            // grpAccountManipulation
            // 
            this.grpAccountManipulation.Controls.Add(this.btnDeposit);
            this.grpAccountManipulation.Controls.Add(this.textBox1);
            this.grpAccountManipulation.Controls.Add(this.lblDeposit);
            this.grpAccountManipulation.Controls.Add(this.btnWithdraw);
            this.grpAccountManipulation.Controls.Add(this.txtWithdraw);
            this.grpAccountManipulation.Controls.Add(this.label2);
            this.grpAccountManipulation.Location = new System.Drawing.Point(21, 173);
            this.grpAccountManipulation.Name = "grpAccountManipulation";
            this.grpAccountManipulation.Size = new System.Drawing.Size(236, 162);
            this.grpAccountManipulation.TabIndex = 12;
            this.grpAccountManipulation.TabStop = false;
            this.grpAccountManipulation.Text = "Account Options";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(143, 122);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 12;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(24, 99);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(88, 13);
            this.lblDeposit.TabIndex = 10;
            this.lblDeposit.Text = "Deposit Amount: ";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(146, 54);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 8;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(121, 19);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(100, 20);
            this.txtWithdraw.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Withdrawl Amount: ";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 390);
            this.Controls.Add(this.grpAccInfo);
            this.Controls.Add(this.grpAccountManipulation);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.grpAccInfo.ResumeLayout(false);
            this.grpAccInfo.PerformLayout();
            this.grpAccountManipulation.ResumeLayout(false);
            this.grpAccountManipulation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccInfo;
        private System.Windows.Forms.Label lblAccInfo;
        private System.Windows.Forms.GroupBox grpAccountManipulation;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.Label label2;
    }
}