
// bu yanlış metod çok uzun bu kullanılmıyor.

string kurs1 = "yazılım geliştirici kampı";
string kurs2 = "programlamaya başlangıc için temel kurs";
string kurs3 = "java";

Console.WriteLine(kurs1);


// array - dizi 

string[] kurslar = new string[] { "yazılım geliştirici kampı", 
	"programlamaya başlangıc için temel kurs",
	"java", "C#" };

for (int i = 0; i<kurslar.Length; i++)
{
	Console.WriteLine(kurslar[i]);
}

Console.WriteLine("for bitti");


// diğer döngü yöntemi (kursları tek tek dolaş)
foreach (string kurs in kurslar)
{
	Console.WriteLine(kurs);
}


Console.WriteLine("sayfa sonu");