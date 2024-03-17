using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticeEntity
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private storeP8Entitieeeeee bd = new storeP8Entitieeeeee();
        public MainWindow()
        {
            InitializeComponent();
            dataGrid1.ItemsSource = bd.Products.ToList();
            dataGrid2.ItemsSource = bd.Categories.ToList();
            dataGrid3.ItemsSource = bd.OrderArchive.ToList();
            
        }
    }
}
