using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class FeaturesCinema
    {
        private string _movieName;
        private double _price;
        private int _peopleCapacity;


        public string MovieName 
        {
            get { return _movieName; }
            set { this.MovieName = _movieName; }
        }

        public double Price => _price;

        public string CinemaHall { get; }

        public string Info() => $"Название фильма: {MovieName}, цена билета: {Price}, вместимось: {_peopleCapacity}, кинозал: {CinemaHall}";



        public FeaturesCinema(string movieName, double price, int peopleCapacity, string cinemaHall)
        {
            _movieName = movieName;
            _price = price;
            _peopleCapacity = peopleCapacity;
            CinemaHall = cinemaHall;
        }
    }
}
