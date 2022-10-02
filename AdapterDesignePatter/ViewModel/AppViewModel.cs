using AdapterDesignePatter.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignePatter.ViewModel
{
    public class AppViewModel
    {
        public RelayCommand ClickCommand { get; set; }
        public AppViewModel()
        {
            ClickCommand = new RelayCommand((e) =>
            {

            });
        }
    }
}
