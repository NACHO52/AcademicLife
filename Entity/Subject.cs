using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Credits { get; set; }
        public int Hours { get; set; }
        public SubjectPeriod Period { get; set; }
        public SubjectStatus Status { get; set; }
    }

    public enum SubjectPeriod
    {
        FirstQuarter = 1,
        SecondQuarter = 2,
        ThirdQuarter = 3,
        FourthQuarter = 4,
        FifthQuarter = 5,
        SixyhQuarter = 6,
        SeventhQuarter = 7,
        EighthQuarter = 8,
        NinethQuarter = 9,
        TenthQuarter = 10,
        EleventhQuarter = 11,
        TwelfthQuarter = 12
    }
    public enum SubjectStatus
    {
        Approved = 1,
        Pending = 2,
        InProgress = 3
    }
}
