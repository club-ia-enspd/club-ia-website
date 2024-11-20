using System;
using System.Collections.Generic;

namespace club_ia_website.Models;

public partial class Ressource
{
    public int IdRessource { get; set; }

    public string Titre { get; set; } = null!;

    public string LienRessource { get; set; } = null!;

    public string? TypeRessource { get; set; }

    public int? IdComite { get; set; }

    public virtual Comite? IdComiteNavigation { get; set; }
}
