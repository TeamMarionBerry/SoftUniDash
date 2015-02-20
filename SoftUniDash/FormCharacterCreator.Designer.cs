namespace SoftUniDash
{
    partial class FormCharacterCreator
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
            this.EnterCharacterName = new System.Windows.Forms.Label();
            this.TextBoxCharacterName = new System.Windows.Forms.TextBox();
            this.ComboBoxCharacterClass = new System.Windows.Forms.ComboBox();
            this.ChooseClass = new System.Windows.Forms.Label();
            this.ButtonCreateCharacter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterCharacterName
            // 
            this.EnterCharacterName.AutoSize = true;
            this.EnterCharacterName.Location = new System.Drawing.Point(99, 30);
            this.EnterCharacterName.Name = "EnterCharacterName";
            this.EnterCharacterName.Size = new System.Drawing.Size(63, 13);
            this.EnterCharacterName.TabIndex = 0;
            this.EnterCharacterName.Text = "Enter Name";
            // 
            // TextBoxCharacterName
            // 
            this.TextBoxCharacterName.Location = new System.Drawing.Point(86, 46);
            this.TextBoxCharacterName.Name = "TextBoxCharacterName";
            this.TextBoxCharacterName.Size = new System.Drawing.Size(121, 20);
            this.TextBoxCharacterName.TabIndex = 1;
            // 
            // ComboBoxCharacterClass
            // 
            this.ComboBoxCharacterClass.FormattingEnabled = true;
            this.ComboBoxCharacterClass.Items.AddRange(new object[] {
            "Warrior ",
            "Mage",
            "Archer"});
            this.ComboBoxCharacterClass.Location = new System.Drawing.Point(86, 100);
            this.ComboBoxCharacterClass.Name = "ComboBoxCharacterClass";
            this.ComboBoxCharacterClass.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCharacterClass.TabIndex = 2;
            // 
            // ChooseClass
            // 
            this.ChooseClass.AutoSize = true;
            this.ChooseClass.Location = new System.Drawing.Point(99, 84);
            this.ChooseClass.Name = "ChooseClass";
            this.ChooseClass.Size = new System.Drawing.Size(96, 13);
            this.ChooseClass.TabIndex = 3;
            this.ChooseClass.Text = "Choose Your Class";
            // 
            // ButtonCreateCharacter
            // 
            this.ButtonCreateCharacter.Location = new System.Drawing.Point(102, 227);
            this.ButtonCreateCharacter.Name = "ButtonCreateCharacter";
            this.ButtonCreateCharacter.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreateCharacter.TabIndex = 4;
            this.ButtonCreateCharacter.Text = "Create";
            this.ButtonCreateCharacter.UseVisualStyleBackColor = true;
            this.ButtonCreateCharacter.Click += new System.EventHandler(this.ButtonCreateCharacter_Click);
            // 
            // FormCharacterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ButtonCreateCharacter);
            this.Controls.Add(this.ChooseClass);
            this.Controls.Add(this.ComboBoxCharacterClass);
            this.Controls.Add(this.TextBoxCharacterName);
            this.Controls.Add(this.EnterCharacterName);
            this.Name = "FormCharacterCreator";
            this.Text = "Create Your Character";
            this.Load += new System.EventHandler(this.FormCharacterCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterCharacterName;
        private System.Windows.Forms.TextBox TextBoxCharacterName;
        private System.Windows.Forms.ComboBox ComboBoxCharacterClass;
        private System.Windows.Forms.Label ChooseClass;
        private System.Windows.Forms.Button ButtonCreateCharacter;
    }
}