using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser
{
    class Student
    {
        string firstName;
        string lastName;
        string age;
        string descripton;
        string group;
        string idPic;

        public Student(string firstName, string lastName, string age, string descripton, string group, string idPic)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.descripton = descripton;
            this.group = group;
            this.idPic = idPic;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Age { get => age; set => age = value; }
        public string Descripton { get => descripton; set => descripton = value; }
        public string Group { get => group; set => group = value; }
        public string[] ToArr()
        {
            return new string[] { FirstName, LastName, Age, Descripton, Group};

        }
    }
}
