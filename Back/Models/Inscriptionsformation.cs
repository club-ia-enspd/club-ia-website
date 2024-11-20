using System;
using System.Collections.Generic;

namespace club_ia_website.Models;

public partial class Inscriptionsformation
{
    public int IdInscription { get; set; }

    public int? IdFormation { get; set; }

    public int? IdMembre { get; set; }

    public DateTime? DateInscription { get; set; }

    public string? Statut { get; set; }

    public virtual Formation? IdFormationNavigation { get; set; }

    public virtual Membre? IdMembreNavigation { get; set; }
}
