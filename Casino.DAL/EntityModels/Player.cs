using System;
using System.Collections.Generic;

namespace Casino.DAL.EntityModels;

public partial class Player
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public int Salt { get; set; }

    public byte Gender { get; set; }

    public byte State { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MobileNumber { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
