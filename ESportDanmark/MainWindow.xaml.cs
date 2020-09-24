using ESportDanmark.DAL;
using ESportDanmark.Entities;
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


namespace ESportDanmark
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BaseRepository baseRepository = new BaseRepository();
        AnsatteRepository ansatteRepository = new AnsatteRepository();
        SpillereRepository spillereRepository = new SpillereRepository();
        SponsorerRepository sponsorerRepository = new SponsorerRepository();
        TournamentRepository tournamentRepository = new TournamentRepository();
        List<Spillere> spillerList = new List<Spillere>();
        
        public MainWindow()
        {
            InitializeComponent();
            dataSpillereList.ItemsSource = spillereRepository.GetSpillere();
            dataAnsatteList.ItemsSource = ansatteRepository.GetAnsatte();
            dataSponsorerList.ItemsSource = sponsorerRepository.GetSponsorer();
            dataTurneringerList.ItemsSource = tournamentRepository.GetTurneringer();
        }

        

        private void DeletePlayer_Click(object sender, RoutedEventArgs e)
        {
            if (spillerList.Count == 1)
            {
                MessageBox.Show("Der skal minimum være en Spiller");
            }
            else
            {
                Spillere deleteId = new Spillere();
                try
                {
                    deleteId.Id = int.Parse(deleteSpillerText.Text);
                    spillereRepository.deleteRow(deleteId);
                }
                catch ( Exception EX)
                {
                    MessageBox.Show("Du har lavet en fejl" + EX.Message);
                }
                //spillereRepository.deleteRow(deleteSpillerText.Text)
            }
        }

        private void MakePlayer_Click(object sender, RoutedEventArgs e)
        {
            Spillere newPlayer = new Spillere();
            newPlayer.Name = LavSpillerName.Text;
            try
            {
                newPlayer.SummonerName = LavSpilleIngameName.Text;
                newPlayer.Rank = LavSpillerRank.Text;
                newPlayer.Telephone = int.Parse(LavTelephone.Text);
                newPlayer.TournamentType = LavSpillerType.Text;
                spillereRepository.checkNumberExists(newPlayer.Telephone);
                spillereRepository.addNew(newPlayer);
            }
            catch(Exception EX)
            {
                MessageBox.Show("Du har lavet en fejl" + EX.Message);
            }
        }
    }
}
