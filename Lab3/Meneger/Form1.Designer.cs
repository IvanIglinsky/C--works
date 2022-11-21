namespace Meneger
{
    partial class TaskManeger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManeger));
            this.CalcButton = new System.Windows.Forms.Button();
            this.ProcsList = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Memory = new System.Windows.Forms.ColumnHeader();
            this.Priority = new System.Windows.Forms.ColumnHeader();
            this.StartTime = new System.Windows.Forms.ColumnHeader();
            this.StreamsCount = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.зупинитиПроцесToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.змінитиПріоритетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboveNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belowNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WordButton = new System.Windows.Forms.Button();
            this.PyCharmButton = new System.Windows.Forms.Button();
            this.SpotifyButton = new System.Windows.Forms.Button();
            this.PhpStorm = new System.Windows.Forms.Button();
            this.WebStormButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalcButton
            // 
            this.CalcButton.BackColor = System.Drawing.Color.Transparent;
            this.CalcButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CalcButton.BackgroundImage")));
            this.CalcButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CalcButton.Location = new System.Drawing.Point(12, 12);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(65, 65);
            this.CalcButton.TabIndex = 0;
            this.CalcButton.UseVisualStyleBackColor = false;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // ProcsList
            // 
            this.ProcsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Memory,
            this.Priority,
            this.StartTime,
            this.StreamsCount});
            this.ProcsList.ContextMenuStrip = this.contextMenuStrip1;
            this.ProcsList.FullRowSelect = true;
            this.ProcsList.Location = new System.Drawing.Point(12, 83);
            this.ProcsList.Name = "ProcsList";
            this.ProcsList.Size = new System.Drawing.Size(749, 462);
            this.ProcsList.TabIndex = 6;
            this.ProcsList.UseCompatibleStateImageBehavior = false;
            this.ProcsList.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Назва";
            this.Name.Width = 200;
            // 
            // Memory
            // 
            this.Memory.Text = "RAM (МБ)";
            this.Memory.Width = 80;
            // 
            // Priority
            // 
            this.Priority.Text = "Пріоритет";
            this.Priority.Width = 130;
            // 
            // StartTime
            // 
            this.StartTime.Text = "Старт";
            this.StartTime.Width = 170;
            // 
            // StreamsCount
            // 
            this.StreamsCount.Text = "Кількість потоків";
            this.StreamsCount.Width = 130;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зупинитиПроцесToolStripMenuItem,
            this.змінитиПріоритетToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 52);
            // 
            // зупинитиПроцесToolStripMenuItem
            // 
            this.зупинитиПроцесToolStripMenuItem.Name = "зупинитиПроцесToolStripMenuItem";
            this.зупинитиПроцесToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.зупинитиПроцесToolStripMenuItem.Text = "Зупинити процес";
            this.зупинитиПроцесToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // змінитиПріоритетToolStripMenuItem
            // 
            this.змінитиПріоритетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realTimeToolStripMenuItem,
            this.highToolStripMenuItem,
            this.aboveNormalToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.belowNormalToolStripMenuItem,
            this.idleToolStripMenuItem});
            this.змінитиПріоритетToolStripMenuItem.Name = "змінитиПріоритетToolStripMenuItem";
            this.змінитиПріоритетToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.змінитиПріоритетToolStripMenuItem.Text = "Змінити пріоритет";
            // 
            // realTimeToolStripMenuItem
            // 
            this.realTimeToolStripMenuItem.Name = "realTimeToolStripMenuItem";
            this.realTimeToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.realTimeToolStripMenuItem.Text = "RealTime";
            this.realTimeToolStripMenuItem.Click += new System.EventHandler(this.ChangePriorityClick);
            // 
            // highToolStripMenuItem
            // 
            this.highToolStripMenuItem.Name = "highToolStripMenuItem";
            this.highToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.highToolStripMenuItem.Text = "High";
            this.highToolStripMenuItem.Click += new System.EventHandler(this.ChangePriorityClick);
            // 
            // aboveNormalToolStripMenuItem
            // 
            this.aboveNormalToolStripMenuItem.Name = "aboveNormalToolStripMenuItem";
            this.aboveNormalToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.aboveNormalToolStripMenuItem.Text = "AboveNormal";
            this.aboveNormalToolStripMenuItem.Click += new System.EventHandler(this.ChangePriorityClick);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.ChangePriorityClick);
            // 
            // belowNormalToolStripMenuItem
            // 
            this.belowNormalToolStripMenuItem.Name = "belowNormalToolStripMenuItem";
            this.belowNormalToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.belowNormalToolStripMenuItem.Text = "BelowNormal";
            this.belowNormalToolStripMenuItem.Click += new System.EventHandler(this.ChangePriorityClick);
            // 
            // idleToolStripMenuItem
            // 
            this.idleToolStripMenuItem.Name = "idleToolStripMenuItem";
            this.idleToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.idleToolStripMenuItem.Text = "Idle";
            this.idleToolStripMenuItem.Click += new System.EventHandler(this.ChangePriorityClick);
            // 
            // WordButton
            // 
            this.WordButton.BackColor = System.Drawing.Color.Transparent;
            this.WordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WordButton.BackgroundImage")));
            this.WordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WordButton.Location = new System.Drawing.Point(142, 12);
            this.WordButton.Name = "WordButton";
            this.WordButton.Size = new System.Drawing.Size(65, 65);
            this.WordButton.TabIndex = 7;
            this.WordButton.UseVisualStyleBackColor = false;
            this.WordButton.Click += new System.EventHandler(this.WordButton_Click);
            // 
            // PyCharmButton
            // 
            this.PyCharmButton.BackColor = System.Drawing.Color.Transparent;
            this.PyCharmButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PyCharmButton.BackgroundImage")));
            this.PyCharmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PyCharmButton.Location = new System.Drawing.Point(404, 12);
            this.PyCharmButton.Name = "PyCharmButton";
            this.PyCharmButton.Size = new System.Drawing.Size(65, 65);
            this.PyCharmButton.TabIndex = 9;
            this.PyCharmButton.UseVisualStyleBackColor = false;
            this.PyCharmButton.Click += new System.EventHandler(this.PyCharmButton_Click);
            // 
            // SpotifyButton
            // 
            this.SpotifyButton.BackColor = System.Drawing.Color.Transparent;
            this.SpotifyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SpotifyButton.BackgroundImage")));
            this.SpotifyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SpotifyButton.Location = new System.Drawing.Point(284, 12);
            this.SpotifyButton.Name = "SpotifyButton";
            this.SpotifyButton.Size = new System.Drawing.Size(65, 65);
            this.SpotifyButton.TabIndex = 10;
            this.SpotifyButton.UseVisualStyleBackColor = false;
            this.SpotifyButton.Click += new System.EventHandler(this.SpotifyButton_Click);
            // 
            // PhpStorm
            // 
            this.PhpStorm.BackColor = System.Drawing.Color.Transparent;
            this.PhpStorm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PhpStorm.BackgroundImage")));
            this.PhpStorm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PhpStorm.Location = new System.Drawing.Point(526, 12);
            this.PhpStorm.Name = "PhpStorm";
            this.PhpStorm.Size = new System.Drawing.Size(65, 65);
            this.PhpStorm.TabIndex = 11;
            this.PhpStorm.UseVisualStyleBackColor = false;
            this.PhpStorm.Click += new System.EventHandler(this.PhpStorm_Click);
            // 
            // WebStormButton
            // 
            this.WebStormButton.BackColor = System.Drawing.Color.Transparent;
            this.WebStormButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WebStormButton.BackgroundImage")));
            this.WebStormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WebStormButton.Location = new System.Drawing.Point(651, 12);
            this.WebStormButton.Name = "WebStormButton";
            this.WebStormButton.Size = new System.Drawing.Size(65, 65);
            this.WebStormButton.TabIndex = 12;
            this.WebStormButton.UseVisualStyleBackColor = false;
            this.WebStormButton.Click += new System.EventHandler(this.WebStormButton_Click);
            // 
            // TaskManeger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(773, 557);
            this.Controls.Add(this.WebStormButton);
            this.Controls.Add(this.PhpStorm);
            this.Controls.Add(this.SpotifyButton);
            this.Controls.Add(this.PyCharmButton);
            this.Controls.Add(this.WordButton);
            this.Controls.Add(this.ProcsList);
            this.Controls.Add(this.CalcButton);

            this.Text = "TaskManeger";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button CalcButton;
        private ListView ProcsList;
        private new ColumnHeader Name;
        private ColumnHeader Memory;
        private ColumnHeader Priority;
        private ColumnHeader StartTime;
        private ColumnHeader StreamsCount;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem зупинитиПроцесToolStripMenuItem;
        private ToolStripMenuItem змінитиПріоритетToolStripMenuItem;
        private ToolStripMenuItem realTimeToolStripMenuItem;
        private ToolStripMenuItem highToolStripMenuItem;
        private ToolStripMenuItem aboveNormalToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem belowNormalToolStripMenuItem;
        private ToolStripMenuItem idleToolStripMenuItem;
        private Button WordButton;
        private Button PyCharmButton;
        private Button SpotifyButton;
        private Button PhpStorm;
        private Button WebStormButton;
    }
}