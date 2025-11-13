namespace DataAccess.Entities
{
    public class EarningLevels
    {
        public int Id { get; set; }

        public int Level { get; set; }

        public int ClubId { get; set; }

        public Decimal Amount { get; set; }
    }
}
