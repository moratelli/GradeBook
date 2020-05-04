using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    interface IBook
    {
        void AddGrade(double grade);
        Stats GetStats();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }
}
