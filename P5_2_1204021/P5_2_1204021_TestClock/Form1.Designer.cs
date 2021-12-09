namespace P5_2_1204021_TestClock
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.digitalClock1 = new P5_2_1204021.DigitalClock();
            this.UniversalTimeLabel = new System.Windows.Forms.Label();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Universal Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local Time";
            // 
            // digitalClock1
            // 
            this.digitalClock1.LocalTimeLabel_BackColor = System.Drawing.SystemColors.ControlLight;
            this.digitalClock1.Location = new System.Drawing.Point(139, 46);
            this.digitalClock1.Name = "digitalClock1";
            this.digitalClock1.Size = new System.Drawing.Size(158, 52);
            this.digitalClock1.TabIndex = 0;
            this.digitalClock1.Timer1_Enabled = true;
            this.digitalClock1.RaiseTimer1_Tick += new System.EventHandler(this.digitalClock1_RaiseTimer1_Tick);
            // 
            // UniversalTimeLabel
            // 
            this.UniversalTimeLabel.Location = new System.Drawing.Point(161, 109);
            this.UniversalTimeLabel.Name = "UniversalTimeLabel";
            this.UniversalTimeLabel.Size = new System.Drawing.Size(124, 26);
            this.UniversalTimeLabel.TabIndex = 3;
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(244, 180);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(75, 23);
            this.StartStopButton.TabIndex = 4;
            this.StartStopButton.Text = "Start/Stop";
            this.StartStopButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 272);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.UniversalTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.digitalClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private P5_2_1204021.DigitalClock digitalClock1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UniversalTimeLabel;
        private System.Windows.Forms.Button StartStopButton;
    }
}

