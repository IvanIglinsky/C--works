using CrypterBib;

namespace CoderForm
{
    public partial class Form1 : Form
    {
        int pointCount = 0;
        string filePath = "";
        string fileName = "";
        string labelText = "";
        Crypter crypter = new Crypter(1024);
        int time = 0;
        bool openFile = false;
        bool enc = true;
        public Form1()
        {
            InitializeComponent();
            OFD.Filter = "All (*.*)|*.*";
            NewFile("", EventArgs.Empty);
        }

        private void SetFile(string s)
        {
            openFile = true;
            filePath = s;
            for (int i = s.Length - 1; i >= 0; i--)
                if (s[i] == '\\')
                {
                    FileLabel.Text = s.Substring(i + 1, s.Length - i - 1);
                    break;
                }
            if (enc)
                fileName = "Encrypted_" + FileLabel.Text;
            else
                fileName = "Decrypted_" + FileLabel.Text;
            FileButton.Text = "Змінити";
            ShifrButton.Enabled = true;
            RozshifrButton.Enabled = true;
        }
        private void file_but_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                SetFile(OFD.FileName);
            }
        }

        private void Form1DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Form1DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (s.Length > 1)
            {
                MessageBox.Show("Ви вибрали більше чим один файл!", "Error4ik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SetFile(s[0]);
        }

        private void CodeButtonClick(object sender, EventArgs e)
        {

            enc = true;

            labelText = "Відбувається шифрування файлу";

            crypter.EncryptFile(filePath, GetKey());

            showProgress();
        }

        private string GetKey()
        {
            string key = TextBoxKey.Text;
            while (key.Length != 16)
                if (key.Length > 16)
                    key = key.Substring(0, 16);
                else
                    key += '\0';
            return key;
        }
        private void showProgress()
        {
            ShifrButton.Visible = false;
            RozshifrButton.Visible = false;
            FileButton.Visible = false;
            TextBoxKey.ReadOnly = true;
            progressBar.Visible = true;
            CancelButton.Visible = true;
            FileLabel.Font = new Font("Arial", 19);
            FileLabel.Top = 175;
            point.Start();
            pointTimerTick("", EventArgs.Empty);
            progress.Start();
            TimeLabel.Visible = true;
            CancelButton.Enabled = true;
        }

        private void decodeButtonClick(object sender, EventArgs e)
        {

            enc = false;

            labelText = "Відбувається розшифрування файлу";

            crypter.DecryptFile(filePath, GetKey());

            showProgress();
        }

        private void pointTimerTick(object sender, EventArgs e)
        {
            FileLabel.Text = labelText;
            for (int i = 0; i < pointCount; i++)
                FileLabel.Text += ".";
            pointCount++;
            if (pointCount == 4)
                pointCount = 0;

            int mins = time / 120;
            int secs = (time % 120) / 2;

            TimeLabel.Text = $"Час від старту: {mins} хв., {secs} сек.";

            time++;
        }

        private void ProgressTimerTick(object sender, EventArgs e)
        {
            int percentage = (int)(((float)Crypter.i / Crypter.n) * 1000);

            progressBar.Value = Math.Max(0, Math.Min(percentage, 1000));

            if (!Crypter.working)
            {
                progressBar.Value = 1000;
                progress.Stop();
                point.Stop();
                AfterСrypto();

                string text = "Шифрування";
                string dir = "Encrypted";
                if (!enc)
                {
                    text = "Розшифрування";
                    dir = "Decrypted";
                }
                MessageBox.Show(
                    text + " файлу відбулось успішно!\n" +
                    "Файл збережено в папку " + dir,
                    "Успіх!",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information
                );

                
            }
        }

        private void AfterСrypto()
        {
            string text = "Шифрування";
            if (!enc)
                text = "Розшифрування";
            FileLabel.Text = text + " відбулось успішно!";
            FileLabel.Top = 120;
            FileButton.Top = 275;
            SaveFile.Visible = true;
            FileButton.Visible = true;
            FileButton.Text = "Новий файл";
            FileButton.Click -= file_but_Click;
            FileButton.Click += NewFile;
            CancelButton.Enabled = false;
        }

        private void NewFile(object sender, EventArgs e)
        {
            FileLabel.Top = 141;
            FileLabel.Text = "Оберіть файл або перемістіть на форму";
            FileButton.Top = 211;
            FileButton.Text = "Обрати файл";
            FileButton.Click -= NewFile;
            FileButton.Click -= file_but_Click;
            FileButton.Click += file_but_Click;
            FileButton.Visible = true;
            TextBoxKey.Text = "";
            TextBoxKey.ReadOnly = false;
            progressBar.Visible = false;
            CancelButton.Visible = false;
            ShifrButton.Visible = true;
            ShifrButton.Enabled = false;
            RozshifrButton.Visible = true;
            RozshifrButton.Enabled = false;
            SaveFile.Visible = false;
            TimeLabel.Visible = false;
            time = 0;
        }

        private void SaveFileButtonClick(object sender, EventArgs e)
        {
            SFD.FileName = fileName;
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(SFD.FileName))
                    File.Delete(SFD.FileName);
                if (enc)
                    File.Copy("Encrypted\\" + fileName, SFD.FileName);
                else
                    File.Copy("Decrypted\\" + fileName, SFD.FileName);
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            string temp = "шифрування";
            if (!enc)
                temp = "розшифрування";
            var res = MessageBox.Show("Ви впевнені що хочете відмінити " + temp + "\nПрогресс буде втрачено",
                "Попередження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                progress.Stop();
                point.Stop();
                crypter.Stop();
                NewFile("", EventArgs.Empty);
            }
        }

        private void Form1FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Crypter.working)
            {
                string temp = "шифрування";
                if (!enc)
                    temp = "розшифрування";
                var res = MessageBox.Show(
                    "Ви впевнені що хочете закрити вікно?\nПрогресс " + temp + " буде втрачено",
                    "Попередження",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    progress.Stop();
                    point.Stop();
                    crypter.Stop();

                    NewFile("", EventArgs.Empty);
                }
                else
                    e.Cancel = true;
            }
        }
    }
}