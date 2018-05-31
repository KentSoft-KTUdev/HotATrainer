using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;

namespace HotATrainer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static VAMemory ProcessesMem = new VAMemory("h3hota");
        public static BackgroundWorker BackgroundWorker = new BackgroundWorker
        {
           WorkerReportsProgress = true,
           WorkerSupportsCancellation = true
        };

    }
}
