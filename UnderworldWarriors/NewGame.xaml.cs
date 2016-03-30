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
    /// Interaction logic for NewGame.xaml
    /// </summary>
    public partial class NewGame : Window
    {

        public NewGame()
        {
            InitializeComponent();
        }

        private void WarriorBtn_Click(object sender, RoutedEventArgs e)
        {
            App.heroChoice = "warrior";
            if(NameTxtBox.Text == "")
            {
                AlertLbl.Content = "You have chosen WARRIOR! Please enter a name.";
            }
            else
            {
                AlertLbl.Content = "You have chosen WARRIOR! This hero's name is " + App.heroName + ".";
            }
        }

        private void EngineerBtn_Click(object sender, RoutedEventArgs e)
        {
            App.heroChoice = "engineer";
            if (NameTxtBox.Text == "")
            {
                AlertLbl.Content = "You have chosen ENGINEER! Please enter a name.";
            }
            else
            {
                AlertLbl.Content = "You have chosen ENGINEER! This hero's name is " + App.heroName + ".";
            }
        }

        private void NinjaBtn_Click(object sender, RoutedEventArgs e)
        {
            App.heroChoice = "ninja";
            if (NameTxtBox.Text == "")
            {
                AlertLbl.Content = "You have chosen NINJA! Please enter a name.";
            }
            else
            {
                AlertLbl.Content = "You have chosen NINJA! This hero's name is " + App.heroName + ".";
            }
        }

        private void RangerBtn_Click(object sender, RoutedEventArgs e)
        {
            App.heroChoice = "ranger";
            if (NameTxtBox.Text == "")
            {
                AlertLbl.Content = "You have chosen RANGER! Please enter a name.";
            }
            else
            {
                AlertLbl.Content = "You have chosen RANGER! This hero's name is " + App.heroName + ".";
            }
        }

        private void PirateBtn_Click(object sender, RoutedEventArgs e)
        {
            App.heroChoice = "pirate";
            if (NameTxtBox.Text == "")
            {
                AlertLbl.Content = "You have chosen PIRATE! Please enter a name.";
            }
            else
            {
                AlertLbl.Content = "You have chosen PIRATE! This hero's name is " + App.heroName + ".";
            }
        }

        private void NameTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NameTxtBox != null)
            {
                App.heroName = NameTxtBox.Text;
                if (App.heroChoice != null)
                {
                    switch(App.heroChoice)
                    {
                        case "warrior":
                            AlertLbl.Content = AlertLbl.Content = "You have chosen WARRIOR! This hero's name is " + App.heroName + ".";
                            break;

                        case "engineer":
                            AlertLbl.Content = AlertLbl.Content = "You have chosen ENGINEER! This hero's name is " + App.heroName + ".";
                            break;

                        case "ninja":
                            AlertLbl.Content = AlertLbl.Content = "You have chosen NINJA! This hero's name is " + App.heroName + ".";
                            break;

                        case "ranger":
                            AlertLbl.Content = AlertLbl.Content = "You have chosen RANGER! This hero's name is " + App.heroName + ".";
                            break;

                        case "pirate":
                            AlertLbl.Content = AlertLbl.Content = "You have chosen PIRATE! This hero's name is " + App.heroName + ".";
                            break;

                        default:
                            AlertLbl.Content = "There has been an issue in the program, please restart and try again.";
                            break;

                    }
                }
                else
                {
                    AlertLbl.Content = "Great! This hero's name is " + App.heroName + ", now please select a hero.";
                }
            }

        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            //MessageBoxResult startmessage = MessageBox.Show("The game will start at this point with " + App.heroChoice + " as the class, and " + App.heroName + " as the hero name.", "Start", MessageBoxButton.OK);

            if (App.heroChoice == null && App.heroName == null)
            {
                AlertLbl.Content = "Please choose a name and class before beginning the game.";
            }
            else if (App.heroName == null)
            {
                AlertLbl.Content = "Your hero needs a name before we can begin their quest!";
            }
            else if (App.heroChoice == null)
            {
                AlertLbl.Content = "Hey! Please choose a class before starting the game!";
            }
            else
            {
                var gameWindow = new Game();
                gameWindow.Show();
                Close();
            }
        }
    }
}
