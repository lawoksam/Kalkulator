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

namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        string x = "";
        string x2 = "";
        double zmienna1 = 0;
        double zmienna2 = 0;
        char znak;
        public void dodajCyfre(double cyfra)
        {
            cyfra = Math.Round(cyfra, 6);
            x += cyfra;
            if (x.Length < 15) { wyswietlacz.Text = x; }
            else
                wyswietlacz.Text = "Liczba poza zakresem";
            
        }
        public void dodajCyfre2(int cyfra)
        {
            x2 += cyfra;
            wyswietlacz.Text = Convert.ToString(x2);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var  a1 = 1;
            x += 1;
            wyswietlacz.Text = Convert.ToString(x);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var a2 = 2;
            dodajCyfre(2);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var a3 = 3;
            dodajCyfre(3);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var a4 = 4;
            dodajCyfre(4);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var a5= 5;
            dodajCyfre(5);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var a6 = 6;
            dodajCyfre(6);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var a7 = 7;
            dodajCyfre(7);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            var a8 = 8;
            dodajCyfre(8);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            var a9= 9;
            dodajCyfre(9);
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            var a0= 0;
            dodajCyfre(0);
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tresc = 1;
            
        }
        
        private void Button_Click_podziel(object sender, RoutedEventArgs e)
        {
            znak = '/';

            x2 = x;
            x = "";
            wyswietlacz.Text = x;

        }

        private void Button_Click_pomnoz(object sender, RoutedEventArgs e)
        {
            znak = '*';

            x2 = x;
            x = "";
            wyswietlacz.Text = x;
        }

        private void Button_Click_odejmij(object sender, RoutedEventArgs e)
        {
            znak = '-';

            x2 = x;
            x = "";
            wyswietlacz.Text = x;
        }

        private void Button_Click_dodaj(object sender, RoutedEventArgs e)
        {
            znak = '+';

            x2 = x;
            x = "";
            wyswietlacz.Text = x;
        }

        private void Button_Click_wynik(object sender, RoutedEventArgs e)
        {
            if (x == "" | x2 == "")
            {
                if (x == "")
                    zmienna1 = 0;
                if (x2 == "")
                    zmienna2 = 0;
            }
            else
            {
                zmienna1 = Convert.ToDouble(x2);
                zmienna2 = Convert.ToDouble(x);
            }
            x = "";
            switch (znak)
            {
                case '*': zmienna1 *= zmienna2;
                    dodajCyfre(zmienna1);
                    break;
                    case '-': zmienna1 -= zmienna2;
                    dodajCyfre(zmienna1);
                    break;
                    case '+': zmienna1 += zmienna2;
                    dodajCyfre(zmienna1);
                    break;
                case '/':
                    
                        
                    if(zmienna1 == 0 | zmienna2 == 0)
                    {
                        x = "";
                        x2 = "";
                        zmienna1 = 0;
                        zmienna2 = 0;
                        wyswietlacz.Text = "Nie dziel przez zero!";
                        break;
                    }
                    zmienna1 /= zmienna2;
                    dodajCyfre(zmienna1);
                    break;
                default:
                    break;
            }
            if(zmienna1> 0) x = Convert.ToString(zmienna1) ;
            x2 = "";
        }

        private void Button_Click_kasuj(object sender, RoutedEventArgs e)
        {
            x = "";
            wyswietlacz.Text = x;
        }
    }
}
