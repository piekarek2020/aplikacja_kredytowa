using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ladowanieDanych();
        }

        private void ladowanieDanych()
        {
            cmbKontakt.Items.Add("08:09");
            cmbKontakt.Items.Add("09:10");
            cmbKontakt.Items.Add("10:11");
            cmbKontakt.Items.Add("11:12");
            cmbKontakt.Items.Add("12:13");
            cmbKontakt.Items.Add("13:14");
            cmbKontakt.Items.Add("14:15");
            cmbKontakt.Items.Add("15:16");
            cmbKontakt.Items.Add("16:17");
            cmbKontakt.Items.Add("17:18");
            cmbKontakt.Items.Add("18:19");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\Python_folders\" + txtNazwisko.Text +"_"+ txtImie.Text +".txt"  ;
            string tekst = "Dane klienta: \r\n";
            tekst += "nazwisko: " + txtNazwisko.Text + " imię: " + txtImie.Text + "\r\n";
            tekst += "Dane kontaktowe:\r\n";
            tekst += "telefon: " + txtTelefon.Text + " email: " + txtEmail.Text + "\r\n";
            tekst += "Dane finansowe:\r\n";
            tekst += "kwota kredytu: " + txtKwota.Text + " okres kredytowania: " + txtOkres.Text + "\r\n";
            tekst += "Godzina kontaktu: " + cmbKontakt.Text + "\r\n";
            tekst += "Złożono: " + DateTime.Now.ToString("F") + "\r\n";
            tekst += "Zgoda na prztwarzanie danych osobowych: " + ((checkBox1.Checked) ? "TAK" : "NIE") + "\r\n";
            tekst += "Zgoda na otrzymywanie informacji handlowych: " + ((checkBox1.Checked) ? "TAK" : "NIE") + "\r\n";
            if (!File.Exists(path))
            {
            File.WriteAllText(path, tekst);
            }
            else
            {
              string  zmiana =  "kwota kredytu: " + txtKwota.Text + " okres kredytowania: " + txtOkres.Text + "\r\n";
                zmiana += "Godzina kontaktu: " + cmbKontakt.Text + "\r\n";
                zmiana += "Złożono: " + DateTime.Now.ToString("F") + "\r\n";

                File.AppendAllText(path, zmiana);
            }
            MessageBox.Show("Dane zostały wysłane!", "Formularz kontaktowy", MessageBoxButtons.OK);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtKwota.Text = $"{trackBar1.Value.ToString()} zł.";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            txtOkres.Text = $"{trackBar2.Value.ToString()} m-cy.";
        }

      
    }
}
