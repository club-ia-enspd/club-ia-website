using System;
using System.Collections.Generic;

namespace club_ia_website.Models;

public partial class Projet
{
    public int IdProjet { get; set; }

    public string Titre { get; set; } = null!;

    public string? Description { get; set; }

    public string Statut { get; set; } = null!;

    public int? IdComite { get; set; }

    public DateTime? DateDebut { get; set; }

    public DateTime? DateFin { get; set; }

    public virtual ICollection<Contribution> Contributions { get; set; } = new List<Contribution>();

    public virtual ICollection<Galerie> Galeries { get; set; } = new List<Galerie>();

    public virtual Comite? IdComiteNavigation { get; set; }
}
