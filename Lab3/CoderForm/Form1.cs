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
            FileButton.Text = "������";
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
                MessageBox.Show("�� ������� ����� ��� ���� ����!", "Error4ik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SetFile(s[0]);
        }

        private void CodeButtonClick(object sender, EventArgs e)
        {

            enc = true;

            labelText = "³��������� ���������� �����";

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

            labelText = "³��������� ������������� �����";

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

            TimeLabel.Text = $"��� �� ������: {mins} ��., {secs} ���.";

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
                After�rypto();

                string text = "����������";
                string dir = "Encrypted";
                if (!enc)
                {
                    text = "�������������";
                    dir = "Decrypted";
                }
                MessageBox.Show(
                    text + " ����� �������� ������!\n" +
                    "���� ��������� � ����� " + dir,
                    "����!",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information
                );

                
            }
        }

        private void After�rypto()
        {
            string text = "����������";
            if (!enc)
                text = "�������������";
            FileLabel.Text = text + " �������� ������!";
            FileLabel.Top = 120;
            FileButton.Top = 275;
            SaveFile.Visible = true;
            FileButton.Visible = true;
            FileButton.Text = "����� ����";
            FileButton.Click -= file_but_Click;
            FileButton.Click += NewFile;
            CancelButton.Enabled = false;
        }

        private void NewFile(object sender, EventArgs e)
        {
            FileLabel.Top = 141;
            FileLabel.Text = "������ ���� ��� ��������� �� �����";
            FileButton.Top = 211;
            FileButton.Text = "������ ����";
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
            string temp = "����������";
            if (!enc)
                temp = "�������������";
            var res = MessageBox.Show("�� ������� �� ������ ������� " + temp + "\n�������� ���� ��������",
                "������������",
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
                string temp = "����������";
                if (!enc)
                    temp = "�������������";
                var res = MessageBox.Show(
                    "�� ������� �� ������ ������� ����?\n�������� " + temp + " ���� ��������",
                    "������������",
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