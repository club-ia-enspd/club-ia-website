using System;
using System.Collections.Generic;

namespace club_ia_website.Models;

public partial class Avi
{
    public int IdAvis { get; set; }

    public int? IdEvenement { get; set; }

    public int? IdMembre { get; set; }

    public string? Commentaire { get; set; }

    public int? Note { get; set; }

    public virtual Evenement? IdEvenementNavigation { get; set; }

    public virtual Membre? IdMembreNavigation { get; set; }
}
