using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using ToDoApp.NewFolder;

namespace ToDoApp.JsonParser
{
    class JsonIO
    {
        private readonly string _PATH="";

       public JsonIO(string PATH)
        {
            _PATH = PATH;
        }

        public BindingList<TodoModel>LoadData()
        {
            var FileExist = File.Exists(_PATH);

            if (!FileExist)
            {
                File.Create(_PATH);
                return new BindingList<TodoModel>();
            }

            using(var reader = File.OpenText(_PATH))
            {
                var textField = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<TodoModel>>(textField);
            }
        }

        public void SaveData(object data)
        {

            using(StreamWriter writer = File.CreateText(_PATH))
            {
                string output = JsonConvert.SerializeObject(data);
                writer.Write(output);
            }

        }

    }
}
