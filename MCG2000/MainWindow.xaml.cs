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


namespace MCG2000
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


        public void btnWarrior_Click(object sender, RoutedEventArgs e)
        {
            GameController vGC = new GameController();
            vGC.ChooseClass("Warrior");
        }
        public void btnThief_Click(object sender, RoutedEventArgs e)
        {
            GameController vGC = new GameController();
            vGC.ChooseClass("Thief");
        }
        public void btnMage_Click(object sender, RoutedEventArgs e)
        {
            GameController vGC = new GameController();
            vGC.ChooseClass("Mage");
        }

        /*private void btnPlayfield_Click(object sender, RoutedEventArgs e)
        {
            Playfield m = new Playfield();
            m.Show();
        }

        private void btnEndMatch_Click(object sender, RoutedEventArgs e)
        {
            EndMatch m = new EndMatch();
            m.Show();
        }*/
    }
}
