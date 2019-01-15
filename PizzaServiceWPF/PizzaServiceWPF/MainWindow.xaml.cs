using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace PizzaServiceWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _pizza;
        private string _drink;
        private string _sauce;

        public MainWindow()
        {
            InitializeComponent();
        }

        private DoubleAnimation HideAnimation()
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.Duration = TimeSpan.FromSeconds(2);
            animation.From = 0;
            animation.To = -800;
            return animation;
        }

        private DoubleAnimation ShowAnimation()
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.Duration = TimeSpan.FromSeconds(2);
            animation.From = 800;
            animation.To = 0;
            return animation;
        }

        private void MainBtn_OnClick(object sender, RoutedEventArgs e)
        {
            MainGridTranslate.BeginAnimation(TranslateTransform.XProperty, HideAnimation());
            PizzaGridTranslate.BeginAnimation(TranslateTransform.XProperty, ShowAnimation());
        }

        private void PizzaBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            _pizza = btn.Name;

            PizzaGridTranslate.BeginAnimation(TranslateTransform.XProperty, HideAnimation());
            DrinkGridTranslate.BeginAnimation(TranslateTransform.XProperty, ShowAnimation());
        }

        private void DrinkBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            _drink = btn.Name;

            DrinkGridTranslate.BeginAnimation(TranslateTransform.XProperty, HideAnimation());
            SauceGridTranslate.BeginAnimation(TranslateTransform.XProperty, ShowAnimation());
        }

        private void SauceBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            _sauce = btn.Name;

            SauceGridTranslate.BeginAnimation(TranslateTransform.XProperty, HideAnimation());
            SummaryGridTranslate.BeginAnimation(TranslateTransform.XProperty, ShowAnimation());
            SummaryText.Text = $"Twoje zamówienie to \n Pizza : {_pizza} \n Napój : {_drink} \n Sos: {_sauce} \n SMACZNEGO";
        }
    }
}