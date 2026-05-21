namespace CapaPresentacion
{
    partial class FAbout
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAbout));
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTeamHeader = new System.Windows.Forms.Label();
            this.lblTeamNames = new System.Windows.Forms.Label();
            this.lblAcademic = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.pbLogo);
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblVersion);
            this.pnlCard.Controls.Add(this.pnlSeparator);
            this.pnlCard.Controls.Add(this.lblDescription);
            this.pnlCard.Controls.Add(this.lblTeamHeader);
            this.pnlCard.Controls.Add(this.lblTeamNames);
            this.pnlCard.Controls.Add(this.lblAcademic);
            this.pnlCard.Controls.Add(this.btnClose);
            this.pnlCard.Location = new System.Drawing.Point(167, 48);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(600, 564);
            this.pnlCard.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(225, 30);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(150, 80);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 115);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 35);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Sistema de Gestión Engage";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(0, 150);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(600, 20);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Versión 1.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.BackColor = System.Drawing.Color.LightGray;
            this.pnlSeparator.Location = new System.Drawing.Point(50, 185);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(500, 1);
            this.pnlSeparator.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescription.Location = new System.Drawing.Point(50, 205);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(500, 65);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTeamHeader
            // 
            this.lblTeamHeader.AutoSize = true;
            this.lblTeamHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
            this.lblTeamHeader.Location = new System.Drawing.Point(140, 280);
            this.lblTeamHeader.Name = "lblTeamHeader";
            this.lblTeamHeader.Size = new System.Drawing.Size(174, 22);
            this.lblTeamHeader.TabIndex = 6;
            this.lblTeamHeader.Text = "Desarrollado por:";
            // 
            // lblTeamNames
            // 
            this.lblTeamNames.AutoSize = true;
            this.lblTeamNames.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTeamNames.Location = new System.Drawing.Point(140, 310);
            this.lblTeamNames.Name = "lblTeamNames";
            this.lblTeamNames.Size = new System.Drawing.Size(314, 76);
            this.lblTeamNames.TabIndex = 7;
            this.lblTeamNames.Text = "• Jensy Morales                 -   [20240821]\r\n• Jeremy José Guevara      -   [2" +
    "0240439]\r\n• Angel Gabriel Capellán     -   [20241133]\r\n• Kevin Pichardo         " +
    "       -   [20240790]";
            // 
            // lblAcademic
            // 
            this.lblAcademic.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademic.ForeColor = System.Drawing.Color.Gray;
            this.lblAcademic.Location = new System.Drawing.Point(0, 410);
            this.lblAcademic.Name = "lblAcademic";
            this.lblAcademic.Size = new System.Drawing.Size(600, 74);
            this.lblAcademic.TabIndex = 8;
            this.lblAcademic.Text = "UCATECI - Ingeniería de Sistemas\r\nDocente: Ing. Jose Ramón Capellán María\r\nDerech" +
    "os Reservados © 2026";
            this.lblAcademic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(225, 504);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Cerrar";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(934, 646);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca del Sistema";
            this.Load += new System.EventHandler(this.FAbout_Load);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Label lblTeamHeader;
        private System.Windows.Forms.Label lblTeamNames;
        private System.Windows.Forms.Label lblAcademic;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblDescription;
    }
}