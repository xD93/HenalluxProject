using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetLabo1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pupil> LstPupils = new List<Pupil>()
            {
                new Pupil ("Jean", 12),
                new Pupil ("Bob", 9),
                new Pupil ("Marc", 4),
                new Pupil ("Jojo", 8),
                new Pupil ("Berth", 12),
                new Pupil ("Anne", 5),
                new Pupil ("Cloclo", 3),
            };
            Pupil p1 = new Pupil("Xavier", 12);
            Activity act1 = new Activity("Math", true);
            Activity act2 = new Activity("Fr", false);
            Activity act3 = new Activity("Geo", true);
            Activity coloriage = new Activity("Coloriage", true);


            p1.AddAvtivity(act1);
            p1.AddAvtivity(act2);
            p1.AddAvtivity(act3);
            p1.AddAvtivity(coloriage);

            p1.AddEvaluation("Geo");
            p1.AddEvaluation("Cloriage", 'T');

            var pupilGrade1Plus6 = from Pupil in LstPupils
                                   where Pupil.Age > 6
                                   select Pupil;
            if (pupilGrade1Plus6 != null)
            {
                foreach (var Pupil in pupilGrade1Plus6)
                {
                    System.Console.Write(Pupil);
                }
                System.Console.Read();
            }

            System.Console.Write(p1);
            System.Console.Read();




        }
    }
}
