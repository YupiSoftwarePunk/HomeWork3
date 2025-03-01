using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Animals
    {
        private string _name;
        private string _breed;
        private string _birthDate;
        private double _weight;


        public virtual string Info() => $"Имя: {_name}, порода: {_breed}, вес: {_weight}, дата рождения: {_birthDate}";
        
        public Animals(string name, string breed, string birthDate, double weight)
        {
            _name = name;
            _breed = breed;
            _birthDate = birthDate;
            _weight = weight;
        }
    }
}
