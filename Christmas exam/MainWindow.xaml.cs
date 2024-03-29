﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Christmas_exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Player> players = new ObservableCollection<Player>(); // All placed into left listbox
        ObservableCollection<Player> selectplayers = new ObservableCollection<Player>(); // All placed into left listbox

        Random rng = new Random();
        static string[] Firstname = new string[9] {"Sophie","Grace","Harry","Micheal","Luke","Sean","Ava","Jack","Amelia"};
        static string[] Lastname = new string[9] { "O'Neill", "Walsh", "Lynch", "Daly", "Nolan", "McCarthy", "Dunne", "Brennan", "O'Sullivan" };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbxPlayers.ItemsSource = players;
            lbxSelect.ItemsSource = selectplayers;
            CreateList();
            cbxFormation.ItemsSource = new string[] { "4-4-2", "4-3-3", "4-5-1" };
        }

        public void CreateList()
        {
            //Goalkeepers
            int randomYear = rng.Next(1989, 2000);
            int randomName = rng.Next(0,9);
            int randomLast = rng.Next(0, 9);

            Player g1 = new Player(Firstname[randomName], Lastname[randomLast], 0, new DateTime(randomYear, 01,02) );

            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);

            Player g2 = new Player(Firstname[randomName], Lastname[randomLast], 0, new DateTime(randomYear, 01, 02));

            players.Add(g1);
            players.Add(g2);

            //Defenders
            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);

            Player d1 = new Player(Firstname[randomName], Lastname[randomLast], Position.Defenders, new DateTime(randomYear, 01, 02));

            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);

            Player d2 = new Player(Firstname[randomName], Lastname[randomLast], Position.Defenders, new DateTime(randomYear, 01, 02));

            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);

            Player d3 = new Player(Firstname[randomName], Lastname[randomLast], Position.Defenders, new DateTime(randomYear, 01, 02));

            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);

            Player d4 = new Player(Firstname[randomName], Lastname[randomLast], Position.Defenders, new DateTime(randomYear, 01, 02));

            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);

            Player d5 = new Player(Firstname[randomName], Lastname[randomLast], Position.Defenders, new DateTime(randomYear, 01, 02));

            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);

            Player d6 = new Player(Firstname[randomName], Lastname[randomLast], Position.Defenders, new DateTime(randomYear, 01, 02));

            players.Add(d1);
            players.Add(d2);
            players.Add(d3);
            players.Add(d4);
            players.Add(d5);
            players.Add(d6);

            //Midfielders
            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);
            Player m1 = new Player(Firstname[randomName], Lastname[randomLast], Position.Midfielder, new DateTime(randomYear, 01, 02));

            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);

            Player m2 = new Player(Firstname[randomName], Lastname[randomLast], Position.Midfielder, new DateTime(randomYear, 01, 02));

            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);

            Player m3 = new Player(Firstname[randomName], Lastname[randomLast], Position.Midfielder, new DateTime(randomYear, 01, 02));

            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);

            Player m4 = new Player(Firstname[randomName], Lastname[randomLast], Position.Midfielder, new DateTime(randomYear, 01, 02));

            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);

            Player m5 = new Player(Firstname[randomName], Lastname[randomLast], Position.Midfielder, new DateTime(randomYear, 01, 02));

            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);

            Player m6 = new Player(Firstname[randomName], Lastname[randomLast], Position.Midfielder, new DateTime(randomYear, 01, 02));

            players.Add(m1);
            players.Add(m2);
            players.Add(m3);
            players.Add(m4);
            players.Add(m5);
            players.Add(m6);

            //Fowards
            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);
            Player f1 = new Player(Firstname[randomName], Lastname[randomLast], Position.Forward, new DateTime(randomYear, 01, 02));

            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);

            Player f2 = new Player(Firstname[randomName], Lastname[randomLast], Position.Forward, new DateTime(randomYear, 01, 02));

            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);

            Player f3 = new Player(Firstname[randomName], Lastname[randomLast], Position.Forward, new DateTime(randomYear, 01, 02));

            randomYear = rng.Next(1989, 2000);
            randomName = rng.Next(0, 9);
            randomLast = rng.Next(0, 9);

            Player f4 = new Player(Firstname[randomName], Lastname[randomLast], Position.Forward, new DateTime(randomYear, 01, 02));

            players.Add(f1);
            players.Add(f2);
            players.Add(f3);
            players.Add(f4);

            sortlist();

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Player selectedactivity = lbxPlayers.SelectedItem as Player;

            if(selectedactivity != null && Player.space !=0)
            {
                players.Remove(selectedactivity);
                selectplayers.Add(selectedactivity);

                Player.space--;

                txtblkSpace.Text = Player.space.ToString();
                sortSelect();
            }
            else if(selectedactivity != null && Player.space == 0)
            {
                MessageBox.Show("No spaces available");
            }
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            Player selectedactivity = lbxSelect.SelectedItem as Player;

            if (selectedactivity != null)
            {
                selectplayers.Remove(selectedactivity);
                players.Add(selectedactivity);

                Player.space++;

                txtblkSpace.Text = Player.space.ToString();
                sortlist();
            }
        }
        public void sortlist()
        {
            List<Player> sorted = players.ToList();
            sorted.Sort();
            players = new ObservableCollection<Player>(sorted);
            lbxPlayers.ItemsSource = null;
            lbxPlayers.ItemsSource = players;
        }
        public void sortSelect()
        {
            List<Player> sorted = selectplayers.ToList();
            sorted.Sort();
            selectplayers = new ObservableCollection<Player>(sorted);
            lbxSelect.ItemsSource = null;
            lbxSelect.ItemsSource = selectplayers;
        }
    }
}
