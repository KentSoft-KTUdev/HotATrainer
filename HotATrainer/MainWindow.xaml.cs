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
using MahApps.Metro.Controls.Dialogs;

namespace HotATrainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private System.Timers.Timer timer = new System.Timers.Timer(200);
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
            try
            {
                GameMemoryAdresses.SetPlayerWood(int.Parse(Wood.Text, System.Globalization.NumberStyles.Integer));
                GameMemoryAdresses.SetPlayerSulfur(int.Parse(Sulfur.Text, System.Globalization.NumberStyles.Integer));
                GameMemoryAdresses.SetPlayerStones(int.Parse(Stones.Text, System.Globalization.NumberStyles.Integer));
                GameMemoryAdresses.SetPlayerMercury(int.Parse(Mercury.Text, System.Globalization.NumberStyles.Integer));
                GameMemoryAdresses.SetPlayerGold(int.Parse(Gold.Text, System.Globalization.NumberStyles.Integer));
                GameMemoryAdresses.SetPlayerCrystals(int.Parse(Crystals.Text, System.Globalization.NumberStyles.Integer));
                GameMemoryAdresses.SetPlayerGems(int.Parse(Gems.Text, System.Globalization.NumberStyles.Integer));
            }
            catch(Exception ex)
            {
                if(ex is ArgumentNullException)
                    this.ShowMessageAsync("Input error...", "All of resources inputs has to filled with integers", MessageDialogStyle.Affirmative);
                if (ex is ArgumentException)
                    this.ShowMessageAsync("Input error...", "Resource inputs must be numeric values", MessageDialogStyle.Affirmative);
                if (ex is FormatException)
                    this.ShowMessageAsync("Input error...", "Inputted values were in wrong format", MessageDialogStyle.Affirmative);
            }
        }

        private void InfMovement_IsCheckedChanged(object sender, EventArgs e)
        {
            if ((bool)InfMovement.IsChecked)
            {
                timer.Start();
                timer.Elapsed += Timer_Elapsed;
            }
            else if ((bool)!InfMovement.IsChecked)
            {
                timer.Stop();
                GameMemoryAdresses.SetPlayerAvailableMovement(0);
            }
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            GameMemoryAdresses.SetPlayerAvailableMovement(float.MaxValue);
        }
    }
}
