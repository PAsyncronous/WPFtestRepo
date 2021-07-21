using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace WPFtestApp
{
    public class MainWindowViewModel
    {
        private DateTime myVar;


        public DateTime MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private ICommand _leftButtonDownCommand;

        public ICommand SelectedDateChanged
        {
            get
            {
                return new RelayCommand<string>((date) => DoStuff(date));
                //return _leftButtonDownCommand ?? (_leftButtonDownCommand = new RelayCommand(
                //   x =>
                //   {
                //       DoStuff(date);
                //   }));
            }
        }

        private static void DoStuff(string date)
        {
            MessageBox.Show("invalid date");

        }
    }
}
