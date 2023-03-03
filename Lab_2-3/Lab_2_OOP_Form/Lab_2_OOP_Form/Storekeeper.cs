using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_OOP_Form
{
    [Serializable]
    public class Storekeeper
    {
        public string LastName { set; get; } 
        public string FirstName { set; get; }
        public string Patronymic { set; get; }
        public int WorkExperience { set; get; }
        public Storekeeper() { }
        public Storekeeper(string LastName, string FirstName, string Patronymic, int WorkExperience)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Patronymic= Patronymic;
            this.WorkExperience = WorkExperience;
        }
    }
}
