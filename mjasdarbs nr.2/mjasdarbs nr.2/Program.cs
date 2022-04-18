//See https;//aka.ms/new-console-template for more information

Console.WriteLine("1. uzdevums: Izveidot konsoles aplikāciju, kas pavaicā un  iegūst lietotāja vārdu, un sasveicinās ar konkrēto lietotāju + 2. uzdevums: Atrādīt lietotājam mazāko skaitli izmantojot Math. Min ");

Console.WriteLine("Kā Tevi sauc ?");
string userName = Console.ReadLine();
Console.WriteLine("Sveiks: " + userName);


Console.WriteLine("Kāds ir Tavs vecums ?");
string age = Console.ReadLine();
int ageUser = int.Parse(age);
int byOneLarger = ageUser + 1;
bool adultTrue = byOneLarger >= 18;
bool adultFalse = ageUser >= 18;
bool adult = adultTrue && adultFalse;

Console.WriteLine("Nākamgad Tev paliks: " + byOneLarger + adult + ", Tu esi pilngadīgs.");


Console.WriteLine("3. uzdevums Atrādīt lietotājam lielāko skaitli izmantojot Math. Max ");

Console.WriteLine("Ievadiet pirmo skaitli");
string firstNumber = Console.ReadLine();
int firstUserNumber = int.Parse(firstNumber);
Console.WriteLine("Ievadiet otro skaitli");
string secondNumber = Console.ReadLine();
int secondUserNumber = int.Parse(secondNumber);
int largerNumber = Math.Max(firstUserNumber, secondUserNumber);
Console.WriteLine("Lielākais no Jūsu ievadītajiem skaitļiem ir: " + largerNumber);

Console.WriteLine("4. uzdevums: Atrādīt lietotājam mazāko skaitli izmantojot Math.Min");

Console.WriteLine("Ievadiet pirmo skaitli");
string firstNumber1 = Console.ReadLine();
int firstUserNumber1 = int.Parse(firstNumber1);
Console.WriteLine("Ievadiet otro skaitli");
string secondNumber1 = Console.ReadLine();
int secondUserNumber1 = int.Parse(secondNumber1);
int smallerNumber = Math.Min(firstUserNumber, secondUserNumber);
Console.WriteLine("Mazākais no Jūsu ievadītajiem skaitļiem ir: " + smallerNumber);

Console.WriteLine("5.uzdevums: Iegūt skaitļu dalījuma atlikumu izmantojot - %");

Console.WriteLine("Ievadiet dalāmo skaitli");
string dalāmais = Console.ReadLine();
int dalāmaisUser = int.Parse(dalāmais);
Console.WriteLine("Ievadiet dalītāju");
string dalītāju = Console.ReadLine();
int dalītājsUser = int.Parse(dalītāju);
int dalījums = dalāmaisUser / dalītājsUser;
int atlikums = dalāmaisUser % dalītājsUser;

Console.WriteLine("Dalījuma atlikums ir :" + atlikums);

Console.WriteLine("6. uzdevums: Parādīt vai lietotājs ievadījis pāra vai nepāra skaitli");

Console.WriteLine("Ievadiet skaitli");
string num = Console.ReadLine();
int numUser = int.Parse(num);
int num1 = 2;
int divided = numUser / num1;
int divisionLeft = numUser % num1;
bool pāraSkaitlis = divisionLeft <= 0;
bool nepāraskaitlis = divisionLeft > 0;
bool vai = pāraSkaitlis || !nepāraskaitlis;

Console.WriteLine("Jūsu ievadītais skaitlis ir pāra skaitlis:  " + vai);


Console.WriteLine("7. uzdevums: Iegūt no lietotāja taisnstūra malu vērtības un aprēķināt taisnstūra laukumu ");

Console.WriteLine("Ievadiet taisnstūra agšējās malas garumu");
string mala1 = Console.ReadLine();
double mala1User = double.Parse(mala1);
Console.WriteLine("Ievadiet taisnstūra sānu malas garumu");
string mala2 = Console.ReadLine();
double mala2User = double.Parse(mala2);
double laukums = mala1User * mala2User;
double laukums2 = Math.Round(laukums, 2);

Console.WriteLine("Taisnstūra laukums ir: " + laukums2);
//Console.WriteLine(laukums);

Console.WriteLine("8.uzdevums: Iegūt no lietotāja skaitli, lai aprēķinātu taisnleņķa vienādsānu trijstūra laukumu ");

//Console.WriteLine("Ievadiet trijstūra pirmās katetes garumu");
//string katete1 = Console.ReadLine();
//double katete1User = double.Parse(katete1);
//Console.WriteLine("Ievadiet trijstūra otrās katetes garumu");
//string katete2 = Console.ReadLine();
//double katete2User = double.Parse(katete2);
//double laukums = katete1User * katete2User;
//double laukums2 = laukums / 2;

//Console.WriteLine("Taisleņķa trijstūra laukums ir:  " + laukums2);

Console.WriteLine("Ievadiet trijstūra malas garumu");
string katete = Console.ReadLine();
double kateteAbasUser = double.Parse(katete);
double laukumsv = kateteAbasUser * kateteAbasUser;
double laukumsv2 = laukumsv / 2;

Console.WriteLine("Vienādsānu trijstūra laukums ir:  " + laukumsv2);

Console.WriteLine("9. uzdevums: Iegūst lietotāja vecumu un izvada lietotājam vārdu un vecumu izmantojot interpolāciju");


Console.WriteLine("Kāds ir Tavs vārds ?");
string userName9 = Console.ReadLine();

Console.WriteLine("Kāds ir Tavs vecums ?");
string age9 = Console.ReadLine();
int ageUser9 = int.Parse(age9);

Console.WriteLine($"Sveiks, {userName9}, Tavs vecums ir {age9}. ");


