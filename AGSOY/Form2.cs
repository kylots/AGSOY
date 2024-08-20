using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGSOY
{
    public partial class Form2 : Form1
    {
        Form formRef;
        Button btnBackToForm1;

        public Form2(string Song, string Composer, string Genre, string Language, string Inspired, string Durarion, Form formRef)
        {
            InitializeComponent();
            LSong.Text = Song;
            LComposer.Text = Composer;
            LGenre.Text = Genre;
            LLanguage.Text = Language;
            LInspiredby.Text = Inspired;
            LDuration.Text = Durarion;
            btnStart.Visible = false;
            txtSong.Visible = false;
            txtComposer.Visible = false;
            txtGenre.Visible = false;
            txtLanguage.Visible = false;
            txtInspiredby.Visible = false;
            txtDuration.Visible = false;

            this.formRef = formRef;

            btnBackToForm1 = new Button();
            this.Controls.Add(btnBackToForm1);
            btnBackToForm1.Location = new Point(304, 403);
            btnBackToForm1.Size = new Size(173, 63);
            btnBackToForm1.Text = "Logout";
            btnBackToForm1.Click += BtnBackToForm1_Click;

            this.Height = 630;
            this.Width = 780;
        }

        private void BtnBackToForm1_Click(object? sender, EventArgs e)
        {
            this.Close();
            formRef.Show();
        }
    }
}
    