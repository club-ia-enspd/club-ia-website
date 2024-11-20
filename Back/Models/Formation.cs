using System;
using System.Collections.Generic;

namespace club_ia_website.Models;

public partial class Formation
{
    public int IdFormation { get; set; }

    public string Titre { get; set; } = null!;

    public string? Description { get; set; }

    public int? Duree { get; set; }

    public decimal? Prix { get; set; }

    public int? IdComite { get; set; }

    public virtual Comite? IdComiteNavigation { get; set; }

    public virtual ICollection<Inscriptionsformation> Inscriptionsformations { get; set; } = new List<Inscriptionsformation>();
}
