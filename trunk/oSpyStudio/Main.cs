// project created on 4/12/2007 at 1:07 AM
using System;
using Gtk;

namespace oSpyStudio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            System.ComponentModel.AsyncOperationManager.SynchronizationContext = new GLibSynchronizationContext();
            
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();
        }
    }
}