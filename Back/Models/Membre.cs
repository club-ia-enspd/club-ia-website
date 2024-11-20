using System;
using System.Collections.Generic;

namespace club_ia_website.Models;

public partial class Membre
{
    public int IdMembre { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MotDePasse { get; set; } = null!;

    public DateTime? DateInscription { get; set; }

    public string? PhotoProfil { get; set; }

    public int? IdRole { get; set; }

    public int? IdComites { get; set; }

    public virtual ICollection<Avi> Avis { get; set; } = new List<Avi>();

    public virtual ICollection<Contribution> Contributions { get; set; } = new List<Contribution>();

    public virtual ICollection<Cotisation> Cotisations { get; set; } = new List<Cotisation>();

    public virtual Comite? IdComitesNavigation { get; set; }

    public virtual Role? IdRoleNavigation { get; set; }

    public virtual ICollection<Inscriptionsformation> Inscriptionsformations { get; set; } = new List<Inscriptionsformation>();
}
