using System;
using System.Collections.Generic;

namespace club_ia_website.Models;

public partial class Galerie
{
    public int IdImage { get; set; }

    public int? IdEvenement { get; set; }

    public int? IdProjet { get; set; }

    public string? CheminImage { get; set; }

    public virtual Evenement? IdEvenementNavigation { get; set; }

    public virtual Projet? IdProjetNavigation { get; set; }
}
