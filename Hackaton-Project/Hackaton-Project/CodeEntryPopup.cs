using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;

namespace Hackaton_Project
{
    public class CodeEntryPopup : Popup
    {
        private Entry codeEntry;
        private Button submitButton;

        public CodeEntryPopup()
        {
            var layout = new VerticalStackLayout
            {
                Padding = new Thickness(20),
                Spacing = 15,
                BackgroundColor = Color.FromRgb(245, 255, 245),
                WidthRequest = 300,
                HeightRequest = 150,
                Margin = new Thickness(10)
            };

            codeEntry = new Entry
            {
                Placeholder = "Enter votre code",
                Keyboard = Keyboard.Numeric,
                BackgroundColor = Color.FromRgb(0, 0, 102),
                FontSize = 18,
                Margin = new Thickness(0, 0, 0, 10)
            };

            submitButton = new Button
            {
                Text = "Connecter à la poubelle",
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.FromRgb(76, 175, 80),
                TextColor = Colors.White,
                FontSize = 18,
                CornerRadius = 10,
                Padding = new Thickness(10)
            };

            submitButton.Clicked += OnSubmitButtonClicked;
            layout.Children.Add(codeEntry);
            layout.Children.Add(submitButton);

            Content = layout;
        }

        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            string code = codeEntry.Text;


            if (code == "greenforgreen")
            {
                Application.Current.MainPage.DisplayAlert("Success", "Connecté!", "OK");
                Close(Result);
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Erreur", "Code Invalide. Réssayer.", "OK");
                codeEntry.Text = string.Empty;
            }
        }
    }
}
