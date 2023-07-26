using System.Windows;

namespace LaboratoryWork.OOP._3
{
	public partial class MainWindow : Window
	{
		private readonly List<Student> students;

		public MainWindow()
		{
			InitializeComponent();
			students = new List<Student>();
		}

		private void AddButton_Click(object sender, RoutedEventArgs e)
		{
			if (int.TryParse(mathTextBox.Text, out int math)
				&& int.TryParse(physicsTextBox.Text, out int physics)
				&& int.TryParse(russianTextBox.Text, out int russian))
			{
				float average = (math + physics + russian) / 3f;
				Student newStudent = new Student(nameTextBox.Text, math, physics, russian, average);
				students.Add(newStudent);
				_ = studentsListBox.Items.Add(newStudent);
			}
			else
			{
				_ = MessageBox.Show("Пожалуйста, введите корректные оценки (целые числа).");
			}
		}
	}
}