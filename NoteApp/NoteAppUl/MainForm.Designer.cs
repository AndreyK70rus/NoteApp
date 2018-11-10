namespace NoteAppUl
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FileToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.AddNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoteListBox = new System.Windows.Forms.ListBox();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.Label();
            this.Created1 = new System.Windows.Forms.Label();
            this.Modified = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripSplitButton,
            this.EditToolStripSplitButton,
            this.AboutToolStripSplitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(144, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FileToolStripSplitButton
            // 
            this.FileToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("FileToolStripSplitButton.Image")));
            this.FileToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileToolStripSplitButton.Name = "FileToolStripSplitButton";
            this.FileToolStripSplitButton.Size = new System.Drawing.Size(41, 22);
            this.FileToolStripSplitButton.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripSplitButton
            // 
            this.EditToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteToolStripMenuItem,
            this.EditNoteToolStripMenuItem,
            this.RemoveNoteToolStripMenuItem});
            this.EditToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripSplitButton.Name = "EditToolStripSplitButton";
            this.EditToolStripSplitButton.Size = new System.Drawing.Size(43, 22);
            this.EditToolStripSplitButton.Text = "Edit";
            // 
            // AddNoteToolStripMenuItem
            // 
            this.AddNoteToolStripMenuItem.Name = "AddNoteToolStripMenuItem";
            this.AddNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddNoteToolStripMenuItem.Text = "Add Note";
            this.AddNoteToolStripMenuItem.Click += new System.EventHandler(this.AddNoteToolStripMenuItem_Click);
            // 
            // EditNoteToolStripMenuItem
            // 
            this.EditNoteToolStripMenuItem.Name = "EditNoteToolStripMenuItem";
            this.EditNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditNoteToolStripMenuItem.Text = "Edit Note";
            this.EditNoteToolStripMenuItem.Click += new System.EventHandler(this.EditNoteToolStripMenuItem_Click);
            // 
            // RemoveNoteToolStripMenuItem
            // 
            this.RemoveNoteToolStripMenuItem.Name = "RemoveNoteToolStripMenuItem";
            this.RemoveNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RemoveNoteToolStripMenuItem.Text = "Remove Note";
            this.RemoveNoteToolStripMenuItem.Click += new System.EventHandler(this.RemoveNoteToolStripMenuItem_Click);
            // 
            // AboutToolStripSplitButton
            // 
            this.AboutToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.AboutToolStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutToolStripSplitButton.Image")));
            this.AboutToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutToolStripSplitButton.Name = "AboutToolStripSplitButton";
            this.AboutToolStripSplitButton.Size = new System.Drawing.Size(48, 22);
            this.AboutToolStripSplitButton.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // NoteListBox
            // 
            this.NoteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.NoteListBox.FormattingEnabled = true;
            this.NoteListBox.Location = new System.Drawing.Point(0, 52);
            this.NoteListBox.Name = "NoteListBox";
            this.NoteListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NoteListBox.Size = new System.Drawing.Size(232, 342);
            this.NoteListBox.TabIndex = 4;
            this.NoteListBox.SelectedIndexChanged += new System.EventHandler(this.NoteListBox_SelectedIndexChanged);
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(0, 25);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(82, 13);
            this.ShowCategoryLabel.TabIndex = 5;
            this.ShowCategoryLabel.Text = "Show Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Location = new System.Drawing.Point(88, 23);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 23;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 2F);
            this.AddButton.Location = new System.Drawing.Point(3, 415);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(23, 21);
            this.AddButton.TabIndex = 7;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackColor = System.Drawing.SystemColors.Control;
            this.EditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditButton.BackgroundImage")));
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 2F);
            this.EditButton.Location = new System.Drawing.Point(32, 415);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(23, 21);
            this.EditButton.TabIndex = 8;
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Category
            // 
            this.Category.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(248, 52);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(52, 13);
            this.Category.TabIndex = 10;
            this.Category.Text = "Category:";
            // 
            // Created1
            // 
            this.Created1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Created1.AutoSize = true;
            this.Created1.Location = new System.Drawing.Point(248, 82);
            this.Created1.Name = "Created1";
            this.Created1.Size = new System.Drawing.Size(47, 13);
            this.Created1.TabIndex = 11;
            this.Created1.Text = "Created:";
            // 
            // Modified
            // 
            this.Modified.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Modified.AutoSize = true;
            this.Modified.Location = new System.Drawing.Point(445, 82);
            this.Modified.Name = "Modified";
            this.Modified.Size = new System.Drawing.Size(50, 13);
            this.Modified.TabIndex = 12;
            this.Modified.Text = "Modified:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedDateTimePicker.Enabled = false;
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(297, 79);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.CreatedDateTimePicker.TabIndex = 14;
            // 
            // ModifiedDateTimePicker
            // 
            this.ModifiedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifiedDateTimePicker.Enabled = false;
            this.ModifiedDateTimePicker.Location = new System.Drawing.Point(498, 79);
            this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            this.ModifiedDateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.ModifiedDateTimePicker.TabIndex = 15;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.CategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CategoryTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CategoryTextBox.Location = new System.Drawing.Point(306, 52);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(103, 13);
            this.CategoryTextBox.TabIndex = 18;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 438);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox1.Location = new System.Drawing.Point(251, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(386, 25);
            this.textBox1.TabIndex = 21;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.BackgroundImage")));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 2F);
            this.DeleteButton.Location = new System.Drawing.Point(60, 415);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(23, 21);
            this.DeleteButton.TabIndex = 22;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // RichTextBox
            // 
            this.RichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RichTextBox.Location = new System.Drawing.Point(251, 105);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.ReadOnly = true;
            this.RichTextBox.Size = new System.Drawing.Size(434, 331);
            this.RichTextBox.TabIndex = 24;
            this.RichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(687, 438);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.ModifiedDateTimePicker);
            this.Controls.Add(this.CreatedDateTimePicker);
            this.Controls.Add(this.Modified);
            this.Controls.Add(this.Created1);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.ShowCategoryLabel);
            this.Controls.Add(this.NoteListBox);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "NoteApp";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton FileToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton EditToolStripSplitButton;
        private System.Windows.Forms.ToolStripSplitButton AboutToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem AddNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ListBox NoteListBox;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Created1;
        private System.Windows.Forms.Label Modified;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.RichTextBox RichTextBox;
    }
}