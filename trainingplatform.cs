using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace standards.bunchofclasses
{
    internal class trainingplatform
    {
        public string model;
        public trainingplatform()
        {
            model = "hardwork";
        }
        static void Main(string[]args)
        {
            trainingplatform skill = new trainingplatform();
            Console.WriteLine(skill.model);
        }
    }
}
