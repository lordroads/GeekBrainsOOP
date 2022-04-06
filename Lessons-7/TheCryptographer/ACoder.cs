namespace TheCryptographer;

public class ACoder : ICoder
{
    string exceptionSymbols = " !\"#$%&'()*+,\\-./:;<=>?@[]^_`{|}\n";

    public string Encode(string text)
    {
        string result = string.Empty;
        
        foreach (char c in text)
        {
            if (!exceptionSymbols.Contains(c))
            {
                int numberChar = Convert.ToInt32(c);
                if (numberChar == 1071)
                {
                    numberChar = 1039;
                }
                else if (numberChar == 1103)
                {
                    numberChar = 1071;
                }
                else if (numberChar == 1045)
                {
                    numberChar = 1024;
                }
                else if (numberChar == 1025)
                {
                    numberChar = 1045;
                }
                else if (numberChar == 1077)
                {
                    numberChar = 1104;
                }
                else if (numberChar == 1105)
                {
                    numberChar = 1077;
                }
                else if (numberChar == 90)
                {
                    numberChar = 64;
                }
                else if (numberChar == 122)
                {
                    numberChar = 96;
                }
                int newNumberChar = numberChar + 1;
                result += Convert.ToChar(newNumberChar);
            }
            else
            {
                result += c;
            }            
        }
        return result;
    }

    public string Decode(string text)
    {
        string result = string.Empty;

        foreach (char c in text)
        {
            if (!exceptionSymbols.Contains(c))
            {
                int numberChar = Convert.ToInt32(c);
                if (numberChar == 1040)
                {
                    numberChar = 1072;
                }
                else if (numberChar == 1072)
                {
                    numberChar = 1104;
                }
                else if (numberChar == 1046)
                {
                    numberChar = 1026;
                }
                else if (numberChar == 1025)
                {
                    numberChar = 1046;
                }
                else if (numberChar == 1078)
                {
                    numberChar = 1106;
                }
                else if (numberChar == 1105)
                {
                    numberChar = 1078;
                }
                else if (numberChar == 65)
                {
                    numberChar = 91;
                }
                else if (numberChar == 97)
                {
                    numberChar = 123;
                }
                int newNumberChar = numberChar - 1;
                result += Convert.ToChar(newNumberChar);
            }
            else
            {
                result += c;
            }
        }
        return result;
    }
}
