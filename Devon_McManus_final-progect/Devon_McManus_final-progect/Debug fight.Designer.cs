
namespace Devon_McManus_final_progect
{
    partial class Form2
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
            this.playerName1 = new System.Windows.Forms.Label();
            this.HP1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MANA1 = new System.Windows.Forms.Label();
            this.attack1 = new System.Windows.Forms.Button();
            this.nameSide1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerName1
            // 
            this.playerName1.AutoSize = true;
            this.playerName1.Location = new System.Drawing.Point(12, 492);
            this.playerName1.Name = "playerName1";
            this.playerName1.Size = new System.Drawing.Size(35, 13);
            this.playerName1.TabIndex = 1;
            this.playerName1.Text = "label1";
            // 
            // HP1
            // 
            this.HP1.AutoSize = true;
            this.HP1.Location = new System.Drawing.Point(12, 516);
            this.HP1.Name = "HP1";
            this.HP1.Size = new System.Drawing.Size(35, 13);
            this.HP1.TabIndex = 2;
            this.HP1.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "/";
            // 
            // MANA1
            // 
            this.MANA1.AutoSize = true;
            this.MANA1.Location = new System.Drawing.Point(71, 516);
            this.MANA1.Name = "MANA1";
            this.MANA1.Size = new System.Drawing.Size(35, 13);
            this.MANA1.TabIndex = 4;
            this.MANA1.Text = "label4";
            // 
            // attack1
            // 
            this.attack1.Location = new System.Drawing.Point(13, 542);
            this.attack1.Name = "attack1";
            this.attack1.Size = new System.Drawing.Size(75, 23);
            this.attack1.TabIndex = 5;
            this.attack1.Text = "Attack";
            this.attack1.UseVisualStyleBackColor = true;
            this.attack1.Click += new System.EventHandler(this.attack1_Click);
            // 
            // nameSide1
            // 
            this.nameSide1.AutoSize = true;
            this.nameSide1.Location = new System.Drawing.Point(973, 34);
            this.nameSide1.Name = "nameSide1";
            this.nameSide1.Size = new System.Drawing.Size(35, 13);
            this.nameSide1.TabIndex = 6;
            this.nameSide1.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(976, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 642);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameSide1);
            this.Controls.Add(this.attack1);
            this.Controls.Add(this.MANA1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HP1);
            this.Controls.Add(this.playerName1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerName1;
        private System.Windows.Forms.Label HP1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MANA1;
        private System.Windows.Forms.Button attack1;
        private System.Windows.Forms.Label nameSide1;
        private System.Windows.Forms.Label label1;
    }
}