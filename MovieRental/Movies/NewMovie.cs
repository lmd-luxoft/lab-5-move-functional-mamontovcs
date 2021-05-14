using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Movies
{
    class NewMovie : MovieBase
    {
        private const double NewMovieRegularPrice = 0;

        public NewMovie(string title) : base(title)
        {
        }

        public override double RegularPrice => NewMovieRegularPrice;

        public override bool AreBonusesAvailable => true;
    }
}
