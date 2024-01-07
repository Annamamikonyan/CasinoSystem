using System;
using System.Collections.Generic;

namespace Casino.DAL.EntityModels;

public partial class Account
{
    public int Id { get; set; }

    public int PlayerId { get; set; }

    public byte AccountType { get; set; }

    public decimal Balance { get; set; }

    public virtual Player Player { get; set; } = null!;

    public virtual ICollection<PlayerTransaction> PlayerTransactions { get; set; } = new List<PlayerTransaction>();
}
