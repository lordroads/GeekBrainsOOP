using Arithmetic;

Complex complex = new Complex(1, 2);
Complex complex2 = new Complex(2, 5);
Complex complex3 = complex + complex2;
Complex complex4 = complex * complex;
Complex complex5 = complex2 - complex;
bool test = complex3.Equals(complex4);
bool test2 = complex2 == complex4;

Console.WriteLine(complex5.ToString());