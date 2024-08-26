using BNMVVM.Model;
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
using System.Windows.Shapes;

namespace BNMVVM
{
    /// <summary>
    /// Interaction logic for GoalWindow.xaml
    /// </summary>
    public partial class GoalWindow : Window
    {
        private Goal goal=new Goal();
        public GoalWindow()
        {
            InitializeComponent();
        }
        public GoalWindow(Goal gl)
        {
            InitializeComponent();
            goal = gl;
            DataContext = goal;
        }
    }
}
