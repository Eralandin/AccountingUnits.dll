namespace AccountingUnits
{
    partial class AddForm
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
            TopPanel = new Panel();
            label1 = new Label();
            TopLabel = new Label();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            CreateBtn = new Button();
            CancelBtn = new Button();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.ForestGreen;
            TopPanel.Controls.Add(label1);
            TopPanel.Controls.Add(TopLabel);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(494, 80);
            TopPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(318, 25);
            label1.TabIndex = 1;
            label1.Text = "Работа с единицами измерения";
            // 
            // TopLabel
            // 
            TopLabel.AutoSize = true;
            TopLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TopLabel.ForeColor = SystemColors.ControlLightLight;
            TopLabel.Location = new Point(12, 7);
            TopLabel.Name = "TopLabel";
            TopLabel.Size = new Size(418, 33);
            TopLabel.TabIndex = 0;
            TopLabel.Text = "Торгово-посредническая фирма";
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Top;
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameLabel.ForeColor = SystemColors.ActiveCaptionText;
            NameLabel.Location = new Point(12, 93);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(400, 33);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Название единицы измерения:";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top;
            NameTextBox.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameTextBox.Location = new Point(23, 138);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(446, 40);
            NameTextBox.TabIndex = 3;
            // 
            // CreateBtn
            // 
            CreateBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateBtn.BackColor = Color.ForestGreen;
            CreateBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CreateBtn.ForeColor = SystemColors.ControlLightLight;
            CreateBtn.Location = new Point(12, 203);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(125, 50);
            CreateBtn.TabIndex = 4;
            CreateBtn.Text = "ОК";
            CreateBtn.UseVisualStyleBackColor = false;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelBtn.BackColor = Color.ForestGreen;
            CancelBtn.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelBtn.ForeColor = SystemColors.ControlLightLight;
            CancelBtn.Location = new Point(357, 203);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(125, 50);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Отмена";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 265);
            Controls.Add(CancelBtn);
            Controls.Add(CreateBtn);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(TopPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimumSize = new Size(510, 304);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Единицы измерения";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Label TopLabel;
        private Label label1;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Button CreateBtn;
        private Button CancelBtn;
    }
}
