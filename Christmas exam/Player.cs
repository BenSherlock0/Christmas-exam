using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_exam
{
    public enum Position {Goalkeeper = 0,Defenders = 1,Midfielder,Forward}
    public class Player
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Position PreferredPosition { get; set; }
        public DateTime DoB { get; set; }
        public int Age { get; set; }

        public static int space = 11;

        public Player(string fname, string lname, Position position, DateTime date)
        {
            FirstName = fname;
            Surname = lname;
            PreferredPosition = position;
            DoB = date;
            Age = DateTime.Now.Year - DoB.Year;
        }
        public Player() { }
        public override string ToString()
        {
            return $"{FirstName} {Surname} ({Age}) {PreferredPosition}"; //To list boxes
        }
    }
}
