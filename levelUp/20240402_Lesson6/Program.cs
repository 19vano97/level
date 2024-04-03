// See https://aka.ms/new-console-template for more information
//10
byte a = 10;
byte b = 20;

System.Console.WriteLine("10: A: {0} ({0:X} - 16sys) ({2}) - binary, B: {1} ({1:X} - 16sys) ({3}) - binary", a, b, Convert.ToString(a, 2), Convert.ToString(b, 2));

//16
byte c = 0x0A;
byte d = 0x20;

System.Console.WriteLine("16: C: {0} ({0:X} - 16sys), D: {1} ({1:X} - 16sys)", c, d);
//binary

// byte e = 0b00001111;
// byte f = 0b10101010;

int e = 225;
int f = 67;


System.Console.WriteLine("2: E: {0} ({0:X} - 16sys), F: {1} ({1:X} - 16sys)", e, f);


//& multiply
System.Console.WriteLine("AND");
byte res = (byte)(e & f);
System.Console.WriteLine("      e: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(e, 2), e);
System.Console.WriteLine("      f: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(f, 2), f);
System.Console.WriteLine("  e & f: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(res, 2), res);

System.Console.WriteLine();

System.Console.WriteLine("OR");
//OR | sum
byte res1 = (byte)(e ^ f);
System.Console.WriteLine("      e: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(e, 2), e);
System.Console.WriteLine("      f: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(f, 2), f);
System.Console.WriteLine("  e ^ f: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(res1, 2), res1);

System.Console.WriteLine();

int mask = 0x3BCDEF3A;

System.Console.WriteLine("enter pin: ");

int pin = int.Parse(Console.ReadLine());

int pin_ = pin ^ mask;

System.Console.WriteLine("pin1: {0}", pin);
System.Console.WriteLine("pin_: {0}", pin_);

int pin2 = pin_ ^ mask;
System.Console.WriteLine("pin2: {0}", pin2);

System.Console.WriteLine("      pin: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(pin, 2), pin);
System.Console.WriteLine("      mask: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(mask, 2), mask);
System.Console.WriteLine("      pin_: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(pin_, 2), pin_);
System.Console.WriteLine("      pin2: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(pin2, 2), pin2);

//~ inversion
int r = 123;
int r1 = ~r;

System.Console.WriteLine();
System.Console.WriteLine("~");

System.Console.WriteLine("      r_: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(r, 2), r);
System.Console.WriteLine("      r1: [{0,8}], ({1,2:X} - 16os), {1, 3}", Convert.ToString(r1, 2), r1);