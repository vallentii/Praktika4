using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Praktika4.Classes
{
    public class RepoStudents
    {
        public static List<Student> AllStudent()
        {
            List<Student> allStudent = new List<Student>();
            allStudent.Add(new Student("Болотов", "Евгений", "Олегович", "/Images/student1.jpg"));
            allStudent.Add(new Student("Григорьев", "Роман", "Владимирович"));
            allStudent.Add(new Student("Гудков", "Георгий", "Константинович", false, 3));
            allStudent.Add(new Student("Исыпова", "Алёна", "Александровна", true));
            allStudent.Add(new Student("Иутин", "Павел", "Алексеевич", false, 3));
            allStudent.Add(new Student("Ишимов", "Виктор", "Алексеевич", "/Images/student1.jpg"));
            allStudent.Add(new Student("Калюжный", "Артем", "Евгеньевич"));
            allStudent.Add(new Student("Кусакина", "Полина", "Олеговна", true));
            allStudent.Add(new Student("Ленченков", "Александр", "Дмитриевич"));
            allStudent.Add(new Student("Лесникова", "Мария", "Михайловна", true));
            allStudent.Add(new Student("Мутагаров", "Даниил", "Ринатович"));
            allStudent.Add(new Student("Нарижный", "Данил", "Владленович", "/Images/student1.jpg"));
            allStudent.Add(new Student("Никонов", "Арсений", "Дмитриевич", false, 3));
            allStudent.Add(new Student("Оборин", "Даниил", "Артёмович", "/Images/student1.jpg"));
            allStudent.Add(new Student("Посадских", "Дарья", "Андреевна", "/Images/student1.jpg"));
            allStudent.Add(new Student("Сторожев", "Денис", "Романович",true));
            allStudent.Add(new Student("Суслов", "Егор", "Владимирович", "/Images/student1.jpg"));
            allStudent.Add(new Student("Токмаков", "Даниил", "Сергеевич", true));
            allStudent.Add(new Student("тронин", "Александр", "Владиславович", "/Images/student1.jpg"));
            allStudent.Add(new Student("Халилов", "Дамир", "Ринатович"));
            allStudent.Add(new Student("Шестаков", "Дмитрий", "Андреевич"));
            return allStudent;
        }
    }
}
