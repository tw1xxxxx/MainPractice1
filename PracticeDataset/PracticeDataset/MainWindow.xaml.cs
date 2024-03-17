using PracticeDataset.storeP8DataSetTableAdapters;
using System;
using System.Windows;
namespace PracticeDataset
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductsTableAdapter products = new ProductsTableAdapter();
        OrderArchiveTableAdapter orders = new OrderArchiveTableAdapter();
        CategoriesTableAdapter categories= new  CategoriesTableAdapter();

        public MainWindow()
        {

            InitializeComponent();

            dataGrid1.ItemsSource = products.GetData();
            dataGrid2.ItemsSource = orders.GetData();
            dataGrid3.ItemsSource = categories.GetData();
            //dataGrid.ItemsSource = products.GetData();
        }

    }
}
