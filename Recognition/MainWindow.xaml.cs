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
using V = Validation.IS;

namespace Recognition
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

        private void textExpression_TextChanged(object sender, TextChangedEventArgs e)
        {
            stackCanNotUse.Children.Clear();
            stackCanUse.Children.Clear();

            string str = textExpression.Text.Trim();
            if (string.IsNullOrWhiteSpace(str))
                return;

            Add("Урл", V.Url(str));
            Add("Електронная почта", V.Email(str));
            Add("Пароль", V.Password(str));
            Add("Логин", V.Login(str));
            Add("Имя", V.Name(str));
            Add("Имя файла", V.FileName(str));
            Add("Имя папки", V.DirectoryPath(str));
            Add("Путь к файлу", V.FullPath(str));
            
        }

        private void Add(string diplayName, bool canUse)
        {
            TextBlock tb = new TextBlock() { Text = diplayName };
            if (canUse)
                stackCanUse.Children.Add(tb);
            else
                stackCanNotUse.Children.Add(tb);
        }
    }
}
