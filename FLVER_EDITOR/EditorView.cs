using SoulsFormats;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLVER_EDITOR
{
    public partial class EditorView : Form
    {
        public EditorView(string[] args)
        {
            InitializeComponent();

            // Get filename from dropped file
            if (args.Length > 0)
            {
                // TODO: add protection if wrong kind of file is dropped
                Program.target_filename = args[0];
                Program.LoadFLVER(Program.target_filename, this);
            }

            status_text.Text = Program.target_filename;
        }

        private void action_OpenFile_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog file_dialog;
            file_dialog = new System.Windows.Forms.OpenFileDialog();
            file_dialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            file_dialog.Title = "Select .flver file";

            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                status_text.Text = file_dialog.FileName;
                Program.LoadFLVER(file_dialog.FileName, this);
            }
            else
            {
                return;
            }
        }

        private void action_SaveFile_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBoneTab()
        {
            if (Program.targetFlver != null)
            {
                Program.boneNameList = new List<DataGridViewTextBoxCell>();
                Program.parentList = new List<short>();
                Program.childList = new List<short>();
                Program.parentList.Clear();
                Program.childList.Clear();

                var boneParentList = new List<DataGridViewTextBoxCell>();
                var boneChildList = new List<DataGridViewTextBoxCell>();

                // Remove old rows
                bone_data_grid.Rows.Clear();

                foreach (DataGridViewColumn column in bone_data_grid.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                // Apply for each bone in the FLVER
                for (int i = 0; i < Program.targetFlver.Bones.Count; i++)
                {
                    FLVER.Bone current_bone = Program.targetFlver.Bones[i];

                    DataGridViewRow row = new DataGridViewRow();
                    {
                        // Index
                        DataGridViewTextBoxCell bone_index = new DataGridViewTextBoxCell();
                        bone_index.Value = "[" + i + "]";
                        row.Cells.Add(bone_index);
                        bone_index.ReadOnly = true;

                        // Name
                        DataGridViewTextBoxCell bone_name = new DataGridViewTextBoxCell();
                        bone_name.Value = current_bone.Name;
                        row.Cells.Add(bone_name);
                        Program.boneNameList.Add(bone_name);

                        // Bone Parent Index
                        DataGridViewTextBoxCell bone_parent_index = new DataGridViewTextBoxCell();
                        bone_parent_index.Value = current_bone.ParentIndex + "";
                        row.Cells.Add(bone_parent_index);
                        boneParentList.Add(bone_parent_index);
                        Program.parentList.Add(current_bone.ParentIndex);

                        // Bone Child Index
                        DataGridViewTextBoxCell bone_child_index = new DataGridViewTextBoxCell();
                        bone_child_index.Value = current_bone.ChildIndex + "";
                        row.Cells.Add(bone_child_index);
                        boneChildList.Add(bone_child_index);
                        Program.childList.Add(current_bone.ChildIndex);

                        // Bone Position
                        DataGridViewTextBoxCell bone_position = new DataGridViewTextBoxCell();
                        bone_position.Value = current_bone.Translation.X + "," + current_bone.Translation.Y + "," + current_bone.Translation.Z;
                        row.Cells.Add(bone_position);

                        // Bone Scale
                        DataGridViewTextBoxCell bone_scale = new DataGridViewTextBoxCell();
                        bone_scale.Value = current_bone.Scale.X + "," + current_bone.Scale.Y + "," + current_bone.Scale.Z;
                        row.Cells.Add(bone_scale);

                        // Bone Rotation
                        DataGridViewTextBoxCell bone_rotation = new DataGridViewTextBoxCell();
                        bone_rotation.Value = current_bone.Rotation.X + "," + current_bone.Rotation.Y + "," + current_bone.Rotation.Z;
                        row.Cells.Add(bone_rotation);
                    }

                    bone_data_grid.Rows.Add(row);

                }
            }
        }

        private void UpdateMaterialTab()
        {
            /*
            if (Program.targetFlver != null)
            {
                // Remove old rows
                mat_data_grid.Rows.Clear();

                foreach (DataGridViewColumn column in mat_data_grid.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                for (int i = 0; i < Program.targetFlver.Materials.Count; i++)
                {
                    FLVER.Material current_material = Program.targetFlver.Materials[i];

                    DataGridViewRow row = new DataGridViewRow();
                    {
                        System.Console.WriteLine(current_material.Name);
                        System.Console.WriteLine(current_material.MTD);
                        System.Console.WriteLine(current_material.Flags);
                        System.Console.WriteLine(current_material.GXBytes);
                        System.Console.WriteLine(current_material.Unk18);
                        System.Console.WriteLine(current_material.Textures);

                        foreach (FLVER.Texture texture in current_material.Textures)
                        {
                            System.Console.WriteLine(texture.Path);
                            System.Console.WriteLine(texture.Type);
                            System.Console.WriteLine(texture.ScaleX);
                            System.Console.WriteLine(texture.ScaleY);
                            System.Console.WriteLine(texture.Unk10);
                            System.Console.WriteLine(texture.Unk11);
                            System.Console.WriteLine(texture.Unk14);
                            System.Console.WriteLine(texture.Unk18);
                            System.Console.WriteLine(texture.Unk1C);

                        }

                        // Index
                        DataGridViewTextBoxCell bone_index = new DataGridViewTextBoxCell();
                        bone_index.Value = "[" + i + "]";
                        row.Cells.Add(bone_index);
                        bone_index.ReadOnly = true;

                        // Name
                        DataGridViewTextBoxCell bone_name = new DataGridViewTextBoxCell();
                        bone_name.Value = current_material.Name;
                        row.Cells.Add(bone_name);

                        // Flags
                        DataGridViewTextBoxCell flags = new DataGridViewTextBoxCell();
                        flags.Value = current_material.Flags;
                        row.Cells.Add(flags);

                        // MTD
                        DataGridViewTextBoxCell mtd_data = new DataGridViewTextBoxCell();
                        mtd_data.Value = current_material.MTD;
                        row.Cells.Add(mtd_data);

                        // Misc
                        DataGridViewTextBoxCell misc_data = new DataGridViewTextBoxCell();
                        misc_data.Value = current_material.Unk18;
                        row.Cells.Add(misc_data);

                        
                    }

                    mat_data_grid.Rows.Add(row);
                }
            }
            */
        }

        private void UpdateMeshTab()
        {
            if (Program.targetFlver != null)
            {

            }
        }

        private void UpdateDummyTab()
        {
            if (Program.targetFlver != null)
            {

            }
        }

        // Menubar
        private void action_import_model_Click(object sender, EventArgs e)
        {
            bool update = Program.ImportModel();
            if (update)
                UpdateEditor();
        }

        private void action_export_model_Click(object sender, EventArgs e)
        {
            bool update = Program.ExportModel();
            if (update)
                UpdateEditor();
        }

        // Bone Tab
        private void bone_tab_action_modify_Click(object sender, EventArgs e)
        {
            bool update = Program.SaveBoneChanges();
            if(update)
                UpdateEditor();
        }

        private void bone_action_import_json_Click(object sender, EventArgs e)
        {
            bool update = Program.ImportJSON_Bones();
            if (update)
                UpdateEditor();
        }

        private void bone_action_export_json_Click(object sender, EventArgs e)
        {
            bool update = Program.ExportJSON_Bones();
            if (update)
                UpdateEditor();
        }

        private void bone_action_bb_to_sekiro_Click(object sender, EventArgs e)
        {
            bool update = Program.BB_Bone_Fix();
            if (update)
                UpdateEditor();
        }

        private void bone_action_view_buffer_layout_Click(object sender, EventArgs e)
        {
            bool update = Program.VieWBufferLayout();
            if (update)
                UpdateEditor();
        }

        // Material Tab

        // Mesh Tab

        // Dummy Tab
        
        public void UpdateEditor()
        {
            UpdateBoneTab();
            UpdateMaterialTab();
            UpdateMeshTab();
            UpdateDummyTab();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newSettingsView = new SettingsView();
            newSettingsView.Show();
        }

        private void button_render_line_Click(object sender, EventArgs e)
        {
            if (Program.showing3D)
                Program.mono.renderMode = RenderMode.Line;
        }

        private void button_render_triangle_Click(object sender, EventArgs e)
        {
            if (Program.showing3D)
                Program.mono.renderMode = RenderMode.Triangle;
        }

        private void button_render_both_Click(object sender, EventArgs e)
        {
            if (Program.showing3D)
                Program.mono.renderMode = RenderMode.BothNoTex;
        }

        private void button_render_both_notex_Click(object sender, EventArgs e)
        {
            if (Program.showing3D)
                Program.mono.renderMode = RenderMode.TexOnly;
        }

        private void button_render_texonly_Click(object sender, EventArgs e)
        {
            if (Program.showing3D)
                Program.mono.renderMode = RenderMode.TexOnly;
        }

        private void button_render_flatshading_Click(object sender, EventArgs e)
        {
            if (Program.showing3D)
            {
                Program.mono.flatShading = !Program.mono.flatShading;
                Program.updateVertices();
            }
        }

        private void button_render_bones_Click(object sender, EventArgs e)
        {
            if (Program.showing3D)
            {
                Program.boneDisplay = !Program.boneDisplay;
                Program.updateVertices();
            }
        }

        private void button_render_dummy_Click(object sender, EventArgs e)
        {
            if (Program.showing3D)
            {
                Program.dummyDisplay = !Program.dummyDisplay;
                Program.updateVertices();
            }
        }

        private void mat_action_save_Click(object sender, EventArgs e)
        {
            
        }

        private void mat_action_export_json_Click(object sender, EventArgs e)
        {

        }

        private void mat_action_import_json_Click(object sender, EventArgs e)
        {

        }
    }
}
