using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class App : Application
    {
        public App()
        {
            ApiProxy apiProxy = new ApiProxy();
            InsultHandler insultHandler = new InsultHandler(apiProxy);
            var allInsults = insultHandler.GetAll();

            ListView listView = new ListView()
            {
                ItemsSource = allInsults,
                ItemTemplate = new DataTemplate(() =>
                {
                    Label insultText = new Label();
                    insultText.SetBinding(Label.TextProperty, "Text");
                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Children =
                            {
                                insultText
                            }
                        }
                    };
                })
            };

            MainPage = new ContentPage
            {
                Content = listView
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
