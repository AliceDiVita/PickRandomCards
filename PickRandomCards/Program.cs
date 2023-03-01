// See https://aka.ms/new-console-template for more information
using PickRandomCards;

Console.Write("Enter the numbers of cards to pick ");
string line = Console.ReadLine();

if (int.TryParse(line, out int numberOfCards))
{
    string[] arrayOfCards = CardPicker.PickSomeCards(numberOfCards);
	foreach (string card in arrayOfCards)
	{
		Console.WriteLine(card);
	}
}
else
{
    Console.WriteLine("The numer submitted is not valid");
}