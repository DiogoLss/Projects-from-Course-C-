using System.Globalization;
namespace Course5.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            if(HealthExpenditures > 0 && AnualIncome < 20000.00) { return (AnualIncome * 0.15) - (HealthExpenditures * 0.5); }
            else if (HealthExpenditures > 0 ) { return (AnualIncome * 0.25) - (HealthExpenditures * 0.5); }
            else if (AnualIncome < 20000.00) { return AnualIncome * 0.15; }
            else { return (AnualIncome * 0.25); }
        }
        public override string ToString()
        {
            return $"{Name}, ${Tax().ToString("F2")}";
        }
    }
}
