using System.Diagnostics;

namespace NoteTaker
{
    public partial class GUI : Form
    {
        private Dictionary<string, int> indexOfNotes;
        private Note currentlyViewedNote = new Note("", "", -1);
        private DBHandler dBHandler = new DBHandler();
        private bool mouseDown;
        private Point lastLocation;


        public GUI()
        {
            InitializeComponent();

            refreshNoteList();

        }

        // This function is linked to the edit button, it's used to display the Title and Content of a note by retreieving it from the database
        private void editNoteButton_Click(object sender, EventArgs e)
        {
            object selectedNote = listBoxOfNotes.SelectedItem;

            if (selectedNote != null)
            {
                titleTextBox.TextAlign = HorizontalAlignment.Left;
                contentTextBox.TextAlign = HorizontalAlignment.Left;
                titleTextBox.Enabled = true;
                contentTextBox.Enabled = true;

                int noteID = indexOfNotes[selectedNote.ToString()];

                currentlyViewedNote = dBHandler.RetrieveSingleNote(noteID);

                titleTextBox.Text = currentlyViewedNote.Title;
                contentTextBox.Text = currentlyViewedNote.Content;
            }
        }

        // The new button creates an instance of the note class, it also does some simple formatting on the GUI
        private void newNoteButton_Click(object sender, EventArgs e)
        {
            currentlyViewedNote = new Note("", "", -1);
            listBoxOfNotes.ClearSelected();
            titleTextBox.Text = "";
            contentTextBox.Text = "";
            titleTextBox.Enabled = true;
            contentTextBox.Enabled = true;
            titleTextBox.TextAlign = HorizontalAlignment.Left;
            contentTextBox.TextAlign = HorizontalAlignment.Left;
        }

        // The delete button deletes a note by calling a method from the DBHandler class
        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            object selectedNote = listBoxOfNotes.SelectedItem;

            if (selectedNote != null)
            {
                int noteID = indexOfNotes[selectedNote.ToString()];
                dBHandler.DeleteNote(noteID);
                refreshNoteList();
                titleTextBox.Text = "";
                contentTextBox.Text = "";
            }
        }

        // This method is used to refresh the notes listbox when a change happens in the database
        private void refreshNoteList()
        {
            listBoxOfNotes.Items.Clear();
            indexOfNotes = dBHandler.RetrieveAllNotes();

            foreach (string title in indexOfNotes.Keys)
            {
                listBoxOfNotes.Items.Add(title);
            }
        }

        // The save button is used to saving new notes or updating old ones, this will depend on the ID value being -1 for a new note or an existing ID from the database
        private void saveNoteButton_Click(object sender, EventArgs e)
        {
            currentlyViewedNote.Title = titleTextBox.Text;
            currentlyViewedNote.Content = contentTextBox.Text;

            if (currentlyViewedNote.ID == -1)
            {
                dBHandler.SaveToDatabase(currentlyViewedNote);
            }
            else
            {
                dBHandler.UpdateNote(currentlyViewedNote);
            }

            refreshNoteList();
        }

        // The next 3 functions below are for the top bar of the GUI in order to make it draggable
        private void draggableBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void draggableBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void draggableBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // A custom exit button for the GUI
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // The listbox of notes is redrawn in order to gain more colour customisation used to match the app colour scheme
        private void listBoxOfNotes_DrawItem(object sender, DrawItemEventArgs e)
        {
            SolidBrush textColour = new SolidBrush(Color.FromArgb(238, 238, 238));
            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.FromArgb(35, 41, 49));

            e.DrawBackground();
            e.Graphics.DrawString(listBoxOfNotes.Items[e.Index].ToString(), e.Font, textColour, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();

            listBoxOfNotes.HorizontalScrollbar = true;
            int width = 0;
            Graphics g = listBoxOfNotes.CreateGraphics();
            foreach (object item in listBoxOfNotes.Items)
            {
                string text = item.ToString();
                SizeF s = g.MeasureString(text, listBoxOfNotes.Font);
                if (s.Width > width)
                    width = (int)s.Width;
            }

            listBoxOfNotes.HorizontalExtent = width + 2;

        }
    }
}