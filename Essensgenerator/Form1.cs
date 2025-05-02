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
                "Asiatisch", "Amerikanisch", "Europäisch", "Afrikanisch", "Indisch",
                "Fleisch", "Vegetarisch", "Vegan",
                "Reis", "Kartoffeln", "Gemüse", "Pasta", "Anderes",
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
            MessageBox.Show($"Generierter Schlüssel: {key}", "Debugging", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
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
               
                { "Asiatisch-Vegan-Reis", new List<string> { "Veganer Sushi-Roll", "Gebratener Reis mit Gemüse" } },
                { "Asiatisch-Vegan-Kartoffeln", new List<string> { "Kartoffel-Curry", "Scharfe Wok-Kartoffeln" } },
                { "Asiatisch-Vegan-Gemüse", new List<string> { "Gedünstetes Gemüse mit Tofu", "Wok-Gemüse mit Erdnuss-Sauce" } },
                { "Asiatisch-Vegan-Pasta", new List<string> { "Asia-Nudeln mit Tofu", "Scharfe Glasnudeln mit Gemüse" } },
                { "Asiatisch-Vegan-Anderes", new List<string> { "Gedämpfte Bao Buns mit Gemüse", "Couscous mit asiatischer Note" } },

                
                { "Asiatisch-Vegetarisch-Reis", new List<string> { "Veganer Sushi-Roll", "Gebratener Reis mit Gemüse" } },
                { "Asiatisch-Vegetarisch-Kartoffeln", new List<string> { "Kartoffel-Curry", "Scharfe Wok-Kartoffeln" } },
                { "Asiatisch-Vegetarisch-Gemüse", new List<string> { "Gedünstetes Gemüse mit Tofu", "Wok-Gemüse mit Erdnuss-Sauce" } },
                { "Asiatisch-Vegetarisch-Pasta", new List<string> { "Asia-Nudeln mit Tofu", "Scharfe Glasnudeln mit Gemüse" } },
                { "Asiatisch-Vegetarisch-Anderes", new List<string> { "Gedämpfte Bao Buns mit Gemüse", "Couscous mit asiatischer Note" } },

                
                { "Asiatisch-Fleisch-Reis", new List<string> { "Hähnchen-Reis mit Erdnusssauce", "Gebratener Reis mit Schweinefleisch" } },
                { "Asiatisch-Fleisch-Kartoffeln", new List<string> { "Gebratene Kartoffeln mit Hähnchen", "Kartoffeln mit Schweinefleisch in Süß-Sauer-Sauce" } },
                { "Asiatisch-Fleisch-Gemüse", new List<string> { "Hähnchen mit Gemüse in Teriyaki-Sauce", "Rindfleisch mit Brokkoli" } },
                { "Asiatisch-Fleisch-Pasta", new List<string> { "Rindfleisch-Nudeln mit Sojasauce", "Hähnchen-Nudeln in Curry-Sauce" } },
                { "Asiatisch-Fleisch-Anderes", new List<string> { "Gedämpfte Hähnchen-Bao Buns", "Schweinefleisch mit Gemüse" } },

                
                { "Amerikanisch-Vegan-Reis", new List<string> { "Reis-Bowl mit Bohnen", "Tex-Mex Reispfanne" } },
                { "Amerikanisch-Vegan-Kartoffeln", new List<string> { "Gefüllte Ofenkartoffel", "Kartoffel-Wedges mit Sour Cream" } },
                { "Amerikanisch-Vegan-Gemüse", new List<string> { "Gegrillte Gemüse-Spieße", "BBQ-Gemüse-Burger" } },
                { "Amerikanisch-Vegan-Pasta", new List<string> { "Mac and Cheese", "Vegetarische Spaghetti Bolognese" } },
                { "Amerikanisch-Vegan-Anderes", new List<string> { "Couscous-Salat mit Mais", "Wraps mit Bohnen und Käse" } },

                
                { "Amerikanisch-Vegetarisch-Reis", new List<string> { "Reis-Bowl mit Bohnen", "Tex-Mex Reispfanne" } },
                { "Amerikanisch-Vegetarisch-Kartoffeln", new List<string> { "Gefüllte Ofenkartoffel", "Kartoffel-Wedges mit Sour Cream" } },
                { "Amerikanisch-Vegetarisch-Gemüse", new List<string> { "Gegrillte Gemüse-Spieße", "BBQ-Gemüse-Burger" } },
                { "Amerikanisch-Vegetarisch-Pasta", new List<string> { "Mac and Cheese", "Vegetarische Spaghetti Bolognese" } },
                { "Amerikanisch-Vegetarisch-Anderes", new List<string> { "Couscous-Salat mit Mais", "Wraps mit Bohnen und Käse" } },

                
                { "Amerikanisch-Fleisch-Reis", new List<string> { "Rindfleisch-Bowl mit Reis", "Chicken Fried Rice" } },
                { "Amerikanisch-Fleisch-Kartoffeln", new List<string> { "Steak mit Kartoffelpüree", "Bratkartoffeln mit Rindfleisch" } },
                { "Amerikanisch-Fleisch-Gemüse", new List<string> { "Rindfleisch-Burger mit Gemüse", "BBQ-Hähnchen mit Maiskolben" } },
                { "Amerikanisch-Fleisch-Pasta", new List<string> { "Rindfleisch-Nudeln mit Barbecue-Sauce", "Spaghetti mit Fleischbällchen" } },
                { "Amerikanisch-Fleisch-Anderes", new List<string> { "BBQ-Ribs mit Krautsalat", "Cheeseburger mit Pommes" } },

                
                { "Europäisch-Vegan-Reis", new List<string> { "Risotto mit Pilzen", "Reis mit Ratatouille" } },
                { "Europäisch-Vegan-Kartoffeln", new List<string> { "Kartoffelsalat mit Senf-Dressing", "Rösti mit Kräutern" } },
                { "Europäisch-Vegan-Gemüse", new List<string> { "Ratatouille", "Vegetarische Moussaka" } },
                { "Europäisch-Vegan-Pasta", new List<string> { "Spaghetti Aglio e Olio", "Vegetarische Lasagne" } },
                { "Europäisch-Vegan-Anderes", new List<string> { "Blätterteig mit Pilzen", "Couscous mit gegrilltem Gemüse" } },

                
                { "Europäisch-Vegetarisch-Reis", new List<string> { "Risotto mit Pilzen", "Reis mit Ratatouille" } },
                { "Europäisch-Vegetarisch-Kartoffeln", new List<string> { "Kartoffelsalat mit Senf-Dressing", "Rösti mit Kräutern" } },
                { "Europäisch-Vegetarisch-Gemüse", new List<string> { "Ratatouille", "Vegetarische Moussaka" } },
                { "Europäisch-Vegetarisch-Pasta", new List<string> { "Spaghetti Aglio e Olio", "Vegetarische Lasagne" } },
                { "Europäisch-Vegetarisch-Anderes", new List<string> { "Blätterteig mit Pilzen", "Couscous mit gegrilltem Gemüse" } },

                
                { "Europäisch-Fleisch-Reis", new List<string> { "Paella mit Hähnchen", "Reisfleisch mit Paprika" } },
                { "Europäisch-Fleisch-Kartoffeln", new List<string> { "Bratwurst mit Kartoffelpüree", "Schnitzel mit Bratkartoffeln" } },
                { "Europäisch-Fleisch-Gemüse", new List<string> { "Gefüllte Paprika mit Hackfleisch", "Gulasch mit Wurzelgemüse" } },
                { "Europäisch-Fleisch-Pasta", new List<string> { "Spaghetti Carbonara", "Lasagne mit Hackfleisch" } },
                { "Europäisch-Fleisch-Anderes", new List<string> { "Couscous mit Lamm", "Blätterteigpastete mit Fleischfüllung" } },

                
                { "Afrikanisch-Vegan-Reis", new List<string> { "Jollof Rice mit Gemüse", "Afrikanischer Reis-Eintopf" } },
                { "Afrikanisch-Vegan-Kartoffeln", new List<string> { "Süßkartoffel-Eintopf", "Kartoffel-Curry nach afrikanischer Art" } },
                { "Afrikanisch-Vegan-Gemüse", new List<string> { "Gemüse-Tagine", "Würziger Spinat mit Erdnusssauce" } },
                { "Afrikanisch-Vegan-Pasta", new List<string> { "Pasta mit Erdnuss-Sauce", "Pikante Nudeln mit Okraschoten" } },
                { "Afrikanisch-Vegan-Anderes", new List<string> { "Hirse mit afrikanischem Gemüse", "Linsensuppe mit afrikanischen Gewürzen" } },

                
                { "Afrikanisch-Vegetarisch-Reis", new List<string> { "Jollof Rice mit Gemüse", "Afrikanischer Reis-Eintopf" } },
                { "Afrikanisch-Vegetarisch-Kartoffeln", new List<string> { "Süßkartoffel-Eintopf", "Kartoffel-Curry nach afrikanischer Art" } },
                { "Afrikanisch-Vegetarisch-Gemüse", new List<string> { "Gemüse-Tagine", "Würziger Spinat mit Erdnusssauce" } },
                { "Afrikanisch-Vegetarisch-Pasta", new List<string> { "Pasta mit Erdnuss-Sauce", "Pikante Nudeln mit Okraschoten" } },
                { "Afrikanisch-Vegetarisch-Anderes", new List<string> { "Hirse mit afrikanischem Gemüse", "Linsensuppe mit afrikanischen Gewürzen" } },

                
                { "Afrikanisch-Fleisch-Reis", new List<string> { "Hähnchen mit Reis und Erdnusssauce", "Fleischbällchen mit Reis und Gemüse" } },
                { "Afrikanisch-Fleisch-Kartoffeln", new List<string> { "Kartoffel-Eintopf mit Lamm", "Gebratene Kartoffeln mit Rindfleisch" } },
                { "Afrikanisch-Fleisch-Gemüse", new List<string> { "Lamm mit Gemüse", "Rindfleisch in Erdnusssauce" } },
                { "Afrikanisch-Fleisch-Pasta", new List<string> { "Pasta mit Hähnchen und Curry", "Rindfleisch-Nudeln" } },
                { "Afrikanisch-Fleisch-Anderes", new List<string> { "Gekochtes Lamm mit Reis", "Afrikanische Fleischspieße" } },

               
                { "Indisch-Vegan-Reis", new List<string> { "Reis mit Dal", "Veganes Biryani" } },
                { "Indisch-Vegan-Kartoffeln", new List<string> { "Aloo Gobi", "Süßkartoffel-Curry" } },
                { "Indisch-Vegan-Gemüse", new List<string> { "Palak Tofu", "Gemüse Tikka Masala" } },
                { "Indisch-Vegan-Pasta", new List<string> { "Veganer Nudel-Curry", "Pasta mit Linsen-Dal" } },
                { "Indisch-Vegan-Anderes", new List<string> { "Veganer Samosa", "Pakoras" } },

                
                { "Indisch-Vegetarisch-Reis", new List<string> { "Reis mit Dal", "Vegetarisches Biryani" } },
                { "Indisch-Vegetarisch-Kartoffeln", new List<string> { "Aloo Gobi", "Süßkartoffel-Curry" } },
                { "Indisch-Vegetarisch-Gemüse", new List<string> { "Palak Paneer", "Gemüse Tikka Masala" } },
                { "Indisch-Vegetarisch-Pasta", new List<string> { "Nudel-Curry", "Pasta mit Linsen-Dal" } },
                { "Indisch-Vegetarisch-Anderes", new List<string> { "Vegetarische Samosa", "Pakoras" } },

                
                { "Indisch-Fleisch-Reis", new List<string> { "Hähnchen Biryani", "Lamm mit Reis und Naan" } },
                { "Indisch-Fleisch-Kartoffeln", new List<string> { "Lamm mit Kartoffeln", "Hähnchen-Curry" } },
                { "Indisch-Fleisch-Gemüse", new List<string> { "Lamm in Masala-Sauce", "Hähnchen mit Gemüse" } },
                { "Indisch-Fleisch-Pasta", new List<string> { "Lamm-Nudeln in Masala-Sauce", "Hähnchen-Nudeln" } },
                { "Indisch-Fleisch-Anderes", new List<string> { "Lamm-Kebabs", "Chicken Tikka" } },

                

            };
        }

       
    }
}