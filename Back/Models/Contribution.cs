using System;
using System.Collections.Generic;

namespace club_ia_website.Models;

public partial class Contribution
{
    public int IdContribution { get; set; }

    public int? IdProjet { get; set; }

    public int? IdMembre { get; set; }

    public string? RoleDansProjet { get; set; }

    public DateTime? DateContribution { get; set; }

    public virtual Membre? IdMembreNavigation { get; set; }

    public virtual Projet? IdProjetNavigation { get; set; }
}
