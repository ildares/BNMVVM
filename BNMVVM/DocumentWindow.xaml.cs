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
using BNMVVM.Model;

namespace BNMVVM
{
    /// <summary>
    /// Interaction logic for DocumentWindow.xaml
    /// </summary>
    public partial class DocumentWindow : Window
    {
        private Document document=new Document();
        public DocumentWindow()
        {
            InitializeComponent();
        }
        public DocumentWindow(Document document)
        {
            InitializeComponent();
            this.document = document;
            DataContext = this.document;
        }
    }
}
