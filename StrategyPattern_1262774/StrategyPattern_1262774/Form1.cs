using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern_1262774
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStrategySort_Click(object sender, EventArgs e)
        {
            IStrategySort<Student> ist = new ShellSortStrategy();
            University u1 = new University(ist);
            Student s1 = new Student
            {
                FirstName = "Bill",
                LastName = "Baker",
                
            Id = 12345,
                Test1Score = 85,
                Test2Score = 91
            };
            u1.AddStudent(s1);
            Student s2 = new Student

            {
                FirstName = "Sally"
           ,
                LastName = "Mathews"
           ,
                Id = 12348,
                Test1Score = 87,
                Test2Score = 93
            };
            u1.AddStudent(s2);
            Student s3 = new Student

            {
                FirstName = "Adam"
           ,
                LastName = "Fredericks"
           ,
                Id = 12341,
                Test1Score = 82,
                Test2Score = 83
            };
            u1.AddStudent(s3);
            u1.SortStudent(); // uses Shell sort
            string out1 = ""
           ;
            foreach
           (Student st in u1.STList)
                out1 += st.ToString() + "\n";
            MessageBox.Show(out1);
            u1.SortStrategy = new QuickSortStrategy();
            u1.SortStudent();
            string out2 = ""
           ;
            foreach
           (Student st in u1.STList)
                out2 += st.ToString() + "\n";
            MessageBox.Show(out2);

        }

    }
}
