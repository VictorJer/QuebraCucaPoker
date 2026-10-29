using System.ComponentModel;

public class Mao
{
    public string card1 {get; set;} = string.Empty;

    public Mao(string card1)
    {
        this.card1 = card1;
    }
    public List<string> Cartas = [
    "2O", "2C", "2E", "2P",
    "3O", "3C", "3E", "3P",
    "4O", "4C", "4E", "4P",
    "5O", "5C", "5E", "5P",
    "6O", "6C", "6E", "6P",
    "7O", "7C", "7E", "7P",
    "8O", "8C", "8E", "8P",
    "9O", "9C", "9E", "9P",

    ];

}

