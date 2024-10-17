
namespace Devon_McManus_final_progect
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
            this.button1 = new System.Windows.Forms.Button();
            this.loadGame = new System.Windows.Forms.Button();
            this.Debug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "new game";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // loadGame
            // 
            this.loadGame.Location = new System.Drawing.Point(421, 631);
            this.loadGame.Name = "loadGame";
            this.loadGame.Size = new System.Drawing.Size(75, 23);
            this.loadGame.TabIndex = 1;
            this.loadGame.Text = "load game";
            this.loadGame.UseVisualStyleBackColor = true;
            // 
            // Debug
            // 
            this.Debug.Location = new System.Drawing.Point(840, 48);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(75, 23);
            this.Debug.TabIndex = 2;
            this.Debug.Text = "Debug";
            this.Debug.UseVisualStyleBackColor = true;
            this.Debug.Click += new System.EventHandler(this.Debug_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1123, 812);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.loadGame);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "dungeon game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loadGame;
        private System.Windows.Forms.Button Debug;
    }
}

