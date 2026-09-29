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

namespace Praktika4.Elements
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Classes.Student sstudent;
        public Window1(Classes.Student student)
        {
            InitializeComponent();
            sstudent = student;
            name.Text = sstudent.FirstName;
            lastname.Text = sstudent.LastName;
            lastlastname.Text = sstudent.Surname;
            kurs.Text = sstudent.Course.ToString();
            scholarshipCheak.IsChecked = sstudent.Scholarship;
        }

        private void Join(object sender, RoutedEventArgs e)
        {
            sstudent.FirstName = name.Text.Trim();
            sstudent.LastName = lastname.Text.Trim();
            sstudent.Surname = lastlastname.Text.Trim();
            this.Close();
        }
    }
}
