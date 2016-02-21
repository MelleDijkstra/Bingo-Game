namespace Bingol_Jingol
{
    partial class GameScreenWithControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreenWithControls));
            this.Title = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.turnsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.DarkRed;
            this.Title.Font = new System.Drawing.Font("Poplar Std", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Title.Location = new System.Drawing.Point(150, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(284, 76);
            this.Title.TabIndex = 0;
            this.Title.Text = "Bingol Jingol";
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.DarkRed;
            this.nextBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.nextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(467, 513);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(105, 36);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Next Turn";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // turnsLabel
            // 
            this.turnsLabel.AutoSize = true;
            this.turnsLabel.ForeColor = System.Drawing.Color.White;
            this.turnsLabel.Location = new System.Drawing.Point(464, 83);
            this.turnsLabel.Name = "turnsLabel";
            this.turnsLabel.Size = new System.Drawing.Size(35, 13);
            this.turnsLabel.TabIndex = 2;
            this.turnsLabel.Text = "label1";
            // 
            // GameScreenWithControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.turnsLabel);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameScreenWithControls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bingol Jingol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label turnsLabel;
    }
}