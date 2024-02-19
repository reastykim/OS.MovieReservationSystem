using System.Numerics;

namespace OS.MovieReservationSystem.Models
{
    public class Money
    {
        public static readonly Money Zero = Wons(0);

        private readonly BigInteger _amount;

        public static Money Wons(long amount)
        {
            return new Money(new BigInteger(amount));
        }

        public static Money Wons(double amount)
        {
            return new Money(new BigInteger(amount));
        }

        Money(BigInteger amount)
        {
            _amount = amount;
        }

        public Money Plus(Money amount)
        {
            return new Money(_amount + amount._amount);
        }

        public Money Minus(Money amount)
        {
            return new Money(_amount - amount._amount);
        }

        public Money Times(double percent)
        {
            return new Money(_amount * new BigInteger(percent));
        }

        public bool IsLessThan(Money other)
        {
            return _amount.CompareTo(other._amount) < 0;
        }

        public bool IsGreaterThan(Money other)
        {
            return _amount.CompareTo(other._amount) >= 0;
        }
    }
}
