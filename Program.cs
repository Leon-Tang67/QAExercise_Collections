using System.Net.NetworkInformation;

string[] muppets =
{
"Kermit the Frog", "Miss Piggy", "Fozzie Bear", "Gonzo", "Rowlf the Dog", "Scooter",
"Animal", "Rizzo the Rat", "Pepe the Prawn", "Walter", "Clifford"
};
foreach (string muppet in muppets)
{
Console.WriteLine(muppet);
}
List<string> muppetList = muppets.ToList();
Console.WriteLine($"The first muppet " + muppets[0]);
Console.WriteLine($"The last muppet " + muppets[^1]);
muppetList.Add("Beaker");
Console.WriteLine($"The last muppet is now " + muppetList[^1]);
//list.Add(true);
//list.Add(3);

Console.WriteLine("\n--- Unsorted List ---");

for (int i = 0; i < muppetList.Count; i++)
{
    Console.Write(muppetList[i]);
    if (i < muppetList.Count - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();

muppetList.Sort();

Console.WriteLine("\n--- Sorted List ---");
for (int i = 0; i < muppetList.Count; i++)
{
    Console.Write(muppetList[i]);
    if (i < muppetList.Count - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();
