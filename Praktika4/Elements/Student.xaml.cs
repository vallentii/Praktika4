using Praktika4.Classes;
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

namespace Praktika4.Elements
{
    /// <summary>
    /// Логика взаимодействия для Student.xaml
    /// </summary>
    public partial class Student : UserControl
    {
        public Classes.Student curStudent;
        public Student(Classes.Student student)
        {
            InitializeComponent();
            curStudent = student;
            UpdateInterfase();
            tb_fio.Content = student.GetFIO();
            tb_scholarship.Content = student.Scholarship ? "Стипендия: получает" : "Стипендия: не получает";
            tb_course.Content = $"Курс: {student.Course}";
            if (!string.IsNullOrEmpty(student.ImagePath))
            {
                img_stu.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(student.ImagePath, UriKind.RelativeOrAbsolute));
            }
        }
        private void UpdateInterfase()
        {
            tb_fio.Content = curStudent.GetFIO();
            tb_scholarship.Content = curStudent.Scholarship ? "Стипендия: получает" : "Стипендия: не получает";
            tb_course.Content = $"Курс: {curStudent.Course}";
        }

        private void izmena(object sender, RoutedEventArgs e)
        {
            Window1 editWindow = new Window1(curStudent);
            editWindow.ShowDialog();
            UpdateInterfase();
        }
    }
}
