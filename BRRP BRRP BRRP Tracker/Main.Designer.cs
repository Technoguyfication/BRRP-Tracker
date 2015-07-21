namespace BRRP_BRRP_BRRP_Tracker
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.PlayButton = new System.Windows.Forms.Button();
            this.BrrpTracker = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.an0nymooosebutton = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.MadeBy = new System.Windows.Forms.ToolStripMenuItem();
            this.InsipredBy = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(12, 12);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(546, 93);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // BrrpTracker
            // 
            this.BrrpTracker.AutoSize = true;
            this.BrrpTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrrpTracker.Location = new System.Drawing.Point(13, 112);
            this.BrrpTracker.Name = "BrrpTracker";
            this.BrrpTracker.Size = new System.Drawing.Size(220, 31);
            this.BrrpTracker.TabIndex = 1;
            this.BrrpTracker.Text = "BRRP Tracker: 0";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(13, 165);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(181, 31);
            this.Status.TabIndex = 2;
            this.Status.Text = "Status: Chillin";
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.an0nymooosebutton,
            this.Separator,
            this.MadeBy,
            this.InsipredBy});
            this.ContextMenu.MaximumSize = new System.Drawing.Size(250, 0);
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(231, 98);
            // 
            // an0nymooosebutton
            // 
            this.an0nymooosebutton.Image = ((System.Drawing.Image)(resources.GetObject("an0nymooosebutton.Image")));
            this.an0nymooosebutton.Name = "an0nymooosebutton";
            this.an0nymooosebutton.Size = new System.Drawing.Size(230, 22);
            this.an0nymooosebutton.Text = "an0nymooose Icon";
            this.an0nymooosebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.an0nymooosebutton.ToolTipText = "Gives you the amazing an0nymooose icon.";
            this.an0nymooosebutton.Click += new System.EventHandler(this.an0nymooosebutton_Clicked);
            // 
            // Separator
            // 
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(227, 6);
            // 
            // MadeBy
            // 
            this.MadeBy.Enabled = false;
            this.MadeBy.Name = "MadeBy";
            this.MadeBy.Size = new System.Drawing.Size(230, 22);
            this.MadeBy.Text = "Copyright Technoguyfication";
            // 
            // InsipredBy
            // 
            this.InsipredBy.Enabled = false;
            this.InsipredBy.Name = "InsipredBy";
            this.InsipredBy.Size = new System.Drawing.Size(230, 22);
            this.InsipredBy.Text = "Insipred by an0nymooose";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 270);
            this.ContextMenuStrip = this.ContextMenu;
            this.Controls.Add(this.Status);
            this.Controls.Add(this.BrrpTracker);
            this.Controls.Add(this.PlayButton);
            this.Name = "Main";
            this.Text = "BRRP BRRP BRRP Tracker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label BrrpTracker;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem an0nymooosebutton;
        private System.Windows.Forms.ToolStripSeparator Separator;
        private System.Windows.Forms.ToolStripMenuItem MadeBy;
        private System.Windows.Forms.ToolStripMenuItem InsipredBy;
    }
}

