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

namespace ToDoList
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

        private void btn_Create_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox.Text;
            if(text != "")
            {
                listBox1.Items.Add(text);
            }
        }

        private void btn_Update_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox.Text;
            if (listBox1.SelectedIndex != -1 && text != "")
            {
                listBox1.Items[listBox1.SelectedIndex] = text;
            }
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
