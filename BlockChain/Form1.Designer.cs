namespace BlockChain
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
            this.ADD = new System.Windows.Forms.Button();
            this.DETAILS = new System.Windows.Forms.Button();
            this.btnBlockChain = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ADD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD.ForeColor = System.Drawing.Color.White;
            this.ADD.Location = new System.Drawing.Point(286, 129);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(194, 36);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // DETAILS
            // 
            this.DETAILS.BackColor = System.Drawing.Color.Red;
            this.DETAILS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DETAILS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DETAILS.Location = new System.Drawing.Point(286, 188);
            this.DETAILS.Name = "DETAILS";
            this.DETAILS.Size = new System.Drawing.Size(194, 36);
            this.DETAILS.TabIndex = 1;
            this.DETAILS.Text = "BlockData";
            this.DETAILS.UseVisualStyleBackColor = false;
            this.DETAILS.Click += new System.EventHandler(this.DETAILS_Click);
            // 
            // btnBlockChain
            // 
            this.btnBlockChain.BackColor = System.Drawing.Color.Blue;
            this.btnBlockChain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockChain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBlockChain.Location = new System.Drawing.Point(286, 258);
            this.btnBlockChain.Name = "btnBlockChain";
            this.btnBlockChain.Size = new System.Drawing.Size(194, 36);
            this.btnBlockChain.TabIndex = 2;
            this.btnBlockChain.Text = "BlockChain";
            this.btnBlockChain.UseVisualStyleBackColor = false;
            this.btnBlockChain.Click += new System.EventHandler(this.btnBlockChain_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(286, 327);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(194, 36);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(167, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Which Funtion do you want to perform?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnBlockChain);
            this.Controls.Add(this.DETAILS);
            this.Controls.Add(this.ADD);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button DETAILS;
        private System.Windows.Forms.Button btnBlockChain;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
    }
}

