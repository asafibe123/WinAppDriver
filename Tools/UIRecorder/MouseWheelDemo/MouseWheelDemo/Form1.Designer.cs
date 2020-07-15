namespace MouseWheelDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LinesLabel = new System.Windows.Forms.Label();
            this.TotalDeltaLabel = new System.Windows.Forms.Label();
            this.DeltaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Delta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lines";
            // 
            // LinesLabel
            // 
            this.LinesLabel.AutoSize = true;
            this.LinesLabel.Location = new System.Drawing.Point(82, 53);
            this.LinesLabel.Name = "LinesLabel";
            this.LinesLabel.Size = new System.Drawing.Size(13, 13);
            this.LinesLabel.TabIndex = 5;
            this.LinesLabel.Text = "0";
            // 
            // TotalDeltaLabel
            // 
            this.TotalDeltaLabel.AutoSize = true;
            this.TotalDeltaLabel.Location = new System.Drawing.Point(82, 31);
            this.TotalDeltaLabel.Name = "TotalDeltaLabel";
            this.TotalDeltaLabel.Size = new System.Drawing.Size(13, 13);
            this.TotalDeltaLabel.TabIndex = 4;
            this.TotalDeltaLabel.Text = "0";
            // 
            // DeltaLabel
            // 
            this.DeltaLabel.AutoSize = true;
            this.DeltaLabel.Location = new System.Drawing.Point(82, 9);
            this.DeltaLabel.Name = "DeltaLabel";
            this.DeltaLabel.Size = new System.Drawing.Size(13, 13);
            this.DeltaLabel.TabIndex = 3;
            this.DeltaLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 178);
            this.Controls.Add(this.LinesLabel);
            this.Controls.Add(this.TotalDeltaLabel);
            this.Controls.Add(this.DeltaLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mouse Wheel Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LinesLabel;
        private System.Windows.Forms.Label TotalDeltaLabel;
        private System.Windows.Forms.Label DeltaLabel;
    }
}

