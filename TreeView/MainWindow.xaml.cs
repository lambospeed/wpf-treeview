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

namespace TreeView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tvMain_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue != DesignItem)
                DesignItem.IsExpanded = false;
        }

        private void tvDesign_GotFocus(object sender, RoutedEventArgs e)
        {
            ResultsItem.IsSelected = false;
        }

        private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            foreach (object obj in DesignItem.Items)
            {
                if (obj.GetType() == typeof(TreeViewItem) && ((TreeViewItem)obj).HasItems == true && sender != obj)
                {
                    ((TreeViewItem)obj).IsExpanded = false;
                }
            }
        }
    }
}
