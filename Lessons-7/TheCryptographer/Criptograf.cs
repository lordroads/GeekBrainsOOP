using TheCryptographer;

public class Criptograf
{
    private ICoder _coder;
    public Criptograf(ICoder coder)
    {
        _coder = coder;
    }
    public string GenerateCripto(string text)
    {
        return _coder.Encode(text);
    }
    public string GenerateString(string text)
    {
        return _coder.Decode(text);
    }
}