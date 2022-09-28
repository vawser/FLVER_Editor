using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FLVER_EDITOR
{

    public partial class SettingsView : Form
    {
        private string SHOW_RENDER_WINDOW_TOOLTIP = "Toggles whether the render window is loaded when opening a FLVER.";
        private string LOAD_TEXTURE_TOOLTIP = "Toggles whether to load the FLVER textures in the render window.";
        private string LEGACY_DISPLAY_TOOLTIP = "Toggles whether to use the legacy render method in the render window.";
        bool silent = false;

        public SettingsView()
        {
            InitializeComponent();

            // Tooltips
            AddCheckboxTooltip(check_showRenderWindow, SHOW_RENDER_WINDOW_TOOLTIP);
            AddCheckboxTooltip(check_loadTexture, LOAD_TEXTURE_TOOLTIP);
            AddCheckboxTooltip(check_legacyRender, LEGACY_DISPLAY_TOOLTIP);

            silent = true;

            // show3D
            if (Program.settingFile.GetSetting("FLVER", "show3D").Trim() != "0")
            {
                Program.show3D = true;
                check_showRenderWindow.Checked = true;
            }
            else
            {
                Program.show3D = false;
                check_showRenderWindow.Checked = false;
            }

            // legacyDisplay
            if (Program.settingFile.GetSetting("FLVER", "legacyDisplay").Trim() != "0")
            {
                Program.legacyDisplay = true;
                check_legacyRender.Checked = true;
            }
            else
            {
                Program.legacyDisplay = false;
                check_legacyRender.Checked = false;
            }

            // loadTexture
            if (Program.settingFile.GetSetting("FLVER", "loadTexture").Trim() != "0")
            {
                Program.loadTexture = true;
                check_loadTexture.Checked = true;
            }
            else
            {
                Program.loadTexture = false;
                check_loadTexture.Checked = false;
            }

            silent = false;
        }

        private void check_showRenderWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (check_showRenderWindow.Checked)
            {
                Program.show3D = true;
                Program.settingFile.AddSetting("FLVER", "show3D", "1");

                if(!silent)
                    MessageBox.Show("Show Render Window enabled.");
            }
            else
            {
                Program.show3D = false;
                Program.settingFile.AddSetting("FLVER", "show3D", "0");

                if (!silent)
                    MessageBox.Show("Show Render Window disabled.");
            }
        }

        private void check_loadTexture_CheckedChanged(object sender, EventArgs e)
        {
            if (check_loadTexture.Checked)
            {
                Program.loadTexture = true;
                Program.settingFile.AddSetting("FLVER", "loadTexture", "1");

                if (!silent)
                    MessageBox.Show("Load Textures in Render Window enabled.");
            }
            else
            {
                Program.loadTexture = false;
                Program.settingFile.AddSetting("FLVER", "loadTexture", "0");

                if (!silent)
                    MessageBox.Show("Load Textures in Render Window disabled.");
            }
        }

        private void check_legacyRender_CheckedChanged(object sender, EventArgs e)
        {
            if (check_legacyRender.Checked)
            {
                Program.legacyDisplay = true;
                Program.settingFile.AddSetting("FLVER", "legacyDisplay", "1");

                if (!silent)
                    MessageBox.Show("Render with Legacy Method disabled.");
            }
            else
            {
                Program.legacyDisplay = false;
                Program.settingFile.AddSetting("FLVER", "legacyDisplay", "0");

                if (!silent)
                    MessageBox.Show("Render with Legacy Method enabled.");
            }
        }

        private void SettingsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.settingFile.SaveSettings(Program.iniPath);
        }

        public static void AddCheckboxTooltip(CheckBox checkbox, string tooltip)
        {
            System.Windows.Forms.ToolTip quick_Tooltip = new System.Windows.Forms.ToolTip();
            quick_Tooltip.SetToolTip(checkbox, tooltip);
        }
    }
}
