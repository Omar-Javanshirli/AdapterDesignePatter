using AdapterDesignePatter.Command;
using AdapterDesignePatter.ConvertJsonAndXml;
using AdapterDesignePatter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AdapterDesignePatter.ViewModel
{
    public class AppViewModel:BaseViewModel
    {
        public RelayCommand ClickCommand { get; set; }
        public RelayCommand JsonCommand { get; set; }
        public RelayCommand XMLCommand { get; set; }
        private Human human;

        public Human Human
        {
            get { return human; }
            set { human = value; OnPropertyChanged(); }
        }


        public AppViewModel()
        {
            Human = new Human();
            ClickCommand = new RelayCommand((e) =>
            {
                IAdapter adapter;
                foreach (var item in App.MyCanvas.Children)
                {
                    if (item is RadioButton rb)
                    {
                        if (rb.IsChecked==true && rb.Name=="jsonRb")
                        {
                            WriteJson json=new WriteJson();
                            adapter =new JsonAdapter(json);
                            adapter.Write(Human);
                        }
                        else if (rb.IsChecked == true && rb.Name == "xmlRb")
                        {
                            XML xml=new XML();
                            adapter = new XMLAdapter(xml);
                            adapter.Write(Human);
                        }
                    }
                }
            });
        }
    }
}


