using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class CafeAssortment
    {
        private string _dishName;
        private double _price;
        private string _category;
        private double _weight;

        public virtual string Info() => $"Название блюда: {_dishName}, цена: {_price}, категория: {_category}";

        public virtual double GetDishPrice()
        {
            return _price / _weight;
        }

        public virtual string CostOfDrink(int percent)
        {
            double res;
            res = _price - (_price * percent / 100);
            return $"Стоимость напитка со скидкой {percent}, будет: {res}";
        }


        public CafeAssortment(string dishName, double price, string category, double weight)
        {
            _dishName = dishName;
            _price = price;
            _category = category;
            _weight = weight;
        }
    }
}
