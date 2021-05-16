using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Movies
{
    class RegularMovie : MovieBase
    {
        private const double RegularMovieRegularPrice = 2;

        public RegularMovie(string title) : base(title)
        {
        }

        public override double RegularPrice => RegularMovieRegularPrice;

        public override bool AreBonusesAvailable => false;
    }
}
