using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Memory;
using System.ComponentModel;

namespace HotATrainer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Mem ProcessesMem = new Mem();
        public static BackgroundWorker BackgroundWorker = new BackgroundWorker
        {
           WorkerReportsProgress = true,
           WorkerSupportsCancellation = true
        };

    }
}
