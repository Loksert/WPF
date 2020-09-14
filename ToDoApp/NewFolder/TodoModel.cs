using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Timers;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.NewFolder
{
    public class TodoModel
    {
        public System.DateTime CreationDate { get; set; } = DateTime.Now;

        private bool _Done;

        public bool Done
        {
            set
            {
                _Done = value;
            }
            get
            {
                return _Done;
            }
        }


        private string _myBusines;

        public string myBusines
        {
            set
            {
                _myBusines = value;
            }
            get
            {
                return _myBusines;
            }
        }

    }
}
