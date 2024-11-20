using System;
using System.Collections.Generic;

namespace club_ia_website.Models;

public partial class Comite
{
    public int IdComite { get; set; }

    public string NomComite { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Evenement> Evenements { get; set; } = new List<Evenement>();

    public virtual ICollection<Formation> Formations { get; set; } = new List<Formation>();

    public virtual ICollection<Membre> Membres { get; set; } = new List<Membre>();

    public virtual ICollection<Projet> Projets { get; set; } = new List<Projet>();

    public virtual ICollection<Ressource> Ressources { get; set; } = new List<Ressource>();
}
