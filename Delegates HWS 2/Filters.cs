using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MechlalaDll;

namespace Delegates_HWS_7._10
{
    public static class Filters
    {
        public static bool FilterGradeUnder50(Student student)
        {
            if (student.Grade < 50) return true;
            return false;
        }

        public static bool FirstNameAndLastNameAreSame(Student student)
        {
            if (student.FirstName[0] == student.LastName[0])
            {
                return true;
            }
            return false;
        }

        public static int FilterDebt(Student student)
        {
            return student.Debt;
        }

        public static int FilterPaid(Student student)
        {
            return student.Paid;
        }

        public static decimal FilterAge(Student student)
        {
            return student.Age;
        }

        public static decimal FilterGrade(Student student)
        {
            return student.Grade;
        }
    }
}
