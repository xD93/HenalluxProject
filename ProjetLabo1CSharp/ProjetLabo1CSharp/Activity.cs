using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetLabo1CSharp
{
    class Activity
    {
        public String Title { get; set; }
        public Boolean Compulsory { get; set; }

        public Activity(String title, Boolean comp)
        {
            Title = title;
            Compulsory = comp;
            
        }

        public override string ToString()
        {
            return Title + (Compulsory? "(obligatoire)": "");

        }
    }
}
