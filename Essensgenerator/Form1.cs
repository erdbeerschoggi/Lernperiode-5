using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace smthNew
{
    public partial class Gericht : Form
    {
        private List<string> benutzerEingaben = new List<string>();
        private string dateiPfad = "eingaben.txt";
        private Dictionary<string, List<string>> gerichte = new Dictionary<string, List<string>>();

        public Gericht()
        {
            InitializeComponent();
            InitialisiereGerichte();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            benutzerEingaben.Clear();
            foreach (Control ctrl in Controls)
            {
                if (ctrl is CheckBox cb && cb.Checked)
                {
                    benutzerEingaben.Add(cb.Text);
                }
            }
            File.WriteAllLines(dateiPfad, benutzerEingaben);
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(dateiPfad))
            {
                var gespeicherteEingaben = File.ReadAllLines(dateiPfad);
                foreach (Control ctrl in Controls)
                {
                    if (ctrl is CheckBox cb && gespeicherteEingaben.Contains(cb.Text))
                    {
                        cb.Checked = true;
                    }
                }
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            benutzerEingaben.Clear();

            
            List<string> kategorieReihenfolge = new List<string> {
                "Asiatisch", "Amerikanisch", "Europ�isch", "Afrikanisch", "Indisch",
                "Fleisch", "Vegetarisch", "Vegan",
                "Reis", "Kartoffeln", "Gem�se", "Pasta", "Anderes",
            };

            
            foreach (string kategorie in kategorieReihenfolge)
            {
                foreach (Control ctrl in Controls)
                {
                    if (ctrl is CheckBox cb && cb.Checked && cb.Text == kategorie)
                    {
                        benutzerEingaben.Add(kategorie);
                    }
                }
            }

            
            string key = string.Join("-", benutzerEingaben);
            MessageBox.Show($"Generierter Schl�ssel: {key}", "Debugging", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            string vorschlag = "Kein passendes Gericht gefunden.";

            if (gerichte.ContainsKey(key))
            {
                vorschlag = string.Join(" und ", gerichte[key]);
            }
            

            
            MessageBox.Show($"Vorschlag: {vorschlag}", "Gerichtsvorschlag", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    cb.Checked = false;
                }
            }
        }


        private void InitialisiereGerichte()
        {
            gerichte = new Dictionary<string, List<string>>()
            {
               
                { "Asiatisch-Vegan-Reis", new List<string> { "Veganer Sushi-Roll", "Gebratener Reis mit Gem�se" } },
                { "Asiatisch-Vegan-Kartoffeln", new List<string> { "Kartoffel-Curry", "Scharfe Wok-Kartoffeln" } },
                { "Asiatisch-Vegan-Gem�se", new List<string> { "Ged�nstetes Gem�se mit Tofu", "Wok-Gem�se mit Erdnuss-Sauce" } },
                { "Asiatisch-Vegan-Pasta", new List<string> { "Asia-Nudeln mit Tofu", "Scharfe Glasnudeln mit Gem�se" } },
                { "Asiatisch-Vegan-Anderes", new List<string> { "Ged�mpfte Bao Buns mit Gem�se", "Couscous mit asiatischer Note" } },

                
                { "Asiatisch-Vegetarisch-Reis", new List<string> { "Veganer Sushi-Roll", "Gebratener Reis mit Gem�se" } },
                { "Asiatisch-Vegetarisch-Kartoffeln", new List<string> { "Kartoffel-Curry", "Scharfe Wok-Kartoffeln" } },
                { "Asiatisch-Vegetarisch-Gem�se", new List<string> { "Ged�nstetes Gem�se mit Tofu", "Wok-Gem�se mit Erdnuss-Sauce" } },
                { "Asiatisch-Vegetarisch-Pasta", new List<string> { "Asia-Nudeln mit Tofu", "Scharfe Glasnudeln mit Gem�se" } },
                { "Asiatisch-Vegetarisch-Anderes", new List<string> { "Ged�mpfte Bao Buns mit Gem�se", "Couscous mit asiatischer Note" } },

                
                { "Asiatisch-Fleisch-Reis", new List<string> { "H�hnchen-Reis mit Erdnusssauce", "Gebratener Reis mit Schweinefleisch" } },
                { "Asiatisch-Fleisch-Kartoffeln", new List<string> { "Gebratene Kartoffeln mit H�hnchen", "Kartoffeln mit Schweinefleisch in S��-Sauer-Sauce" } },
                { "Asiatisch-Fleisch-Gem�se", new List<string> { "H�hnchen mit Gem�se in Teriyaki-Sauce", "Rindfleisch mit Brokkoli" } },
                { "Asiatisch-Fleisch-Pasta", new List<string> { "Rindfleisch-Nudeln mit Sojasauce", "H�hnchen-Nudeln in Curry-Sauce" } },
                { "Asiatisch-Fleisch-Anderes", new List<string> { "Ged�mpfte H�hnchen-Bao Buns", "Schweinefleisch mit Gem�se" } },

                
                { "Amerikanisch-Vegan-Reis", new List<string> { "Reis-Bowl mit Bohnen", "Tex-Mex Reispfanne" } },
                { "Amerikanisch-Vegan-Kartoffeln", new List<string> { "Gef�llte Ofenkartoffel", "Kartoffel-Wedges mit Sour Cream" } },
                { "Amerikanisch-Vegan-Gem�se", new List<string> { "Gegrillte Gem�se-Spie�e", "BBQ-Gem�se-Burger" } },
                { "Amerikanisch-Vegan-Pasta", new List<string> { "Mac and Cheese", "Vegetarische Spaghetti Bolognese" } },
                { "Amerikanisch-Vegan-Anderes", new List<string> { "Couscous-Salat mit Mais", "Wraps mit Bohnen und K�se" } },

                
                { "Amerikanisch-Vegetarisch-Reis", new List<string> { "Reis-Bowl mit Bohnen", "Tex-Mex Reispfanne" } },
                { "Amerikanisch-Vegetarisch-Kartoffeln", new List<string> { "Gef�llte Ofenkartoffel", "Kartoffel-Wedges mit Sour Cream" } },
                { "Amerikanisch-Vegetarisch-Gem�se", new List<string> { "Gegrillte Gem�se-Spie�e", "BBQ-Gem�se-Burger" } },
                { "Amerikanisch-Vegetarisch-Pasta", new List<string> { "Mac and Cheese", "Vegetarische Spaghetti Bolognese" } },
                { "Amerikanisch-Vegetarisch-Anderes", new List<string> { "Couscous-Salat mit Mais", "Wraps mit Bohnen und K�se" } },

                
                { "Amerikanisch-Fleisch-Reis", new List<string> { "Rindfleisch-Bowl mit Reis", "Chicken Fried Rice" } },
                { "Amerikanisch-Fleisch-Kartoffeln", new List<string> { "Steak mit Kartoffelp�ree", "Bratkartoffeln mit Rindfleisch" } },
                { "Amerikanisch-Fleisch-Gem�se", new List<string> { "Rindfleisch-Burger mit Gem�se", "BBQ-H�hnchen mit Maiskolben" } },
                { "Amerikanisch-Fleisch-Pasta", new List<string> { "Rindfleisch-Nudeln mit Barbecue-Sauce", "Spaghetti mit Fleischb�llchen" } },
                { "Amerikanisch-Fleisch-Anderes", new List<string> { "BBQ-Ribs mit Krautsalat", "Cheeseburger mit Pommes" } },

                
                { "Europ�isch-Vegan-Reis", new List<string> { "Risotto mit Pilzen", "Reis mit Ratatouille" } },
                { "Europ�isch-Vegan-Kartoffeln", new List<string> { "Kartoffelsalat mit Senf-Dressing", "R�sti mit Kr�utern" } },
                { "Europ�isch-Vegan-Gem�se", new List<string> { "Ratatouille", "Vegetarische Moussaka" } },
                { "Europ�isch-Vegan-Pasta", new List<string> { "Spaghetti Aglio e Olio", "Vegetarische Lasagne" } },
                { "Europ�isch-Vegan-Anderes", new List<string> { "Bl�tterteig mit Pilzen", "Couscous mit gegrilltem Gem�se" } },

                
                { "Europ�isch-Vegetarisch-Reis", new List<string> { "Risotto mit Pilzen", "Reis mit Ratatouille" } },
                { "Europ�isch-Vegetarisch-Kartoffeln", new List<string> { "Kartoffelsalat mit Senf-Dressing", "R�sti mit Kr�utern" } },
                { "Europ�isch-Vegetarisch-Gem�se", new List<string> { "Ratatouille", "Vegetarische Moussaka" } },
                { "Europ�isch-Vegetarisch-Pasta", new List<string> { "Spaghetti Aglio e Olio", "Vegetarische Lasagne" } },
                { "Europ�isch-Vegetarisch-Anderes", new List<string> { "Bl�tterteig mit Pilzen", "Couscous mit gegrilltem Gem�se" } },

                
                { "Europ�isch-Fleisch-Reis", new List<string> { "Paella mit H�hnchen", "Reisfleisch mit Paprika" } },
                { "Europ�isch-Fleisch-Kartoffeln", new List<string> { "Bratwurst mit Kartoffelp�ree", "Schnitzel mit Bratkartoffeln" } },
                { "Europ�isch-Fleisch-Gem�se", new List<string> { "Gef�llte Paprika mit Hackfleisch", "Gulasch mit Wurzelgem�se" } },
                { "Europ�isch-Fleisch-Pasta", new List<string> { "Spaghetti Carbonara", "Lasagne mit Hackfleisch" } },
                { "Europ�isch-Fleisch-Anderes", new List<string> { "Couscous mit Lamm", "Bl�tterteigpastete mit Fleischf�llung" } },

                
                { "Afrikanisch-Vegan-Reis", new List<string> { "Jollof Rice mit Gem�se", "Afrikanischer Reis-Eintopf" } },
                { "Afrikanisch-Vegan-Kartoffeln", new List<string> { "S��kartoffel-Eintopf", "Kartoffel-Curry nach afrikanischer Art" } },
                { "Afrikanisch-Vegan-Gem�se", new List<string> { "Gem�se-Tagine", "W�rziger Spinat mit Erdnusssauce" } },
                { "Afrikanisch-Vegan-Pasta", new List<string> { "Pasta mit Erdnuss-Sauce", "Pikante Nudeln mit Okraschoten" } },
                { "Afrikanisch-Vegan-Anderes", new List<string> { "Hirse mit afrikanischem Gem�se", "Linsensuppe mit afrikanischen Gew�rzen" } },

                
                { "Afrikanisch-Vegetarisch-Reis", new List<string> { "Jollof Rice mit Gem�se", "Afrikanischer Reis-Eintopf" } },
                { "Afrikanisch-Vegetarisch-Kartoffeln", new List<string> { "S��kartoffel-Eintopf", "Kartoffel-Curry nach afrikanischer Art" } },
                { "Afrikanisch-Vegetarisch-Gem�se", new List<string> { "Gem�se-Tagine", "W�rziger Spinat mit Erdnusssauce" } },
                { "Afrikanisch-Vegetarisch-Pasta", new List<string> { "Pasta mit Erdnuss-Sauce", "Pikante Nudeln mit Okraschoten" } },
                { "Afrikanisch-Vegetarisch-Anderes", new List<string> { "Hirse mit afrikanischem Gem�se", "Linsensuppe mit afrikanischen Gew�rzen" } },

                
                { "Afrikanisch-Fleisch-Reis", new List<string> { "H�hnchen mit Reis und Erdnusssauce", "Fleischb�llchen mit Reis und Gem�se" } },
                { "Afrikanisch-Fleisch-Kartoffeln", new List<string> { "Kartoffel-Eintopf mit Lamm", "Gebratene Kartoffeln mit Rindfleisch" } },
                { "Afrikanisch-Fleisch-Gem�se", new List<string> { "Lamm mit Gem�se", "Rindfleisch in Erdnusssauce" } },
                { "Afrikanisch-Fleisch-Pasta", new List<string> { "Pasta mit H�hnchen und Curry", "Rindfleisch-Nudeln" } },
                { "Afrikanisch-Fleisch-Anderes", new List<string> { "Gekochtes Lamm mit Reis", "Afrikanische Fleischspie�e" } },

               
                { "Indisch-Vegan-Reis", new List<string> { "Reis mit Dal", "Veganes Biryani" } },
                { "Indisch-Vegan-Kartoffeln", new List<string> { "Aloo Gobi", "S��kartoffel-Curry" } },
                { "Indisch-Vegan-Gem�se", new List<string> { "Palak Tofu", "Gem�se Tikka Masala" } },
                { "Indisch-Vegan-Pasta", new List<string> { "Veganer Nudel-Curry", "Pasta mit Linsen-Dal" } },
                { "Indisch-Vegan-Anderes", new List<string> { "Veganer Samosa", "Pakoras" } },

                
                { "Indisch-Vegetarisch-Reis", new List<string> { "Reis mit Dal", "Vegetarisches Biryani" } },
                { "Indisch-Vegetarisch-Kartoffeln", new List<string> { "Aloo Gobi", "S��kartoffel-Curry" } },
                { "Indisch-Vegetarisch-Gem�se", new List<string> { "Palak Paneer", "Gem�se Tikka Masala" } },
                { "Indisch-Vegetarisch-Pasta", new List<string> { "Nudel-Curry", "Pasta mit Linsen-Dal" } },
                { "Indisch-Vegetarisch-Anderes", new List<string> { "Vegetarische Samosa", "Pakoras" } },

                
                { "Indisch-Fleisch-Reis", new List<string> { "H�hnchen Biryani", "Lamm mit Reis und Naan" } },
                { "Indisch-Fleisch-Kartoffeln", new List<string> { "Lamm mit Kartoffeln", "H�hnchen-Curry" } },
                { "Indisch-Fleisch-Gem�se", new List<string> { "Lamm in Masala-Sauce", "H�hnchen mit Gem�se" } },
                { "Indisch-Fleisch-Pasta", new List<string> { "Lamm-Nudeln in Masala-Sauce", "H�hnchen-Nudeln" } },
                { "Indisch-Fleisch-Anderes", new List<string> { "Lamm-Kebabs", "Chicken Tikka" } },

                

            };
        }

       
    }
}