namespace TheCryptographer;

public interface ICoder
{
    public string Encode(string text);
    public string Decode(string text);
}
