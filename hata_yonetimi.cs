try
{
    Console.WriteLine("bir sayı giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("girmiş olduğunuz sayı:" + sayi);
}
catch(Exception ex)
{
    Console.WriteLine("Hata: " + ex.Message.ToString());
}
 finally{
     Console.WriteLine("İşlem tamamlandı.");
  }

try
{
    int a = int.Parse("test");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girdiniz");
    Console.WriteLine(ex);
}
catch(FormatException ex)
{
    Console.WriteLine("Veri tipi uygun değil");
    Console.WriteLine(ex);
}