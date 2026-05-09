
namespace wowdumbcalculator
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
            this.txtWishedAmt = new System.Windows.Forms.TextBox();
            this.txtCurrentAmt = new System.Windows.Forms.TextBox();
            this.txtGamesAmt = new System.Windows.Forms.TextBox();
            this.lblGamesAmt = new System.Windows.Forms.Label();
            this.lblWishedAmt = new System.Windows.Forms.Label();
            this.lblCurrentAmt = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWishedAmt
            // 
            this.txtWishedAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWishedAmt.Location = new System.Drawing.Point(152, 12);
            this.txtWishedAmt.Name = "txtWishedAmt";
            this.txtWishedAmt.Size = new System.Drawing.Size(80, 20);
            this.txtWishedAmt.TabIndex = 0;
            // 
            // txtCurrentAmt
            // 
            this.txtCurrentAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentAmt.Location = new System.Drawing.Point(152, 38);
            this.txtCurrentAmt.Name = "txtCurrentAmt";
            this.txtCurrentAmt.Size = new System.Drawing.Size(80, 20);
            this.txtCurrentAmt.TabIndex = 1;
            this.txtCurrentAmt.Tag = "";
            // 
            // txtGamesAmt
            // 
            this.txtGamesAmt.Location = new System.Drawing.Point(192, 64);
            this.txtGamesAmt.Name = "txtGamesAmt";
            this.txtGamesAmt.ReadOnly = true;
            this.txtGamesAmt.Size = new System.Drawing.Size(40, 20);
            this.txtGamesAmt.TabIndex = 2;
            // 
            // lblGamesAmt
            // 
            this.lblGamesAmt.AutoSize = true;
            this.lblGamesAmt.Location = new System.Drawing.Point(97, 67);
            this.lblGamesAmt.Name = "lblGamesAmt";
            this.lblGamesAmt.Size = new System.Drawing.Size(89, 13);
            this.lblGamesAmt.TabIndex = 3;
            this.lblGamesAmt.Text = "Amount of games";
            // 
            // lblWishedAmt
            // 
            this.lblWishedAmt.AutoSize = true;
            this.lblWishedAmt.Location = new System.Drawing.Point(12, 14);
            this.lblWishedAmt.Name = "lblWishedAmt";
            this.lblWishedAmt.Size = new System.Drawing.Size(120, 13);
            this.lblWishedAmt.TabIndex = 4;
            this.lblWishedAmt.Text = "Wished amount of items";
            // 
            // lblCurrentAmt
            // 
            this.lblCurrentAmt.AutoSize = true;
            this.lblCurrentAmt.Location = new System.Drawing.Point(12, 38);
            this.lblCurrentAmt.Name = "lblCurrentAmt";
            this.lblCurrentAmt.Size = new System.Drawing.Size(118, 13);
            this.lblCurrentAmt.TabIndex = 5;
            this.lblCurrentAmt.Text = "Current amount of items";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 61);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "run calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 91);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblCurrentAmt);
            this.Controls.Add(this.lblWishedAmt);
            this.Controls.Add(this.lblGamesAmt);
            this.Controls.Add(this.txtGamesAmt);
            this.Controls.Add(this.txtCurrentAmt);
            this.Controls.Add(this.txtWishedAmt);
            this.Name = "Form1";
            this.Text = "Dumb calcualtor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWishedAmt;
        private System.Windows.Forms.TextBox txtCurrentAmt;
        private System.Windows.Forms.TextBox txtGamesAmt;
        private System.Windows.Forms.Label lblGamesAmt;
        private System.Windows.Forms.Label lblWishedAmt;
        private System.Windows.Forms.Label lblCurrentAmt;
        private System.Windows.Forms.Button btnCalc;
    }
}

