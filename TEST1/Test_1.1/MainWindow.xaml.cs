using System.Windows;
using Test_Module_1._1;
using Test_Module_2._1;

namespace Test_1._1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        Module_1_1 Module_1_1;
        Module_2_1 Module_2_1;

        public MainWindow()
        {
            InitializeComponent();

            Module_1_1 = new Module_1_1();
            Module_2_1 = new Module_2_1();

            View_Text.Text = $"{Module_1_1.Module_Name} ({Module_1_1.Module_Function(0, 1)})";
            View_ShareText.Text = $"{Module_2_1.Module_Name} ({Module_2_1.Module_Function(1, 1)})";
        }
    }
}
