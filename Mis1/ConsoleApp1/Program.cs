//1 
/* byte a = 12;
int  p = 4;
Console.WriteLine(a + p);
//2

byte p1 = 2;
object a1 = Math.Pow(p1,2);
Console.WriteLine(a1);
//3

byte A = 31;
byte B = 32;
int S = A * B;
int P = 2 * (A + B);
Console.WriteLine(S);
Console.WriteLine(P);
//4

byte d = 12;
double l = Math.PI * d;
Console.WriteLine(l);
//5
     
byte a = 21;
double v = Math.Pow(a, 3);
double  s = 6 * Math.Pow(a, 3);
Console.WriteLine(s);
Console.WriteLine(v);
using System;
//6

byte a = 22;
byte b = 24;
byte c = 34;

double V = a * b * c;
double S = 2 * (a * b + b * c + a * c);

Console.WriteLine(V);
Console.WriteLine(S);
//7

byte r = 123;
byte l = 12;
byte s = 123;

double L = 2 * Math.PI * r ;
double S = Math.PI * Math.Pow(r, 2);
Console.WriteLine(S);
Console.WriteLine(l);
//8

 byte a = 12;
 byte b = 11;
 int c = (a+b)/2;
 Console.WriteLine(c);
 //9
 
 byte a = 43;
 byte b = 32;
 double c = Math.Sqrt(a*b);
 Console.WriteLine(c);
 //10
 byte a = 32;
 byte b = 34;

 int a2 = a * a;
 int b2 = b * b;

 Console.WriteLine(a2 + b2);
 Console.WriteLine(a2 - b2);
 Console.WriteLine(a2 * b2);
 Console.WriteLine(a2 / b2);
 //11
 
 byte a = 23;
 byte b = 44;

 double A = Math.Abs(a);
 double B = Math.Abs(b);

 Console.WriteLine(A + B);
 Console.WriteLine(A - B);
 Console.WriteLine(A * B);
 Console.WriteLine(A / B);
 //12
 byte a = 35;
 byte b = 44;

 double c = Math.Sqrt(Math.Pow(a , 2) + Math.Pow(b , 2));
 double P = a + b + c;

 Console.WriteLine(c);
 Console.WriteLine(P);
//13 

byte R1 = 33;
byte R2 = 42 ;

double S1 = Math.PI * Math.Pow(R1 , 2);
double S2 = Math.PI * Math.Pow(R2,2);
double S3 = S1 - S2;

Console.WriteLine(S1);
Console.WriteLine(S2);
Console.WriteLine(S3);
//14

byte L = 23;

double pi = Math.PI;
double R = L / (2 * pi);
double S = pi * R * R;

Console.WriteLine(R);
Console.WriteLine(S);
//15

byte S = 23;

double pi = Math.PI;
double R = Math.Sqrt(S / pi);
double D = 2 * R;
double L = 2 * pi * R;

Console.WriteLine(D);
Console.WriteLine(L);
//16

byte  x1 = 113;
byte  x2 = 23;
double a = (x1 - x2);
Console.WriteLine( a );
//17

byte A = 23;
byte B = 24;
byte C = 25;
double F1 = Math.Abs(A-B);
double F2 = Math.Abs(B-C);
Console.WriteLine(F1+F2);
//18

byte A = 128;
byte B = 133;
byte C = 134;
double f1 = Math.Abs(C-A);
double f2 = Math.Abs(B-C);
Console.WriteLine(f1*f2);
//19

byte x1 = 65;
byte x2 = 66;
byte y1 = 45;
byte y2 = 44;
int A = Math.Abs(x2 - x1);
int B = Math.Abs(y2 - y1);
int p = 2 * (A + B);
int s = A * B;
Console.WriteLine(p);
Console.WriteLine(s);
//20

byte x1 = 65;
byte x2 = 66;
byte y1 = 45;
byte y2 = 44;

double a = Math.Sqrt( (x2 - x1 ) ^ 2 + (y2 - y1) ^ 2 );

Console.WriteLine(a);
//21

byte x1 = 65;
byte x2 = 66;
byte x3 = 67;
byte y1 = 45;
byte y2 = 44;
byte y3 = 46;

int A = x1 - y1;
int B = x2 - y2;
int C = x3 - y3;

int p  = A + B + C;
double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
Console.WriteLine(S);
//22

byte A = 10;
byte B = 20;

byte C = A;
A = B;
B = C;

Console.WriteLine(A);
Console.WriteLine(B);
//23

byte A = 23;
byte B = 45;
byte C = 32;

byte f = A;
A = B;
B = C;
C = f;

Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(C)
//24

int A = 1;
int B = 2;
int C = 3;

int x = A;
A = C;
C = B;
B = x;

Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(C);
//25

byte x =134;
double y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;
Console.WriteLine(y);
//26

byte x =134;
double y = 4 * ( x - 3 ) ^ 6 - 7 * (x-3) ^ 3 + 2 ;
Console.WriteLine(y);
//27

byte A = 12;

double A2 = A * A;
double A4 = A2 * A2;
double A8 = A4 * A4;

Console.WriteLine(A2);
Console.WriteLine(A4);
Console.WriteLine(A8);
//28
byte A = 21;

double A2 = A * A;
double A3 = A2 * A;
double A5 = A3 * A2;
double A10 = A5 * A5;
double A15 = A10 * A5;

Console.WriteLine(A2);
Console.WriteLine(A3);
Console.WriteLine(A5);
Console.WriteLine(A10);
Console.WriteLine(A15);
//29

byte a = 12;

double p = Math.PI;
double c = a * p / 180;

Console.WriteLine(c);
//30

byte a = 34;

double c = a * 180 / Math.PI;

Console.WriteLine(c);
//31

byte Tf = 23;
int Tc = (Tf-32)* 5 / 9 ;
Console.WriteLine(Tc);
//32

byte Tc = 23;
int Tf = Tc * 9 / 5 + 32 ;
Console.WriteLine(Tc);
//33

byte X = 100;
byte A = 10;
byte Y = 30;

int F1 = X / A;
int f2 = A * Y / X;

Console.WriteLine(F1);
Console.WriteLine(f2);
//34

double X = 20;
double A = 35;
double Y = 25;
double B = 15;

double F1 = A / X;
double F2 = B / Y;
double F3 = F1 / F2;

Console.WriteLine(F1);
Console.WriteLine(F2);
Console.WriteLine(F3);
//35

byte V = 50;
byte U = 35;
byte T1 = 10;
byte T2 = 33;

double S = V * T1 + (V - U)*T2;

Console.WriteLine(S);
//36


byte V1 = 5;
byte V2 = 5;
byte T = 5;

byte s = 2;

int S1 = V1 * T;
int S2 = V1 * T;
int S3 = S1 + S2 + s;
Console.WriteLine(S3);
//37

byte V1 = 15;
byte V2 = 10;
byte T = 6;

byte S = 200;

int S1 = V1 * T;
int S2 = V2 * T;
int S3 = S - S1 - S2;

Console.WriteLine(S3);
//38

byte A = 150;
byte B = 15;

int X = - A / B;

Console.WriteLine(X);
//39


byte A = 53;
byte B = 33;
byte C = 45;


double D = Math.Pow(B,2) + 4 * A * C;
double X = (- B + Math.Sqrt(D)) / (2 * A);

double F1 = (A * Math.Pow(X,2) + B * X + C );
Console.WriteLine(F1);*/
//40 

byte A1 = 10;
byte B1 = 25;
byte C1 = 10;
byte A2 = 5;
byte B2 = 15;
byte C2 = 20;

int D = A1 * B2 - A2 * B1;

int x = (C1 * B2 - C2 * B1) / D;
int y = (A1 * C2 - A2 * C1) / D;

Console.WriteLine(x);
Console.WriteLine(y);






