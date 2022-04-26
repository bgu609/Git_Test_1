using System.Windows;
using Test_ShareProject_2;
using Test_Util_1;

namespace Test_1._1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        Test_Util_1_Source Test_Util_1_Source;
        Test_Share_2_Source Test_Share_2_Source;

        public MainWindow()
        {
            InitializeComponent();

            Test_Util_1_Source = new Test_Util_1_Source();
            Test_Share_2_Source = new Test_Share_2_Source();

            View_Text.Text = Test_Util_1_Source.Instance_Name;
            View_ShareText.Text = Test_Share_2_Source.Sharing_Name;
        }
    }
}
