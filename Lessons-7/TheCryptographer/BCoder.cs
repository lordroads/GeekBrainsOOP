namespace TheCryptographer;

public class BCoder : ICoder
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
                int indexCharInAlphavite;
                int newIndexChar = 0;
                //RU or ENG?
                if (numberChar > 1000)
                {
                    //RU
                    if (char.IsUpper(c))
                    {
                        //Upper
                        if (numberChar == 1025)
                        {
                            newIndexChar = 1072 - 7;
                        }
                        else
                        {
                            indexCharInAlphavite = numberChar - 1039;
                            
                            if (indexCharInAlphavite == 26)
                            {
                                newIndexChar = 1025;
                            }
                            else if (indexCharInAlphavite > 26)
                            {
                                newIndexChar = 1072 - indexCharInAlphavite;
                            }
                            else if (indexCharInAlphavite >= 7)
                            {
                                newIndexChar = 1072 - indexCharInAlphavite - 1;
                            }
                            else
                            {
                                newIndexChar = 1072 - indexCharInAlphavite;
                            }
                        }
                    }
                    else
                    {
                        //Lower
                        if (numberChar == 1105)
                        {
                            newIndexChar = 1104 - 7;
                        }
                        else
                        {
                            indexCharInAlphavite = numberChar - 1071;

                            if (indexCharInAlphavite == 26)
                            {
                                newIndexChar = 1105;
                            }
                            else if (indexCharInAlphavite > 26)
                            {
                                newIndexChar = 1104 - indexCharInAlphavite;
                            }
                            else if (indexCharInAlphavite >= 7)
                            {
                                newIndexChar = 1104 - indexCharInAlphavite - 1; 
                            }
                            else
                            {
                                newIndexChar = 1104 - indexCharInAlphavite;
                            }
                        }
                    }
                }
                else
                {
                    //ENG
                    if (char.IsUpper(c))
                    {
                        //Upper
                        indexCharInAlphavite = numberChar - 64;

                        newIndexChar = 91 - indexCharInAlphavite;
                    }
                    else
                    {
                        //Lower
                        indexCharInAlphavite = numberChar - 96;

                        newIndexChar = 123 - indexCharInAlphavite;
                    }
                }
                result += Convert.ToChar(newIndexChar);
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
                int indexCharInAlphavite;
                int newIndexChar = 0;
                //RU or ENG?
                if (numberChar > 1000)
                {
                    //RU
                    if (char.IsUpper(c))
                    {
                        //Upper
                        if (numberChar == 1025)
                        {
                            newIndexChar = 1072 - 7;
                        }
                        else
                        {
                            indexCharInAlphavite = numberChar - 1039;

                            if (indexCharInAlphavite == 26)
                            {
                                newIndexChar = 1025;
                            }
                            else if (indexCharInAlphavite > 26)
                            {
                                newIndexChar = 1072 - indexCharInAlphavite;
                            }
                            else if (indexCharInAlphavite >= 7)
                            {
                                newIndexChar = 1072 - indexCharInAlphavite - 1;
                            }
                            else
                            {
                                newIndexChar = 1072 - indexCharInAlphavite;
                            }
                        }
                    }
                    else
                    {
                        //Lower
                        if (numberChar == 1105)
                        {
                            newIndexChar = 1104 - 7;
                        }
                        else
                        {
                            indexCharInAlphavite = numberChar - 1071;

                            if (indexCharInAlphavite == 26)
                            {
                                newIndexChar = 1105;
                            }
                            else if (indexCharInAlphavite > 26)
                            {
                                newIndexChar = 1104 - indexCharInAlphavite;
                            }
                            else if (indexCharInAlphavite >= 7)
                            {
                                newIndexChar = 1104 - indexCharInAlphavite - 1;
                            }
                            else
                            {
                                newIndexChar = 1104 - indexCharInAlphavite;
                            }
                        }
                    }
                }
                else
                {
                    //ENG
                    if (char.IsUpper(c))
                    {
                        //Upper
                        indexCharInAlphavite = numberChar - 64;

                        newIndexChar = 91 - indexCharInAlphavite;
                    }
                    else
                    {
                        //Lower
                        indexCharInAlphavite = numberChar - 96;

                        newIndexChar = 123 - indexCharInAlphavite;
                    }
                }
                result += Convert.ToChar(newIndexChar);
            }
            else
            {
                result += c;
            }
        }

        return result;
    }
}
