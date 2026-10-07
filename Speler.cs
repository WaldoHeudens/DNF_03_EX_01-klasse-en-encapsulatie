namespace KlasseVoorbeeld;

/// <summary>
/// Toont de bouwstenen van een klasse: een private field, properties
/// met verschillende toegang, een constructor en methods.
/// </summary>
public class Speler
{
    // Een private field: interne toestand die niemand van buitenaf mag aanraken.
    private int _ervaring;

    // Auto-property: de compiler maakt zelf een verborgen field aan.
    // De set is private, dus enkel de klasse zelf wijzigt de naam.
    public string Naam { get; private set; }

    // Init-only property: je stelt ze in bij het aanmaken, daarna niet meer.
    public string Klasse { get; init; } = "Avonturier";

    // Berekende (read-only) property: enkel een get, afgeleid van _ervaring.
    public int Niveau => _ervaring / 100 + 1;

    // Constructor: stelt de begintoestand in.
    public Speler(string naam)
    {
        Naam = naam;
    }

    // Method die de interne toestand wijzigt via een gecontroleerde weg.
    public void VerdienErvaring(int punten)
    {
        if (punten < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(punten), "Ervaring kan niet negatief zijn.");
        }

        _ervaring += punten;
    }

    public void HernoemNaar(string nieuweNaam)
    {
        // 'this' verwijst naar het huidige object. Hier maakt het duidelijk
        // dat we de property van dit object bedoelen.
        this.Naam = nieuweNaam;
    }
}
