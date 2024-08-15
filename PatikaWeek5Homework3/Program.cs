
//string liste tanımlanıyor...
List<string> coffees = new List<string>();

Console.WriteLine("Lütfen 5 adet kahve ismi giriniz..:");

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Kahve {i}..:");
    coffees.Add(Console.ReadLine());//listeye kahve adı ekleniyor..
}

//kullanıcı tarafından girilmiş 5 kahve adı ekrana yazdırılıyor...
Console.WriteLine("\nGirdiğiniz kahve isimleri:");
foreach (string coffee in coffees)
{
    Console.WriteLine(coffee);
}