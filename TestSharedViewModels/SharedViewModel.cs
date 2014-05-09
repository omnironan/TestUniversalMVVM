using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSharedViewModels
{
    public class SharedViewModel : ViewModelBase
    {
        public SharedViewModel()
        {
            TestProperty = IsInDesignMode
                ? "This Test Property from Design Mode"
                : "This Test Property from Runtime Mode";
        }

        private string _testProperty;

        public string TestProperty
        {
            get { return _testProperty; }
            set
            {
                _testProperty = value;
                RaisePropertyChanged();
            }
        }
    }
}
