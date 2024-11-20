using System;
using System.Collections.Generic;

namespace club_ia_website.Models;

public partial class Role
{
    public int IdRole { get; set; }

    public string NomRole { get; set; } = null!;

    public virtual ICollection<Membre> Membres { get; set; } = new List<Membre>();
}
