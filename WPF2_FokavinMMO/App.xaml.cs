using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF2_FokavinMMO.Models;

namespace WPF2_FokavinMMO
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static WPF2_FokavinMMOEntities DB = new WPF2_FokavinMMOEntities();
        public static User LoggedUser;
    }
}
