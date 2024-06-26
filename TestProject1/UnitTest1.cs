using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace generator;

[TestClass]
public class UnitTest1 {

    [TestMethod]
    public void TestMethod1() {
        CharGenerator generator = new CharGenerator();
        char symbol = generator.getSym();
        Assert.IsNotNull(symbol);
    }


    [TestMethod]
    public void TestMethod2() {
        string[] words = { "a", "b", "c", "d" };
        double[] values = { 0, 0.3, 0.6, 0 };
        generator.TextGenerator generator = new TextGenerator(words, values);
        string sym = generator.GetSym();
        Assert.IsTrue(sym == "b" || sym == "c");
    }
    [TestMethod]
    public void TestMethod3() {
        TextGenerator generator = new TextGenerator();
        generator.LoadFromFile("../../../../ProjCharGenerator/data1.txt");
        string sym = generator.GetSym();
        Assert.IsTrue(sym != null);
    }

    [TestMethod]
    public void TestMethod4() {
        TextGenerator generator = new TextGenerator();
        generator.LoadFromFile("../../../../ProjCharGenerator/data1.txt");
        Assert.IsTrue(generator.GetSym() != null);
    }

    [TestMethod]
    public void TestMethod5() {
        TextGenerator generator = new TextGenerator();
        generator.LoadFromFile("../../../../ProjCharGenerator/data1.txt");
        Assert.IsNotNull(generator);
    }

    [TestMethod]
    public void TestMethod6() {
        string[] words = { "apple", "banana", "cherry" };
        double[] values = { 0.1, 0.3, 0.6 };
        TextGenerator generator = new TextGenerator(words, values);
        Assert.IsNotNull(generator);
    }
}