using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using MahApps.Metro.Controls;
using Memory;

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
        }

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while(true)
            {
                int pid = App.ProcessesMem.getProcIDFromName("h3hota HD");
                bool procOpenStatus = false;
                if (pid != 0)
                    procOpenStatus = App.ProcessesMem.OpenProcess(pid);
                if (procOpenStatus)
                {

                }
            }
        }
    }
}
