// See https://aka.ms/new-console-template for more information

string mygreating = "Mans vārds ir Andris";
string mygreeting1 = "es mācos C#";
string mygreating2 = "Mans vecums ir";
string mygreeting3 = "51";
int age = 60;
int age1 = 51;
char komats = ',';
Char punkts = '.';
Char atstarpe = ' ';
Double pi = 3.314;
char favoriteSymbol = '@';
bool isMale = true;

    ;
string atdalošāsvītra = "-------------------------------";

Console.WriteLine(mygreating);
Console.WriteLine(mygreeting1);
Console.WriteLine($"{age},{mygreeting3}");
Console.WriteLine(pi);
Console.WriteLine(favoriteSymbol);
Console.WriteLine(isMale);


Console.WriteLine(atdalošāsvītra);
Console.WriteLine();

double a = 10;
double b = 35;
double sum = a + b;
double differnce = b - a;
double multiplication = a * b;
double divided = b / a;

int c = 5;
int d = 2;

int sum1 = c + d;
int difference1 = c - d;
int muliplication1 = c * d;
double divided1 = c / (double)d;

Console.WriteLine("pareizi jāeraksta int sum a+b, kāpēc");
Console.WriteLine(sum);
//Console.WriteLine(a + b);
//Console.WriteLine(a - b);
//Console.WriteLine(b - a);
Console.WriteLine(differnce);
Console.WriteLine(multiplication);
Console.WriteLine(divided);

Console.WriteLine($"{divided1} , {difference1} , {muliplication1} , {(double)a / b}");


Console.WriteLine();
Console.WriteLine(atdalošāsvītra);
Console.WriteLine();

int divisionLeft = c % d;
int divided2 = c / d;
Console.WriteLine(divided2);
Console.WriteLine("dalījums");
Console.WriteLine(divisionLeft);
Console.WriteLine("atlikums");
// 1) 5 / 2 = 2,5
// 2) 2 * 2 = 4
// 3) 5 - 4 = 1(atbilde) ja vēlas precīzu dalījumu aiz komata, tad jāeksperimentē ar double


Console.WriteLine();
Console.WriteLine(atdalošāsvītra);
Console.WriteLine();

c++;
d--;

Console.WriteLine(c);
Console.WriteLine(d);

Console.WriteLine();
Console.WriteLine(atdalošāsvītra);
Console.WriteLine();

int num1 = 10;
int num2 = 15;  

bool isEqual = num1 == num2;
bool isnotEqual = num2 != num1;  
bool isLarger = (num1 > num2);
bool isSmaller = (num1 < num2);
bool isLargerEqual = (num1 >= num2);
bool isSmallerEqual = (num1 <= num2);

Console.WriteLine(isEqual);
Console.WriteLine(isnotEqual);
Console.WriteLine(isLarger);
Console.WriteLine(isSmaller);
Console.WriteLine(isLargerEqual);
Console.WriteLine(isSmallerEqual);

Console.WriteLine();
Console.WriteLine(atdalošāsvītra);
Console.WriteLine();

bool isTrue = true;
bool isFalse = false;

bool andAction = isTrue && isFalse;  //ir patiess, ja abi ir true
bool orAction = isTrue || isFalse;    //ir patiess, ja kaut viens ir true
bool convertedTrue = !isTrue;            //apvērš mainīgā vērtību uz pretējo
bool convertedTrue1 = !isFalse;

Console.WriteLine(andAction);
Console.WriteLine(orAction);
Console.WriteLine(convertedTrue);
Console.WriteLine(convertedTrue1);

Console.WriteLine();
Console.WriteLine(atdalošāsvītra);
Console.WriteLine();

int x = 4;

x += 2;     //x = x + 2
Console.WriteLine(x);

x -= 3;     // x = x - 2
Console.WriteLine(x);

x *= 3;
Console.WriteLine(x);
x /= 3;
Console.WriteLine(x);

Console.WriteLine();
Console.WriteLine(atdalošāsvītra);
Console.WriteLine();

//// Dabut input no lietotāja

//// 1. Paprasam lietotājam ievadīt viņavārdu
//Console.WriteLine("Lūdzu ievadi savu vārdu ?");

//// 2. Sagaidam lietotāja ievadi 
//string userName = Console.ReadLine();

//// 3. Sasveicinamies ar lietotāju izmantojot viņa vārdu paterns: "Sveiks: {vārds}"
//Console.WriteLine("Sveiks: " + userName);

//// Skaitļa ievade

//Console.WriteLine("Lūdzu ievadi skaitli ?");

//string userNumberString = Console.ReadLine();
//int userNumber = int.Parse(userNumberString);

//int byThenLarger = userNumber + 10;

//Console.WriteLine("Tavs skaitlis palielināts par 10: " + byThenLarger);

int positiveNumber = 15;
int negativeNumber = -15;

int positiveAbs = Math.Abs(positiveNumber);
int negativeAbs = Math.Abs(negativeNumber);

Console.WriteLine("Default negative: " + negativeNumber);
Console.WriteLine(positiveAbs);
Console.WriteLine(negativeAbs);

int maxNumberHigh = 40;
int maxNumberLow = 29;

int largerNumber = Math.Max(maxNumberHigh, maxNumberLow);
Console.WriteLine("Larger number: " + largerNumber);

int maxNumberHigh = 40;
int maxNumberLow = 29;

int largerNumber = Math.Max(maxNumberHigh, maxNumberLow);



