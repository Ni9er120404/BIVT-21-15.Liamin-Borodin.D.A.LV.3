namespace LaboratoryWork.OOP._3
{
	public class Student
	{
		public string FullName { get; }
		public int Math { get; }
		public int Physics { get; }
		public int Russian { get; }
		public float Average { get; }

		public Student(string fullName, int math, int physics, int russian, float average)
		{
			FullName = fullName;
			Math = math;
			Physics = physics;
			Russian = russian;
			Average = average;
		}

		public override string ToString()
		{
			return $"Имя: {FullName}, Математика: {Math}, Физика: {Physics}, Русский: {Russian}, Средний балл: {Average:F2}";
		}
	}
}