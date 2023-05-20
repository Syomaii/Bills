namespace Bills
{
    partial class Form1
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBoxType = new System.Windows.Forms.ComboBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.lblBName = new System.Windows.Forms.Label();
            this.lblBtype = new System.Windows.Forms.Label();
            this.lblBamount = new System.Windows.Forms.Label();
            this.lblBid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(203, 293);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(138, 44);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Submit";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 36);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bills payment";
            // 
            // cbBoxType
            // 
            this.cbBoxType.FormattingEnabled = true;
            this.cbBoxType.Location = new System.Drawing.Point(288, 199);
            this.cbBoxType.Name = "cbBoxType";
            this.cbBoxType.Size = new System.Drawing.Size(171, 24);
            this.cbBoxType.TabIndex = 7;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(288, 153);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(171, 22);
            this.txtBoxName.TabIndex = 8;
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(288, 114);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(171, 22);
            this.txtBoxID.TabIndex = 9;
            // 
            // txtBoxAmount
            // 
            this.txtBoxAmount.Location = new System.Drawing.Point(288, 245);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.Size = new System.Drawing.Size(171, 22);
            this.txtBoxAmount.TabIndex = 10;
            // 
            // lblBName
            // 
            this.lblBName.AutoSize = true;
            this.lblBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBName.Location = new System.Drawing.Point(69, 153);
            this.lblBName.Name = "lblBName";
            this.lblBName.Size = new System.Drawing.Size(121, 25);
            this.lblBName.TabIndex = 2;
            this.lblBName.Text = "BILL NAME:";
            // 
            // lblBtype
            // 
            this.lblBtype.AutoSize = true;
            this.lblBtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtype.Location = new System.Drawing.Point(69, 199);
            this.lblBtype.Name = "lblBtype";
            this.lblBtype.Size = new System.Drawing.Size(115, 25);
            this.lblBtype.TabIndex = 3;
            this.lblBtype.Text = "BILL TYPE:";
            // 
            // lblBamount
            // 
            this.lblBamount.AutoSize = true;
            this.lblBamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBamount.Location = new System.Drawing.Point(69, 245);
            this.lblBamount.Name = "lblBamount";
            this.lblBamount.Size = new System.Drawing.Size(145, 25);
            this.lblBamount.TabIndex = 4;
            this.lblBamount.Text = "BILL AMOUNT";
            // 
            // lblBid
            // 
            this.lblBid.AutoSize = true;
            this.lblBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBid.Location = new System.Drawing.Point(69, 110);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(82, 25);
            this.lblBid.TabIndex = 1;
            this.lblBid.Text = "BILL ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 382);
            this.Controls.Add(this.txtBoxAmount);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.cbBoxType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBamount);
            this.Controls.Add(this.lblBtype);
            this.Controls.Add(this.lblBName);
            this.Controls.Add(this.lblBid);
            this.Controls.Add(this.btnDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBoxType;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxAmount;
        private System.Windows.Forms.Label lblBName;
        private System.Windows.Forms.Label lblBtype;
        private System.Windows.Forms.Label lblBamount;
        private System.Windows.Forms.Label lblBid;
    }
}

