public class Mao
{
    public int card1 { get; set; }
    public int? card2 { get; set; }
    public int? card3 { get; set; }
    public int? card4 { get; set; }
    public int? card5 { get; set; }

    public Mao(
        string card1,
        string? card2 = null,
        string? card3 = null,
        string? card4 = null,
        string? card5 = null)
    {
        this.card1 = Cartas[card1];
        this.card2 = card2 is null ? null : Cartas[card2];
        this.card3 = card3 is null ? null : Cartas[card3];
        this.card4 = card4 is null ? null : Cartas[card4];
        this.card5 = card5 is null ? null : Cartas[card5];
    }

    public Dictionary<string, int> Cartas = new()
    {
        ["2O"] = 2, ["2C"] = 2, ["2E"] = 2, ["2P"] = 2,
        ["3O"] = 3, ["3C"] = 3, ["3E"] = 3, ["3P"] = 3,
        ["4O"] = 4, ["4C"] = 4, ["4E"] = 4, ["4P"] = 4,
        ["5O"] = 5, ["5C"] = 5, ["5E"] = 5, ["5P"] = 5,
        ["6O"] = 6, ["6C"] = 6, ["6E"] = 6, ["6P"] = 6,
        ["7O"] = 7, ["7C"] = 7, ["7E"] = 7, ["7P"] = 7,
        ["8O"] = 8, ["8C"] = 8, ["8E"] = 8, ["8P"] = 8,
        ["9O"] = 9, ["9C"] = 9, ["9E"] = 9, ["9P"] = 9
    };

}
