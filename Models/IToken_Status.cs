namespace Queue_Project.Models
{
    public interface IToken_Status
    {
        bool InQueue { get; set; }
        bool IsCancel { get; set; }
        bool IsCurrent { get; set; }
        bool IsPending { get; set; }
        int Token_Available { get; set; }
        int Token_Running { get; set; }
    }
}