using TheCryptographer;

string incomingText = "Lorem Ipsum - это текст-\"рыба\",\nчасто используемый в печати и вэб-дизайне.\nLorem Ipsum является стандартной \"рыбой\"\nдля текстов на латинице с начала XVI века.";
Criptograf criptografACoder = new Criptograf(new ACoder());
Criptograf criptografBCoder = new Criptograf(new BCoder());

string encodeA = criptografACoder.GenerateCripto(incomingText);
string encodeB = criptografBCoder.GenerateCripto(incomingText);
Console.WriteLine($"ENCODE A - {encodeA}");
Console.WriteLine($"ENCODE B - {encodeB}");
Console.WriteLine();
Console.WriteLine($"DECODE A - {criptografACoder.GenerateString(encodeA)}");
Console.WriteLine($"DECODE B - {criptografBCoder.GenerateString(encodeB)}");
