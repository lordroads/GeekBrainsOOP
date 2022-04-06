using TheCryptographer;
using Xunit;


namespace TheCriptographerTests;

public class BCoderTests
{
    [Fact]
    public void PunctuationEncodeTest()
    {
        string punctuation = " !.,\\\";%:?*()_+=-/";
        BCoder coder = new BCoder();
        Assert.Equal(punctuation, coder.Encode(punctuation));
    }
    [Fact]
    public void AlphaviteRuEncodeTest()
    {
        string incoming = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ  абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string expected = "ЯЮЭЬЫЪЩШЧЦХФУТСРПОНМЛКЙИЗЖЁЕДГВБА  яюэьыъщшчцхфутсрпонмлкйизжёедгвба";
        BCoder coder = new BCoder();
        Assert.Equal(expected, coder.Encode(incoming));
    }
    [Fact]
    public void AlphaviteEngEncodeTest()
    {
        string incoming = "ABCDEFGHIJKLMNOPQRSTUVWXYZ  abcdefghijklmnopqrstuvwxyz";
        string expected = "ZYXWVUTSRQPONMLKJIHGFEDCBA  zyxwvutsrqponmlkjihgfedcba";
        BCoder coder = new BCoder();
        Assert.Equal(expected, coder.Encode(incoming));
    }
    [Fact]
    public void TextRuEncodeTest()
    {
        string incoming = "Привет, мир!";
        string expected = "Поцэъм, тцо!";
        BCoder coder = new BCoder();
        Assert.Equal(expected, coder.Encode(incoming));
    }
    [Fact]
    public void TextEngEncodeTest()
    {
        string incoming = "Hellow World!";
        string expected = "Svoold Dliow!";
        BCoder coder = new BCoder();
        Assert.Equal(expected, coder.Encode(incoming));
    }
    [Fact]
    public void PunctuationDecodeTest()
    {
        string punctuation = " !.,\\\";%:?*()_+=-/";
        BCoder coder = new BCoder();
        Assert.Equal(punctuation, coder.Decode(punctuation));
    }
    [Fact]
    public void AlphaviteRuDecodeTest()
    {
        string incoming = "ЯЮЭЬЫЪЩШЧЦХФУТСРПОНМЛКЙИЗЖЁЕДГВБА  яюэьыъщшчцхфутсрпонмлкйизжёедгвба";
        string expected = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ  абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        BCoder coder = new BCoder();
        Assert.Equal(expected, coder.Decode(incoming));
    }
    [Fact]
    public void AlphaviteEngDecodeTest()
    {
        string incoming = "ZYXWVUTSRQPONMLKJIHGFEDCBA  zyxwvutsrqponmlkjihgfedcba";
        string expected = "ABCDEFGHIJKLMNOPQRSTUVWXYZ  abcdefghijklmnopqrstuvwxyz";
        BCoder coder = new BCoder();
        Assert.Equal(expected, coder.Decode(incoming));
    }
    [Fact]
    public void TextRuDecodeTest()
    {
        string incoming = "Поцэъм, тцо!";
        string expected = "Привет, мир!";
        BCoder coder = new BCoder();
        Assert.Equal(expected, coder.Decode(incoming));
    }
    [Fact]
    public void TextEngDecodeTest()
    {
        string incoming = "Svoold Dliow!";
        string expected = "Hellow World!";
        BCoder coder = new BCoder();
        Assert.Equal(expected, coder.Decode(incoming));
    }
}
