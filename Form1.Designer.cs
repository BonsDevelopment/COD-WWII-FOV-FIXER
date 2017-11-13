namespace CoDWWII_FoV_Fix
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
            this.fovButton = new System.Windows.Forms.Button();
            this.fovTrack = new System.Windows.Forms.TrackBar();
            this.fovLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fovTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // fovButton
            // 
            this.fovButton.Location = new System.Drawing.Point(248, 75);
            this.fovButton.Name = "fovButton";
            this.fovButton.Size = new System.Drawing.Size(77, 31);
            this.fovButton.TabIndex = 0;
            this.fovButton.Text = "Set FOV";
            this.fovButton.UseVisualStyleBackColor = true;
            this.fovButton.Click += new System.EventHandler(this.fovButton_Click);
            // 
            // fovTrack
            // 
            this.fovTrack.Location = new System.Drawing.Point(1, 12);
            this.fovTrack.Maximum = 95;
            this.fovTrack.Minimum = 50;
            this.fovTrack.Name = "fovTrack";
            this.fovTrack.Size = new System.Drawing.Size(324, 45);
            this.fovTrack.TabIndex = 1;
            this.fovTrack.Value = 65;
            this.fovTrack.Scroll += new System.EventHandler(this.fovTrack_Scroll);
            // 
            // fovLabel
            // 
            this.fovLabel.AutoSize = true;
            this.fovLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fovLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fovLabel.Location = new System.Drawing.Point(2, 55);
            this.fovLabel.Name = "fovLabel";
            this.fovLabel.Size = new System.Drawing.Size(0, 50);
            this.fovLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 113);
            this.Controls.Add(this.fovLabel);
            this.Controls.Add(this.fovTrack);
            this.Controls.Add(this.fovButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "CoD WWII FoV Fixer";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.fovTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fovButton;
        private System.Windows.Forms.TrackBar fovTrack;
        private System.Windows.Forms.Label fovLabel;
    }
}

