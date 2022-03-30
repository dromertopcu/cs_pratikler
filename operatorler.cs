// Atama ve işlemli atama

int x = 3;
int y = 43;

y= y+2;
y+=2;

y/=1;

x*=2;

Console.WriteLine(y);


//Mantıksal Operatörler
// ||, &&, !

bool isSuccess = true;
bool isCompleted = false;

if(isSuccess && isCompleted)
    Console.WriteLine("great");

if(isSuccess || isCompleted)
    Console.WriteLine("uww");

int a = 3;
int b= 4;
bool sonuc = a<b;

Console.WriteLine(sonuc);


