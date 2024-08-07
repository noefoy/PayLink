using Microsoft.Maui.Controls;
using System;
using System.Linq;

namespace PayLink2
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Set the current page to the "Home" tab
            CurrentPage = Children[1]; // Assuming the "Home" tab is at index 1


            // Find the appropriate parent StackLayout where you want to add buttons
            var existingStackLayout = FindParentStackLayout(CurrentPage);

            // Add buttons to the existing StackLayout
            var buttonsStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 20, 0, 0), // Add margin for spacing
            };

            // Send button
            var sendButton = new Button
            {
                Text = "Send",
                Command = new Command(OnSendButtonClicked),
                Margin = new Thickness(5),
            };

            // Request button
            var requestButton = new Button
            {
                Text = "Request",
                Command = new Command(OnRequestButtonClicked),
                Margin = new Thickness(5),
            };

            var transactionButton = new Button
            {
                Text = "Transactions",
                Command = new Command(OnTransactionButtonClicked),
                Margin = new Thickness(5),
            };

            buttonsStackLayout.Children.Add(sendButton);
            buttonsStackLayout.Children.Add(requestButton);
            buttonsStackLayout.Children.Add(transactionButton);

            // Add the buttonsStackLayout to the existing StackLayout
            existingStackLayout?.Children.Add(buttonsStackLayout);
        }

        private void OnRequestButtonClicked(object obj)
        {
            throw new NotImplementedException();
        }

        private void OnSendButtonClicked(object obj)
        {
            throw new NotImplementedException();
        }
        private void OnTransactionButtonClicked(object obj)
        {
            throw new NotImplementedException();
        }

        private StackLayout FindParentStackLayout(Element element)
        {
            // Traverse up the visual tree to find the StackLayout parent
            Element parent = element.Parent;
            while (parent != null)
            {
                if (parent is StackLayout stackLayout)
                    return stackLayout;

                parent = parent.Parent;
            }

            return null;
        }

        private void OnSendButtonClicked(object sender, EventArgs e)
        {
            // Open a new page for sending
            Navigation.PushAsync(new SendPage());
        }


        private void OnRequestButtonClicked(object sender, EventArgs e)
        {
            // Open a new page for requesting
            Navigation.PushAsync(new RequestPage());
        }

        private void OnTransactionButtonClicked(object sender, EventArgs e)
        {
            // Open a new page for sending
            Navigation.PushAsync(new TransactionPage());
        }

        private async void OnCardTapped(string cardIdentifier)
        {
            // Navigate to the new page when a card is tapped
            await Navigation.PushAsync(new CardDetailsPage());
        }

        // ... (Other methods as needed)
    }
}
