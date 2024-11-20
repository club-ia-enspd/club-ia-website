using System;
using System.Collections.Generic;

namespace club_ia_website.Models;

public partial class Evenement
{
    public int IdEvenement { get; set; }

    public string Titre { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime DateEvenement { get; set; }

    public string Lieu { get; set; } = null!;

    public int? IdComite { get; set; }

    public virtual ICollection<Avi> Avis { get; set; } = new List<Avi>();

    public virtual ICollection<Galerie> Galeries { get; set; } = new List<Galerie>();

    public virtual Comite? IdComiteNavigation { get; set; }
}
