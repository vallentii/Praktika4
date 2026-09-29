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

namespace Praktika4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Classes.Student> AllStudent = Classes.RepoStudents.AllStudent();
        public int Count = 10;
        public int Step = 0;
        public MainWindow()
        {
            InitializeComponent();
            CreateStudent(Step, Count);
        }
        public void CreateStudent(int Step, int Count)
        {
            for (int iStudent = Step; iStudent < Step + Count; iStudent++)
                if (AllStudent.Count > iStudent)
                    parent.Children.Add(new Elements.Student(AllStudent[iStudent]));
            this.Step += Count;
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer scroll = sender as ScrollViewer;
            double ParentHeinght = parent.ActualHeight;
            double WindowHeight = scroll.ActualHeight - 20;
            double DeltaHeight = ParentHeinght - WindowHeight;
            if (DeltaHeight - scroll.VerticalOffset < 140)
            {
                CreateStudent(Step, Count);
            }
        }
        private void Search_Students(object sender, TextChangedEventArgs e)
        {
            parent.Children.Clear();
            string f = search.Text.Trim().ToLower();
            foreach(var student in AllStudent)
            {
                if(student.GetFIO().ToLower().Contains(f))
                parent.Children.Add(new Elements.Student(student));
            }
        }
    }
}
