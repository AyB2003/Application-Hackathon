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
"Suggestion 1 : Séparer les déchets recyclables des non-recyclables.",
"Suggestion 2 : Réutiliser les contenants en verre au lieu de les jeter.",
"Suggestion 3 : Recycler les déchets électroniques dans des points de collecte spécialisés.",
"Suggestion 4 : Réduire l'utilisation de plastique en optant pour des sacs réutilisables.",
"Suggestion 5 : Composter les déchets alimentaires pour réduire les ordures ménagères.",
            };

        SuggestionsCollectionView.ItemsSource = suggestions;
    }

    private void LoadAstuces()
    {
        List<string> astuces = new List<string>
            {
"Astuces 1 : Utilisez des bacs distincts pour les matières recyclables et non-recyclables.",
"Astuces 2 : Rincez les emballages en plastique ou en métal avant de les recycler.",
"Astuces 3 : Préférez les produits avec des emballages recyclables ou biodégradables.",
"Astuces 4 : Apportez vos déchets électroniques à des centres de recyclage spécialisés.",
"Astuces 5 : Limitez l'utilisation de produits jetables en choisissant des alternatives réutilisables.",
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