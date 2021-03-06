using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Engine
{
    public class BaseNotificationClass : INotifyPropertyChanged
    { 
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(String PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
