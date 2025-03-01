using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class FeaturesStudent
    {
        private string _FIO;
        private int _groupName;
        private int _gradeBookNum;


        public string FIO
        {
            get { return _FIO; }
            set { _FIO = value; }
        }

        public int GroupName { get; }
        public int GradeBookNum { get; }
        public string SNILS { get; }

        public string Info() => $"ФИО: {FIO}, номер группы: {GroupName}, номер зачетной книжки: {GradeBookNum}, СНИЛС: {SNILS}";

        public FeaturesStudent(string fIO, int groupName, int gradeBookNum)
        {
            FIO = fIO;
            GroupName = groupName;
            GradeBookNum = gradeBookNum;
        }
    }
}
