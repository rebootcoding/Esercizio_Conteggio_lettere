using System.Security.Cryptography.X509Certificates;

namespace EsercizioConteggio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcola_Click(object sender, EventArgs e)
        {
            var nome = txb_nome.Text.Trim();
            var cognome = txb_cognome.Text.Trim();
            string NomeCompleto = ($"{nome} {cognome}");
            lbl_nome_completo.Text = NomeCompleto;


            var annoNascita = dateTimePicker1.Value;
            var dataOggi = DateTime.Today;
            var età = DateTimeSpan.CompareDates(dataOggi, annoNascita);


            lbl_età.Text = ($"Anni: {età.Years} , Mesi: {età.Months}");
            var città = txb_città.Text;
            string NomeECitta = ($"{nome}{cognome}{città}").ToLower();

            string elencoRisultati = "";

            Dictionary<string, int> lettereNome = new Dictionary<string, int>();

            foreach (var item in NomeECitta)
            {;
                var lettera = item.ToString().ToUpper();
                string letteraMaiuscola;
                if (!lettereNome.ContainsKey(lettera))
                {
                    letteraMaiuscola = lettera.ToString().ToUpper();
                    lettereNome.Add(letteraMaiuscola, 1);
                }
                else
                {
                    lettereNome[lettera] += 1;
                }
            }
           

            foreach (var item in lettereNome)
            {
                string contenuto = ($"La lettera {item.Key} ed è ripetuta {item.Value} volte!{Environment.NewLine}");
                elencoRisultati += (contenuto);
            }

            lbl_conteggio_carattere.Text = elencoRisultati;
            this.AutoSize = true;
        }
    }
}