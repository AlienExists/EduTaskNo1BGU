namespace PP1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConferentionsCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.SectionsCB = new System.Windows.Forms.ComboBox();
            this.SecondNameField = new System.Windows.Forms.TextBox();
            this.FirstNameField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.toParticipationsBtn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.additionalServicesChLB = new System.Windows.Forms.CheckedListBox();
            this.registrationBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RegistratePersonL = new System.Windows.Forms.Label();
            this.ExistingPersonL = new System.Windows.Forms.Label();
            this.RegistratePanel = new System.Windows.Forms.Panel();
            this.ExistingPersonsCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RegistratePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConferentionsCB
            // 
            this.ConferentionsCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConferentionsCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ConferentionsCB.FormattingEnabled = true;
            this.ConferentionsCB.Location = new System.Drawing.Point(36, 123);
            this.ConferentionsCB.Name = "ConferentionsCB";
            this.ConferentionsCB.Size = new System.Drawing.Size(284, 21);
            this.ConferentionsCB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя и фамилия участника";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(36, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Доступные конференции";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.RegistratePanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.registrationBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 465);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(33, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Секции";
            // 
            // SectionsCB
            // 
            this.SectionsCB.FormattingEnabled = true;
            this.SectionsCB.Location = new System.Drawing.Point(36, 174);
            this.SectionsCB.Name = "SectionsCB";
            this.SectionsCB.Size = new System.Drawing.Size(284, 21);
            this.SectionsCB.TabIndex = 28;
            // 
            // SecondNameField
            // 
            this.SecondNameField.Location = new System.Drawing.Point(33, 72);
            this.SecondNameField.Name = "SecondNameField";
            this.SecondNameField.Size = new System.Drawing.Size(287, 20);
            this.SecondNameField.TabIndex = 27;
            // 
            // FirstNameField
            // 
            this.FirstNameField.Location = new System.Drawing.Point(33, 46);
            this.FirstNameField.Name = "FirstNameField";
            this.FirstNameField.Size = new System.Drawing.Size(287, 20);
            this.FirstNameField.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Controls.Add(this.toParticipationsBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 63);
            this.panel2.TabIndex = 25;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.closeBtn.Location = new System.Drawing.Point(320, -3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(21, 33);
            this.closeBtn.TabIndex = 26;
            this.closeBtn.Text = "×";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // toParticipationsBtn
            // 
            this.toParticipationsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toParticipationsBtn.AutoSize = true;
            this.toParticipationsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toParticipationsBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.toParticipationsBtn.Location = new System.Drawing.Point(188, 33);
            this.toParticipationsBtn.Name = "toParticipationsBtn";
            this.toParticipationsBtn.Size = new System.Drawing.Size(156, 18);
            this.toParticipationsBtn.TabIndex = 27;
            this.toParticipationsBtn.Text = "Список участников >>";
            this.toParticipationsBtn.Click += new System.EventHandler(this.toParticipationsBtn_Click);
            this.toParticipationsBtn.MouseEnter += new System.EventHandler(this.toParticipationsBtn_MouseEnter);
            this.toParticipationsBtn.MouseLeave += new System.EventHandler(this.toParticipationsBtn_MouseLeave);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Регистрация участника";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.additionalServicesChLB);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(33, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 79);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дополнительные услуги";
            // 
            // additionalServicesChLB
            // 
            this.additionalServicesChLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.additionalServicesChLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.additionalServicesChLB.CheckOnClick = true;
            this.additionalServicesChLB.FormattingEnabled = true;
            this.additionalServicesChLB.Location = new System.Drawing.Point(9, 20);
            this.additionalServicesChLB.Name = "additionalServicesChLB";
            this.additionalServicesChLB.Size = new System.Drawing.Size(158, 64);
            this.additionalServicesChLB.TabIndex = 14;
            // 
            // registrationBtn
            // 
            this.registrationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(111)))));
            this.registrationBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.registrationBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registrationBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.registrationBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.registrationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrationBtn.Location = new System.Drawing.Point(0, 410);
            this.registrationBtn.Name = "registrationBtn";
            this.registrationBtn.Size = new System.Drawing.Size(345, 55);
            this.registrationBtn.TabIndex = 12;
            this.registrationBtn.Text = "Зарегистрировать";
            this.registrationBtn.UseVisualStyleBackColor = false;
            this.registrationBtn.Click += new System.EventHandler(this.registrationBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ExistingPersonL);
            this.panel3.Controls.Add(this.RegistratePersonL);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 30);
            this.panel3.TabIndex = 30;
            // 
            // RegistratePersonL
            // 
            this.RegistratePersonL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.RegistratePersonL.Dock = System.Windows.Forms.DockStyle.Left;
            this.RegistratePersonL.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.RegistratePersonL.ForeColor = System.Drawing.Color.White;
            this.RegistratePersonL.Location = new System.Drawing.Point(0, 0);
            this.RegistratePersonL.Name = "RegistratePersonL";
            this.RegistratePersonL.Size = new System.Drawing.Size(179, 30);
            this.RegistratePersonL.TabIndex = 0;
            this.RegistratePersonL.Text = "Зарегистрировать";
            this.RegistratePersonL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegistratePersonL.Click += new System.EventHandler(this.RegistratePersonL_Click);
            // 
            // ExistingPersonL
            // 
            this.ExistingPersonL.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExistingPersonL.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExistingPersonL.Location = new System.Drawing.Point(178, 0);
            this.ExistingPersonL.Name = "ExistingPersonL";
            this.ExistingPersonL.Size = new System.Drawing.Size(167, 30);
            this.ExistingPersonL.TabIndex = 1;
            this.ExistingPersonL.Text = "Выбрать";
            this.ExistingPersonL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExistingPersonL.Click += new System.EventHandler(this.ExistingPersonL_Click);
            // 
            // RegistratePanel
            // 
            this.RegistratePanel.Controls.Add(this.ExistingPersonsCB);
            this.RegistratePanel.Controls.Add(this.label1);
            this.RegistratePanel.Controls.Add(this.ConferentionsCB);
            this.RegistratePanel.Controls.Add(this.label4);
            this.RegistratePanel.Controls.Add(this.label2);
            this.RegistratePanel.Controls.Add(this.SectionsCB);
            this.RegistratePanel.Controls.Add(this.groupBox1);
            this.RegistratePanel.Controls.Add(this.SecondNameField);
            this.RegistratePanel.Controls.Add(this.FirstNameField);
            this.RegistratePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegistratePanel.Location = new System.Drawing.Point(0, 93);
            this.RegistratePanel.Name = "RegistratePanel";
            this.RegistratePanel.Size = new System.Drawing.Size(345, 317);
            this.RegistratePanel.TabIndex = 31;
            // 
            // ExistingPersonsCB
            // 
            this.ExistingPersonsCB.FormattingEnabled = true;
            this.ExistingPersonsCB.Location = new System.Drawing.Point(33, 58);
            this.ExistingPersonsCB.Name = "ExistingPersonsCB";
            this.ExistingPersonsCB.Size = new System.Drawing.Size(287, 21);
            this.ExistingPersonsCB.TabIndex = 30;
            this.ExistingPersonsCB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 465);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(361, 429);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.RegistratePanel.ResumeLayout(false);
            this.RegistratePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox ConferentionsCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox additionalServicesChLB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label toParticipationsBtn;
        private System.Windows.Forms.Button registrationBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox SecondNameField;
        private System.Windows.Forms.TextBox FirstNameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SectionsCB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ExistingPersonL;
        private System.Windows.Forms.Label RegistratePersonL;
        private System.Windows.Forms.Panel RegistratePanel;
        private System.Windows.Forms.ComboBox ExistingPersonsCB;
    }
}

