using System;
using Microsoft.Maui.Controls;
using CommunityToolkit.Maui.Views;
namespace Hackaton_Project
{
    public partial class MainPage : ContentPage
    {
        private double _lastTranslationX;
        private double _lastTranslationY;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {
            if (sender is Image image)
            {
                if (e.StatusType == GestureStatus.Started)
                {
                    _lastTranslationX = 0;
                    _lastTranslationY = 0;
                }
                else if (e.StatusType == GestureStatus.Running)
                {
                    var translationX = e.TotalX - _lastTranslationX;
                    var translationY = e.TotalY - _lastTranslationY;
                    var newTranslationX = image.TranslationX + translationX;
                    var newTranslationY = image.TranslationY + translationY;
                    var imageWidth = image.Width;
                    var imageHeight = image.Height;
                    var scrollViewWidth = (sender as VisualElement).Width;
                    var scrollViewHeight = (sender as VisualElement).Height;

                    if (newTranslationX > 0)
                    {
                        newTranslationX = 0;
                    }
                    else if (newTranslationX < scrollViewWidth - imageWidth)
                    {
                        newTranslationX = scrollViewWidth - imageWidth;
                    }

                    if (newTranslationY > 0)
                    {
                        newTranslationY = 0;
                    }
                    else if (newTranslationY < scrollViewHeight - imageHeight)
                    {
                        newTranslationY = scrollViewHeight - imageHeight;
                    }

                    image.TranslationX = newTranslationX;
                    image.TranslationY = newTranslationY;

                    _lastTranslationX = e.TotalX;
                    _lastTranslationY = e.TotalY;
                }
            }
        }


        private async void OnStatistiquesButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPage1());
        }
        private async void OnSuggestionsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPage2());
        }
        private void OnConnectButtonClicked(object sender, EventArgs e)
        {
            var popup = new CodeEntryPopup();
            this.ShowPopup(popup);
        }
    }
}
