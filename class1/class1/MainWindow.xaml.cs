using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace class1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_dobav(object sender, RoutedEventArgs e)
        {
            string newItemText = TextBoxDob.Text;
            List1.Items.Add(newItemText);
            TextBoxDob.Text = string.Empty;
        }
        private void Button_Click_ydal(object sender, RoutedEventArgs e)
        {
            string iT = TextBoxYdl.Text;

            if (!string.IsNullOrEmpty(iT))
            {
                string[] str = iT.Split(',');
                List<int> del = new List<int>();

                foreach (string iS in str)
                {
                    if (int.TryParse(iS, out int preobraz) && preobraz >= 0 && preobraz < List1.Items.Count)
                    {
                        del.Add(preobraz);
                    }
                }

                del.Sort((a, b) => b.CompareTo(a));

                foreach (int idel in del)
                {
                    List1.Items.RemoveAt(idel);
                }
            }
            TextBoxYdl.Text = string.Empty;
        }

        private void Button_Click_vsta(object sender, RoutedEventArgs e)
        {
            string ved = TextBoxVst.Text;
            string[] str = ved.Split(',');

            if (str.Length == 2)
            {
                if (int.TryParse(str[0], out int razd))
                {
                    string item = str[1];

                    if (razd >= 0 && razd <= List1.Items.Count + 1)
                    {
                        List1.Items.Insert(razd, item);
                    }
                }
            }
            TextBoxVst.Text = string.Empty;
        }
    }
}
