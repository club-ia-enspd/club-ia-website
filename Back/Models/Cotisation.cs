using System;
using System.Collections.Generic;

namespace club_ia_website.Models;

public partial class Cotisation
{
    public int IdCotisation { get; set; }

    public int? IdMembre { get; set; }

    public decimal Montant { get; set; }

    public DateTime? DatePaiement { get; set; }

    public string Type { get; set; } = null!;

    public virtual Membre? IdMembreNavigation { get; set; }
}
