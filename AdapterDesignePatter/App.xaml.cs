﻿using AdapterDesignePatter.ConvertJsonAndXml;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AdapterDesignePatter
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Canvas MyCanvas;
        public static Convertor convertor;
        public App()
        {

        }
    }
}
