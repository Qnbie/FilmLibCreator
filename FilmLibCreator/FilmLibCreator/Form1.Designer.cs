namespace FilmLibCreator
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
            this.tbFilmTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nSceneNumber = new System.Windows.Forms.NumericUpDown();
            this.bCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvCharacters = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNewCharacter = new System.Windows.Forms.TextBox();
            this.tbNewProp = new System.Windows.Forms.TextBox();
            this.bAddCharacter = new System.Windows.Forms.Button();
            this.bAddProp = new System.Windows.Forms.Button();
            this.lvProps = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.bDeleteCharacter = new System.Windows.Forms.Button();
            this.bDeleteProp = new System.Windows.Forms.Button();
            this.bBrowser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nSceneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFilmTitle
            // 
            this.tbFilmTitle.Location = new System.Drawing.Point(89, 6);
            this.tbFilmTitle.Name = "tbFilmTitle";
            this.tbFilmTitle.Size = new System.Drawing.Size(163, 20);
            this.tbFilmTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Scene";
            // 
            // nSceneNumber
            // 
            this.nSceneNumber.Location = new System.Drawing.Point(455, 7);
            this.nSceneNumber.Name = "nSceneNumber";
            this.nSceneNumber.Size = new System.Drawing.Size(120, 20);
            this.nSceneNumber.TabIndex = 3;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(18, 340);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(557, 83);
            this.bCreate.TabIndex = 19;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.BCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Path";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(89, 43);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(486, 20);
            this.tbPath.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Characters:";
            // 
            // lvCharacters
            // 
            this.lvCharacters.Location = new System.Drawing.Point(15, 208);
            this.lvCharacters.Name = "lvCharacters";
            this.lvCharacters.Size = new System.Drawing.Size(251, 72);
            this.lvCharacters.TabIndex = 11;
            this.lvCharacters.UseCompatibleStateImageBehavior = false;
            this.lvCharacters.View = System.Windows.Forms.View.List;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "New Character";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "New Prop";
            // 
            // tbNewCharacter
            // 
            this.tbNewCharacter.Location = new System.Drawing.Point(146, 138);
            this.tbNewCharacter.Name = "tbNewCharacter";
            this.tbNewCharacter.Size = new System.Drawing.Size(120, 20);
            this.tbNewCharacter.TabIndex = 8;
            // 
            // tbNewProp
            // 
            this.tbNewProp.Location = new System.Drawing.Point(455, 138);
            this.tbNewProp.Name = "tbNewProp";
            this.tbNewProp.Size = new System.Drawing.Size(120, 20);
            this.tbNewProp.TabIndex = 14;
            // 
            // bAddCharacter
            // 
            this.bAddCharacter.Location = new System.Drawing.Point(99, 164);
            this.bAddCharacter.Name = "bAddCharacter";
            this.bAddCharacter.Size = new System.Drawing.Size(110, 23);
            this.bAddCharacter.TabIndex = 9;
            this.bAddCharacter.Text = "Add Character";
            this.bAddCharacter.UseVisualStyleBackColor = true;
            this.bAddCharacter.Click += new System.EventHandler(this.BAddCharacter_Click);
            // 
            // bAddProp
            // 
            this.bAddProp.Location = new System.Drawing.Point(418, 164);
            this.bAddProp.Name = "bAddProp";
            this.bAddProp.Size = new System.Drawing.Size(75, 23);
            this.bAddProp.TabIndex = 15;
            this.bAddProp.Text = "Add Prop";
            this.bAddProp.UseVisualStyleBackColor = true;
            this.bAddProp.Click += new System.EventHandler(this.BAddProp_Click);
            // 
            // lvProps
            // 
            this.lvProps.Location = new System.Drawing.Point(324, 208);
            this.lvProps.Name = "lvProps";
            this.lvProps.Size = new System.Drawing.Size(251, 72);
            this.lvProps.TabIndex = 17;
            this.lvProps.UseCompatibleStateImageBehavior = false;
            this.lvProps.View = System.Windows.Forms.View.List;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Props:";
            // 
            // bDeleteCharacter
            // 
            this.bDeleteCharacter.Location = new System.Drawing.Point(15, 287);
            this.bDeleteCharacter.Name = "bDeleteCharacter";
            this.bDeleteCharacter.Size = new System.Drawing.Size(204, 23);
            this.bDeleteCharacter.TabIndex = 12;
            this.bDeleteCharacter.Text = "Delete Character";
            this.bDeleteCharacter.UseVisualStyleBackColor = true;
            this.bDeleteCharacter.Click += new System.EventHandler(this.BDeleteCharacter_Click);
            // 
            // bDeleteProp
            // 
            this.bDeleteProp.Location = new System.Drawing.Point(324, 286);
            this.bDeleteProp.Name = "bDeleteProp";
            this.bDeleteProp.Size = new System.Drawing.Size(75, 23);
            this.bDeleteProp.TabIndex = 18;
            this.bDeleteProp.Text = "Delete Prop";
            this.bDeleteProp.UseVisualStyleBackColor = true;
            this.bDeleteProp.Click += new System.EventHandler(this.BDeleteProp_Click);
            // 
            // bBrowser
            // 
            this.bBrowser.Location = new System.Drawing.Point(18, 78);
            this.bBrowser.Name = "bBrowser";
            this.bBrowser.Size = new System.Drawing.Size(557, 27);
            this.bBrowser.TabIndex = 6;
            this.bBrowser.Text = "Browser";
            this.bBrowser.UseVisualStyleBackColor = true;
            this.bBrowser.Click += new System.EventHandler(this.BBrowser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 463);
            this.Controls.Add(this.bBrowser);
            this.Controls.Add(this.bDeleteProp);
            this.Controls.Add(this.bDeleteCharacter);
            this.Controls.Add(this.lvProps);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bAddProp);
            this.Controls.Add(this.bAddCharacter);
            this.Controls.Add(this.tbNewProp);
            this.Controls.Add(this.tbNewCharacter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvCharacters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.nSceneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFilmTitle);
            this.Name = "Form1";
            this.Text = "FilmLibCreator";
            ((System.ComponentModel.ISupportInitialize)(this.nSceneNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilmTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nSceneNumber;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvCharacters;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNewCharacter;
        private System.Windows.Forms.TextBox tbNewProp;
        private System.Windows.Forms.Button bAddCharacter;
        private System.Windows.Forms.Button bAddProp;
        private System.Windows.Forms.ListView lvProps;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bDeleteCharacter;
        private System.Windows.Forms.Button bDeleteProp;
        private System.Windows.Forms.Button bBrowser;
    }
}

