using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Timers;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ToDoApp.NewFolder
{
    public class TodoModel : INotifyPropertyChanged
    {
        public System.DateTime CreationDate { get; set; } = DateTime.Now;

        private bool _Done;

        public bool Done
        {
            set
            {
                if (_Done == value)
                {
                    return;
                }
                _Done = value;
                OnPropertyChanged("IsDone");
            }
            get
            {
                return _Done;
            }
        }


        private string Text;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string str=" ")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }

        public string myBusines
        {
            set
            {
                if (Text == value)
                {
                    return;
                }
                Text = value;
                OnPropertyChanged("Text Changed");
            }
            get
            {
                return Text;
            }
        }

    }
}
