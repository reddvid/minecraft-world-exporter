using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TransferCraft
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            FrameworkElement.StyleProperty.OverrideMetadata(typeof(Window), new FrameworkPropertyMetadata
            {
                DefaultValue = FindResource(typeof(Window))
            });
        }
    }
}
