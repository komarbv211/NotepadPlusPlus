using System.Drawing.Printing;
using System.Runtime.Serialization.Formatters.Binary;

namespace NotepadPlusPlus_10._11._23
{
    public partial class Form1 : Form
    {
        private PrintDocument printDocument1 = new PrintDocument();

        public string DesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Form1()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Form1_Resize_1!);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            richTextBox.AllowDrop = true;
            richTextBox.DragEnter += (s, arg) => richTextBox_DragEnter(s!, arg);
            richTextBox.DragLeave += (s, arg) => richTextBox_DragLeave(s!, arg);
            richTextBox.DragDrop += (s, arg) => richTextBox_DragDrop(s!, arg);
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            RichTextBox selectedRichTextBox = GetSelectRichTextBox();

            string text = selectedRichTextBox!.Text;
            int digitCount = text.Count(char.IsDigit);
            int letterCount = text.Count(char.IsLetter);
            int wordCount = text.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            toolStripStatusLabelCountDigit.Text = digitCount.ToString();
            toolStripStatusLabelCountLetters.Text = letterCount.ToString();
            toolStripStatusLabelCountWords.Text = wordCount.ToString();
        }
        private void newRichTextBoxInitialize(RichTextBox richTextBox)
        {
            richTextBox.EnableAutoDragDrop = true;
            richTextBox.Location = new Point(0, 0);
            richTextBox.Name = "richTextBox";
            richTextBox.ContextMenuStrip = contextMenuStrip1;
            richTextBox.AllowDrop = true;
            richTextBox.DragEnter += (s, arg) => richTextBox_DragEnter(s!, arg);
            richTextBox.DragLeave += (s, arg) => richTextBox_DragLeave(s!, arg);
            richTextBox.DragDrop += (s, arg) => richTextBox_DragDrop(s!, arg);
            richTextBox.TextChanged += richTextBox1_TextChanged!;
        }
        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage($"New Tab {tabControl.TabPages.Count + 1}");
            tabPage.UseVisualStyleBackColor = true;

            // Встановлюємо пропорційні значення для розмірів відносно tabControl
            int tabControlWidth = tabControl.ClientSize.Width;
            int tabControlHeight = tabControl.ClientSize.Height;

            tabPage.Size = new Size(tabControlWidth - 20, tabControlHeight - 40);
            RichTextBox richTextBox = new RichTextBox();

            newRichTextBoxInitialize(richTextBox);
            // Встановлюємо пропорційний розмір RichTextBox відносно tabPage
            int richTextBoxWidth = tabPage.ClientSize.Width - 10;
            int richTextBoxHeight = tabPage.ClientSize.Height - 10;

            richTextBox.Size = new Size(richTextBoxWidth, richTextBoxHeight);
            richTextBox.TabIndex = 5;
            richTextBox.Text = "";
            tabPage.Controls.Add(richTextBox);
            tabControl.TabPages.Add(tabPage);
        }
        RichTextBox GetSelectRichTextBox()
        {
            foreach (var item in tabControl.SelectedTab.Controls.OfType<RichTextBox>())
            {
                if (item.Name == "richTextBox")
                    return item;
            }
            return null!;
        }
        private void SaveFile(RichTextBox richTextBox, string filePath)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                if (Path.GetExtension(filePath).ToLower() == ".rtf")
                {
                    richTextBox.SaveFile(filePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                }
                MessageBox.Show("File saved successfully.", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SaveRichTextBoxContents(bool saveAs)
        {
            RichTextBox selectedRichTextBox = GetSelectRichTextBox();
            if (selectedRichTextBox != null)
            {
                string filePath = "";
                if (!saveAs && tabControl.SelectedTab != null && tabControl.SelectedTab.Tag != null)
                {
                    filePath = tabControl.SelectedTab.Tag.ToString()!;
                    SaveFile(selectedRichTextBox, filePath);
                }
                else
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.InitialDirectory = DesktopPath;
                        saveFileDialog.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt| Rich Text Files (*.rtf)|*.rtf||";
                        saveFileDialog.FilterIndex = 3;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            filePath = saveFileDialog.FileName;
                            SaveFile(selectedRichTextBox, filePath);

                            string fileName = Path.GetFileName(filePath);
                            TabPage selectedTabPage = tabControl.SelectedTab!;
                            if (selectedTabPage != null)
                            {
                                selectedTabPage.Text = fileName;
                                selectedTabPage.Tag = filePath;
                            }
                        }
                    }
                }
            }
        }
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveRichTextBoxContents(false);
        }
        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveRichTextBoxContents(true);
        }
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox selectedRichTextBox = GetSelectRichTextBox();
            if (selectedRichTextBox != null)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = DesktopPath;
                    openFileDialog.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt| Rich Text Files (*.rtf)|*.rtf||";
                    openFileDialog.FilterIndex = 3;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        if (File.Exists(filePath))
                        {
                            if (Path.GetExtension(filePath).ToLower() == ".rtf")
                            {
                                selectedRichTextBox.LoadFile(filePath, RichTextBoxStreamType.RichText);
                            }
                            else
                            {
                                selectedRichTextBox.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                            }

                            string fileName = Path.GetFileName(filePath);
                            TabPage selectedTabPage = tabControl.SelectedTab;
                            if (selectedTabPage != null)
                            {
                                selectedTabPage.Text = fileName;
                                selectedTabPage.Tag = filePath;
                            }
                        }
                    }
                }
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            RichTextBox selectedRichTextBox = GetSelectRichTextBox();

            if (selectedRichTextBox != null)
            {
                string text = selectedRichTextBox.Text;
                Font printFont = selectedRichTextBox.Font;
                Brush printBrush = new SolidBrush(selectedRichTextBox.ForeColor);

                // Встановлення області друку та виведення тексту
                RectangleF printArea = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height);
                e.Graphics!.DrawString(text, printFont, printBrush, printArea);
            }
        }
        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            RichTextBox selectedRichTextBox = GetSelectRichTextBox();

            if (selectedRichTextBox != null)
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedRichTextBox.SelectionFont = fontDialog.Font;
                }
            }
        }
        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            RichTextBox selectedRichTextBox = GetSelectRichTextBox();

            if (selectedRichTextBox != null)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedRichTextBox.SelectionColor = colorDialog.Color;
                }
            }
        }
        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox selectedRichTextBox = GetSelectRichTextBox();

            if (selectedRichTextBox != null)
            {
                if (selectedRichTextBox.WordWrap)
                {
                    selectedRichTextBox.WordWrap = !richTextBox.WordWrap;
                }
                else
                {
                    selectedRichTextBox.WordWrap = true;
                }

            }
        }
        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox selectedRichTextBox = GetSelectRichTextBox();

            if (selectedRichTextBox != null)
            {
                selectedRichTextBox.Undo();
            }
        }
        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox selectedRichTextBox = GetSelectRichTextBox();

            if (selectedRichTextBox != null)
            {
                selectedRichTextBox.Redo();
            }
        }
        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox selectedRichTextBox = GetSelectRichTextBox();

            if (selectedRichTextBox != null)
            {
                selectedRichTextBox.Copy();
            }
        }
        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox selectedRichTextBox = GetSelectRichTextBox();

            if (selectedRichTextBox != null)
            {
                selectedRichTextBox.Cut();
            }
        }
        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox selectedRichTextBox = GetSelectRichTextBox();

            if (selectedRichTextBox != null)
            {
                selectedRichTextBox.Paste();
            }
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox selectedRichTextBox = GetSelectRichTextBox();

            if (selectedRichTextBox != null)
            {
                selectedRichTextBox.Clear();
            }
        }
        private void Form1_Resize_1(object sender, EventArgs e)
        {
            tabControl.Size = new Size(this.ClientSize.Width - tabControl.Location.X * 2, this.ClientSize.Height - tabControl.Location.Y * 2);

            foreach (TabPage tabPage in tabControl.TabPages)
            {
                RichTextBox richTextBox = tabPage.Controls.OfType<RichTextBox>().FirstOrDefault()!;

                if (richTextBox != null)
                {
                    richTextBox.Size = new Size(tabPage.ClientSize.Width, tabPage.ClientSize.Height);
                }
            }
        }
        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                TabPage selectedTabPage = tabControl.SelectedTab;
                RichTextBox selectedRichTextBox = GetSelectRichTextBox();

                if (selectedRichTextBox != null && !string.IsNullOrEmpty(selectedRichTextBox.Text))
                {
                    DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.InitialDirectory = DesktopPath;
                            saveFileDialog.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt| Rich Text Files (*.rtf)|*.rtf||";
                            saveFileDialog.FilterIndex = 3;

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                string filePath = saveFileDialog.FileName;
                                SaveFile(selectedRichTextBox, filePath);
                            }
                        }
                        tabControl.TabPages.Remove(selectedTabPage);
                    }
                    else if (result == DialogResult.No)
                    {
                        tabControl.TabPages.Remove(selectedTabPage);
                    }
                }
                else
                {
                    tabControl.TabPages.Remove(selectedTabPage);
                }
            }
        }
        private void richTextBox_DragEnter(object sender, DragEventArgs e)
        {

            RichTextBox selectedRichTextBox = GetSelectRichTextBox();

            if (selectedRichTextBox != null)
            {
                if (e.Data!.GetDataPresent(DataFormats.Text) ||
                    e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    selectedRichTextBox.BackColor = Color.Cyan;
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }
        private void richTextBox_DragLeave(object sender, EventArgs e)
        {
            RichTextBox selectedRichTextBox = GetSelectRichTextBox();

            if (selectedRichTextBox != null)
            {
                selectedRichTextBox.ResetBackColor();
            }
        }
        private void richTextBox_DragDrop(object sender, DragEventArgs e)
        {
            RichTextBox selectedRichTextBox = GetSelectRichTextBox();

            if (selectedRichTextBox != null)
            {
                if (e.Data!.GetDataPresent(DataFormats.Text))
                {
                    string text = e.Data.GetData(DataFormats.Text).ToString()!;

                    // Отримання позиції курсору
                    int selectionStart = selectedRichTextBox.SelectionStart;
                    int selectionLength = selectedRichTextBox.SelectionLength;

                    // Вставлення тексту на позицію курсору
                    selectedRichTextBox.Select(selectionStart, selectionLength);
                    selectedRichTextBox.SelectedText = text;
                }
                else if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    foreach (string file in files)
                    {
                        if (Path.GetExtension(file).ToLower() == ".rtf")
                        {
                            string fileText = File.ReadAllText(file);

                            int selectionStart = selectedRichTextBox.SelectionStart;
                            int selectionLength = selectedRichTextBox.SelectionLength;

                            selectedRichTextBox.Select(selectionStart, selectionLength);
                            selectedRichTextBox.SelectedRtf = fileText;
                        }
                        else
                        {
                            string fileText = File.ReadAllText(file);

                            int selectionStart = selectedRichTextBox.SelectionStart;
                            int selectionLength = selectedRichTextBox.SelectionLength;

                            selectedRichTextBox.Select(selectionStart, selectionLength);
                            selectedRichTextBox.SelectedText = fileText;
                        }
                    }
                }
                selectedRichTextBox.ResetBackColor();
            }
        }
        private void toolStripButtonBackgroundColor_Click(object sender, EventArgs e)
        {
            RichTextBox selectedRichTextBox = GetSelectRichTextBox();
            ColorDialog colorDialog = new ColorDialog();

            if (selectedRichTextBox != null && colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedRichTextBox.BackColor = colorDialog.Color;
            }

        }
        private void SaveFileOpenTabPage()
        {
            List<TabInfo> tabInfos = new List<TabInfo>();

            foreach (TabPage tabPage in tabControl.TabPages)
            {
                RichTextBox richTextBox = tabPage.Controls.OfType<RichTextBox>().FirstOrDefault()!;

                if (richTextBox != null && !string.IsNullOrEmpty(richTextBox.Text))
                {
                    string filePath = tabPage.Tag?.ToString() ?? string.Empty;
                    string tabText = tabPage.Text;
                    string richText = richTextBox.Text;
                    TabInfo tabInfo = new TabInfo(tabText, filePath, richText);
                    tabInfos.Add(tabInfo);
                }
            }

            using (FileStream fs = new FileStream("tabs_info.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, tabInfos);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFileOpenTabPage();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTabsFromFile();
            MessageBox.Show("");

        }
        private void LoadTabsFromFile()
        {
            if (File.Exists("tabs_info.dat"))
            {
                List<TabInfo> tabInfos;

                using (FileStream fs = new FileStream("tabs_info.dat", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    tabInfos = (List<TabInfo>)formatter.Deserialize(fs);
                }

                foreach (var tabInfo in tabInfos)
                {
                    TabPage tabPage = new TabPage();
                    tabPage.Tag = tabInfo.FilePath;
                    tabPage.Text = tabInfo.TabText;
                    tabPage.UseVisualStyleBackColor = true;

                    RichTextBox richTextBox = new RichTextBox();
                    richTextBox.Text = tabInfo.RichText;
                    newRichTextBoxInitialize(richTextBox);
                    tabPage.Controls.Add(richTextBox);
                    tabControl.TabPages.Add(tabPage);
                }
            }
        }
        [Serializable]
        public class TabInfo
        {
            public string TabText { get; set; }
            public string FilePath { get; set; }
            public string RichText { get; set; }

            public TabInfo(string tabText, string filePath, string richText = null)
            {
                TabText = tabText;
                FilePath = filePath;
                RichText = richText;
            }
        }
        private string GetNewName(string prompt, string currentName)
        {
            using (var dialog = new Form())
            {
                dialog.Text = "Rename";
                dialog.Width = 300;
                dialog.Height = 200;
                Label label = new Label() { Left = 50, Top = 20, Text = prompt };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200, Text = currentName };
                Button confirmButton = new Button() { Text = "Rename", Left = 90, Width = 100, Top = 100, DialogResult = DialogResult.OK };
                dialog.Controls.Add(confirmButton);
                dialog.Controls.Add(textBox);
                dialog.Controls.Add(label);
                dialog.AcceptButton = confirmButton;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    return textBox.Text.Trim();
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        private void toolStripButtonRrenameTab_Click(object sender, EventArgs e)
        {
            TabPage selectedTabPage = tabControl.SelectedTab;

            if (selectedTabPage != null)
            {
                string currentName = selectedTabPage.Text;
                string newName = GetNewName("Enter new tab name:", currentName);

                if (!string.IsNullOrWhiteSpace(newName))
                {
                    selectedTabPage.Text = newName;
                }
            }
        }
    }
}
