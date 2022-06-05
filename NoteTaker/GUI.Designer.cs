namespace NoteTaker
{
    partial class GUI
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
            this.notesPanel = new System.Windows.Forms.Panel();
            this.viewAndEditNoteButton = new System.Windows.Forms.Button();
            this.deleteNoteButton = new System.Windows.Forms.Button();
            this.newNoteButton = new System.Windows.Forms.Button();
            this.listBoxOfNotes = new System.Windows.Forms.ListBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.applicationLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.saveNoteButton = new System.Windows.Forms.Button();
            this.draggableBar = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.notesPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.draggableBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // notesPanel
            // 
            this.notesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.notesPanel.Controls.Add(this.viewAndEditNoteButton);
            this.notesPanel.Controls.Add(this.deleteNoteButton);
            this.notesPanel.Controls.Add(this.newNoteButton);
            this.notesPanel.Controls.Add(this.listBoxOfNotes);
            this.notesPanel.Controls.Add(this.notesLabel);
            this.notesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.notesPanel.Location = new System.Drawing.Point(0, 0);
            this.notesPanel.Name = "notesPanel";
            this.notesPanel.Size = new System.Drawing.Size(200, 800);
            this.notesPanel.TabIndex = 0;
            // 
            // viewAndEditNoteButton
            // 
            this.viewAndEditNoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(204)))), ((int)(((byte)(163)))));
            this.viewAndEditNoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAndEditNoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.viewAndEditNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAndEditNoteButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewAndEditNoteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(49)))));
            this.viewAndEditNoteButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.viewAndEditNoteButton.Location = new System.Drawing.Point(44, 705);
            this.viewAndEditNoteButton.Name = "viewAndEditNoteButton";
            this.viewAndEditNoteButton.Size = new System.Drawing.Size(111, 32);
            this.viewAndEditNoteButton.TabIndex = 5;
            this.viewAndEditNoteButton.Text = "View/Edit";
            this.viewAndEditNoteButton.UseVisualStyleBackColor = false;
            this.viewAndEditNoteButton.Click += new System.EventHandler(this.editNoteButton_Click);
            // 
            // deleteNoteButton
            // 
            this.deleteNoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(204)))), ((int)(((byte)(163)))));
            this.deleteNoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteNoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteNoteButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteNoteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(49)))));
            this.deleteNoteButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteNoteButton.Location = new System.Drawing.Point(44, 743);
            this.deleteNoteButton.Name = "deleteNoteButton";
            this.deleteNoteButton.Size = new System.Drawing.Size(111, 32);
            this.deleteNoteButton.TabIndex = 4;
            this.deleteNoteButton.Text = "Delete Note";
            this.deleteNoteButton.UseVisualStyleBackColor = false;
            this.deleteNoteButton.Click += new System.EventHandler(this.deleteNoteButton_Click);
            // 
            // newNoteButton
            // 
            this.newNoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(204)))), ((int)(((byte)(163)))));
            this.newNoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newNoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newNoteButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newNoteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(49)))));
            this.newNoteButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newNoteButton.Location = new System.Drawing.Point(44, 667);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(111, 32);
            this.newNoteButton.TabIndex = 3;
            this.newNoteButton.Text = "New Note";
            this.newNoteButton.UseVisualStyleBackColor = false;
            this.newNoteButton.Click += new System.EventHandler(this.newNoteButton_Click);
            // 
            // listBoxOfNotes
            // 
            this.listBoxOfNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.listBoxOfNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxOfNotes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxOfNotes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxOfNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.listBoxOfNotes.FormattingEnabled = true;
            this.listBoxOfNotes.HorizontalScrollbar = true;
            this.listBoxOfNotes.ItemHeight = 18;
            this.listBoxOfNotes.Location = new System.Drawing.Point(13, 123);
            this.listBoxOfNotes.Name = "listBoxOfNotes";
            this.listBoxOfNotes.Size = new System.Drawing.Size(174, 522);
            this.listBoxOfNotes.TabIndex = 2;
            this.listBoxOfNotes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxOfNotes_DrawItem);
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(204)))), ((int)(((byte)(163)))));
            this.notesLabel.Location = new System.Drawing.Point(63, 55);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(79, 28);
            this.notesLabel.TabIndex = 1;
            this.notesLabel.Text = "Notes";
            // 
            // applicationLabel
            // 
            this.applicationLabel.AutoSize = true;
            this.applicationLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.applicationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(204)))), ((int)(((byte)(163)))));
            this.applicationLabel.Location = new System.Drawing.Point(516, 37);
            this.applicationLabel.Name = "applicationLabel";
            this.applicationLabel.Size = new System.Drawing.Size(188, 38);
            this.applicationLabel.TabIndex = 2;
            this.applicationLabel.Text = "NoteTaker";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.titleTextBox);
            this.panel2.Controls.Add(this.contentTextBox);
            this.panel2.Controls.Add(this.saveNoteButton);
            this.panel2.Location = new System.Drawing.Point(220, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 652);
            this.panel2.TabIndex = 3;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Enabled = false;
            this.titleTextBox.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.titleTextBox.Location = new System.Drawing.Point(0, 30);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(759, 25);
            this.titleTextBox.TabIndex = 7;
            this.titleTextBox.Text = "Title";
            this.titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contentTextBox
            // 
            this.contentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.contentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contentTextBox.Enabled = false;
            this.contentTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contentTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.contentTextBox.Location = new System.Drawing.Point(0, 104);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(759, 498);
            this.contentTextBox.TabIndex = 6;
            this.contentTextBox.Text = "Content";
            this.contentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveNoteButton
            // 
            this.saveNoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(204)))), ((int)(((byte)(163)))));
            this.saveNoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveNoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNoteButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveNoteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(49)))));
            this.saveNoteButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveNoteButton.Location = new System.Drawing.Point(315, 620);
            this.saveNoteButton.Name = "saveNoteButton";
            this.saveNoteButton.Size = new System.Drawing.Size(111, 32);
            this.saveNoteButton.TabIndex = 5;
            this.saveNoteButton.Text = "Save Note";
            this.saveNoteButton.UseVisualStyleBackColor = false;
            this.saveNoteButton.Click += new System.EventHandler(this.saveNoteButton_Click);
            // 
            // draggableBar
            // 
            this.draggableBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(49)))));
            this.draggableBar.Controls.Add(this.closeButton);
            this.draggableBar.Location = new System.Drawing.Point(201, 0);
            this.draggableBar.Name = "draggableBar";
            this.draggableBar.Size = new System.Drawing.Size(799, 34);
            this.draggableBar.TabIndex = 4;
            this.draggableBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.draggableBar_MouseDown);
            this.draggableBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.draggableBar_MouseMove);
            this.draggableBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.draggableBar_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(204)))), ((int)(((byte)(163)))));
            this.closeButton.Location = new System.Drawing.Point(761, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(27, 27);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.draggableBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.applicationLabel);
            this.Controls.Add(this.notesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI";
            this.Text = "GUI";
            this.notesPanel.ResumeLayout(false);
            this.notesPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.draggableBar.ResumeLayout(false);
            this.draggableBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel notesPanel;
        private Label notesLabel;
        private Label applicationLabel;
        private ListBox listBoxOfNotes;
        private Panel panel2;
        private Button newNoteButton;
        private Button deleteNoteButton;
        private Button saveNoteButton;
        private TextBox contentTextBox;
        private TextBox titleTextBox;
        private Button viewAndEditNoteButton;
        private Panel draggableBar;
        private Label closeButton;
    }
}