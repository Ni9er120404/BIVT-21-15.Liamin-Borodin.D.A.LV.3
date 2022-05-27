namespace BIVT_21_15_Liamin_Borodin.D.A_LV_3
{
    public partial class Form1 : Form
    {
        private readonly List<Student> students;

        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            students.Add(new Student(textBox1.Text,
                               int.Parse(textBox2.Text),
                               int.Parse(textBox4.Text),
                               int.Parse(textBox3.Text),
                               (int.Parse(textBox2.Text)
                               + int.Parse(textBox3.Text)
                               + int.Parse(textBox4.Text)) / 3));
            richTextBox1.AppendText((students[students.Count - 1]).ToString());

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = 0; j < students.Count; j++)
                {
                    if (students[j].Average < students[i].Average)
                    {
                        float temp = students[j].Average;
                        students[j].Average = students[i].Average;
                        students[i].Average = temp;
                    }
                }
            }
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Math > 2 && students[i].Physics > 2 && students[i].Russian > 2)
                {
                    richTextBox1.AppendText((students[i]).ToString());
                }
            }

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void Label1_Click(object sender, EventArgs e)
        {
        }
        private void Label2_Click(object sender, EventArgs e)
        {
        }
        private void Label3_Click(object sender, EventArgs e)
        {
        }
        private void Label4_Click(object sender, EventArgs e)
        {
        }
    }
    public class Student
    {
        public string Last_Name;
        public int Math;
        public int Physics;
        public int Russian;
        public float Average;
        public Student(string last_name, int math, int physics, int russian, float average)
        {
            Last_Name = last_name;
            Math = math;
            Physics = physics;
            Russian = russian;
            Average = average;

        }
        public override string ToString()
        {
            return $"Имя: {Last_Name} Математика: {Math} Физика: {Physics} Русский: {Russian} average: {Average}";
        }
    }

}