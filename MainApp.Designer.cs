namespace DoteApp
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.NavBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.openNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pageNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.printNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.copyNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.searchToolNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpItNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longLineBrakeItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDoteAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.InputText = new System.Windows.Forms.RichTextBox();
            this.redoNavBar = new System.Windows.Forms.ToolStripMenuItem();
            this.splintPanel = new System.Windows.Forms.SplitContainer();
            this.Board_1 = new System.Windows.Forms.Panel();
            this.Board_3 = new System.Windows.Forms.Panel();
            this.Board_2 = new System.Windows.Forms.Panel();
            this.textSearch = new System.Windows.Forms.Label();
            this.textInfo = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.TextBox();
            this.outPutButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.NavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splintPanel)).BeginInit();
            this.splintPanel.Panel2.SuspendLayout();
            this.splintPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(800, 24);
            this.NavBar.TabIndex = 3;
            this.NavBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNavBar,
            this.newWindowNavBar,
            this.openNavBar,
            this.saveNavBar,
            this.saveAsNavBar,
            this.toolStripSeparator1,
            this.pageNavBar,
            this.printNavBar,
            this.settingsNavBar,
            this.toolStripSeparator2,
            this.exitNavBar});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newNavBar
            // 
            this.newNavBar.Name = "newNavBar";
            this.newNavBar.ShortcutKeyDisplayString = "Ctrl + N";
            this.newNavBar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newNavBar.Size = new System.Drawing.Size(230, 22);
            this.newNavBar.Text = "New";
            this.newNavBar.Click += new System.EventHandler(this.newNavBar_Click);
            // 
            // newWindowNavBar
            // 
            this.newWindowNavBar.Name = "newWindowNavBar";
            this.newWindowNavBar.ShortcutKeyDisplayString = "Ctrl + Shift + N";
            this.newWindowNavBar.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newWindowNavBar.Size = new System.Drawing.Size(230, 22);
            this.newWindowNavBar.Text = "New window";
            this.newWindowNavBar.Click += new System.EventHandler(this.newWindowNavBar_Click);
            // 
            // openNavBar
            // 
            this.openNavBar.Name = "openNavBar";
            this.openNavBar.ShortcutKeyDisplayString = "Ctrl + O";
            this.openNavBar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openNavBar.Size = new System.Drawing.Size(230, 22);
            this.openNavBar.Text = "Open";
            this.openNavBar.Click += new System.EventHandler(this.openNavBar_Click);
            // 
            // saveNavBar
            // 
            this.saveNavBar.Name = "saveNavBar";
            this.saveNavBar.ShortcutKeyDisplayString = "Ctrl + S";
            this.saveNavBar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveNavBar.Size = new System.Drawing.Size(230, 22);
            this.saveNavBar.Text = "Save";
            this.saveNavBar.Click += new System.EventHandler(this.saveNavBar_Click);
            // 
            // saveAsNavBar
            // 
            this.saveAsNavBar.Name = "saveAsNavBar";
            this.saveAsNavBar.ShortcutKeyDisplayString = "Ctrl + Shift + S";
            this.saveAsNavBar.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsNavBar.Size = new System.Drawing.Size(230, 22);
            this.saveAsNavBar.Text = "Save as";
            this.saveAsNavBar.Click += new System.EventHandler(this.saveAsNavBar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // pageNavBar
            // 
            this.pageNavBar.Enabled = false;
            this.pageNavBar.Name = "pageNavBar";
            this.pageNavBar.ShowShortcutKeys = false;
            this.pageNavBar.Size = new System.Drawing.Size(230, 22);
            this.pageNavBar.Text = "Page settings";
            // 
            // printNavBar
            // 
            this.printNavBar.Enabled = false;
            this.printNavBar.Name = "printNavBar";
            this.printNavBar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printNavBar.Size = new System.Drawing.Size(230, 22);
            this.printNavBar.Text = "Print";
            // 
            // settingsNavBar
            // 
            this.settingsNavBar.Enabled = false;
            this.settingsNavBar.Name = "settingsNavBar";
            this.settingsNavBar.ShowShortcutKeys = false;
            this.settingsNavBar.Size = new System.Drawing.Size(230, 22);
            this.settingsNavBar.Text = "Settings";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(227, 6);
            // 
            // exitNavBar
            // 
            this.exitNavBar.Name = "exitNavBar";
            this.exitNavBar.ShortcutKeyDisplayString = "Ctrl + E";
            this.exitNavBar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitNavBar.Size = new System.Drawing.Size(230, 22);
            this.exitNavBar.Text = "Exit";
            this.exitNavBar.Click += new System.EventHandler(this.exitNavBar_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoNavBar,
            this.redoNavBar,
            this.toolStripSeparator3,
            this.cutNavBar,
            this.copyNavBar,
            this.pasteNavBar,
            this.deleteNavBar,
            this.toolStripSeparator4,
            this.searchToolNavBar,
            this.replaceNavBar,
            this.jumpItNavBar,
            this.toolStripSeparator5});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoNavBar
            // 
            this.undoNavBar.Name = "undoNavBar";
            this.undoNavBar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoNavBar.Size = new System.Drawing.Size(180, 22);
            this.undoNavBar.Text = "Undo";
            this.undoNavBar.Click += new System.EventHandler(this.undoNavBar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // cutNavBar
            // 
            this.cutNavBar.Name = "cutNavBar";
            this.cutNavBar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutNavBar.Size = new System.Drawing.Size(180, 22);
            this.cutNavBar.Text = "Cut";
            this.cutNavBar.Click += new System.EventHandler(this.cutNavBar_Click);
            // 
            // copyNavBar
            // 
            this.copyNavBar.Name = "copyNavBar";
            this.copyNavBar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyNavBar.Size = new System.Drawing.Size(180, 22);
            this.copyNavBar.Text = "Copy";
            this.copyNavBar.Click += new System.EventHandler(this.copyNavBar_Click);
            // 
            // pasteNavBar
            // 
            this.pasteNavBar.Name = "pasteNavBar";
            this.pasteNavBar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteNavBar.Size = new System.Drawing.Size(180, 22);
            this.pasteNavBar.Text = "Paste";
            this.pasteNavBar.Click += new System.EventHandler(this.pasteNavBar_Click);
            // 
            // deleteNavBar
            // 
            this.deleteNavBar.Name = "deleteNavBar";
            this.deleteNavBar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.deleteNavBar.Size = new System.Drawing.Size(180, 22);
            this.deleteNavBar.Text = "Delete";
            this.deleteNavBar.Click += new System.EventHandler(this.deleteNavBar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // searchToolNavBar
            // 
            this.searchToolNavBar.Name = "searchToolNavBar";
            this.searchToolNavBar.Size = new System.Drawing.Size(180, 22);
            this.searchToolNavBar.Text = "Search";
            this.searchToolNavBar.Visible = false;
            this.searchToolNavBar.Click += new System.EventHandler(this.searchToolNavBar_Click);
            // 
            // replaceNavBar
            // 
            this.replaceNavBar.Name = "replaceNavBar";
            this.replaceNavBar.Size = new System.Drawing.Size(180, 22);
            this.replaceNavBar.Text = "Replace ...";
            this.replaceNavBar.Visible = false;
            // 
            // jumpItNavBar
            // 
            this.jumpItNavBar.Name = "jumpItNavBar";
            this.jumpItNavBar.Size = new System.Drawing.Size(180, 22);
            this.jumpItNavBar.Text = "Jump it ...";
            this.jumpItNavBar.Visible = false;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.longLineBrakeItToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.formToolStripMenuItem.Enabled = false;
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.formToolStripMenuItem.Text = "Form";
            // 
            // longLineBrakeItToolStripMenuItem
            // 
            this.longLineBrakeItToolStripMenuItem.Name = "longLineBrakeItToolStripMenuItem";
            this.longLineBrakeItToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.longLineBrakeItToolStripMenuItem.Text = "Long line brake it";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.informationBarToolStripMenuItem});
            this.viewToolStripMenuItem.Enabled = false;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // informationBarToolStripMenuItem
            // 
            this.informationBarToolStripMenuItem.Name = "informationBarToolStripMenuItem";
            this.informationBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informationBarToolStripMenuItem.Text = "Information bar";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutDoteAppToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutDoteAppToolStripMenuItem
            // 
            this.aboutDoteAppToolStripMenuItem.Name = "aboutDoteAppToolStripMenuItem";
            this.aboutDoteAppToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutDoteAppToolStripMenuItem.Text = "About DoteApp";
            this.aboutDoteAppToolStripMenuItem.Click += new System.EventHandler(this.aboutDoteAppToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 428);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 22);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 404);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(790, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 404);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(780, 10);
            this.panel3.TabIndex = 7;
            // 
            // InputText
            // 
            this.InputText.BackColor = System.Drawing.SystemColors.Control;
            this.InputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputText.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InputText.Location = new System.Drawing.Point(10, 34);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(780, 394);
            this.InputText.TabIndex = 8;
            this.InputText.Text = "";
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // redoNavBar
            // 
            this.redoNavBar.Name = "redoNavBar";
            this.redoNavBar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoNavBar.Size = new System.Drawing.Size(180, 22);
            this.redoNavBar.Text = "Redo";
            this.redoNavBar.Click += new System.EventHandler(this.redoNavBar_Click);
            // 
            // splintPanel
            // 
            this.splintPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.splintPanel.Location = new System.Drawing.Point(592, 34);
            this.splintPanel.Name = "splintPanel";
            this.splintPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splintPanel.Panel1
            // 
            this.splintPanel.Panel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            // 
            // splintPanel.Panel2
            // 
            this.splintPanel.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splintPanel.Panel2.Controls.Add(this.DownButton);
            this.splintPanel.Panel2.Controls.Add(this.UpButton);
            this.splintPanel.Panel2.Controls.Add(this.infoLabel);
            this.splintPanel.Panel2.Controls.Add(this.outPutButton);
            this.splintPanel.Panel2.Controls.Add(this.inputLabel);
            this.splintPanel.Panel2.Controls.Add(this.textInfo);
            this.splintPanel.Panel2.Controls.Add(this.textSearch);
            this.splintPanel.Panel2.Controls.Add(this.Board_2);
            this.splintPanel.Panel2.Controls.Add(this.Board_3);
            this.splintPanel.Panel2.Controls.Add(this.Board_1);
            this.splintPanel.Panel2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.splintPanel.Size = new System.Drawing.Size(198, 394);
            this.splintPanel.SplitterDistance = 205;
            this.splintPanel.TabIndex = 9;
            this.splintPanel.Visible = false;
            // 
            // Board_1
            // 
            this.Board_1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Board_1.Location = new System.Drawing.Point(0, 0);
            this.Board_1.Name = "Board_1";
            this.Board_1.Size = new System.Drawing.Size(12, 185);
            this.Board_1.TabIndex = 0;
            this.Board_1.Visible = false;
            // 
            // Board_3
            // 
            this.Board_3.Dock = System.Windows.Forms.DockStyle.Right;
            this.Board_3.Location = new System.Drawing.Point(186, 0);
            this.Board_3.Name = "Board_3";
            this.Board_3.Size = new System.Drawing.Size(12, 185);
            this.Board_3.TabIndex = 1;
            this.Board_3.Visible = false;
            // 
            // Board_2
            // 
            this.Board_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Board_2.Location = new System.Drawing.Point(12, 0);
            this.Board_2.Name = "Board_2";
            this.Board_2.Size = new System.Drawing.Size(174, 15);
            this.Board_2.TabIndex = 2;
            // 
            // textSearch
            // 
            this.textSearch.AutoSize = true;
            this.textSearch.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textSearch.Location = new System.Drawing.Point(19, 22);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(51, 19);
            this.textSearch.TabIndex = 3;
            this.textSearch.Text = "Search";
            this.textSearch.Visible = false;
            // 
            // textInfo
            // 
            this.textInfo.AutoSize = true;
            this.textInfo.Location = new System.Drawing.Point(20, 41);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(142, 13);
            this.textInfo.TabIndex = 4;
            this.textInfo.Text = "Please enter the search text.";
            this.textInfo.Visible = false;
            // 
            // inputLabel
            // 
            this.inputLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.inputLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputLabel.Location = new System.Drawing.Point(23, 66);
            this.inputLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(146, 19);
            this.inputLabel.TabIndex = 5;
            this.inputLabel.Visible = false;
            // 
            // outPutButton
            // 
            this.outPutButton.Location = new System.Drawing.Point(23, 88);
            this.outPutButton.Name = "outPutButton";
            this.outPutButton.Size = new System.Drawing.Size(75, 23);
            this.outPutButton.TabIndex = 6;
            this.outPutButton.Text = "Search";
            this.outPutButton.UseVisualStyleBackColor = true;
            this.outPutButton.Visible = false;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(23, 118);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(66, 13);
            this.infoLabel.TabIndex = 7;
            this.infoLabel.Text = "This 1 for 25";
            this.infoLabel.Visible = false;
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(26, 135);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(25, 25);
            this.UpButton.TabIndex = 8;
            this.UpButton.Text = "<";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Visible = false;
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(58, 136);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(25, 25);
            this.DownButton.TabIndex = 9;
            this.DownButton.Text = ">";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Visible = false;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splintPanel);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.NavBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainApp";
            this.Text = "NoNamed - DoteApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainApp_FormClosing);
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.splintPanel.Panel2.ResumeLayout(false);
            this.splintPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splintPanel)).EndInit();
            this.splintPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip NavBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNavBar;
        private System.Windows.Forms.ToolStripMenuItem newWindowNavBar;
        private System.Windows.Forms.ToolStripMenuItem openNavBar;
        private System.Windows.Forms.ToolStripMenuItem saveNavBar;
        private System.Windows.Forms.ToolStripMenuItem saveAsNavBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pageNavBar;
        private System.Windows.Forms.ToolStripMenuItem printNavBar;
        private System.Windows.Forms.ToolStripMenuItem settingsNavBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitNavBar;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoNavBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutNavBar;
        private System.Windows.Forms.ToolStripMenuItem copyNavBar;
        private System.Windows.Forms.ToolStripMenuItem pasteNavBar;
        private System.Windows.Forms.ToolStripMenuItem deleteNavBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem searchToolNavBar;
        private System.Windows.Forms.ToolStripMenuItem replaceNavBar;
        private System.Windows.Forms.ToolStripMenuItem jumpItNavBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longLineBrakeItToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDoteAppToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox InputText;
        private System.Windows.Forms.ToolStripMenuItem redoNavBar;
        private System.Windows.Forms.SplitContainer splintPanel;
        private System.Windows.Forms.Label textInfo;
        private System.Windows.Forms.Label textSearch;
        private System.Windows.Forms.Panel Board_2;
        private System.Windows.Forms.Panel Board_3;
        private System.Windows.Forms.Panel Board_1;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button outPutButton;
        private System.Windows.Forms.TextBox inputLabel;
    }
}

