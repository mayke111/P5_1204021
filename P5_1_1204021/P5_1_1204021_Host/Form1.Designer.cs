namespace P5_1_1204021_Host
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
            this.numericTextBox1 = new P5_1_1204021.NumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VerticalLabel = new P5_1_1204021.VerticalLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extended Control  :  Numeric Text Box";
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.Location = new System.Drawing.Point(16, 30);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(100, 20);
            this.numericTextBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Custom Control   : Vertical Label";
            // 
            // VerticalLabel
            // 
            this.VerticalLabel.Location = new System.Drawing.Point(52, 111);
            this.VerticalLabel.Name = "VerticalLabel";
            this.VerticalLabel.Size = new System.Drawing.Size(23, 72);
            this.VerticalLabel.TabIndex = 3;
            this.VerticalLabel.Text = "Vertical Label";
            this.VerticalLabel.Click += new System.EventHandler(this.verticalLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 286);
            this.Controls.Add(this.VerticalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Control Host";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private P5_1_1204021.NumericTextBox numericTextBox1;
        private System.Windows.Forms.Label label2;
        private P5_1_1204021.VerticalLabel VerticalLabel;
    }
}

