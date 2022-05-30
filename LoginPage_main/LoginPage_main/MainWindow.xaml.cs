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

namespace LoginPage_main
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Btn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(IDTextBox.Text) || string.IsNullOrEmpty(IPTextBox.Text))
            {
                MessageBox.Show("ID과 비밀번호를 정확히 입력해주세요", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string nameCheck = String.Format("당신은 {0} 님이 맞습니까?", IDTextBox.Text);
            MessageBoxResult nameMessageBoxResult = MessageBox.Show(nameCheck, "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (nameMessageBoxResult == MessageBoxResult.No)
            {
                return;
            }

            string ipCheck = string.Format("비밀번호는 {0} 이 맞습니까?", IPTextBox.Text);
            MessageBoxResult ipmessageBoxResult = MessageBox.Show(ipCheck, "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ipmessageBoxResult == MessageBoxResult.No)
            {
                return;
            }

            this.DialogResult = true;
        }
    }
}
