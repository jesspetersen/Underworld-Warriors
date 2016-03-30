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
using System.Windows.Shapes;

namespace UnderworldWarriors
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        public Game()
        {
            InitializeComponent();
            NameLbl.Content = App.heroName;
            ClassLbl.Content = App.heroChoice;
            if (App.heroChoice == "engineer")
                HeroImg.Source = new BitmapImage(new Uri(@"/Images/engineer.gif", UriKind.Relative));
            if (App.heroChoice == "ninja")
                HeroImg.Source = new BitmapImage(new Uri(@"/Images/ninja.gif", UriKind.Relative));
            if (App.heroChoice == "pirate")
                HeroImg.Source = new BitmapImage(new Uri(@"/Images/pirate.gif", UriKind.Relative));
            if (App.heroChoice == "ranger")
                HeroImg.Source = new BitmapImage(new Uri(@"/Images/ranger.gif", UriKind.Relative));
        }
    }
}
