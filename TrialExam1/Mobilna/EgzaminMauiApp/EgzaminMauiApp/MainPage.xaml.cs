using EgzaminMauiApp.ProjectElements.Validators;

namespace EgzaminMauiApp
{
    public partial class MainPage : ContentPage
    {
        int currentMinutes = 0, currentSeconds = 0;

        public MainPage()
        {
            InitializeComponent();

            ResultLabel.Text = "0:00";
        }

        private bool VariablesValidation(out string message)
        {
            List<IValidate> listOfValuesToValidation = new List<IValidate>();
            listOfValuesToValidation.Add(new ObjectToValidate()
            {
                ObjectName = "[Wprowadzone minuty] ",
                Value = MinutesEntry.Text,
                ValueMinRange = 0,
                ValueMaxRange = 200
            });
            listOfValuesToValidation.Add(new ObjectToValidate()
            {
                ObjectName = "[Wprowadzone sekundy] ",
                Value = SecondsEntry.Text,
                ValueMinRange = 0,
                ValueMaxRange = 60
            });

            if (new Validate().Validation(listOfValuesToValidation, out message))
            {
                return true;
            }
            return false;
        }

        private void Button_Clicked_Add(object sender, EventArgs e) // ADD TO TIMER
        {
            string message;
            if(VariablesValidation(out message))
            {
                currentMinutes += int.Parse(MinutesEntry.Text);
                int userSecounds = int.Parse(SecondsEntry.Text);
                if ((currentSeconds + userSecounds) >= 60)
                {
                    currentMinutes++;
                    currentSeconds += userSecounds - 60;
                }
                else
                {
                    currentSeconds += userSecounds;
                }

                ResultLabel.Text = currentSeconds > 9 ? currentMinutes.ToString() + ":" + currentSeconds.ToString() : currentMinutes.ToString() + ":0" + currentSeconds.ToString();

                MinutesEntry.Text = string.Empty;
                SecondsEntry.Text = string.Empty;
            }
            else
            {
                MinutesEntry.Text = string.Empty;
                SecondsEntry.Text = string.Empty;
                DisplayAlert("Błąd", message, "OK");
            }
        }

        private void Button_Clicked_Reset(object sender, EventArgs e) // RESET TIMER
        {
            currentMinutes = 0;
            currentSeconds = 0;
            ResultLabel.Text = "0:00";
            MinutesEntry.Text = string.Empty;
            SecondsEntry.Text = string.Empty;
        }
    }
}
