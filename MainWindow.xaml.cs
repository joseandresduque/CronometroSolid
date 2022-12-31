using System;
using System.Windows;

namespace CronometroSolid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ICronometrar cronometrar;

        public MainWindow()
        {
            InitializeComponent();
            cronometrar = Crono.Create(RefreshValue);
        }

        private void RefreshValue(object sender, EventArgs e)
        {
            cronometrar.AddSecond();
            CronoTexBlock.Text = cronometrar.ValueCrono;
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            cronometrar.Start();
        }

        private void Pause(object sender, RoutedEventArgs e)
        {
            cronometrar.Pause();
        }

        private void Stop(object sender, RoutedEventArgs e)
        {
            cronometrar.Stop();
            CronoTexBlock.Text = "00:00:00";
        }
    }
}
