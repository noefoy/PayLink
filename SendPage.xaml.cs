using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace PayLink2
{
    public partial class SendPage : ContentPage
    {
        public SendPage()
        {
            InitializeComponent();
        }

        private async void OnSendButtonClicked(object sender, EventArgs e)
        {
            // Retrieve the amount entered by the user
            string amountText = AmountEntry.Text;

            // Convert the string to a numeric type (e.g., double)
            if (double.TryParse(amountText, out double amount))
            {
                // Perform the send operation with the 'amount'
                // ...

                // Animate the confetti
            }
            else
            {
                await DisplayAlert("Error", "Please enter a valid number.", "OK");
            }
        }

    }
}
