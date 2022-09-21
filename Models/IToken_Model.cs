using System;
using System.Collections.Generic;

namespace Queue_Project.Models
{
    public interface IToken_Model 
    {
        
        int TokenId { get; set; }
        int TokenNumber { get; set; }
        DateTime Date { get; set; }

        List<IToken_Model> AllData { get; set; }
        int Total_Attended { get; set; }
        int Total_Cancelled { get; set; }
        int Total_NotAttended { get; set; }
        int Total_Remaining { get; set; }

        bool InQueue { get; set; }
        bool IsCancel { get; set; }
        bool IsCurrent { get; set; }
        bool IsPending { get; set; }
        int Token_Available { get; set; }
        int Token_Running { get; set; }
    }
}