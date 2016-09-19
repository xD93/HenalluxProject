using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetLabo1CSharp
{
    class Pupil : Person
    {
        public int Grade { get; set; }
        private List<Activity> lstActivities;

        public List<Activity> LstActivities
        {
            get { return lstActivities; }
            set { lstActivities = value; }
        }

        private char[] TabEval;

        public char[] tabEval
        {
            get { return TabEval; }
            set { TabEval = value; }
        }

        public Pupil(String name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            TabEval = new char[10];
        }

        public Pupil( String name, int age): this(name, age,1)
        {

        }

        public void AddAvtivity(Activity newActivity)
        {
            LstActivities.Add(newActivity);
        }

        public override string ToString()
        {
            string ch = base.ToString();
            int cptActivities = LstActivities.Count();
            if (cptActivities == 0)
            {
                ch += "n'a pas encore d'activité\n";
            }
            else
            {
                ch += "a choisi les activités suivantes: \n";
                foreach (Activity activity in LstActivities)
                {
                   ch += activity.ToString() + "\n";
                }   
            }
            return ch;
        }

        public void AddEvaluation(String title = null, char evaluation = 'S')
        {
            if (title != null)
            {


                for (int i = 0; i < tabEval.Length && i < LstActivities.Count(); i++)
                {
                    if (LstActivities.ElementAt(i).Title.Equals(title))
                    {
                        tabEval[i] = evaluation;
                    }
                }
            }
            else
            {
                System.Console.Write("Titre ne peut pas etre vide");
            }
        }

    }
}
