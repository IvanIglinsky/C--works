namespace CoderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBoxKey = new System.Windows.Forms.TextBox();
            this.ChooseKey_label = new System.Windows.Forms.Label();
            this.FileLabel = new System.Windows.Forms.Label();
            this.FileButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ShifrButton = new System.Windows.Forms.Button();
            this.RozshifrButton = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.point = new System.Windows.Forms.Timer(this.components);
            this.progress = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxKey
            // 
            this.TextBoxKey.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxKey.Location = new System.Drawing.Point(40, 111);
            this.TextBoxKey.Name = "TextBoxKey";
            this.TextBoxKey.Size = new System.Drawing.Size(463, 36);
            this.TextBoxKey.TabIndex = 0;
            // 
            // ChooseKey_label
            // 
            this.ChooseKey_label.AutoSize = true;
            this.ChooseKey_label.BackColor = System.Drawing.Color.Transparent;
            this.ChooseKey_label.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseKey_label.ForeColor = System.Drawing.Color.Red;
            this.ChooseKey_label.Location = new System.Drawing.Point(40, 80);
            this.ChooseKey_label.Name = "ChooseKey_label";
            this.ChooseKey_label.Size = new System.Drawing.Size(187, 28);
            this.ChooseKey_label.TabIndex = 1;
            this.ChooseKey_label.Text = "Виберіть ключ:";
            // 
            // FileLabel
            // 
            this.FileLabel.BackColor = System.Drawing.Color.Transparent;
            this.FileLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileLabel.ForeColor = System.Drawing.Color.Red;
            this.FileLabel.Location = new System.Drawing.Point(12, 150);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(605, 58);
            this.FileLabel.TabIndex = 2;
            this.FileLabel.Text = "Оберіть файл або перемістіть на форму";
            this.FileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileButton
            // 
            this.FileButton.BackColor = System.Drawing.Color.Goldenrod;
            this.FileButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileButton.ForeColor = System.Drawing.Color.Blue;
            this.FileButton.Location = new System.Drawing.Point(50, 290);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(193, 39);
            this.FileButton.TabIndex = 3;
            this.FileButton.Text = "Вибрати файл";
            this.FileButton.UseVisualStyleBackColor = false;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Red;
            this.progressBar.Location = new System.Drawing.Point(12, 386);
            this.progressBar.Maximum = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(506, 21);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 4;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.ForestGreen;
            this.CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CancelButton.Location = new System.Drawing.Point(524, 378);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 29);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Скасувати";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // ShifrButton
            // 
            this.ShifrButton.BackColor = System.Drawing.Color.ForestGreen;
            this.ShifrButton.Enabled = false;
            this.ShifrButton.Font = new System.Drawing.Font("Bradley Hand ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShifrButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ShifrButton.Location = new System.Drawing.Point(317, 207);
            this.ShifrButton.Name = "ShifrButton";
            this.ShifrButton.Size = new System.Drawing.Size(300, 57);
            this.ShifrButton.TabIndex = 6;
            this.ShifrButton.Text = "Зашифрувати";
            this.ShifrButton.UseVisualStyleBackColor = false;
            this.ShifrButton.Click += new System.EventHandler(this.CodeButtonClick);
            // 
            // RozshifrButton
            // 
            this.RozshifrButton.BackColor = System.Drawing.Color.ForestGreen;
            this.RozshifrButton.Enabled = false;
            this.RozshifrButton.Font = new System.Drawing.Font("Bradley Hand ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RozshifrButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RozshifrButton.Location = new System.Drawing.Point(318, 290);
            this.RozshifrButton.Name = "RozshifrButton";
            this.RozshifrButton.Size = new System.Drawing.Size(300, 49);
            this.RozshifrButton.TabIndex = 7;
            this.RozshifrButton.Text = "Розшифрувати";
            this.RozshifrButton.UseVisualStyleBackColor = false;
            this.RozshifrButton.Click += new System.EventHandler(this.decodeButtonClick);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // point
            // 
            this.point.Interval = 500;
            this.point.Tick += new System.EventHandler(this.pointTimerTick);
            // 
            // progress
            // 
            this.progress.Tick += new System.EventHandler(this.ProgressTimerTick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.ForeColor = System.Drawing.Color.Red;
            this.TimeLabel.Location = new System.Drawing.Point(12, 421);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(606, 25);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "Витрачений час: 0 хв 0 сек.";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimeLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(204, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Шифратор_2000";
            // 
            // SaveFile
            // 
            this.SaveFile.BackColor = System.Drawing.Color.Goldenrod;
            this.SaveFile.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveFile.ForeColor = System.Drawing.Color.Blue;
            this.SaveFile.Location = new System.Drawing.Point(34, 211);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(233, 47);
            this.SaveFile.TabIndex = 9;
            this.SaveFile.Text = "Зберегти файл";
            this.SaveFile.UseVisualStyleBackColor = false;
            this.SaveFile.Visible = false;
            this.SaveFile.Click += new System.EventHandler(this.SaveFileButtonClick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.RozshifrButton);
            this.Controls.Add(this.ShifrButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.ChooseKey_label);
            this.Controls.Add(this.TextBoxKey);
            this.MaximumSize = new System.Drawing.Size(647, 497);
            this.MinimumSize = new System.Drawing.Size(647, 497);
            this.Name = "Form1";
            this.Text = "Шифратор2000";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxKey;
        private Label ChooseKey_label;
        private Label FileLabel;
        private Button FileButton;
        private ProgressBar progressBar;
        private Button CancelButton;
        private Button ShifrButton;
        private Button RozshifrButton;
        private OpenFileDialog OFD;
        private System.Windows.Forms.Timer point;
        private System.Windows.Forms.Timer progress;
        private Label TimeLabel;
        private SaveFileDialog SFD;
        private Label label1;
        private Button SaveFile;
    }
}