using System;
namespace Course8.Entities
{
    class Studants
    {
        public int Number { get; set; }
        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if(!(obj is Studants)) { return false; }
            Studants other = obj as Studants;
            return Number.Equals(other.Number);
        }
    }
}
