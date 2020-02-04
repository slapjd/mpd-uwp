using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace mpd_uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NowPlayingPage : Page
    {
        private bool _playState = false;

        public NowPlayingPage()
        {
            this.InitializeComponent();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            _playState = !_playState; //Play state is now the state we switched TO

            PauseButtonSymbol.Symbol = _playState ? Symbol.Pause : Symbol.Play;
        }
    }
}
