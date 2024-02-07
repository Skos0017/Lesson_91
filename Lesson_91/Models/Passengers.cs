using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Controls;

namespace Lesson_91.Models
{
    public class Passengers
    {
        public string PassengerId { get; set; }
        public string Name { get; set; }
        public string PClass { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string Survived { get; set; }
        public string SexCode { get; set; }

    }
}