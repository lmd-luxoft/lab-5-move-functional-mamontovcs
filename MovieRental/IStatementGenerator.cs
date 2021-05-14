using System.Collections.Generic;

namespace MovieRental
{
    internal interface IStatementGenerator
    {
        string GetStatement(string name, IEnumerable<Rental> rentals);
    }
}