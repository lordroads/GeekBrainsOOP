using TheCryptographer;
using Xunit;

namespace TheCriptographerTests;

public class ACoderTests
{
    [Fact]
    public void PunctuationEncodeTest()
    {
        string punctuation = " !.,\\\";%:?*()_+=-/";
        ACoder coder = new ACoder();
        Assert.Equal(punctuation, coder.Encode(punctuation));
    }
    [Fact]
    public void AlphaviteRuEncodeTest()
    {
        string incoming = "ÀÁÂÃÄÅ¨ÆÇÈÉÊËÌÍÎÏĞÑÒÓÔÕÖ×ØÙÚÛÜİŞß  àáâãäå¸æçèéêëìíîïğñòóôõö÷øùúûüışÿ";
        string expected = "ÁÂÃÄÅ¨ÆÇÈÉÊËÌÍÎÏĞÑÒÓÔÕÖ×ØÙÚÛÜİŞßÀ  áâãäå¸æçèéêëìíîïğñòóôõö÷øùúûüışÿà";
        ACoder coder = new ACoder();
        Assert.Equal(expected, coder.Encode(incoming));
    }
    [Fact]
    public void AlphaviteEngEncodeTest()
    {
        string incoming = "ABCDEFGHIJKLMNOPQRSTUVWXYZ  abcdefghijklmnopqrstuvwxyz";
        string expected = "BCDEFGHIJKLMNOPQRSTUVWXYZA  bcdefghijklmnopqrstuvwxyza";
        ACoder coder = new ACoder();
        Assert.Equal(expected, coder.Encode(incoming));
    }
    [Fact]
    public void TextRuEncodeTest()
    {
        string incoming = "Ïğèâåò, ìèğ!";
        string expected = "Ğñéã¸ó, íéñ!";
        ACoder coder = new ACoder();
        Assert.Equal(expected, coder.Encode(incoming));
    }
    [Fact]
    public void TextEngEncodeTest()
    {
        string incoming = "Hellow World!";
        string expected = "Ifmmpx Xpsme!";
        ACoder coder = new ACoder();
        Assert.Equal(expected, coder.Encode(incoming));
    }
    [Fact]
    public void PunctuationDecodeTest()
    {
        string punctuation = " !.,\\\";%:?*()_+=-/";
        ACoder coder = new ACoder();
        Assert.Equal(punctuation, coder.Decode(punctuation));
    }
    [Fact]
    public void AlphaviteRuDecodeTest()
    {
        string incoming = "ÁÂÃÄÅ¨ÆÇÈÉÊËÌÍÎÏĞÑÒÓÔÕÖ×ØÙÚÛÜİŞßÀ  áâãäå¸æçèéêëìíîïğñòóôõö÷øùúûüışÿà";
        string expected = "ÀÁÂÃÄÅ¨ÆÇÈÉÊËÌÍÎÏĞÑÒÓÔÕÖ×ØÙÚÛÜİŞß  àáâãäå¸æçèéêëìíîïğñòóôõö÷øùúûüışÿ";
        ACoder coder = new ACoder();
        Assert.Equal(expected, coder.Decode(incoming));
    }
    [Fact]
    public void AlphaviteEngDecodeTest()
    {
        string incoming = "BCDEFGHIJKLMNOPQRSTUVWXYZA  bcdefghijklmnopqrstuvwxyza";
        string expected = "ABCDEFGHIJKLMNOPQRSTUVWXYZ  abcdefghijklmnopqrstuvwxyz";
        ACoder coder = new ACoder();
        Assert.Equal(expected, coder.Decode(incoming));
    }
    [Fact]
    public void TextRuDecodeTest()
    {
        string incoming = "Ğñéã¸ó, íéñ!";
        string expected = "Ïğèâåò, ìèğ!";
        ACoder coder = new ACoder();
        Assert.Equal(expected, coder.Decode(incoming));
    }
    [Fact]
    public void TextEngDecodeTest()
    {
        string incoming = "Ifmmpx Xpsme!";
        string expected = "Hellow World!";
        ACoder coder = new ACoder();
        Assert.Equal(expected, coder.Decode(incoming));
    }
}
