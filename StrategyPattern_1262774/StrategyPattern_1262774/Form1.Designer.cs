namespace StrategyPattern_1262774
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
            this.btnStrategySort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStrategySort
            // 
            this.btnStrategySort.Location = new System.Drawing.Point(58, 38);
            this.btnStrategySort.Name = "btnStrategySort";
            this.btnStrategySort.Size = new System.Drawing.Size(157, 23);
            this.btnStrategySort.TabIndex = 0;
            this.btnStrategySort.Text = "btnStrategySort";
            this.btnStrategySort.UseVisualStyleBackColor = true;
            this.btnStrategySort.Click += new System.EventHandler(this.btnStrategySort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStrategySort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStrategySort;
    }
}

