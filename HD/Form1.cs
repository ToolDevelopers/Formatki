using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HD
{
    public partial class Formatki : Form
    {
        int OknoRuch, OśX, OśY;

        public Formatki()
        {
            InitializeComponent();
        }

        private void PanelGórny_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (OknoRuch == 1)
            {
                SetDesktopLocation(MousePosition.X - OśX, MousePosition.Y - OśY);
            }
        }

        private void PanelGórny_MouseDown_1(object sender, MouseEventArgs e)
        {
            OknoRuch = 1; OśX = e.X; OśY = e.Y;
        }

        private void PanelGórny_MouseUp_1(object sender, MouseEventArgs e)
        {
            OknoRuch = 0;
        }

        private void oknoTop_Click(object sender, EventArgs e)
        {
            ToolTip Informacje = new ToolTip();

            if (TopMost == true)
            {
                TopMost = false;

                oknoTop.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;

                if (oknoTop.FlatAppearance.MouseOverBackColor == Color.MediumSeaGreen)
                {
                    Informacje.SetToolTip(oknoTop, "Okno programu zawsze na wierzchu (włącz)");
                }

                else
                {
                    Informacje.SetToolTip(oknoTop, "Okno programu zawsze na wierzchu (wyłącz)");
                }
            }

            else
            {
                TopMost = true;

                oknoTop.FlatAppearance.MouseOverBackColor = Color.Red;

                if (oknoTop.FlatAppearance.MouseOverBackColor == Color.MediumSeaGreen)
                {
                    Informacje.SetToolTip(oknoTop, "Okno programu zawsze na wierzchu (włącz)");
                }

                else
                {
                    Informacje.SetToolTip(oknoTop, "Okno programu zawsze na wierzchu (wyłącz)");
                }
            }
        }

        private void Formatki_Load(object sender, EventArgs e)
        {
            Linia_Click(this, new EventArgs());

            ToolTip Informacje = new ToolTip();

            Informacje.SetToolTip(ustawienia, "Ustawienia");

            Informacje.SetToolTip(Linia, "Odpowiedzi dla pracowników linii telefonicznej");

            Informacje.SetToolTip(zgłoszenia, "Odpowiedzi dla pracowników wykonujących zgłoszenia");

            Informacje.SetToolTip(Poczta, "Odpowiedzi związane z pocztą");

            Informacje.SetToolTip(pozostałe, "Pozostałe odpowiedzi");

            Informacje.SetToolTip(Wyjście, "Zamknij program");

            Informacje.SetToolTip(minimalizuj, "Minimalizuj okno");

            if (oknoTop.FlatAppearance.MouseOverBackColor == Color.MediumSeaGreen)
            {
                Informacje.SetToolTip(oknoTop, "Okno programu zawsze na wierzchu (włącz)");
            }

            else
            {
                Informacje.SetToolTip(oknoTop, "Okno programu zawsze na wierzchu (wyłącz)");
            }

            Informacje.SetToolTip(motywKremowy, "Kremowy");

            Informacje.SetToolTip(motywSzary, "Szary");

            Informacje.SetToolTip(motywZłoty, "Zółty");

            Informacje.SetToolTip(motywZielony, "Zielony");

            Informacje.SetToolTip(motywCzerwony, "Czerwony");

            Informacje.SetToolTip(MotywNiebieski, "Niebieski");

            Informacje.SetToolTip(MotywBrązowy, "Brązaowy");

            Informacje.SetToolTip(MotywFioletowy, "Fioletowy");

            Informacje.SetToolTip(MotywLimonkowy, "Limonkowy");

            Informacje.SetToolTip(MotywTurkusowy, "Turkusowy");

            Informacje.SetToolTip(MotywBiały, "Biały");

            Informacje.SetToolTip(generatorKoloru, "Stwórz własny kolor");

            Informacje.SetToolTip(Binduj, "Umożliwia przypisanie danej formatki dla wybranego przycisku na klawiaturze");

            Informacje.SetToolTip(Import, "Umożliwia zaimportowanie wybranych formatek z pliku");

            Informacje.SetToolTip(generator, "Umożliwia wygenerowanie własnej formatki oraz ustawienie przycisku");

            Informacje.SetToolTip(edytor, "Umożliwia edycję gotowych formatek w aplikacji");

            Informacje.SetToolTip(potwierdzenie, "Użytkownik potwierdził prawidłowe działanie. W przypadku pytań lub problemów dotyczących zrealizowanego zgłoszenia, proszę o kontakt" +
                "z infolinią IT TALEX (opcja nr 3). Konsultant, w przypadku dostępności administratora, niezwłocznie przekieruję do niego rozmowę.");

            Informacje.SetToolTip(recznaInstalacja, "Wykonano instalację ręczną. Użytkownik telefonicznie potwierdził prawidłowe działanie programu. W przypadku pytań lub problemów" +
                "proszę o kontakt z infolinią IT TALEX - 71 395 3333 (opcja nr 3). Konsultant, w przypadku dostępności administratora, niezwłocznie przekieruję do niego rozmowę.");

            Informacje.SetToolTip(button3, "Wykonano konfigurację. Użytkownik telefonicznie potwierdził prawidłowe działanie programu. W przypadku pytań lub problemów" +
                "proszę o kontakt z infolinią IT TALEX - 71 395 3333 (opcja nr 3). Konsultant, w przypadku dostępności administratora, niezwłocznie przekieruję do niego rozmowę.");

        }

        private void ustawienia_Click(object sender, EventArgs e)
        {
            OknoUstawienia.Dock = DockStyle.Fill;

            OknoUstawienia.Visible = true;

            oknoLinia.Visible = false;

            oknoZgłoszenia.Visible = false;

            oknoPoczta.Visible = false;

            oknoPozostałe.Visible = false;

            ustawienia.BackColor = Color.SaddleBrown;

            Linia.BackColor = Color.LemonChiffon;

            zgłoszenia.BackColor = Color.LemonChiffon;

            Poczta.BackColor = Color.LemonChiffon;

            pozostałe.BackColor = Color.LemonChiffon;

            ustawienia.FlatAppearance.MouseOverBackColor = Color.Sienna;

            Linia.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;

            zgłoszenia.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;

            Poczta.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;

            pozostałe.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;
        }

        private void motywSzary_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja premium :)", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void motywZłoty_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja premium :)", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void motywZielony_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja premium :)", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void motywCzerwony_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja premium :)", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MotywNiebieski_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja premium :)", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MotywBrązowy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja premium :)", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MotywFioletowy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja premium :)", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MotywLimonkowy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja premium :)", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MotywTurkusowy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja premium :)", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MotywBiały_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja premium :)", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void generatorKoloru_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja premium :)", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Linia_Click(object sender, EventArgs e)
        {
            oknoLinia.Dock = DockStyle.Fill;

            oknoLinia.Visible = true;

            OknoUstawienia.Visible = false;

            oknoZgłoszenia.Visible = false;

            oknoPoczta.Visible = false;

            oknoPozostałe.Visible = false;

            ustawienia.BackColor = Color.LemonChiffon;

            Linia.BackColor = Color.SaddleBrown;

            zgłoszenia.BackColor = Color.LemonChiffon;

            Poczta.BackColor = Color.LemonChiffon;

            pozostałe.BackColor = Color.LemonChiffon;

            ustawienia.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;

            Linia.FlatAppearance.MouseOverBackColor = Color.Sienna;

            zgłoszenia.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;

            Poczta.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;

            pozostałe.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;
        }

        private void zgłoszenia_Click(object sender, EventArgs e)
        {
            oknoZgłoszenia.Dock = DockStyle.Fill;

            oknoZgłoszenia.Visible = true;

            OknoUstawienia.Visible = false;

            oknoLinia.Visible = false;

            oknoPoczta.Visible = false;

            oknoPozostałe.Visible = false;

            ustawienia.BackColor = Color.LemonChiffon;

            Linia.BackColor = Color.LemonChiffon;

            zgłoszenia.BackColor = Color.SaddleBrown;

            Poczta.BackColor = Color.LemonChiffon;

            pozostałe.BackColor = Color.LemonChiffon;

            ustawienia.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;

            Linia.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;

            zgłoszenia.FlatAppearance.MouseOverBackColor = Color.Sienna;

            Poczta.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;

            pozostałe.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;
        }

        private void Poczta_Click(object sender, EventArgs e)
        {
            oknoPoczta.Dock = DockStyle.Fill;

            oknoPozostałe.Visible = false;

            OknoUstawienia.Visible = false;

            oknoLinia.Visible = false;

            oknoZgłoszenia.Visible = false;

            oknoPoczta.Visible = true;

            ustawienia.BackColor = Color.LemonChiffon;

            Linia.BackColor = Color.LemonChiffon;

            zgłoszenia.BackColor = Color.LemonChiffon;

            Poczta.BackColor = Color.SaddleBrown;

            pozostałe.BackColor = Color.LemonChiffon;

            ustawienia.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;

            Linia.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;

            zgłoszenia.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;

            Poczta.FlatAppearance.MouseOverBackColor = Color.Sienna;

            pozostałe.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;
        }

        private void pozostałe_Click(object sender, EventArgs e)
        {
            oknoPozostałe.Dock = DockStyle.Fill;

            oknoPoczta.Visible = true;

            OknoUstawienia.Visible = false;

            oknoLinia.Visible = false;

            oknoZgłoszenia.Visible = false;

            oknoPoczta.Visible = false;

            oknoPozostałe.Visible = true;

            ustawienia.BackColor = Color.LemonChiffon;

            Linia.BackColor = Color.LemonChiffon;

            zgłoszenia.BackColor = Color.LemonChiffon;

            Poczta.BackColor = Color.LemonChiffon;

            pozostałe.BackColor = Color.SaddleBrown;

            ustawienia.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;

            Linia.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;

            zgłoszenia.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;

            Poczta.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;

            pozostałe.FlatAppearance.MouseOverBackColor = Color.Sienna;
        }

        private void edytor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja premium :)", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void generator_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja premium :)", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Import_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja premium :)", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Binduj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja premium :)", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Wykonano konfigurację. Użytkownik telefonicznie potwierdził prawidłowe działanie programu.\n\nW przypadku pytań lub problemów" +
                "proszę o kontakt z infolinią IT TALEX - 71 395 3333 (opcja nr 3). Konsultant, w przypadku dostępności administratora, niezwłocznie przekieruję do niego rozmowę.");
        }

        private void potwierdzenie_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Użytkownik telefonicznie potwierdził prawidłowe działanie.\n\nW przypadku pytań lub problemów dotyczących zrealizowanego zgłoszenia, proszę o kontakt" +
                "z infolinią IT TALEX - 71 395 3333 (opcja nr 3). Konsultant, w przypadku dostępności administratora, niezwłocznie przekieruję do niego rozmowę.");
        }

        private void recznaInstalacja_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Wykonano instalację ręczną. Użytkownik telefonicznie potwierdził prawidłowe działanie programu.\n\nW przypadku pytań lub problemów" +
                "proszę o kontakt z infolinią IT TALEX - 71 395 3333 (opcja nr 3). Konsultant, w przypadku dostępności administratora, niezwłocznie przekieruję do niego rozmowę.");
        }

        private void Wyjście_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimalizuj_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
