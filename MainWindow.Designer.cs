
namespace HorairETML
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.periodPB = new System.Windows.Forms.PictureBox();
            this.timeTick = new System.Windows.Forms.Timer(this.components);
            this.globalPeriodPB = new System.Windows.Forms.PictureBox();
            this.globalLbl = new System.Windows.Forms.Label();
            this.globalTimeLeft = new System.Windows.Forms.Label();
            this.periodTimeLeft = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.currentDate = new System.Windows.Forms.Label();
            this.moduleLbl = new System.Windows.Forms.Label();
            this.roomLbl = new System.Windows.Forms.Label();
            this.teacherLbl = new System.Windows.Forms.Label();
            this.roomDataLbl = new System.Windows.Forms.Label();
            this.teacherDataLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Button();
            this.chance = new System.Windows.Forms.Button();
            this.linkPDF = new System.Windows.Forms.LinkLabel();
            this.versionLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.normalLbl = new System.Windows.Forms.Label();
            this.restaurantButton = new System.Windows.Forms.Button();
            this.wikiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.periodPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalPeriodPB)).BeginInit();
            this.SuspendLayout();
            // 
            // periodPB
            // 
            this.periodPB.Location = new System.Drawing.Point(9, 197);
            this.periodPB.Margin = new System.Windows.Forms.Padding(2);
            this.periodPB.Name = "periodPB";
            this.periodPB.Size = new System.Drawing.Size(653, 46);
            this.periodPB.TabIndex = 0;
            this.periodPB.TabStop = false;
            // 
            // timeTick
            // 
            this.timeTick.Tick += new System.EventHandler(this.timeTick_Tick);
            // 
            // globalPeriodPB
            // 
            this.globalPeriodPB.Location = new System.Drawing.Point(9, 266);
            this.globalPeriodPB.Margin = new System.Windows.Forms.Padding(2);
            this.globalPeriodPB.Name = "globalPeriodPB";
            this.globalPeriodPB.Size = new System.Drawing.Size(653, 23);
            this.globalPeriodPB.TabIndex = 1;
            this.globalPeriodPB.TabStop = false;
            // 
            // globalLbl
            // 
            this.globalLbl.AutoSize = true;
            this.globalLbl.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.globalLbl.Location = new System.Drawing.Point(7, 248);
            this.globalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.globalLbl.Name = "globalLbl";
            this.globalLbl.Size = new System.Drawing.Size(56, 13);
            this.globalLbl.TabIndex = 2;
            this.globalLbl.Text = "[globalLbl]";
            // 
            // globalTimeLeft
            // 
            this.globalTimeLeft.AutoSize = true;
            this.globalTimeLeft.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.globalTimeLeft.Location = new System.Drawing.Point(567, 248);
            this.globalTimeLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.globalTimeLeft.Name = "globalTimeLeft";
            this.globalTimeLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.globalTimeLeft.Size = new System.Drawing.Size(83, 13);
            this.globalTimeLeft.TabIndex = 3;
            this.globalTimeLeft.Text = "[globalTimeLeft]";
            // 
            // periodTimeLeft
            // 
            this.periodTimeLeft.AutoSize = true;
            this.periodTimeLeft.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodTimeLeft.Location = new System.Drawing.Point(564, 176);
            this.periodTimeLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.periodTimeLeft.Name = "periodTimeLeft";
            this.periodTimeLeft.Size = new System.Drawing.Size(102, 17);
            this.periodTimeLeft.TabIndex = 4;
            this.periodTimeLeft.Text = "[periodTimeLeft]";
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Carlito", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime.Location = new System.Drawing.Point(9, 7);
            this.currentTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(219, 42);
            this.currentTime.TabIndex = 5;
            this.currentTime.Text = "[currentTime]";
            // 
            // currentDate
            // 
            this.currentDate.AutoSize = true;
            this.currentDate.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDate.Location = new System.Drawing.Point(253, 16);
            this.currentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(125, 24);
            this.currentDate.TabIndex = 6;
            this.currentDate.Text = "[currentDate]";
            // 
            // moduleLbl
            // 
            this.moduleLbl.AutoSize = true;
            this.moduleLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleLbl.Location = new System.Drawing.Point(12, 58);
            this.moduleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moduleLbl.Name = "moduleLbl";
            this.moduleLbl.Size = new System.Drawing.Size(91, 19);
            this.moduleLbl.TabIndex = 7;
            this.moduleLbl.Text = "[moduleLbl]";
            // 
            // roomLbl
            // 
            this.roomLbl.AutoSize = true;
            this.roomLbl.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomLbl.Location = new System.Drawing.Point(13, 92);
            this.roomLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomLbl.Name = "roomLbl";
            this.roomLbl.Size = new System.Drawing.Size(69, 18);
            this.roomLbl.TabIndex = 8;
            this.roomLbl.Text = "[roomLbl]";
            // 
            // teacherLbl
            // 
            this.teacherLbl.AutoSize = true;
            this.teacherLbl.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLbl.Location = new System.Drawing.Point(13, 118);
            this.teacherLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teacherLbl.Name = "teacherLbl";
            this.teacherLbl.Size = new System.Drawing.Size(87, 18);
            this.teacherLbl.TabIndex = 8;
            this.teacherLbl.Text = "[teacherLbll]";
            // 
            // roomDataLbl
            // 
            this.roomDataLbl.AutoSize = true;
            this.roomDataLbl.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomDataLbl.Location = new System.Drawing.Point(71, 92);
            this.roomDataLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomDataLbl.Name = "roomDataLbl";
            this.roomDataLbl.Size = new System.Drawing.Size(69, 18);
            this.roomDataLbl.TabIndex = 8;
            this.roomDataLbl.Text = "[roomLbl]";
            // 
            // teacherDataLbl
            // 
            this.teacherDataLbl.AutoSize = true;
            this.teacherDataLbl.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherDataLbl.Location = new System.Drawing.Point(71, 118);
            this.teacherDataLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teacherDataLbl.Name = "teacherDataLbl";
            this.teacherDataLbl.Size = new System.Drawing.Size(111, 18);
            this.teacherDataLbl.TabIndex = 8;
            this.teacherDataLbl.Text = "[teacherDataLbl]";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(70, 58);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(77, 19);
            this.nameLbl.TabIndex = 7;
            this.nameLbl.Text = "[nameLbl]";
            // 
            // settings
            // 
            this.settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.Location = new System.Drawing.Point(624, 7);
            this.settings.Margin = new System.Windows.Forms.Padding(2);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(42, 43);
            this.settings.TabIndex = 9;
            this.settings.TabStop = false;
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // chance
            // 
            this.chance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chance.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chance.FlatAppearance.BorderSize = 0;
            this.chance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chance.Image = ((System.Drawing.Image)(resources.GetObject("chance.Image")));
            this.chance.Location = new System.Drawing.Point(477, 90);
            this.chance.Margin = new System.Windows.Forms.Padding(2);
            this.chance.Name = "chance";
            this.chance.Size = new System.Drawing.Size(79, 82);
            this.chance.TabIndex = 10;
            this.chance.TabStop = false;
            this.chance.UseVisualStyleBackColor = true;
            this.chance.Click += new System.EventHandler(this.chance_Click);
            // 
            // linkPDF
            // 
            this.linkPDF.AutoSize = true;
            this.linkPDF.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPDF.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkPDF.Location = new System.Drawing.Point(11, 152);
            this.linkPDF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkPDF.Name = "linkPDF";
            this.linkPDF.Size = new System.Drawing.Size(28, 13);
            this.linkPDF.TabIndex = 11;
            this.linkPDF.TabStop = true;
            this.linkPDF.Text = "[pdf]";
            this.linkPDF.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPDF_LinkClicked);
            // 
            // versionLbl
            // 
            this.versionLbl.AutoSize = true;
            this.versionLbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.versionLbl.Location = new System.Drawing.Point(611, 296);
            this.versionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.versionLbl.Name = "versionLbl";
            this.versionLbl.Size = new System.Drawing.Size(37, 13);
            this.versionLbl.TabIndex = 12;
            this.versionLbl.Text = "v1.1.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(13, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Envoyez vos bugs / remarques / suggestions à l\'adresse morgane.lebre@eduvaud.ch, " +
    "merci ! :)";
            // 
            // normalLbl
            // 
            this.normalLbl.AutoSize = true;
            this.normalLbl.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalLbl.Location = new System.Drawing.Point(7, 179);
            this.normalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.normalLbl.Name = "normalLbl";
            this.normalLbl.Size = new System.Drawing.Size(61, 13);
            this.normalLbl.TabIndex = 2;
            this.normalLbl.Text = "[normalLbl]";
            // 
            // restaurantButton
            // 
            this.restaurantButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restaurantButton.FlatAppearance.BorderSize = 0;
            this.restaurantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restaurantButton.Image = ((System.Drawing.Image)(resources.GetObject("restaurantButton.Image")));
            this.restaurantButton.Location = new System.Drawing.Point(399, 97);
            this.restaurantButton.Name = "restaurantButton";
            this.restaurantButton.Size = new System.Drawing.Size(73, 68);
            this.restaurantButton.TabIndex = 14;
            this.restaurantButton.UseVisualStyleBackColor = true;
            this.restaurantButton.Click += new System.EventHandler(this.RestaurantButton_Click);
            // 
            // wikiButton
            // 
            this.wikiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wikiButton.FlatAppearance.BorderSize = 0;
            this.wikiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wikiButton.Image = ((System.Drawing.Image)(resources.GetObject("wikiButton.Image")));
            this.wikiButton.Location = new System.Drawing.Point(561, 74);
            this.wikiButton.Name = "wikiButton";
            this.wikiButton.Size = new System.Drawing.Size(57, 53);
            this.wikiButton.TabIndex = 15;
            this.wikiButton.UseVisualStyleBackColor = true;
            this.wikiButton.Click += new System.EventHandler(this.WikiButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 317);
            this.Controls.Add(this.wikiButton);
            this.Controls.Add(this.restaurantButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.versionLbl);
            this.Controls.Add(this.linkPDF);
            this.Controls.Add(this.chance);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.teacherDataLbl);
            this.Controls.Add(this.teacherLbl);
            this.Controls.Add(this.roomDataLbl);
            this.Controls.Add(this.roomLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.moduleLbl);
            this.Controls.Add(this.currentDate);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.periodTimeLeft);
            this.Controls.Add(this.globalTimeLeft);
            this.Controls.Add(this.normalLbl);
            this.Controls.Add(this.globalLbl);
            this.Controls.Add(this.globalPeriodPB);
            this.Controls.Add(this.periodPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 300);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HorairETML - v1.1.1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.periodPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalPeriodPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox periodPB;
        private System.Windows.Forms.Timer timeTick;
        private System.Windows.Forms.PictureBox globalPeriodPB;
        private System.Windows.Forms.Label globalLbl;
        private System.Windows.Forms.Label globalTimeLeft;
        private System.Windows.Forms.Label periodTimeLeft;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Label currentDate;
        private System.Windows.Forms.Label moduleLbl;
        private System.Windows.Forms.Label roomLbl;
        private System.Windows.Forms.Label teacherLbl;
        private System.Windows.Forms.Label roomDataLbl;
        private System.Windows.Forms.Label teacherDataLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button chance;
        private System.Windows.Forms.LinkLabel linkPDF;
        private System.Windows.Forms.Label versionLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label normalLbl;
        private System.Windows.Forms.Button restaurantButton;
        private System.Windows.Forms.Button wikiButton;
    }
}

