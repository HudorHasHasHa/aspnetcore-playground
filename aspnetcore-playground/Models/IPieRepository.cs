namespace aspnetcore_playground.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById { get; }
        IEnumerable<Pie> SearchPies { get; }
    }
}
