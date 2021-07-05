using System.Windows.Forms;
using System.Drawing;
using System;
using System.Globalization;

namespace NotesGUI
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

        System.ComponentModel.ComponentResourceManager resources;
        private void InitializeComponent()
        {
            resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.esToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ruToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            resources.ApplyResources(this.searchTextBox, "searchTextBox");
            this.searchTextBox.Name = "searchTextBox";
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.Name = "searchButton";
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Gray;
            this.bottomPanel.Controls.Add(this.button2);
            this.bottomPanel.Controls.Add(this.button1);
            resources.ApplyResources(this.bottomPanel, "bottomPanel");
            this.bottomPanel.Name = "bottomPanel";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // languageToolStripMenuItem1
            // 
            this.languageToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arToolStripMenuItem1,
            this.esToolStripMenuItem1,
            this.ruToolStripMenuItem1,
            this.enUSToolStripMenuItem});
            this.languageToolStripMenuItem1.Name = "languageToolStripMenuItem1";
            resources.ApplyResources(this.languageToolStripMenuItem1, "languageToolStripMenuItem1");
            // 
            // arToolStripMenuItem1
            // 
            this.arToolStripMenuItem1.Name = "arToolStripMenuItem1";
            this.arToolStripMenuItem1.Click += LanguageToolStripMenuItem_Click;
            resources.ApplyResources(this.arToolStripMenuItem1, "arToolStripMenuItem1");
            // 
            // esToolStripMenuItem1
            // 
            this.esToolStripMenuItem1.Name = "esToolStripMenuItem1";
            this.esToolStripMenuItem1.Click += LanguageToolStripMenuItem_Click;
            resources.ApplyResources(this.esToolStripMenuItem1, "esToolStripMenuItem1");
            //
            // ruToolStripMenuItem1
            // 
            this.ruToolStripMenuItem1.Name = "ruToolStripMenuItem1";
            this.ruToolStripMenuItem1.Click += LanguageToolStripMenuItem_Click;
            resources.ApplyResources(this.ruToolStripMenuItem1, "ruToolStripMenuItem1");
            // 
            // enUSToolStripMenuItem
            // 
            this.enUSToolStripMenuItem.Name = "enUSToolStripMenuItem";
            this.enUSToolStripMenuItem.Click += LanguageToolStripMenuItem_Click;
            resources.ApplyResources(this.enUSToolStripMenuItem, "enUSToolStripMenuItem");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.bottomPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }

        private void LanguageToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            CultureInfo ci = new CultureInfo((sender as ToolStripMenuItem).Text);
            foreach (Control c in this.Controls)
                resources.ApplyResources(c, c.Name, ci);
            foreach (ToolStripItem c in menuStrip1.Items)
            {
                foreach (ToolStripItem item in languageToolStripMenuItem1.DropDownItems)
                    resources.ApplyResources(item, item.Name, ci);
                resources.ApplyResources(c, c.Name, ci);
            }
        }

        private Panel bottomPanel;
        private Button searchButton;
        private TextBox searchTextBox;


        #endregion
        private MenuStrip menuStrip1;
        private Button button1;
        private Button button2;
        private ToolStripMenuItem languageToolStripMenuItem1;
        private ToolStripMenuItem arToolStripMenuItem1;
        private ToolStripMenuItem esToolStripMenuItem1;
        private ToolStripMenuItem ruToolStripMenuItem1;
        private ToolStripMenuItem enUSToolStripMenuItem;
    }
}

