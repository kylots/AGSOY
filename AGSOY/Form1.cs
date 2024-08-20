namespace AGSOY
{
    public partial class Form1 : Form
    {
        public Label lblSong, lblComposer, lblGenre, lblLanguage, lblInspiredby, lblDuration,
            LSong, LComposer, LGenre, LLanguage, LInspiredby, LDuration;
        public TextBox txtSong, txtComposer, txtGenre, txtLanguage, txtInspiredby, txtDuration;
        public Button btnStart;
        public Form1()
        { 
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            lblSong = new Label();
            this.Controls.Add(lblSong);
            lblSong.Location = new Point(331, 36);
            lblSong.Size = new Size(45, 32);
            lblSong.Text = "Song";

            lblComposer = new Label();
            this.Controls.Add(lblComposer);
            lblComposer.Location = new Point(268, 101);
            lblComposer.Size = new Size(82, 21);
            lblComposer.Text = "Composer";

            lblGenre = new Label();
            this.Controls.Add(lblGenre);
            lblGenre.Location = new Point(268, 159);
            lblGenre.Size = new Size(52, 21);
            lblGenre.Text = "Genre";

            lblLanguage = new Label();
            this.Controls.Add(lblLanguage);
            lblLanguage.Location = new Point(268, 217);
            lblLanguage.Size = new Size(78, 21);
            lblLanguage.Text = "Language";

            lblInspiredby = new Label();
            this.Controls.Add(lblInspiredby);
            lblInspiredby.Location = new Point(268, 279);
            lblInspiredby.Size = new Size(87, 21);
            lblInspiredby.Text = "Inspired by";

            lblDuration = new Label();
            this.Controls.Add(lblDuration);
            lblDuration.Location = new Point(268, 339);
            lblDuration.Size = new Size(71, 21);
            lblDuration.Text = "Duration";

            txtSong = new TextBox();
            this.Controls.Add(txtSong);
            txtSong.Location = new Point(377, 28);
            txtSong.Size = new Size(161, 26);

            txtComposer = new TextBox();
            this.Controls.Add(txtComposer);
            txtComposer.Location = new Point(366, 93);
            txtComposer.Size = new Size(172, 29);

            txtGenre = new TextBox();
            this.Controls.Add(txtGenre);
            txtGenre.Location = new Point(366, 151);
            txtGenre.Size = new Size(172, 29);

            txtLanguage = new TextBox();
            this.Controls.Add(txtLanguage);
            txtLanguage.Location = new Point(366, 209);
            txtLanguage.Size = new Size(172, 29);

            txtInspiredby = new TextBox();
            this.Controls.Add(txtInspiredby);
            txtInspiredby.Location = new Point(366, 271);
            txtInspiredby.Size = new Size(172, 29);

            txtDuration = new TextBox();
            this.Controls.Add(txtDuration);
            txtDuration.Location = new Point(366, 331);
            txtDuration.Size = new Size(172, 29);
            //lbl here
            LSong = new Label();
            this.Controls.Add(LSong);
            LSong.Location = new Point(390, 32);
            LSong.Size = new Size(161, 26);
            txtSong.Text = LSong.Text;

            LComposer = new Label();
            this.Controls.Add(LComposer);
            LComposer.Location = new Point(366, 101);
            LComposer.Size = new Size(172, 29);
            txtComposer.Text = LComposer.Text;

            LGenre = new Label();
            this.Controls.Add(LGenre);
            LGenre.Location = new Point(366, 151);
            LGenre.Size = new Size(172, 29);
            txtGenre.Text = LGenre.Text;

            LLanguage = new Label();
            this.Controls.Add(LLanguage);
            LLanguage.Location = new Point(366, 279);
            LLanguage.Size = new Size(172, 29);
            txtLanguage.Text = LLanguage.Text;

            LInspiredby = new Label();
            this.Controls.Add(LInspiredby);
            LInspiredby.Location = new Point(366, 279);
            LInspiredby.Size = new Size(172, 29);
            txtInspiredby.Text = LInspiredby.Text;

            LDuration = new Label();
            this.Controls.Add(LDuration);
            LDuration.Location = new Point(366, 339);
            LDuration.Size = new Size(172, 29);
            txtDuration.Text = LDuration.Text;

            btnStart = new Button();
            this.Controls.Add(btnStart);
            btnStart.Location = new Point(304, 403);
            btnStart.Size = new Size(173, 63);
            btnStart.Text = "Go!!!";

            this.Height = 630;
            this.Width = 780;

            btnStart.Click += BtnStart_Click1;
        }

        private void BtnStart_Click1(object? sender, EventArgs e)
        {
            string Song = txtSong.Text;
            string Composer = txtComposer.Text;
            string Genre = txtGenre.Text;
            string Language = txtLanguage.Text;
            string Inspired = txtInspiredby.Text;
            string Duration = txtDuration.Text;

            Form2 form2 = new Form2(Song, Composer, Genre, Language, Inspired, Duration, this);
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.Show();
            this.Hide();
        }
    }
}
    