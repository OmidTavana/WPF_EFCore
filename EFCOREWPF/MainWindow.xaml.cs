using EFCOREWPF.Models;
using Microsoft.EntityFrameworkCore;
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

namespace EFCOREWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //خوندن
        }
        
    

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var books = await App.DbContext.Books.Include(r=>r.Category).ToListAsync();
            var groupedData = books.GroupBy(r => r.Category).Select(g => new { Title = g.Key.Title, Count = g.Count() }).ToList();
            dg.ItemsSource = groupedData;
        }
    }
}
