namespace OS.MovieReservationSystem.Models
{
    public class DiscountCondition(DiscountConditionTypes type, int sequence, DayOfWeek dayOfWeek, TimeOnly startTime, TimeOnly endTime)
    {
        public DiscountConditionTypes Type { get; } = type;
        public int Sequence { get; } = sequence;
        public DayOfWeek DayOfWeek { get; } = dayOfWeek;
        public TimeOnly StartTime { get; } = startTime;
        public TimeOnly EndTime { get; } = endTime;
    }

    public enum DiscountConditionTypes
    {
        /// <summary>
        /// 순번 조건
        /// </summary>
        Sequence,
        /// <summary>
        /// 기간 조건
        /// </summary>
        Period
    }
}
