using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoteApp
{
    public partial class MainApp : Form
    {
        private bool asWrite = false;
        private string onTitle = "NoNamed";
        private string onText = "";
        private string saveOnText = "";
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/DoteApp";
        public string outPath;
        public MainApp()
        {
            InitializeComponent();
        }
        private void TextChanger()
        {
            try
            {
                if (onText == saveOnText)
                {
                    MainApp.ActiveForm.Text = onTitle + " - DoteApp";
                    asWrite = false;
                }
                else
                {
                    MainApp.ActiveForm.Text = "* " + onTitle + " - DoteApp";
                    asWrite = true;
                }
                onText = InputText.Text;
            }
            catch { }
        }
        private void InputText_TextChanged(object sender, EventArgs e)
        {
            TextChanger();
        }

        private void exitNavBar_Click(object sender, EventArgs e)
        {
            if (asWrite)
            {
                string message = "Do you want to close this window?";
                string title = "Save";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes) Application.Exit();
            }
            else Application.Exit();
        }

        private void newNavBar_Click(object sender, EventArgs e)
        {
            if (asWrite)
            {
                string message = "Do you want to close this window?";
                string title = "Save";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes) Application.Restart();
            }
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            try
            {
                outPath = Environment.GetCommandLineArgs()[1];
                if (Path.GetExtension(outPath) == ".dapps" || Path.GetExtension(outPath) == ".txt")
                {
                    onText = System.IO.File.ReadAllText(outPath);
                    onTitle = Path.GetFileNameWithoutExtension(outPath);
                    saveOnText = System.IO.File.ReadAllText(outPath);
                    InputText.Text = onText;
                }
                TextChanger();
            } catch {
                outPath = null;
            }
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }

        private void newWindowNavBar_Click(object sender, EventArgs e)
        {
            MainApp mainApp = new MainApp();
            mainApp.ShowDialog();
        }

        private void MainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (asWrite)
            {
                string message = "Do you want to close this window?";
                string title = "Save";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes) Application.Exit();
                else e.Cancel = true;
            }
        }

        private void openNavBar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    path = dlg.FileName;
                    onTitle = Path.GetFileNameWithoutExtension(path);
                    var fileStream = dlg.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        onText = reader.ReadToEnd();
                        InputText.Text = onText;
                        saveOnText = onText;
                        asWrite = false;
                        ActiveForm.Text = onTitle + " - DoteApp";
                    }
                }
            }
        }

        private void saveNavBar_Click(object sender, EventArgs e)
        {
            if (outPath != null)
            {
                System.IO.File.WriteAllText(outPath, onText);
                saveOnText = onText;
                asWrite = false;
                TextChanger();
            } if (path == Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/DoteApp") {
                using (SaveFileDialog slg = new SaveFileDialog())
                {
                    slg.Filter = "Text file (*.txt)|*.txt|DoteApp file (*.dapp)|*.dapps";
                    slg.InitialDirectory = path;
                    slg.ValidateNames = true;
                    slg.FileName = onTitle;
                    if (slg.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllText(slg.FileName, onText);
                        saveOnText = onText;
                        asWrite = false;
                        TextChanger();
                    }
                }
            }
            else
            {
                System.IO.File.WriteAllText(path, onText);
                saveOnText = onText;
                asWrite = false;
                TextChanger();
            }
        }

        private void saveAsNavBar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog slg = new SaveFileDialog())
            {
                slg.Filter = "Text file (*.txt)|*.txt|DoteApp file (*.dapp)|*.dapps";
                slg.InitialDirectory = path;
                slg.ValidateNames = true;
                slg.FileName = onTitle;
                if (slg.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(slg.FileName, onText);
                    saveOnText = onText;
                    asWrite = false;
                    
                }
            }
        }
        private void undoNavBar_Click(object sender, EventArgs e)
        {
            InputText.Undo();
        }

        private void cutNavBar_Click(object sender, EventArgs e)
        {
             if (InputText.SelectedText != "") InputText.Cut();
        }

        private void copyNavBar_Click(object sender, EventArgs e)
        {
            if (InputText.SelectedText != "") InputText.Copy();
        }

        private void pasteNavBar_Click(object sender, EventArgs e)
        {
            if (InputText.SelectedText != "") InputText.Paste();
        }

        private void deleteNavBar_Click(object sender, EventArgs e)
        {
            if (InputText.SelectedText != "") InputText.Clear();
        }

        private void redoNavBar_Click(object sender, EventArgs e)
        {
            InputText.Redo();
        }

        private void searchToolNavBar_Click(object sender, EventArgs e)
        {
            /*splintPanel.Visible = true;
            Board_1.Visible = true;
            Board_2.Visible = true;
            Board_3.Visible = true;
            textSearch.Visible = true;
            textInfo.Visible = true;
            infoLabel.Visible = true;
            outPutButton.Visible = true;
            infoLabel.Visible = true;
            UpButton.Visible = true;
            DownButton.Visible = true;*/
        }

        private void aboutDoteAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBoxx = new AboutBox1();
            aboutBoxx.Show();
        }
    }
}
