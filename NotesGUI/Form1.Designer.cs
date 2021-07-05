using System.Windows.Forms;
using System.Drawing;
using System;
using System.Globalization;

using System.Collections.Generic;

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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.arToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.esToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ruToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchButton = new System.Windows.Forms.Button();
            this.notexText = new System.Windows.Forms.TextBox();
            this.deleteNote = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(127, 37);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(213, 20);
            this.searchTextBox.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem1,
            this.notesToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 3;
            // 
            // languageToolStripMenuItem1
            // 
            this.languageToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arToolStripMenuItem1,
            this.esToolStripMenuItem1,
            this.ruToolStripMenuItem1,
            this.enUSToolStripMenuItem});
            this.languageToolStripMenuItem1.Name = "languageToolStripMenuItem1";
            this.languageToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem1.Text = "Language";
            // 
            // arToolStripMenuItem1
            // 
            this.arToolStripMenuItem1.Name = "arToolStripMenuItem1";
            this.arToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.arToolStripMenuItem1.Text = "ar";
            // 
            // esToolStripMenuItem1
            // 
            this.esToolStripMenuItem1.Name = "esToolStripMenuItem1";
            this.esToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.esToolStripMenuItem1.Text = "es";
            // 
            // ruToolStripMenuItem1
            // 
            this.ruToolStripMenuItem1.Name = "ruToolStripMenuItem1";
            this.ruToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.ruToolStripMenuItem1.Text = "ru";
            // 
            // enUSToolStripMenuItem
            // 
            this.enUSToolStripMenuItem.Name = "enUSToolStripMenuItem";
            this.enUSToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.enUSToolStripMenuItem.Text = "en-US";
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notesToolStripMenuItem.Text = "Notes";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // searchButton
            // 
            this.searchButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchButton.Location = new System.Drawing.Point(348, 37);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 20);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Поиск";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // notexText
            // 
            this.notexText.Location = new System.Drawing.Point(127, 222);
            this.notexText.Name = "notexText";
            this.notexText.Size = new System.Drawing.Size(213, 20);
            this.notexText.TabIndex = 4;
            this.notexText.Text = "Enter note\'s name";
            this.notexText.Visible = false;
            this.notexText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.notexText_KeyDown);
            // 
            // deleteNote
            // 
            this.deleteNote.Location = new System.Drawing.Point(127, 248);
            this.deleteNote.Name = "deleteNote";
            this.deleteNote.Size = new System.Drawing.Size(213, 20);
            this.deleteNote.TabIndex = 5;
            this.deleteNote.Text = "Enter note\'s name";
            this.deleteNote.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 661);
            this.Controls.Add(this.deleteNote);
            this.Controls.Add(this.notexText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox searchTextBox;
        public List<Button> Notes { get; private set; }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem languageToolStripMenuItem1;
        private ToolStripMenuItem arToolStripMenuItem1;
        private ToolStripMenuItem esToolStripMenuItem1;
        private ToolStripMenuItem ruToolStripMenuItem1;
        private ToolStripMenuItem enUSToolStripMenuItem;
        private ToolStripMenuItem notesToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Button searchButton;
        private TextBox notexText;
        private TextBox deleteNote;
    }
}

