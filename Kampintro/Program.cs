// See https://aka.ms/new-console-template for more information


	// type safety
	// Bu durumda sürekli tekrar etmek gerekiyor buna gerek yok
	// Do not repeat yourself - kendini tekrarlama altta ki örnek buna aykırı 

	// Console.WriteLine("Kategori");
	
string kategoriEtiketi = "kategoriler ";

int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = false;
double dolarDun = 7.35;
double dolarBugun = 7.45;

if (dolarDun>dolarBugun)
{
	Console.WriteLine("azalış butonu");
}
else if (dolarDun<dolarBugun)
{
	Console.WriteLine("artış butonu");
}
else
{
	Console.WriteLine("değişmedi butonu");
}

if (sistemeGirisYapmisMi == true)
{
	Console.WriteLine("Ayarlar butonu");
}
else
{
	Console.WriteLine("Giriş yap butonu");
}


Console.WriteLine(kategoriEtiketi);


