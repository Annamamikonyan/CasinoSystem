using System;
using System.Collections.Generic;

namespace Casino.DAL.EntityModels;

public partial class PlayerTransaction
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public bool OperationType { get; set; }

    public decimal Amount { get; set; }

    public DateTime CreationTime { get; set; }

    public virtual Account Account { get; set; } = null!;
}
