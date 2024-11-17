namespace Hackaton_Project;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
        LoadSuggestions();
        LoadAstuces();
	}
    private void LoadSuggestions()
    {
        List<string> suggestions = new List<string>
            {
"Suggestion 1 : S�parer les d�chets recyclables des non-recyclables.",
"Suggestion 2 : R�utiliser les contenants en verre au lieu de les jeter.",
"Suggestion 3 : Recycler les d�chets �lectroniques dans des points de collecte sp�cialis�s.",
"Suggestion 4 : R�duire l'utilisation de plastique en optant pour des sacs r�utilisables.",
"Suggestion 5 : Composter les d�chets alimentaires pour r�duire les ordures m�nag�res.",
            };

        SuggestionsCollectionView.ItemsSource = suggestions;
    }

    private void LoadAstuces()
    {
        List<string> astuces = new List<string>
            {
"Astuces 1 : Utilisez des bacs distincts pour les mati�res recyclables et non-recyclables.",
"Astuces 2 : Rincez les emballages en plastique ou en m�tal avant de les recycler.",
"Astuces 3 : Pr�f�rez les produits avec des emballages recyclables ou biod�gradables.",
"Astuces 4 : Apportez vos d�chets �lectroniques � des centres de recyclage sp�cialis�s.",
"Astuces 5 : Limitez l'utilisation de produits jetables en choisissant des alternatives r�utilisables.",
            };
        AstucesView.ItemsSource = astuces;
    }
    private async void OnHomeButtonClicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }
    private async void OnstatButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage1());
    }
}