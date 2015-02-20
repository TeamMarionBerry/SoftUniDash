namespace SoftUniDash
{
    partial class FormMenuUIScreen
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
            this.GameTitle = new System.Windows.Forms.Label();
            this.ButtonCreateCharacter = new System.Windows.Forms.Button();
            this.ButtonLoadGame = new System.Windows.Forms.Button();
            this.ButtonHightScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameTitle
            // 
            this.GameTitle.AutoSize = true;
            this.GameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameTitle.Location = new System.Drawing.Point(28, 9);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(225, 29);
            this.GameTitle.TabIndex = 0;
            this.GameTitle.Text = "SoftUni Dash RPG";
            // 
            // ButtonCreateCharacter
            // 
            this.ButtonCreateCharacter.Location = new System.Drawing.Point(60, 85);
            this.ButtonCreateCharacter.Name = "ButtonCreateCharacter";
            this.ButtonCreateCharacter.Size = new System.Drawing.Size(176, 41);
            this.ButtonCreateCharacter.TabIndex = 1;
            this.ButtonCreateCharacter.Text = "Create Character";
            this.ButtonCreateCharacter.UseVisualStyleBackColor = true;
            this.ButtonCreateCharacter.Click += new System.EventHandler(this.ButtonCreateCharacter_Click);
            // 
            // ButtonLoadGame
            // 
            this.ButtonLoadGame.Location = new System.Drawing.Point(60, 132);
            this.ButtonLoadGame.Name = "ButtonLoadGame";
            this.ButtonLoadGame.Size = new System.Drawing.Size(176, 41);
            this.ButtonLoadGame.TabIndex = 2;
            this.ButtonLoadGame.Text = "Load Game";
            this.ButtonLoadGame.UseVisualStyleBackColor = true;
            // 
            // ButtonHightScore
            // 
            this.ButtonHightScore.Location = new System.Drawing.Point(60, 179);
            this.ButtonHightScore.Name = "ButtonHightScore";
            this.ButtonHightScore.Size = new System.Drawing.Size(176, 41);
            this.ButtonHightScore.TabIndex = 3;
            this.ButtonHightScore.Text = "Hight Score";
            this.ButtonHightScore.UseVisualStyleBackColor = true;
            // 
            // FormMenuUIScreen
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ButtonHightScore);
            this.Controls.Add(this.ButtonLoadGame);
            this.Controls.Add(this.ButtonCreateCharacter);
            this.Controls.Add(this.GameTitle);
            this.Name = "FormMenuUIScreen";
            this.Text = "SoftUni Dash";
            this.Load += new System.EventHandler(this.FormMenuUIScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameTitle;
        private System.Windows.Forms.Button ButtonCreateCharacter;
        private System.Windows.Forms.Button ButtonLoadGame;
        private System.Windows.Forms.Button ButtonHightScore;
    }
}

