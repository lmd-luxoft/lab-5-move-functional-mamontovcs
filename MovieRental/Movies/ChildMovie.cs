using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Movies
{
    class ChildMovie : MovieBase
    {
        private const double ChildMovieRegularPrice = 15;

        public ChildMovie(string title) : base(title)
        {
        }

        public override double RegularPrice => ChildMovieRegularPrice;

        public override bool AreBonusesAvailable => false;
    }
}
