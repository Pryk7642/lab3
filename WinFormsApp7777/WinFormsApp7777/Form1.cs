using System.Diagnostics;
using System.Xml.Linq;

namespace WinFormsApp7777
{
    public partial class Form1 : Form
    {

        List<Class1> Class1List = new List<Class1>();
        List<double> GradeList = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //
                string name = this.textBox1.Text;
                string studentid = this.textBox2.Text;
                string year = this.textBox3.Text;
                string height = this.textBox4.Text;
                double grade = double.Parse(this.textBox5.Text);
                string branch = this.textBox6.Text;

                //
                Class1 class1 = new Class1(name,studentid,year,height,grade,branch);

                Class1List.Add(class1);

                //
                BindingSource source = new BindingSource();
                source.DataSource = Class1List;
                this.dataGridView1.DataSource= source;

                //
                foreach (var val in Class1List)
                {
                    this.GradeList.Add(val.Grade);
                }
                //
                double Maxgrade = GradeList.Max();
                double Mingrade = GradeList.Min();
                //
                int allClass = Class1List.Count();

                this.labelAllStu.Text = allClass.ToString();
                this.labelMax.Text = Maxgrade.ToString();
                this.labelMin.Text = Mingrade.ToString();


            }
            catch
            {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }
    }
}