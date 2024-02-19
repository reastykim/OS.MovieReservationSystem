using OS.MovieReservationSystem.Models;

namespace OS.MovieReservationSystem
{
    public class ReservationAgency
    {
        public Reservation Reserve(Screening screening, Customer customer, int audienceCount)
        {
            var movie = screening.Movie;

            bool discountable = false;

            foreach (var condition in movie.DiscountConditions)
            {
                if (condition.Type == DiscountConditionTypes.Period)
                {
                    discountable = screening.WhenScreened.DayOfWeek == condition.DayOfWeek &&
                                   condition.StartTime.CompareTo(TimeOnly.FromDateTime(screening.WhenScreened)) <= 0 &&
                                   condition.EndTime.CompareTo(TimeOnly.FromDateTime(screening.WhenScreened)) >= 0;
                }
                else
                {
                    discountable = condition.Sequence == screening.Sequence;
                }

                if (discountable)
                {
                    break;
                }
            }

            Money fee = Money.Zero;

            if (discountable)
            {
                var discountAmount = Money.Zero;

                switch (movie.MovieType)
                {
                    case MovieTypes.AmountDiscount:
                        discountAmount = movie.DiscountAmount;
                        break;
                    case MovieTypes.PercentDiscount:
                        discountAmount = movie.Fee.Times(movie.DiscountPercent);
                        break;
                    case MovieTypes.NoneDiscount:
                    default:
                        discountAmount = Money.Zero;
                        break;
                }

                fee = movie.Fee.Minus(discountAmount);
            }
            else
            {
                fee = movie.Fee;
            }

            return new Reservation(customer, screening, fee, audienceCount);
        }
    }
}
