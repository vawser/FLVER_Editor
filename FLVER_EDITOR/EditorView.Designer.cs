namespace FLVER_EDITOR
{
    partial class EditorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorView));
            this.status_bar = new System.Windows.Forms.StatusStrip();
            this.status_text = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.action_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.action_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.action_import_model = new System.Windows.Forms.ToolStripMenuItem();
            this.action_export_model = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.render_bar = new System.Windows.Forms.MenuStrip();
            this.tool_bar = new System.Windows.Forms.ToolStrip();
            this.button_render_line = new System.Windows.Forms.ToolStripButton();
            this.button_render_triangle = new System.Windows.Forms.ToolStripButton();
            this.button_render_both = new System.Windows.Forms.ToolStripButton();
            this.button_render_both_notex = new System.Windows.Forms.ToolStripButton();
            this.button_render_texonly = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.button_render_flatshading = new System.Windows.Forms.ToolStripButton();
            this.button_render_bones = new System.Windows.Forms.ToolStripButton();
            this.button_render_dummy = new System.Windows.Forms.ToolStripButton();
            this.flow_layout = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_control = new System.Windows.Forms.TabControl();
            this.tab_bones = new System.Windows.Forms.TabPage();
            this.bone_split_container = new System.Windows.Forms.SplitContainer();
            this.bone_data_grid = new System.Windows.Forms.DataGridView();
            this.bone_data_grid_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bone_data_grid_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bone_data_grid_parent_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bone_data_grid_child_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bone_data_grid_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bone_data_grid_scale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bone_data_grid_rotation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bone_action_bb_to_sekiro = new System.Windows.Forms.Button();
            this.bone_action_view_buffer_layout = new System.Windows.Forms.Button();
            this.bone_action_export_json = new System.Windows.Forms.Button();
            this.bone_action_import_json = new System.Windows.Forms.Button();
            this.bone_tab_action_modify = new System.Windows.Forms.Button();
            this.tab_material = new System.Windows.Forms.TabPage();
            this.material_split_container = new System.Windows.Forms.SplitContainer();
            this.tab_mesh = new System.Windows.Forms.TabPage();
            this.mesh_split_container = new System.Windows.Forms.SplitContainer();
            this.tab_dummy = new System.Windows.Forms.TabPage();
            this.dummy_split_container = new System.Windows.Forms.SplitContainer();
            this.status_bar.SuspendLayout();
            this.render_bar.SuspendLayout();
            this.tool_bar.SuspendLayout();
            this.flow_layout.SuspendLayout();
            this.tab_control.SuspendLayout();
            this.tab_bones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bone_split_container)).BeginInit();
            this.bone_split_container.Panel1.SuspendLayout();
            this.bone_split_container.Panel2.SuspendLayout();
            this.bone_split_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bone_data_grid)).BeginInit();
            this.tab_material.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.material_split_container)).BeginInit();
            this.material_split_container.SuspendLayout();
            this.tab_mesh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesh_split_container)).BeginInit();
            this.mesh_split_container.SuspendLayout();
            this.tab_dummy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dummy_split_container)).BeginInit();
            this.dummy_split_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_bar
            // 
            this.status_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_text});
            this.status_bar.Location = new System.Drawing.Point(0, 932);
            this.status_bar.Name = "status_bar";
            this.status_bar.Size = new System.Drawing.Size(890, 22);
            this.status_bar.TabIndex = 2;
            // 
            // status_text
            // 
            this.status_text.Name = "status_text";
            this.status_text.Size = new System.Drawing.Size(0, 17);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.action_OpenFile,
            this.action_SaveFile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // action_OpenFile
            // 
            this.action_OpenFile.Name = "action_OpenFile";
            this.action_OpenFile.Size = new System.Drawing.Size(108, 22);
            this.action_OpenFile.Text = "Open";
            this.action_OpenFile.Click += new System.EventHandler(this.action_OpenFile_Click);
            // 
            // action_SaveFile
            // 
            this.action_SaveFile.Name = "action_SaveFile";
            this.action_SaveFile.Size = new System.Drawing.Size(108, 22);
            this.action_SaveFile.Text = "Save";
            this.action_SaveFile.Click += new System.EventHandler(this.action_SaveFile_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.action_import_model,
            this.action_export_model});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // action_import_model
            // 
            this.action_import_model.Name = "action_import_model";
            this.action_import_model.Size = new System.Drawing.Size(157, 22);
            this.action_import_model.Text = "Import Model";
            this.action_import_model.Click += new System.EventHandler(this.action_import_model_Click);
            // 
            // action_export_model
            // 
            this.action_export_model.Name = "action_export_model";
            this.action_export_model.Size = new System.Drawing.Size(157, 22);
            this.action_export_model.Text = "Export Model";
            this.action_export_model.Click += new System.EventHandler(this.action_export_model_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // render_bar
            // 
            this.render_bar.AutoSize = false;
            this.render_bar.BackColor = System.Drawing.Color.Transparent;
            this.render_bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.render_bar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.render_bar.GripMargin = new System.Windows.Forms.Padding(4);
            this.render_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.render_bar.Location = new System.Drawing.Point(0, 0);
            this.render_bar.Margin = new System.Windows.Forms.Padding(4);
            this.render_bar.MaximumSize = new System.Drawing.Size(0, 32);
            this.render_bar.Name = "render_bar";
            this.render_bar.Padding = new System.Windows.Forms.Padding(4);
            this.render_bar.Size = new System.Drawing.Size(890, 32);
            this.render_bar.TabIndex = 4;
            // 
            // tool_bar
            // 
            this.tool_bar.BackColor = System.Drawing.Color.Transparent;
            this.tool_bar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tool_bar.CanOverflow = false;
            this.tool_bar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tool_bar.GripMargin = new System.Windows.Forms.Padding(4);
            this.tool_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_render_line,
            this.button_render_triangle,
            this.button_render_both,
            this.button_render_both_notex,
            this.button_render_texonly,
            this.toolStripSeparator1,
            this.button_render_flatshading,
            this.button_render_bones,
            this.button_render_dummy});
            this.tool_bar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tool_bar.Location = new System.Drawing.Point(0, 32);
            this.tool_bar.Margin = new System.Windows.Forms.Padding(4);
            this.tool_bar.MaximumSize = new System.Drawing.Size(0, 32);
            this.tool_bar.Name = "tool_bar";
            this.tool_bar.Padding = new System.Windows.Forms.Padding(4);
            this.tool_bar.Size = new System.Drawing.Size(890, 31);
            this.tool_bar.TabIndex = 5;
            // 
            // button_render_line
            // 
            this.button_render_line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_render_line.Image = ((System.Drawing.Image)(resources.GetObject("button_render_line.Image")));
            this.button_render_line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_render_line.Name = "button_render_line";
            this.button_render_line.Size = new System.Drawing.Size(23, 20);
            this.button_render_line.ToolTipText = "Set render mode to Line.";
            this.button_render_line.Click += new System.EventHandler(this.button_render_line_Click);
            // 
            // button_render_triangle
            // 
            this.button_render_triangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_render_triangle.Image = ((System.Drawing.Image)(resources.GetObject("button_render_triangle.Image")));
            this.button_render_triangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_render_triangle.Name = "button_render_triangle";
            this.button_render_triangle.Size = new System.Drawing.Size(23, 20);
            this.button_render_triangle.ToolTipText = "Set render mode to Triangle.";
            this.button_render_triangle.Click += new System.EventHandler(this.button_render_triangle_Click);
            // 
            // button_render_both
            // 
            this.button_render_both.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_render_both.Image = ((System.Drawing.Image)(resources.GetObject("button_render_both.Image")));
            this.button_render_both.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_render_both.Name = "button_render_both";
            this.button_render_both.Size = new System.Drawing.Size(23, 20);
            this.button_render_both.ToolTipText = "Set render mode to Both.";
            this.button_render_both.Click += new System.EventHandler(this.button_render_both_Click);
            // 
            // button_render_both_notex
            // 
            this.button_render_both_notex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_render_both_notex.Image = ((System.Drawing.Image)(resources.GetObject("button_render_both_notex.Image")));
            this.button_render_both_notex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_render_both_notex.Name = "button_render_both_notex";
            this.button_render_both_notex.Size = new System.Drawing.Size(23, 20);
            this.button_render_both_notex.ToolTipText = "Set render mode to Both, No Texture.";
            this.button_render_both_notex.Click += new System.EventHandler(this.button_render_both_notex_Click);
            // 
            // button_render_texonly
            // 
            this.button_render_texonly.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_render_texonly.Image = ((System.Drawing.Image)(resources.GetObject("button_render_texonly.Image")));
            this.button_render_texonly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_render_texonly.Name = "button_render_texonly";
            this.button_render_texonly.Size = new System.Drawing.Size(23, 20);
            this.button_render_texonly.ToolTipText = "Set render mode to Texture Only.";
            this.button_render_texonly.Click += new System.EventHandler(this.button_render_texonly_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // button_render_flatshading
            // 
            this.button_render_flatshading.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_render_flatshading.Image = ((System.Drawing.Image)(resources.GetObject("button_render_flatshading.Image")));
            this.button_render_flatshading.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_render_flatshading.Name = "button_render_flatshading";
            this.button_render_flatshading.Size = new System.Drawing.Size(23, 20);
            this.button_render_flatshading.ToolTipText = "Toggle flat shading mode.";
            this.button_render_flatshading.Click += new System.EventHandler(this.button_render_flatshading_Click);
            // 
            // button_render_bones
            // 
            this.button_render_bones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_render_bones.Image = ((System.Drawing.Image)(resources.GetObject("button_render_bones.Image")));
            this.button_render_bones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_render_bones.Name = "button_render_bones";
            this.button_render_bones.Size = new System.Drawing.Size(23, 20);
            this.button_render_bones.ToolTipText = "Toggle display of bones.";
            this.button_render_bones.Click += new System.EventHandler(this.button_render_bones_Click);
            // 
            // button_render_dummy
            // 
            this.button_render_dummy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.button_render_dummy.Image = ((System.Drawing.Image)(resources.GetObject("button_render_dummy.Image")));
            this.button_render_dummy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_render_dummy.Name = "button_render_dummy";
            this.button_render_dummy.Size = new System.Drawing.Size(23, 20);
            this.button_render_dummy.ToolTipText = "Toggle display of dummy points.";
            this.button_render_dummy.Click += new System.EventHandler(this.button_render_dummy_Click);
            // 
            // flow_layout
            // 
            this.flow_layout.Controls.Add(this.tab_control);
            this.flow_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_layout.Location = new System.Drawing.Point(0, 63);
            this.flow_layout.Name = "flow_layout";
            this.flow_layout.Size = new System.Drawing.Size(890, 869);
            this.flow_layout.TabIndex = 6;
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.tab_bones);
            this.tab_control.Controls.Add(this.tab_material);
            this.tab_control.Controls.Add(this.tab_mesh);
            this.tab_control.Controls.Add(this.tab_dummy);
            this.tab_control.Location = new System.Drawing.Point(3, 3);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(875, 856);
            this.tab_control.TabIndex = 0;
            // 
            // tab_bones
            // 
            this.tab_bones.Controls.Add(this.bone_split_container);
            this.tab_bones.Location = new System.Drawing.Point(4, 22);
            this.tab_bones.Name = "tab_bones";
            this.tab_bones.Padding = new System.Windows.Forms.Padding(3);
            this.tab_bones.Size = new System.Drawing.Size(867, 830);
            this.tab_bones.TabIndex = 0;
            this.tab_bones.Text = "Bones";
            this.tab_bones.UseVisualStyleBackColor = true;
            // 
            // bone_split_container
            // 
            this.bone_split_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bone_split_container.Location = new System.Drawing.Point(3, 3);
            this.bone_split_container.Name = "bone_split_container";
            // 
            // bone_split_container.Panel1
            // 
            this.bone_split_container.Panel1.Controls.Add(this.bone_data_grid);
            // 
            // bone_split_container.Panel2
            // 
            this.bone_split_container.Panel2.Controls.Add(this.bone_action_bb_to_sekiro);
            this.bone_split_container.Panel2.Controls.Add(this.bone_action_view_buffer_layout);
            this.bone_split_container.Panel2.Controls.Add(this.bone_action_export_json);
            this.bone_split_container.Panel2.Controls.Add(this.bone_action_import_json);
            this.bone_split_container.Panel2.Controls.Add(this.bone_tab_action_modify);
            this.bone_split_container.Size = new System.Drawing.Size(861, 824);
            this.bone_split_container.SplitterDistance = 650;
            this.bone_split_container.TabIndex = 0;
            // 
            // bone_data_grid
            // 
            this.bone_data_grid.AllowUserToAddRows = false;
            this.bone_data_grid.AllowUserToDeleteRows = false;
            this.bone_data_grid.AllowUserToResizeColumns = false;
            this.bone_data_grid.AllowUserToResizeRows = false;
            this.bone_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bone_data_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bone_data_grid_index,
            this.bone_data_grid_name,
            this.bone_data_grid_parent_index,
            this.bone_data_grid_child_index,
            this.bone_data_grid_position,
            this.bone_data_grid_scale,
            this.bone_data_grid_rotation});
            this.bone_data_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bone_data_grid.Location = new System.Drawing.Point(0, 0);
            this.bone_data_grid.MinimumSize = new System.Drawing.Size(160, 0);
            this.bone_data_grid.MultiSelect = false;
            this.bone_data_grid.Name = "bone_data_grid";
            this.bone_data_grid.RowHeadersVisible = false;
            this.bone_data_grid.RowHeadersWidth = 51;
            this.bone_data_grid.Size = new System.Drawing.Size(650, 824);
            this.bone_data_grid.TabIndex = 1;
            // 
            // bone_data_grid_index
            // 
            this.bone_data_grid_index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bone_data_grid_index.DataPropertyName = "Index";
            this.bone_data_grid_index.HeaderText = "Index";
            this.bone_data_grid_index.MinimumWidth = 6;
            this.bone_data_grid_index.Name = "bone_data_grid_index";
            this.bone_data_grid_index.Width = 58;
            // 
            // bone_data_grid_name
            // 
            this.bone_data_grid_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bone_data_grid_name.DataPropertyName = "Name";
            this.bone_data_grid_name.HeaderText = "Name";
            this.bone_data_grid_name.MinimumWidth = 6;
            this.bone_data_grid_name.Name = "bone_data_grid_name";
            this.bone_data_grid_name.Width = 60;
            // 
            // bone_data_grid_parent_index
            // 
            this.bone_data_grid_parent_index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bone_data_grid_parent_index.DataPropertyName = "Parent ID";
            this.bone_data_grid_parent_index.HeaderText = "Parent ID";
            this.bone_data_grid_parent_index.MinimumWidth = 6;
            this.bone_data_grid_parent_index.Name = "bone_data_grid_parent_index";
            this.bone_data_grid_parent_index.Width = 77;
            // 
            // bone_data_grid_child_index
            // 
            this.bone_data_grid_child_index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bone_data_grid_child_index.DataPropertyName = "Child ID";
            this.bone_data_grid_child_index.HeaderText = "Child ID";
            this.bone_data_grid_child_index.MinimumWidth = 6;
            this.bone_data_grid_child_index.Name = "bone_data_grid_child_index";
            this.bone_data_grid_child_index.Width = 69;
            // 
            // bone_data_grid_position
            // 
            this.bone_data_grid_position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bone_data_grid_position.DataPropertyName = "Position";
            this.bone_data_grid_position.HeaderText = "Position";
            this.bone_data_grid_position.MinimumWidth = 6;
            this.bone_data_grid_position.Name = "bone_data_grid_position";
            this.bone_data_grid_position.Width = 69;
            // 
            // bone_data_grid_scale
            // 
            this.bone_data_grid_scale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bone_data_grid_scale.DataPropertyName = "Scale";
            this.bone_data_grid_scale.HeaderText = "Scale";
            this.bone_data_grid_scale.MinimumWidth = 6;
            this.bone_data_grid_scale.Name = "bone_data_grid_scale";
            this.bone_data_grid_scale.Width = 59;
            // 
            // bone_data_grid_rotation
            // 
            this.bone_data_grid_rotation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bone_data_grid_rotation.DataPropertyName = "Rotation";
            this.bone_data_grid_rotation.HeaderText = "Rotation";
            this.bone_data_grid_rotation.MinimumWidth = 6;
            this.bone_data_grid_rotation.Name = "bone_data_grid_rotation";
            this.bone_data_grid_rotation.Width = 72;
            // 
            // bone_action_bb_to_sekiro
            // 
            this.bone_action_bb_to_sekiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.bone_action_bb_to_sekiro.Location = new System.Drawing.Point(0, 92);
            this.bone_action_bb_to_sekiro.Name = "bone_action_bb_to_sekiro";
            this.bone_action_bb_to_sekiro.Size = new System.Drawing.Size(207, 23);
            this.bone_action_bb_to_sekiro.TabIndex = 4;
            this.bone_action_bb_to_sekiro.Text = "Apply Bloodborne to Sekiro Bone Fix";
            this.bone_action_bb_to_sekiro.UseVisualStyleBackColor = true;
            this.bone_action_bb_to_sekiro.Click += new System.EventHandler(this.bone_action_bb_to_sekiro_Click);
            // 
            // bone_action_view_buffer_layout
            // 
            this.bone_action_view_buffer_layout.Dock = System.Windows.Forms.DockStyle.Top;
            this.bone_action_view_buffer_layout.Location = new System.Drawing.Point(0, 69);
            this.bone_action_view_buffer_layout.Name = "bone_action_view_buffer_layout";
            this.bone_action_view_buffer_layout.Size = new System.Drawing.Size(207, 23);
            this.bone_action_view_buffer_layout.TabIndex = 3;
            this.bone_action_view_buffer_layout.Text = "Edit Buffer Layout";
            this.bone_action_view_buffer_layout.UseVisualStyleBackColor = true;
            this.bone_action_view_buffer_layout.Click += new System.EventHandler(this.bone_action_view_buffer_layout_Click);
            // 
            // bone_action_export_json
            // 
            this.bone_action_export_json.Dock = System.Windows.Forms.DockStyle.Top;
            this.bone_action_export_json.Location = new System.Drawing.Point(0, 46);
            this.bone_action_export_json.Name = "bone_action_export_json";
            this.bone_action_export_json.Size = new System.Drawing.Size(207, 23);
            this.bone_action_export_json.TabIndex = 2;
            this.bone_action_export_json.Text = "Export JSON";
            this.bone_action_export_json.UseVisualStyleBackColor = true;
            this.bone_action_export_json.Click += new System.EventHandler(this.bone_action_export_json_Click);
            // 
            // bone_action_import_json
            // 
            this.bone_action_import_json.Dock = System.Windows.Forms.DockStyle.Top;
            this.bone_action_import_json.Location = new System.Drawing.Point(0, 23);
            this.bone_action_import_json.Name = "bone_action_import_json";
            this.bone_action_import_json.Size = new System.Drawing.Size(207, 23);
            this.bone_action_import_json.TabIndex = 1;
            this.bone_action_import_json.Text = "Import JSON";
            this.bone_action_import_json.UseVisualStyleBackColor = true;
            this.bone_action_import_json.Click += new System.EventHandler(this.bone_action_import_json_Click);
            // 
            // bone_tab_action_modify
            // 
            this.bone_tab_action_modify.Dock = System.Windows.Forms.DockStyle.Top;
            this.bone_tab_action_modify.Location = new System.Drawing.Point(0, 0);
            this.bone_tab_action_modify.Name = "bone_tab_action_modify";
            this.bone_tab_action_modify.Size = new System.Drawing.Size(207, 23);
            this.bone_tab_action_modify.TabIndex = 0;
            this.bone_tab_action_modify.Text = "Modify";
            this.bone_tab_action_modify.UseVisualStyleBackColor = true;
            this.bone_tab_action_modify.Click += new System.EventHandler(this.bone_tab_action_modify_Click);
            // 
            // tab_material
            // 
            this.tab_material.Controls.Add(this.material_split_container);
            this.tab_material.Location = new System.Drawing.Point(4, 22);
            this.tab_material.Name = "tab_material";
            this.tab_material.Padding = new System.Windows.Forms.Padding(3);
            this.tab_material.Size = new System.Drawing.Size(867, 830);
            this.tab_material.TabIndex = 1;
            this.tab_material.Text = "Materials";
            this.tab_material.UseVisualStyleBackColor = true;
            // 
            // material_split_container
            // 
            this.material_split_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.material_split_container.Location = new System.Drawing.Point(3, 3);
            this.material_split_container.Name = "material_split_container";
            this.material_split_container.Size = new System.Drawing.Size(861, 824);
            this.material_split_container.SplitterDistance = 650;
            this.material_split_container.TabIndex = 0;
            // 
            // tab_mesh
            // 
            this.tab_mesh.Controls.Add(this.mesh_split_container);
            this.tab_mesh.Location = new System.Drawing.Point(4, 22);
            this.tab_mesh.Name = "tab_mesh";
            this.tab_mesh.Padding = new System.Windows.Forms.Padding(3);
            this.tab_mesh.Size = new System.Drawing.Size(867, 830);
            this.tab_mesh.TabIndex = 2;
            this.tab_mesh.Text = "Meshes";
            this.tab_mesh.UseVisualStyleBackColor = true;
            // 
            // mesh_split_container
            // 
            this.mesh_split_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesh_split_container.Location = new System.Drawing.Point(3, 3);
            this.mesh_split_container.Name = "mesh_split_container";
            this.mesh_split_container.Size = new System.Drawing.Size(861, 824);
            this.mesh_split_container.SplitterDistance = 650;
            this.mesh_split_container.TabIndex = 0;
            // 
            // tab_dummy
            // 
            this.tab_dummy.Controls.Add(this.dummy_split_container);
            this.tab_dummy.Location = new System.Drawing.Point(4, 22);
            this.tab_dummy.Name = "tab_dummy";
            this.tab_dummy.Padding = new System.Windows.Forms.Padding(3);
            this.tab_dummy.Size = new System.Drawing.Size(867, 830);
            this.tab_dummy.TabIndex = 3;
            this.tab_dummy.Text = "Dummy Points";
            this.tab_dummy.UseVisualStyleBackColor = true;
            // 
            // dummy_split_container
            // 
            this.dummy_split_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dummy_split_container.Location = new System.Drawing.Point(3, 3);
            this.dummy_split_container.Name = "dummy_split_container";
            this.dummy_split_container.Size = new System.Drawing.Size(861, 824);
            this.dummy_split_container.SplitterDistance = 650;
            this.dummy_split_container.TabIndex = 0;
            // 
            // EditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 954);
            this.Controls.Add(this.flow_layout);
            this.Controls.Add(this.tool_bar);
            this.Controls.Add(this.status_bar);
            this.Controls.Add(this.render_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditorView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLVER EDITOR";
            this.status_bar.ResumeLayout(false);
            this.status_bar.PerformLayout();
            this.render_bar.ResumeLayout(false);
            this.render_bar.PerformLayout();
            this.tool_bar.ResumeLayout(false);
            this.tool_bar.PerformLayout();
            this.flow_layout.ResumeLayout(false);
            this.tab_control.ResumeLayout(false);
            this.tab_bones.ResumeLayout(false);
            this.bone_split_container.Panel1.ResumeLayout(false);
            this.bone_split_container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bone_split_container)).EndInit();
            this.bone_split_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bone_data_grid)).EndInit();
            this.tab_material.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.material_split_container)).EndInit();
            this.material_split_container.ResumeLayout(false);
            this.tab_mesh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mesh_split_container)).EndInit();
            this.mesh_split_container.ResumeLayout(false);
            this.tab_dummy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dummy_split_container)).EndInit();
            this.dummy_split_container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.StatusStrip status_bar;
        public System.Windows.Forms.MenuStrip render_bar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem action_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem action_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem action_import_model;
        private System.Windows.Forms.ToolStripMenuItem action_export_model;
        private System.Windows.Forms.ToolStripStatusLabel status_text;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;

        // Bone Data Grid
        private System.Windows.Forms.DataGridView bone_data_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bone_data_grid_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn bone_data_grid_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bone_data_grid_parent_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn bone_data_grid_child_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn bone_data_grid_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn bone_data_grid_scale;
        private System.Windows.Forms.DataGridViewTextBoxColumn bone_data_grid_rotation;

        // Toolbar
        private System.Windows.Forms.ToolStrip tool_bar;
        private System.Windows.Forms.ToolStripButton button_render_line;
        private System.Windows.Forms.ToolStripButton button_render_triangle;
        private System.Windows.Forms.ToolStripButton button_render_both;
        private System.Windows.Forms.ToolStripButton button_render_both_notex;
        private System.Windows.Forms.ToolStripButton button_render_texonly;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton button_render_dummy;
        private System.Windows.Forms.ToolStripButton button_render_flatshading;
        private System.Windows.Forms.ToolStripButton button_render_bones;
        private System.Windows.Forms.FlowLayoutPanel flow_layout;
        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage tab_bones;
        private System.Windows.Forms.TabPage tab_material;
        private System.Windows.Forms.TabPage tab_mesh;
        private System.Windows.Forms.TabPage tab_dummy;
        private System.Windows.Forms.SplitContainer bone_split_container;
        private System.Windows.Forms.SplitContainer material_split_container;
        private System.Windows.Forms.SplitContainer mesh_split_container;
        private System.Windows.Forms.SplitContainer dummy_split_container;
        private System.Windows.Forms.Button bone_tab_action_modify;
        private System.Windows.Forms.Button bone_action_bb_to_sekiro;
        private System.Windows.Forms.Button bone_action_view_buffer_layout;
        private System.Windows.Forms.Button bone_action_export_json;
        private System.Windows.Forms.Button bone_action_import_json;
    }
}