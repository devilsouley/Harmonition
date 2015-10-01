using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Harmonition___Accueil
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public WMPLib.WindowsMediaPlayer wplayer;
        static readonly object locker = new object();

        public MainWindow()
        {
            InitializeComponent();

            wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = "H:/Bureau/Harmonition - Accueil/Harmonition - Accueil/FichiersAudio/ValleeGerudo.mp3";
            
            
            wplayer.controls.play();
            

        }

        private void UpdateDureeCourante(Action callback)
        {
            //lblDureeCourante.Content = wplayer.controls.currentPositionString;

            Thread.Sleep(1000);
            callback();
        }

        // TODO
        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            new Thread(() => UpdateDureeCourante(() => lblDureeCourante.Content = wplayer.controls.currentPositionString)).Start();


            /*
            while (wplayer.controls.currentPosition < wplayer.currentMedia.duration)
            {
                lock(locker)
                {
                    new Thread(UpdateDureeCourante).Start();
                    UpdateDureeCourante();
                }
            }
            */
            
        }

    }
}
