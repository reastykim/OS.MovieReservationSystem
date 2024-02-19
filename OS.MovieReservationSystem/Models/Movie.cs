namespace OS.MovieReservationSystem.Models
{
    public class Movie(string title, TimeSpan runningTime, Money fee, MovieTypes movieType, Money discountAmount, double discountPercent)
    {
        public string Title { get; } = title;
        public TimeSpan RunningTime { get; } = runningTime;
        public Money Fee { get; } = fee;
        public List<DiscountCondition> DiscountConditions { get; set; } = new List<DiscountCondition>();

        public MovieTypes MovieType { get; } = movieType;
        public Money DiscountAmount { get; } = discountAmount;
        public double DiscountPercent { get; } = discountPercent;
    }

    public enum MovieTypes
    {
        /// <summary>
        /// 금액 할인 정책
        /// </summary>
        AmountDiscount,
        /// <summary>
        /// 비율 할인 정책
        /// </summary>
        PercentDiscount,
        /// <summary>
        /// 미적용
        /// </summary>
        NoneDiscount,
    }
}
