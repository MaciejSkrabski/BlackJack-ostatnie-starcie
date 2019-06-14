namespace BlackJackOstatnieStarcie
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
            this.labelC = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.buttonHit = new System.Windows.Forms.Button();
            this.buttonStand = new System.Windows.Forms.Button();
            this.labelCP = new System.Windows.Forms.Label();
            this.labelPP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelC.Location = new System.Drawing.Point(12, 79);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(133, 31);
            this.labelC.TabIndex = 0;
            this.labelC.Text = "Computer";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelY.Location = new System.Drawing.Point(81, 110);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(62, 31);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "You";
            // 
            // buttonHit
            // 
            this.buttonHit.Location = new System.Drawing.Point(103, 154);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(75, 23);
            this.buttonHit.TabIndex = 2;
            this.buttonHit.Text = "Hit";
            this.buttonHit.UseVisualStyleBackColor = true;
            this.buttonHit.Click += new System.EventHandler(this.ButtonHit_Click);
            // 
            // buttonStand
            // 
            this.buttonStand.Location = new System.Drawing.Point(184, 154);
            this.buttonStand.Name = "buttonStand";
            this.buttonStand.Size = new System.Drawing.Size(75, 23);
            this.buttonStand.TabIndex = 3;
            this.buttonStand.Text = "Stand";
            this.buttonStand.UseVisualStyleBackColor = true;
            this.buttonStand.Click += new System.EventHandler(this.ButtonStand_Click);
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelCP.Location = new System.Drawing.Point(149, 79);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(29, 31);
            this.labelCP.TabIndex = 4;
            this.labelCP.Text = "0";
            // 
            // labelPP
            // 
            this.labelPP.AutoSize = true;
            this.labelPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelPP.Location = new System.Drawing.Point(149, 110);
            this.labelPP.Name = "labelPP";
            this.labelPP.Size = new System.Drawing.Size(29, 31);
            this.labelPP.TabIndex = 5;
            this.labelPP.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 227);
            this.Controls.Add(this.labelPP);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.buttonStand);
            this.Controls.Add(this.buttonHit);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Button buttonStand;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.Label labelPP;
    }
}

