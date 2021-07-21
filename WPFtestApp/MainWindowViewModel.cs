using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace WPFtestApp
{
    public class MainWindowViewModel
    {
        private ICommand _leftButtonDownCommand;

        public ICommand LeftMouseButtonDown
        {
            get
            {
                return _leftButtonDownCommand ?? (_leftButtonDownCommand = new RelayCommand(
                   x =>
                   {
                       DoStuff();
                   }));
            }
        }

        private static void DoStuff()
        {
            MessageBox.Show("Responding to left mouse button click event...");
        }
    }
}
