namespace FLVER_EDITOR
{
    partial class SettingsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsView));
            this.group_general = new System.Windows.Forms.GroupBox();
            this.check_legacyRender = new System.Windows.Forms.CheckBox();
            this.check_showRenderWindow = new System.Windows.Forms.CheckBox();
            this.check_loadTexture = new System.Windows.Forms.CheckBox();
            this.group_general.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_general
            // 
            this.group_general.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_general.AutoSize = true;
            this.group_general.Controls.Add(this.check_legacyRender);
            this.group_general.Controls.Add(this.check_showRenderWindow);
            this.group_general.Controls.Add(this.check_loadTexture);
            this.group_general.Location = new System.Drawing.Point(12, 12);
            this.group_general.Name = "group_general";
            this.group_general.Size = new System.Drawing.Size(330, 101);
            this.group_general.TabIndex = 0;
            this.group_general.TabStop = false;
            this.group_general.Text = "General";
            // 
            // check_legacyRender
            // 
            this.check_legacyRender.AutoSize = true;
            this.check_legacyRender.Location = new System.Drawing.Point(6, 65);
            this.check_legacyRender.Name = "check_legacyRender";
            this.check_legacyRender.Size = new System.Drawing.Size(160, 17);
            this.check_legacyRender.TabIndex = 2;
            this.check_legacyRender.Text = "Render with Legacy Method";
            this.check_legacyRender.UseVisualStyleBackColor = true;
            this.check_legacyRender.CheckedChanged += new System.EventHandler(this.check_legacyRender_CheckedChanged);
            // 
            // check_showRenderWindow
            // 
            this.check_showRenderWindow.AutoSize = true;
            this.check_showRenderWindow.Location = new System.Drawing.Point(6, 19);
            this.check_showRenderWindow.Name = "check_showRenderWindow";
            this.check_showRenderWindow.Size = new System.Drawing.Size(133, 17);
            this.check_showRenderWindow.TabIndex = 1;
            this.check_showRenderWindow.Text = "Show Render Window";
            this.check_showRenderWindow.UseVisualStyleBackColor = true;
            this.check_showRenderWindow.CheckedChanged += new System.EventHandler(this.check_showRenderWindow_CheckedChanged);
            // 
            // check_loadTexture
            // 
            this.check_loadTexture.AutoSize = true;
            this.check_loadTexture.Location = new System.Drawing.Point(6, 42);
            this.check_loadTexture.Name = "check_loadTexture";
            this.check_loadTexture.Size = new System.Drawing.Size(185, 17);
            this.check_loadTexture.TabIndex = 0;
            this.check_loadTexture.Text = "Load Textures in Render Window";
            this.check_loadTexture.UseVisualStyleBackColor = true;
            this.check_loadTexture.CheckedChanged += new System.EventHandler(this.check_loadTexture_CheckedChanged);
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 121);
            this.Controls.Add(this.group_general);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsView_FormClosing);
            this.group_general.ResumeLayout(false);
            this.group_general.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group_general;
        private System.Windows.Forms.CheckBox check_loadTexture;
        private System.Windows.Forms.CheckBox check_legacyRender;
        private System.Windows.Forms.CheckBox check_showRenderWindow;
    }
}