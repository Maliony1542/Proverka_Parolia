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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lbl1.Visibility = Visibility.Hidden; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //int vvod=0;

            //string text = txtB1.Text; 
            //int kol  = text.Length;
            //if (kol < 6)  
            //{
            //    lbl1.Visibility = Visibility.Visible;
            //}
            //txtkol.Text = Convert.ToString(kol);

            //for (int i = 0; i < text.Length; i++)
            //    if (text[i] == text.ToUpper()[i]) Console.WriteLine("{0} в верхнем регистре ", str[i]);
            try
            {
                string s = txtB1.Text;
                char[] array = s.ToCharArray();
                int d = s.Length;
                int k = 0;
                int u = 0;
                int b = 0;
                char p = '$';
                char j = '!';
                char f = '@';
                char h = '%';
                char z = '^';
                char x = '#';
                for(int i=0; i<d; i++)
                {
                    if (char.IsUpper(array[i]))
                        k++;
                }
                for (int i = 0; i < d; i++)
                {
                    if (char.IsNumber(array[i]))
                        u++;
                }
                for (int i = 0; i < d; i++)
                {
                    if (array[i] == p || array[i] == j || array[i] == f || array[i] == h || array[i] == z || array[i] == z)
                        b++;
                }
                if(k>0 && u>1 && b>0)
                {
                    MessageBox.Show("Пароль сохранён в password.txt");
                    StreamWriter SW = new StreamWriter(new FileStream(@"C:\password.txt", FileMode.Create, FileAccess.Write));
                    SW.Write(s);
                    SW.Close();
                }
                else 
                {
                    MessageBox.Show("В пароле допущены ошибки, чтобы сохранить пароль \nнужно минимум 6 символов \n1 прописная буква\n1цифра\nминимум один символ из набора !@#$%^");
                }
            }
            catch
            {
                MessageBox.Show("Возникло исключение!");
            }
            finally
            {
                MessageBox.Show("Блок finally");
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
