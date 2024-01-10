using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BukkMaraton2019
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            combobox1.Items.Add("Mini - 16km");
            combobox1.Items.Add("Rövid - 38km");
            combobox1.Items.Add("Pedelec - 54km");
            combobox1.Items.Add("Közép - 57km");
            combobox1.Items.Add("Hosszu - 94km");
            combobox1.Text=("Rövid - 38km");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            double ido             = 0;
            string[] Szetszed   = textBox1.Text.Split(':');
            ido                 = int.Parse(Szetszed[0])*3600 +int.Parse(Szetszed[1])*60 +int.Parse(Szetszed[2]);
            double tavolsag = 0;
            switch (combobox1.SelectedIndex)
            {
                case 0: tavolsag = 16;
                    break;
                case 1: tavolsag = 38;
                    break; 
                case 2: tavolsag = 54;
                    break;
                case 3: tavolsag = 57;
                    break;                
                case 4: tavolsag = 94;
                    break;
            }
            double meterPerSecundum = 0, KmH = 0;
            meterPerSecundum =  Math.Round (tavolsag * 1000 / ido ,2);
            KmH = Math.Round(tavolsag / (ido / 3600), 2);
            label4.Content +=": " +meterPerSecundum.ToString();
            label3.Content +=": " +KmH.ToString();
        }
    }
}
