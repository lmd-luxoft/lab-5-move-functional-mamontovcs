using MovieRental.Movies;
using System.Collections.Generic;
using System.Text;

namespace MovieRental
{
    internal class StatementGenerator : IStatementGenerator
    {
        public string GetStatement(string name, IEnumerable<Rental> rentals)
        {
            StringBuilder report = new StringBuilder();
            report.Append($"учет аренды для {name}\n");
            double totalAmount = 0;

            int frequentRenterPoints = 0;
            foreach (var rental in rentals)
            {
                double thisAmount = 0;

                thisAmount += rental.Movie.RegularPrice + ApplyAmountDependOnDaysRental(rental);

                frequentRenterPoints++;

                ApplyBonuses(report, rental, ref frequentRenterPoints, ref thisAmount);

                totalAmount += thisAmount;

                report.Append($"\t{rental.Movie}\t{thisAmount}\n");
            }
            report.Append($"Сумма задолженности составляет {totalAmount}\nВы заработали {frequentRenterPoints} очков за активность");
            return report.ToString();
        }

        private double ApplyAmountDependOnDaysRental(Rental rental)
        {
            double additionalAmount = 0;

            //TODO: Distribute this calculations

            //if (rental.DaysRental > 2)
            //{
            //    additionalAmount += (rental.DaysRental - 2) * 15;
            //}
            //else if (rental.DaysRental > 3)
            //{
            //    additionalAmount += (rental.DaysRental - 3) * 15;
            //}
            //else
            //{
            //    additionalAmount += rental.DaysRental * 3;
            //}

            return additionalAmount;
        }

        private void ApplyBonuses(StringBuilder report, Rental rental, ref int frequentRenterPoints, ref double thisAmount)
        {
            if (rental.Movie.AreBonusesAvailable && rental.DaysRental > 2)
                frequentRenterPoints++;
        }
    }
}
