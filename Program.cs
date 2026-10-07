using KlasseVoorbeeld;

// Een object aanmaken met de constructor.
var held = new Speler("Wannes");
held.VerdienErvaring(250);

Console.WriteLine($"{held.Naam} is niveau {held.Niveau} ({held.Klasse}).");

// Object initializer: stel de init-only property in bij het aanmaken.
var magier = new Speler("Luna") { Klasse = "Magier" };
Console.WriteLine($"{magier.Naam} speelt als {magier.Klasse}.");

// De naam wijzigen kan enkel via een method, niet rechtstreeks.
held.HernoemNaar("Wannes de Dappere");
Console.WriteLine($"Nieuwe naam: {held.Naam}");
