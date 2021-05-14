using System.Collections.Generic;

namespace MovieRental
{
    internal class Customer
    {
        List<Rental> rentals = new List<Rental>();

        private IStatementGenerator _statementGenerator;

        public Customer(string name, IStatementGenerator statementGenerator)
        {
            Name = name;
            _statementGenerator = statementGenerator;
        }

        public string Name { get; }

        internal void AddRental(Rental rental)
        {
           rentals.Add(rental);
        }

        internal string GetStatement()
        {
            return _statementGenerator.GetStatement(Name, rentals);
        }
    }
}