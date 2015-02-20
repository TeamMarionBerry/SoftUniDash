namespace SoftUniDash
{
    partial class FormGameScreen
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
            this.components = new System.ComponentModel.Container();
            this.mainCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.playerNameLable = new System.Windows.Forms.Label();
            this.characterTypeLable = new System.Windows.Forms.Label();
            this.Health = new System.Windows.Forms.Label();
            this.currentHealthLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCanvas
            // 
            this.mainCanvas.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.mainCanvas.Enabled = false;
            this.mainCanvas.Location = new System.Drawing.Point(12, 12);
            this.mainCanvas.Name = "mainCanvas";
            this.mainCanvas.Size = new System.Drawing.Size(635, 538);
            this.mainCanvas.TabIndex = 0;
            this.mainCanvas.TabStop = false;
            this.mainCanvas.Click += new System.EventHandler(this.canvas_Click);
            this.mainCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.mainCanvas_Paint);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Size = new System.Drawing.Size(884, 562);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(0, 0);
            this.rectangleShape1.Name = "";
            this.rectangleShape1.Size = new System.Drawing.Size(0, 0);
            // 
            // playerNameLable
            // 
            this.playerNameLable.AutoSize = true;
            this.playerNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerNameLable.Location = new System.Drawing.Point(701, 24);
            this.playerNameLable.Name = "playerNameLable";
            this.playerNameLable.Size = new System.Drawing.Size(129, 24);
            this.playerNameLable.TabIndex = 2;
            this.playerNameLable.Text = "Player Name";
            // 
            // characterTypeLable
            // 
            this.characterTypeLable.AutoSize = true;
            this.characterTypeLable.Location = new System.Drawing.Point(705, 89);
            this.characterTypeLable.Name = "characterTypeLable";
            this.characterTypeLable.Size = new System.Drawing.Size(75, 13);
            this.characterTypeLable.TabIndex = 3;
            this.characterTypeLable.Text = "characrar type";
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Health.Location = new System.Drawing.Point(718, 143);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(92, 24);
            this.Health.TabIndex = 4;
            this.Health.Text = "HEALTH";
            // 
            // currentHealthLable
            // 
            this.currentHealthLable.AutoSize = true;
            this.currentHealthLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentHealthLable.ForeColor = System.Drawing.Color.Red;
            this.currentHealthLable.Location = new System.Drawing.Point(740, 177);
            this.currentHealthLable.Name = "currentHealthLable";
            this.currentHealthLable.Size = new System.Drawing.Size(51, 26);
            this.currentHealthLable.TabIndex = 5;
            this.currentHealthLable.Text = "200";
            this.currentHealthLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.currentHealthLable);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.characterTypeLable);
            this.Controls.Add(this.playerNameLable);
            this.Controls.Add(this.mainCanvas);
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftUni Dash";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGameScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormGameScreen_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void canvas_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox mainCanvas;
        private System.Windows.Forms.Timer gameTimer;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label playerNameLable;
        private System.Windows.Forms.Label characterTypeLable;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.Label currentHealthLable;
    }
}