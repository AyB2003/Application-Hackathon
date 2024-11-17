using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;

namespace Hackaton_Project
{
    public class PlayerData
    {
        public string NomJoueur { get; set; }
        public double Score { get; set; }
        public string Voisin { get; set; }
        public int LebienTriée { get; set; }
        public int MalTriée { get; set; }
        public string Classement { get; set; }
        public double Quantité { get; set; } //en kg
        public double Qualité { get; set; }
        public string ClassementQuartier { get; set; }

        public PlayerData(string nomJoueur, double score, string voisin, int lebienTriée, int malTriée,
                          string classement, double quantité, double qualité, string classementQuartier)
        {
            NomJoueur = nomJoueur;
            Score = score;
            Voisin = voisin;
            LebienTriée = lebienTriée;
            MalTriée = malTriée;
            Classement = classement;
            Quantité = quantité;
            Qualité = qualité;
            ClassementQuartier = classementQuartier;
        }
    }
    public partial class NewPage1 : ContentPage
    {
        public NewPage1()
        {
            InitializeComponent();
            LoadNegihbourhoud(); 
            Loadplayer();
            Loaddata();
        }

        private List<PlayerData> Loaddata()
        {
            List<PlayerData> playerlist = new List<PlayerData>()
            {
                new PlayerData("player0", 9.4, "Quartier 1", 1, 0, "player9", 1, 0.014, "nieghbourhood2"),
                new PlayerData("player1", 10.6, "Quartier 2", 4, 0, "player11", 1, 0.056, "nieghbourhood3"),
                new PlayerData("player2", 11, "Quartier 3", 5, 0, "player12", 1, 0.07, "nieghbourhood1"),
                new PlayerData("player3", 12.2, "Quartier 3", 8, 0, "player4", 1, 0.112, "nieghbourhood3"),
                new PlayerData("player4", 10.6, "Quartier 2", 4, 0, "player8", 1, 0.056, "nieghbourhood1"),
                new PlayerData("player5", 9.4, "Quartier 1", 1, 0, "player3", 1, 0.014, "nieghbourhood2"),
                new PlayerData("player6", 0, "Quartier 1", 0, 0, "player10", 0, 0, "nieghbourhood1"),
                new PlayerData("player7", 12.2, "Quartier 1", 8, 0, "player2", 1, 0.112, "nieghbourhood2"),
                new PlayerData("player8", 14.4, "Quartier 2", 15, 2, "player5", 0.8823529411764706, 0.238, "nieghbourhood3"),
                new PlayerData("player9", 10.8, "Quartier 2", 6, 2, "player13", 0.75, 0.112, "nieghbourhood1"),
                new PlayerData("player10", 13, "Quartier 3", 10, 0, "player1", 1, 0.14, "nieghbourhood2"),
                new PlayerData("player11", 13, "Quartier 3", 10, 0, "player6", 1, 0.14, "nieghbourhood3"),
                new PlayerData("player12", 10.4, "Quartier 3", 5, 2, "player7", 0.7142857142857143, 0.098, "nieghbourhood1")
            };
            return playerlist;
        }
        private void LoadNegihbourhoud()
        {
            List<string> astuces = new List<string>
            {
                "Quartier 1 : 9.3 points",
                "Quartier 2 : 6.7 points",
                "Quartier 3 : 3.2 points",
                "Quartier 4 : 1.1 points"
            };
            NeighView.ItemsSource = astuces;
        }

        private void Loadplayer()
        {
            List<string> astuces = new List<string>
            {
                "Utilisateur 1 : 14.4 points",
                "Utilisateur 2 : 12 points",
                "Utlisateur 3 : 9.4 points",
                "Utilisateur 4 : 5.3 points",
                "Utilisateur 5 : 2.2 points"
            };
            PlayerView.ItemsSource = astuces;
        }
        private async void OnHomeButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private async void OnSuggestionsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPage2());
        }
    }
}