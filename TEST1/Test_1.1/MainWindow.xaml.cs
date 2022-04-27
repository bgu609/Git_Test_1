using System.Windows;
using Test_Module_1._1;

namespace Test_1._1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        Module_1_1 Module_1_1;

        public MainWindow()
        {
            InitializeComponent();

            Module_1_1 = new Module_1_1();

            View_Text.Text = $"{Module_1_1.Module_Name} ({Module_1_1.Module_Function(0, 1)})";
            //View_ShareText.Text = Test_Share_2_Source.Sharing_Name;
        }
    }
}
