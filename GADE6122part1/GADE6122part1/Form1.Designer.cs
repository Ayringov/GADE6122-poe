namespace GADE6122part1
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
            this.lblMap = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.lblStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMap
            // 
            this.lblMap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMap.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMap.Location = new System.Drawing.Point(9, 7);
            this.lblMap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(500, 373);
            this.lblMap.TabIndex = 0;
            this.lblMap.Text = "no map loaded";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(654, 302);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(56, 19);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(580, 350);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(56, 19);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click_1);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(736, 350);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(56, 19);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(654, 397);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(56, 19);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "v";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(652, 152);
            this.lblStats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(35, 13);
            this.lblStats.TabIndex = 5;
            this.lblStats.Text = "[stats]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 499);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblMap);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label lblStats;
    }
}

