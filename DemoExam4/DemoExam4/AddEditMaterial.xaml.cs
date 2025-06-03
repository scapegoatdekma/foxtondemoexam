using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace DemoExam4
{
    /// <summary>
    /// Логика взаимодействия для AddEditMaterial.xaml
    /// </summary>
    public partial class AddEditMaterial : Page
    {
      
        public AddEditMaterial()
        {
            InitializeComponent();

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данные сохранены");
            Manager.MainFrame.GoBack();
        }
    }
}
