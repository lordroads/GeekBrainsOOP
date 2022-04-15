//Организация тестирования
string[] textIncoming = new[]
{
    "qwerty",
    "",
    "Hello World",
    "1234567890"
};
string[] expectedResult = new[]
{
    "ytrewq",
    "",
    "dlroW olleH",
    "0987654321"
};

//Действие тестирования
for (int i = 0; i < textIncoming.Length; i++)
{
    string resultTest = expectedResult[i] == ReversalString(textIncoming[i]) ? "пройден." : "не пройден."; //Утверждение тестирования
    Console.WriteLine($"{i + 1}: Тест {resultTest}");
}

string ReversalString(string text)
{
    string result = string.Empty;

    for (int i = text.Length; i > 0; i--)
    {
        result += text[i - 1];
    }

    return result;
}