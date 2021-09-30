namespace HorairETML
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plusBtn = new System.Windows.Forms.Button();
            this.lessBtn = new System.Windows.Forms.Button();
            this.themeCB = new System.Windows.Forms.ComboBox();
            this.activationPercents = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paramètres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nb de décimales des pourcents";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thèmes";
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.Color.Black;
            this.plusBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.ForeColor = System.Drawing.Color.White;
            this.plusBtn.Location = new System.Drawing.Point(262, 75);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(30, 30);
            this.plusBtn.TabIndex = 2;
            this.plusBtn.TabStop = false;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = false;
            this.plusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // lessBtn
            // 
            this.lessBtn.BackColor = System.Drawing.Color.Black;
            this.lessBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lessBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessBtn.ForeColor = System.Drawing.Color.White;
            this.lessBtn.Location = new System.Drawing.Point(226, 75);
            this.lessBtn.Name = "lessBtn";
            this.lessBtn.Size = new System.Drawing.Size(30, 30);
            this.lessBtn.TabIndex = 2;
            this.lessBtn.TabStop = false;
            this.lessBtn.Text = "-";
            this.lessBtn.UseVisualStyleBackColor = false;
            this.lessBtn.Click += new System.EventHandler(this.lessBtn_Click);
            // 
            // themeCB
            // 
            this.themeCB.BackColor = System.Drawing.SystemColors.Control;
            this.themeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeCB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeCB.FormattingEnabled = true;
            this.themeCB.Location = new System.Drawing.Point(84, 112);
            this.themeCB.Name = "themeCB";
            this.themeCB.Size = new System.Drawing.Size(121, 23);
            this.themeCB.TabIndex = 3;
            this.themeCB.TabStop = false;
            this.themeCB.SelectedValueChanged += new System.EventHandler(this.themeCB_SelectedValueChanged);
            // 
            // activationPercents
            // 
            this.activationPercents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activationPercents.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activationPercents.Location = new System.Drawing.Point(12, 43);
            this.activationPercents.Name = "activationPercents";
            this.activationPercents.Size = new System.Drawing.Size(190, 27);
            this.activationPercents.TabIndex = 4;
            this.activationPercents.TabStop = false;
            this.activationPercents.Text = "Activer / Désactiver les pourcentages";
            this.activationPercents.UseVisualStyleBackColor = true;
            this.activationPercents.Click += new System.EventHandler(this.ActivationPercents_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fond";
            // 
            // backgroundCB
            // 
            this.backgroundCB.BackColor = System.Drawing.SystemColors.Control;
            this.backgroundCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.backgroundCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundCB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundCB.FormattingEnabled = true;
            this.backgroundCB.Location = new System.Drawing.Point(84, 152);
            this.backgroundCB.Name = "backgroundCB";
            this.backgroundCB.Size = new System.Drawing.Size(121, 23);
            this.backgroundCB.TabIndex = 3;
            this.backgroundCB.TabStop = false;
            this.backgroundCB.SelectedValueChanged += new System.EventHandler(this.backgroundCB_SelectedValueChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 204);
            this.Controls.Add(this.activationPercents);
            this.Controls.Add(this.backgroundCB);
            this.Controls.Add(this.themeCB);
            this.Controls.Add(this.lessBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(687, 356);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button lessBtn;
        private System.Windows.Forms.ComboBox themeCB;
        private System.Windows.Forms.Button activationPercents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox backgroundCB;
    }
}