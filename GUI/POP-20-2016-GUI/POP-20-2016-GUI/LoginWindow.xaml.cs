using POP_20_2016_GUI.Model;
using System.Windows;

namespace POP_SF_20_2016_GUI
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginClick(object sender, RoutedEventArgs e)
        {
            foreach(Korisnik kor in Projekat.instanca.Korisnik)
            {
                if(kor.korisnickoIme.Equals(tbKorisnicko.Text) && kor.lozinka.Equals(tbLozinka.Text))
                {
                    MainWindow mejn = new MainWindow();
                    mejn.ShowDialog();
                    this.Close();
                    return;
                }  
            }
            MessageBox.Show("Nisu dobri login podaci");
            tbKorisnicko.Clear();
            tbLozinka.Clear();

        }
    }
}
