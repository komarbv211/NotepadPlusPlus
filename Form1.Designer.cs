namespace NotepadPlusPlus_10._11._23
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            toolStripStatusDigit = new ToolStripStatusLabel();
            toolStripStatusLetters = new ToolStripStatusLabel();
            toolStripStatusWords = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelCountDigit = new ToolStripStatusLabel();
            toolStripStatusLabelCountLetters = new ToolStripStatusLabel();
            toolStripStatusLabelCountWords = new ToolStripStatusLabel();
            toolTip1 = new ToolTip(components);
            toolStrip1 = new ToolStrip();
            toolStripButtonNew = new ToolStripButton();
            toolStripButtonOpen = new ToolStripButton();
            toolStripButtonSave = new ToolStripButton();
            toolStripButtonPrint = new ToolStripButton();
            toolStripButtonFontText = new ToolStripButton();
            toolStripButtonTextColor = new ToolStripButton();
            toolStripButtonWord_wrap = new ToolStripButton();
            toolStripButtonUndo = new ToolStripButton();
            toolStripButtonRedo = new ToolStripButton();
            toolStripButtonCopy = new ToolStripButton();
            toolStripButtonCut = new ToolStripButton();
            toolStripButtonPaste = new ToolStripButton();
            toolStripButtonBackgroundColor = new ToolStripButton();
            toolStripButtonClear = new ToolStripButton();
            toolStripButtonCloseTab = new ToolStripButton();
            toolStripButtonRrenameTab = new ToolStripButton();
            toolStripButtonExit = new ToolStripButton();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem1 = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            saveAsToolStripMenuItem1 = new ToolStripMenuItem();
            printToolStripMenuItem1 = new ToolStripMenuItem();
            closeTabToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            renameTabToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            textToolStripMenuItem1 = new ToolStripMenuItem();
            colorToolStripMenuItem1 = new ToolStripMenuItem();
            wordWrapToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem1 = new ToolStripMenuItem();
            redoToolStripMenuItem1 = new ToolStripMenuItem();
            copyToolStripMenuItem1 = new ToolStripMenuItem();
            cutToolStripMenuItem1 = new ToolStripMenuItem();
            pasteToolStripMenuItem1 = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            tabPage1 = new TabPage();
            richTextBox = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            wordWrapToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem1 = new ToolStripMenuItem();
            closeTabToolStripMenuItem1 = new ToolStripMenuItem();
            tabControl = new TabControl();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            tabPage1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 6);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 1;
            label1.Text = "Maximum letters:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Location = new Point(128, 4);
            numericUpDown1.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(49, 23);
            numericUpDown1.TabIndex = 2;
            toolTip1.SetToolTip(numericUpDown1, "enter the required number of letters");
            // 
            // toolStripStatusDigit
            // 
            toolStripStatusDigit.Name = "toolStripStatusDigit";
            toolStripStatusDigit.Size = new Size(35, 17);
            toolStripStatusDigit.Text = "Digit:";
            // 
            // toolStripStatusLetters
            // 
            toolStripStatusLetters.Name = "toolStripStatusLetters";
            toolStripStatusLetters.Size = new Size(87, 17);
            toolStripStatusLetters.Text = "              Letters:";
            // 
            // toolStripStatusWords
            // 
            toolStripStatusWords.Name = "toolStripStatusWords";
            toolStripStatusWords.Size = new Size(83, 17);
            toolStripStatusWords.Text = "             Words:";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusDigit, toolStripStatusLabelCountDigit, toolStripStatusLetters, toolStripStatusLabelCountLetters, toolStripStatusWords, toolStripStatusLabelCountWords });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(798, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCountDigit
            // 
            toolStripStatusLabelCountDigit.Name = "toolStripStatusLabelCountDigit";
            toolStripStatusLabelCountDigit.Size = new Size(13, 17);
            toolStripStatusLabelCountDigit.Text = "0";
            toolStripStatusLabelCountDigit.ToolTipText = "the number of entered digits";
            // 
            // toolStripStatusLabelCountLetters
            // 
            toolStripStatusLabelCountLetters.Name = "toolStripStatusLabelCountLetters";
            toolStripStatusLabelCountLetters.Size = new Size(13, 17);
            toolStripStatusLabelCountLetters.Text = "0";
            // 
            // toolStripStatusLabelCountWords
            // 
            toolStripStatusLabelCountWords.Name = "toolStripStatusLabelCountWords";
            toolStripStatusLabelCountWords.Size = new Size(13, 17);
            toolStripStatusLabelCountWords.Text = "0";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonNew, toolStripButtonOpen, toolStripButtonSave, toolStripButtonPrint, toolStripButtonFontText, toolStripButtonTextColor, toolStripButtonWord_wrap, toolStripButtonUndo, toolStripButtonRedo, toolStripButtonCopy, toolStripButtonCut, toolStripButtonPaste, toolStripButtonBackgroundColor, toolStripButtonClear, toolStripButtonCloseTab, toolStripButtonRrenameTab, toolStripButtonExit });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(798, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            toolStripButtonNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNew.Image = (Image)resources.GetObject("toolStripButtonNew.Image");
            toolStripButtonNew.ImageTransparentColor = Color.Magenta;
            toolStripButtonNew.Name = "toolStripButtonNew";
            toolStripButtonNew.Size = new Size(23, 22);
            toolStripButtonNew.Text = "New Tab";
            toolStripButtonNew.ToolTipText = "New Tab (Ctrl + N)";
            toolStripButtonNew.Click += newToolStripMenuItem1_Click;
            // 
            // toolStripButtonOpen
            // 
            toolStripButtonOpen.BackColor = SystemColors.Window;
            toolStripButtonOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonOpen.Image = (Image)resources.GetObject("toolStripButtonOpen.Image");
            toolStripButtonOpen.ImageTransparentColor = Color.Magenta;
            toolStripButtonOpen.Name = "toolStripButtonOpen";
            toolStripButtonOpen.Size = new Size(23, 22);
            toolStripButtonOpen.Text = "Open";
            toolStripButtonOpen.ToolTipText = "Open (Ctrl + O)";
            toolStripButtonOpen.Click += openToolStripMenuItem1_Click;
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(23, 22);
            toolStripButtonSave.Text = "Save (Ctrl + S)";
            toolStripButtonSave.Click += saveToolStripMenuItem1_Click;
            // 
            // toolStripButtonPrint
            // 
            toolStripButtonPrint.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonPrint.Image = (Image)resources.GetObject("toolStripButtonPrint.Image");
            toolStripButtonPrint.ImageTransparentColor = Color.Magenta;
            toolStripButtonPrint.Name = "toolStripButtonPrint";
            toolStripButtonPrint.Size = new Size(23, 22);
            toolStripButtonPrint.Text = "toolStripButton1";
            toolStripButtonPrint.ToolTipText = "Print (Ctrl + P)";
            toolStripButtonPrint.Click += printToolStripMenuItem1_Click;
            // 
            // toolStripButtonFontText
            // 
            toolStripButtonFontText.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonFontText.Image = (Image)resources.GetObject("toolStripButtonFontText.Image");
            toolStripButtonFontText.ImageTransparentColor = Color.Magenta;
            toolStripButtonFontText.Name = "toolStripButtonFontText";
            toolStripButtonFontText.Size = new Size(23, 22);
            toolStripButtonFontText.Text = "toolStripButton1";
            toolStripButtonFontText.ToolTipText = "Font Text";
            toolStripButtonFontText.Click += textToolStripMenuItem1_Click;
            // 
            // toolStripButtonTextColor
            // 
            toolStripButtonTextColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonTextColor.Image = (Image)resources.GetObject("toolStripButtonTextColor.Image");
            toolStripButtonTextColor.ImageTransparentColor = Color.Magenta;
            toolStripButtonTextColor.Name = "toolStripButtonTextColor";
            toolStripButtonTextColor.Size = new Size(23, 22);
            toolStripButtonTextColor.Text = "toolStripButton2";
            toolStripButtonTextColor.ToolTipText = "Font Color";
            toolStripButtonTextColor.Click += colorToolStripMenuItem1_Click;
            // 
            // toolStripButtonWord_wrap
            // 
            toolStripButtonWord_wrap.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonWord_wrap.Image = (Image)resources.GetObject("toolStripButtonWord_wrap.Image");
            toolStripButtonWord_wrap.ImageTransparentColor = Color.Magenta;
            toolStripButtonWord_wrap.Name = "toolStripButtonWord_wrap";
            toolStripButtonWord_wrap.Size = new Size(23, 22);
            toolStripButtonWord_wrap.Text = "Word Wrap";
            toolStripButtonWord_wrap.Click += wordWrapToolStripMenuItem_Click;
            // 
            // toolStripButtonUndo
            // 
            toolStripButtonUndo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonUndo.Image = (Image)resources.GetObject("toolStripButtonUndo.Image");
            toolStripButtonUndo.ImageTransparentColor = Color.Magenta;
            toolStripButtonUndo.Name = "toolStripButtonUndo";
            toolStripButtonUndo.Size = new Size(23, 22);
            toolStripButtonUndo.Text = "toolStripButton4";
            toolStripButtonUndo.ToolTipText = "Undo (Ctrl + Z)";
            toolStripButtonUndo.Click += undoToolStripMenuItem1_Click;
            // 
            // toolStripButtonRedo
            // 
            toolStripButtonRedo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRedo.Image = (Image)resources.GetObject("toolStripButtonRedo.Image");
            toolStripButtonRedo.ImageTransparentColor = Color.Magenta;
            toolStripButtonRedo.Name = "toolStripButtonRedo";
            toolStripButtonRedo.Size = new Size(23, 22);
            toolStripButtonRedo.Text = "toolStripButton5";
            toolStripButtonRedo.ToolTipText = "Redo (Ctrl + Y)";
            toolStripButtonRedo.Click += redoToolStripMenuItem1_Click;
            // 
            // toolStripButtonCopy
            // 
            toolStripButtonCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCopy.Image = (Image)resources.GetObject("toolStripButtonCopy.Image");
            toolStripButtonCopy.ImageTransparentColor = Color.Magenta;
            toolStripButtonCopy.Name = "toolStripButtonCopy";
            toolStripButtonCopy.Size = new Size(23, 22);
            toolStripButtonCopy.Text = "toolStripButton1";
            toolStripButtonCopy.ToolTipText = "Copy (Ctrl + C)";
            toolStripButtonCopy.Click += copyToolStripMenuItem1_Click;
            // 
            // toolStripButtonCut
            // 
            toolStripButtonCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCut.Image = (Image)resources.GetObject("toolStripButtonCut.Image");
            toolStripButtonCut.ImageTransparentColor = Color.Magenta;
            toolStripButtonCut.Name = "toolStripButtonCut";
            toolStripButtonCut.Size = new Size(23, 22);
            toolStripButtonCut.Text = "toolStripButton2";
            toolStripButtonCut.ToolTipText = "Cut";
            toolStripButtonCut.Click += cutToolStripMenuItem1_Click;
            // 
            // toolStripButtonPaste
            // 
            toolStripButtonPaste.BackColor = SystemColors.ControlText;
            toolStripButtonPaste.Checked = true;
            toolStripButtonPaste.CheckState = CheckState.Checked;
            toolStripButtonPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonPaste.ForeColor = SystemColors.ControlText;
            toolStripButtonPaste.Image = (Image)resources.GetObject("toolStripButtonPaste.Image");
            toolStripButtonPaste.ImageTransparentColor = Color.Magenta;
            toolStripButtonPaste.Name = "toolStripButtonPaste";
            toolStripButtonPaste.Size = new Size(23, 22);
            toolStripButtonPaste.Text = "toolStripButton3";
            toolStripButtonPaste.ToolTipText = "Paste (Ctrl + V)";
            toolStripButtonPaste.Click += pasteToolStripMenuItem1_Click;
            // 
            // toolStripButtonBackgroundColor
            // 
            toolStripButtonBackgroundColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonBackgroundColor.Image = (Image)resources.GetObject("toolStripButtonBackgroundColor.Image");
            toolStripButtonBackgroundColor.ImageTransparentColor = Color.Magenta;
            toolStripButtonBackgroundColor.Name = "toolStripButtonBackgroundColor";
            toolStripButtonBackgroundColor.Size = new Size(23, 22);
            toolStripButtonBackgroundColor.Text = "Background color";
            toolStripButtonBackgroundColor.Click += toolStripButtonBackgroundColor_Click;
            // 
            // toolStripButtonClear
            // 
            toolStripButtonClear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonClear.Image = (Image)resources.GetObject("toolStripButtonClear.Image");
            toolStripButtonClear.ImageTransparentColor = Color.Magenta;
            toolStripButtonClear.Name = "toolStripButtonClear";
            toolStripButtonClear.Size = new Size(23, 22);
            toolStripButtonClear.Text = "toolStripButton1";
            toolStripButtonClear.ToolTipText = "Clear (Ctrl + Q)";
            toolStripButtonClear.Click += clearToolStripMenuItem_Click;
            // 
            // toolStripButtonCloseTab
            // 
            toolStripButtonCloseTab.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCloseTab.Image = (Image)resources.GetObject("toolStripButtonCloseTab.Image");
            toolStripButtonCloseTab.ImageTransparentColor = Color.Magenta;
            toolStripButtonCloseTab.Name = "toolStripButtonCloseTab";
            toolStripButtonCloseTab.Size = new Size(23, 22);
            toolStripButtonCloseTab.Text = "Close Tab";
            toolStripButtonCloseTab.ToolTipText = "Close Tab (Ctrl + W)";
            toolStripButtonCloseTab.Click += closeTabToolStripMenuItem_Click;
            // 
            // toolStripButtonRrenameTab
            // 
            toolStripButtonRrenameTab.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRrenameTab.Image = (Image)resources.GetObject("toolStripButtonRrenameTab.Image");
            toolStripButtonRrenameTab.ImageTransparentColor = Color.Magenta;
            toolStripButtonRrenameTab.Name = "toolStripButtonRrenameTab";
            toolStripButtonRrenameTab.Size = new Size(23, 22);
            toolStripButtonRrenameTab.Text = "toolStripButton1";
            toolStripButtonRrenameTab.ToolTipText = "Rename the Tab";
            toolStripButtonRrenameTab.Click += toolStripButtonRrenameTab_Click;
            // 
            // toolStripButtonExit
            // 
            toolStripButtonExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonExit.Image = (Image)resources.GetObject("toolStripButtonExit.Image");
            toolStripButtonExit.ImageTransparentColor = Color.Magenta;
            toolStripButtonExit.Name = "toolStripButtonExit";
            toolStripButtonExit.Size = new Size(23, 22);
            toolStripButtonExit.Text = "toolStripButton1";
            toolStripButtonExit.ToolTipText = "Exit (Alt + F4)";
            toolStripButtonExit.Click += exitToolStripMenuItem1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, fontToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(798, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem1, openToolStripMenuItem1, saveToolStripMenuItem1, saveAsToolStripMenuItem1, printToolStripMenuItem1, closeTabToolStripMenuItem, exitToolStripMenuItem1, renameTabToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            newToolStripMenuItem1.Image = (Image)resources.GetObject("newToolStripMenuItem1.Image");
            newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            newToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem1.Size = new Size(179, 22);
            newToolStripMenuItem1.Text = "New";
            newToolStripMenuItem1.Click += newToolStripMenuItem1_Click;
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Image = (Image)resources.GetObject("openToolStripMenuItem1.Image");
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem1.Size = new Size(179, 22);
            openToolStripMenuItem1.Text = "Open";
            openToolStripMenuItem1.Click += openToolStripMenuItem1_Click;
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Image = (Image)resources.GetObject("saveToolStripMenuItem1.Image");
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem1.Size = new Size(179, 22);
            saveToolStripMenuItem1.Text = "Save";
            saveToolStripMenuItem1.Click += saveToolStripMenuItem1_Click;
            // 
            // saveAsToolStripMenuItem1
            // 
            saveAsToolStripMenuItem1.Image = (Image)resources.GetObject("saveAsToolStripMenuItem1.Image");
            saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            saveAsToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Alt | Keys.S;
            saveAsToolStripMenuItem1.Size = new Size(179, 22);
            saveAsToolStripMenuItem1.Text = "Save as";
            saveAsToolStripMenuItem1.Click += saveAsToolStripMenuItem1_Click;
            // 
            // printToolStripMenuItem1
            // 
            printToolStripMenuItem1.Image = (Image)resources.GetObject("printToolStripMenuItem1.Image");
            printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            printToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem1.Size = new Size(179, 22);
            printToolStripMenuItem1.Text = "Print";
            printToolStripMenuItem1.Click += printToolStripMenuItem1_Click;
            // 
            // closeTabToolStripMenuItem
            // 
            closeTabToolStripMenuItem.Image = (Image)resources.GetObject("closeTabToolStripMenuItem.Image");
            closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            closeTabToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;
            closeTabToolStripMenuItem.Size = new Size(179, 22);
            closeTabToolStripMenuItem.Text = "Close Tab";
            closeTabToolStripMenuItem.Click += closeTabToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Image = (Image)resources.GetObject("exitToolStripMenuItem1.Image");
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem1.Size = new Size(179, 22);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // renameTabToolStripMenuItem
            // 
            renameTabToolStripMenuItem.Image = (Image)resources.GetObject("renameTabToolStripMenuItem.Image");
            renameTabToolStripMenuItem.Name = "renameTabToolStripMenuItem";
            renameTabToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            renameTabToolStripMenuItem.Size = new Size(179, 22);
            renameTabToolStripMenuItem.Text = "Rename Tab";
            renameTabToolStripMenuItem.Click += toolStripButtonRrenameTab_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { textToolStripMenuItem1, colorToolStripMenuItem1, wordWrapToolStripMenuItem });
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(43, 20);
            fontToolStripMenuItem.Text = "Font";
            // 
            // textToolStripMenuItem1
            // 
            textToolStripMenuItem1.Image = (Image)resources.GetObject("textToolStripMenuItem1.Image");
            textToolStripMenuItem1.Name = "textToolStripMenuItem1";
            textToolStripMenuItem1.Size = new Size(132, 22);
            textToolStripMenuItem1.Text = "Text";
            textToolStripMenuItem1.Click += textToolStripMenuItem1_Click;
            // 
            // colorToolStripMenuItem1
            // 
            colorToolStripMenuItem1.Image = (Image)resources.GetObject("colorToolStripMenuItem1.Image");
            colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            colorToolStripMenuItem1.Size = new Size(132, 22);
            colorToolStripMenuItem1.Text = "Color";
            colorToolStripMenuItem1.Click += colorToolStripMenuItem1_Click;
            // 
            // wordWrapToolStripMenuItem
            // 
            wordWrapToolStripMenuItem.Image = (Image)resources.GetObject("wordWrapToolStripMenuItem.Image");
            wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            wordWrapToolStripMenuItem.Size = new Size(132, 22);
            wordWrapToolStripMenuItem.Text = "Word wrap";
            wordWrapToolStripMenuItem.Click += wordWrapToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem1, redoToolStripMenuItem1, copyToolStripMenuItem1, cutToolStripMenuItem1, pasteToolStripMenuItem1, clearToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem1
            // 
            undoToolStripMenuItem1.Image = (Image)resources.GetObject("undoToolStripMenuItem1.Image");
            undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            undoToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem1.Size = new Size(144, 22);
            undoToolStripMenuItem1.Text = "Undo";
            undoToolStripMenuItem1.Click += undoToolStripMenuItem1_Click;
            // 
            // redoToolStripMenuItem1
            // 
            redoToolStripMenuItem1.Image = (Image)resources.GetObject("redoToolStripMenuItem1.Image");
            redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            redoToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem1.Size = new Size(144, 22);
            redoToolStripMenuItem1.Text = "Redo";
            redoToolStripMenuItem1.Click += redoToolStripMenuItem1_Click;
            // 
            // copyToolStripMenuItem1
            // 
            copyToolStripMenuItem1.Image = (Image)resources.GetObject("copyToolStripMenuItem1.Image");
            copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            copyToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem1.Size = new Size(144, 22);
            copyToolStripMenuItem1.Text = "Copy";
            copyToolStripMenuItem1.Click += copyToolStripMenuItem1_Click;
            // 
            // cutToolStripMenuItem1
            // 
            cutToolStripMenuItem1.Image = (Image)resources.GetObject("cutToolStripMenuItem1.Image");
            cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            cutToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem1.Size = new Size(144, 22);
            cutToolStripMenuItem1.Text = "Cut";
            cutToolStripMenuItem1.Click += cutToolStripMenuItem1_Click;
            // 
            // pasteToolStripMenuItem1
            // 
            pasteToolStripMenuItem1.Image = (Image)resources.GetObject("pasteToolStripMenuItem1.Image");
            pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            pasteToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem1.Size = new Size(144, 22);
            pasteToolStripMenuItem1.Text = "Paste";
            pasteToolStripMenuItem1.Click += pasteToolStripMenuItem1_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Image = (Image)resources.GetObject("clearToolStripMenuItem.Image");
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            clearToolStripMenuItem.Size = new Size(144, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(richTextBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(790, 345);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox
            // 
            richTextBox.BackColor = SystemColors.Window;
            richTextBox.ContextMenuStrip = contextMenuStrip1;
            richTextBox.EnableAutoDragDrop = true;
            richTextBox.Location = new Point(0, 0);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(790, 345);
            richTextBox.TabIndex = 5;
            richTextBox.Text = "";
            richTextBox.TextChanged += richTextBox1_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { textToolStripMenuItem, colorToolStripMenuItem, wordWrapToolStripMenuItem1, toolStripMenuItem2, copyToolStripMenuItem, cutToolStripMenuItem, pasteToolStripMenuItem, clearToolStripMenuItem1, closeTabToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(265, 202);
            // 
            // textToolStripMenuItem
            // 
            textToolStripMenuItem.Image = (Image)resources.GetObject("textToolStripMenuItem.Image");
            textToolStripMenuItem.Name = "textToolStripMenuItem";
            textToolStripMenuItem.Size = new Size(264, 22);
            textToolStripMenuItem.Text = "Text";
            textToolStripMenuItem.Click += textToolStripMenuItem1_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Image = (Image)resources.GetObject("colorToolStripMenuItem.Image");
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(264, 22);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem1_Click;
            // 
            // wordWrapToolStripMenuItem1
            // 
            wordWrapToolStripMenuItem1.Image = (Image)resources.GetObject("wordWrapToolStripMenuItem1.Image");
            wordWrapToolStripMenuItem1.Name = "wordWrapToolStripMenuItem1";
            wordWrapToolStripMenuItem1.Size = new Size(264, 22);
            wordWrapToolStripMenuItem1.Text = "Word wrap";
            wordWrapToolStripMenuItem1.Click += wordWrapToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Enabled = false;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(264, 22);
            toolStripMenuItem2.Text = "--------------------------------------";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(264, 22);
            copyToolStripMenuItem.Text = "Copy  (Ctrl + C)";
            copyToolStripMenuItem.Click += copyToolStripMenuItem1_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(264, 22);
            cutToolStripMenuItem.Text = "Cut     (Ctrl + X)";
            cutToolStripMenuItem.Click += cutToolStripMenuItem1_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(264, 22);
            pasteToolStripMenuItem.Text = "Paste  (Ctrl + V)";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem1_Click;
            // 
            // clearToolStripMenuItem1
            // 
            clearToolStripMenuItem1.Image = (Image)resources.GetObject("clearToolStripMenuItem1.Image");
            clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            clearToolStripMenuItem1.Size = new Size(264, 22);
            clearToolStripMenuItem1.Text = "Clear  (Ctrl + Q)";
            clearToolStripMenuItem1.Click += clearToolStripMenuItem_Click;
            // 
            // closeTabToolStripMenuItem1
            // 
            closeTabToolStripMenuItem1.Image = (Image)resources.GetObject("closeTabToolStripMenuItem1.Image");
            closeTabToolStripMenuItem1.Name = "closeTabToolStripMenuItem1";
            closeTabToolStripMenuItem1.Size = new Size(264, 22);
            closeTabToolStripMenuItem1.Text = "Close tab";
            closeTabToolStripMenuItem1.Click += closeTabToolStripMenuItem_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Location = new Point(0, 52);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(798, 373);
            tabControl.TabIndex = 7;
            tabControl.SelectedIndexChanged += Form1_Resize_1;
            tabControl.DoubleClick += toolStripButtonRrenameTab_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(798, 450);
            Controls.Add(tabControl);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabPage1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private NumericUpDown numericUpDown1;
        private ToolStripStatusLabel toolStripStatusDigit;
        private ToolStripStatusLabel toolStripStatusLetters;
        private ToolStripStatusLabel toolStripStatusWords;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelCountLetters;
        private ToolStripStatusLabel toolStripStatusLabelCountWords;
        private ToolTip toolTip1;
        private ToolStripStatusLabel toolStripStatusLabelCountDigit;
        private ToolStrip toolStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem saveAsToolStripMenuItem1;
        private ToolStripMenuItem printToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem textToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripButton toolStripButtonSave;
        private ToolStripMenuItem colorToolStripMenuItem1;
        private ToolStripMenuItem wordWrapToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem1;
        private ToolStripMenuItem redoToolStripMenuItem1;
        private ToolStripMenuItem copyToolStripMenuItem1;
        private ToolStripMenuItem cutToolStripMenuItem1;
        private ToolStripMenuItem pasteToolStripMenuItem1;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripButton toolStripButtonOpen;
        private ToolStripButton toolStripButtonNew;
        private ToolStripButton toolStripButtonPrint;
        private ToolStripButton toolStripButtonFontText;
        private ToolStripButton toolStripButtonTextColor;
        private ToolStripButton toolStripButtonWord_wrap;
        private ToolStripButton toolStripButtonUndo;
        private ToolStripButton toolStripButtonRedo;
        private ToolStripButton toolStripButtonCopy;
        private ToolStripButton toolStripButtonCut;
        private ToolStripButton toolStripButtonPaste;
        private ToolStripButton toolStripButtonClear;
        private ToolStripButton toolStripButtonExit;
        private ToolStripButton toolStripButtonCloseTab;
        private ToolStripMenuItem closeTabToolStripMenuItem;
        private TabPage tabPage1;
        private RichTextBox richTextBox;
        private TabControl tabControl;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem textToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem wordWrapToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem1;
        private ToolStripMenuItem closeTabToolStripMenuItem1;
        private ToolStripButton toolStripButtonBackgroundColor;
        private ToolStripButton toolStripButtonRrenameTab;
        private ToolStripMenuItem renameTabToolStripMenuItem;
    }
}