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
using System.Windows.Threading;
using MahApps.Metro.Controls;

namespace HotATrainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            App.BackgroundWorker.DoWork += BackgroundWorker_DoWork;
            App.BackgroundWorker.RunWorkerAsync();
            MinHeight = Height;
            MinWidth = Width;
            Wood.MaxLength = 8;
            Crystals.MaxLength = 8;
            Mercury.MaxLength = 8;
            Gems.MaxLength = 8;
            Stones.MaxLength = 8;
            Sulfur.MaxLength = 8;
            Wood.Text = GameMemoryAdresses.GetPlayerWood().ToString();
            Crystals.Text = GameMemoryAdresses.GetPlayerCrystals().ToString();
            Mercury.Text = GameMemoryAdresses.GetPlayerMercury().ToString();
            Gems.Text = GameMemoryAdresses.GetPlayerGems().ToString();
            Stones.Text = GameMemoryAdresses.GetPlayerStones().ToString();
            Sulfur.Text = GameMemoryAdresses.GetPlayerSulfur().ToString();
            Gold.Text = GameMemoryAdresses.GetPlayerGold().ToString();
        }

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                WoodText.Invoke(() => WoodText.Text = String.Format("Wood ({0})", GameMemoryAdresses.GetPlayerWood()));
                CrystalsText.Invoke(() => CrystalsText.Text = String.Format("Crystals ({0})", GameMemoryAdresses.GetPlayerCrystals()));
                MercuryText.Invoke(() => MercuryText.Text = String.Format("Mercury ({0})", GameMemoryAdresses.GetPlayerMercury()));
                GemsText.Invoke(() => GemsText.Text = String.Format("Gems ({0})", GameMemoryAdresses.GetPlayerGems()));
                StonesText.Invoke(() => StonesText.Text = String.Format("Stones ({0})", GameMemoryAdresses.GetPlayerStones()));
                SulfurText.Invoke(() => SulfurText.Text = String.Format("Sulfur ({0})", GameMemoryAdresses.GetPlayerSulfur()));
                GoldText.Invoke(() => GoldText.Text = String.Format("Gold ({0})", GameMemoryAdresses.GetPlayerGold()));
            }
        }

        private void SubmitResources_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
