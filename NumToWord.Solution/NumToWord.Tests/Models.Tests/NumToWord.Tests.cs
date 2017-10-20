using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumToWord.Models;

namespace NumToWord.Tests
{
  [TestClass]
  public class ConvertTest
  {
    [TestMethod]
    public void NumberConvert_ConvertNumberIntoWords_String()
    {
      Translator newTranslator = new Translator("18");
      string result = "Eighteen";
      Assert.AreEqual(result, newTranslator.NumberConvert(newTranslator));
    }
    [TestMethod]
    public void TensConvert_ConvertTensIntoWords_String()
    {
      Translator newTranslator = new Translator("46");
      string result = "FortySix";
      Assert.AreEqual(result, newTranslator.NumberConvert(newTranslator));
    }
    [TestMethod]
    public void SuffixConvert_ConvertHundredsIntoWords_String()
    {
      Translator newTranslator = new Translator("253");
      string result = "TwoHundredFiftyThree";
      Assert.AreEqual(result, newTranslator.NumberConvert(newTranslator));
    }
    [TestMethod]
    public void SuffixConvert_ConvertThousandsIntoWords_String()
    {
      Translator newTranslator = new Translator("3227");
      string result = "ThreeThousandTwoHundredTwentySeven";
      Assert.AreEqual(result, newTranslator.NumberConvert(newTranslator));
    }
    [TestMethod]
    public void SuffixConvert_ConvertTenThousandsIntoWords_String()
    {
      Translator newTranslator = new Translator("30259");
      string result = "ThirtyThousandTwoHundredFiftyNine";
      Assert.AreEqual(result, newTranslator.NumberConvert(newTranslator));
    }
    [TestMethod]
    public void SuffixConvert_ConvertHundredThousandsIntoWords_String()
    {
      Translator newTranslator = new Translator("320238");
      string result = "ThreeHundredTwentyThousandTwoHundredThirtyEight";
      Assert.AreEqual(result, newTranslator.NumberConvert(newTranslator));
    }
    [TestMethod]
    public void SuffixConvert_ConvertMillionsIntoWords_String()
    {
      Translator newTranslator = new Translator("3000227");
      string result = "ThreeMillionTwoHundredTwentySeven";
      Assert.AreEqual(result, newTranslator.NumberConvert(newTranslator));
    }
    [TestMethod]
    public void SuffixConvert_ConvertTenMillionsIntoWords_String()
    {
      Translator newTranslator = new Translator("30000227");
      string result = "ThirtyMillionTwoHundredTwentySeven";
      Assert.AreEqual(result, newTranslator.NumberConvert(newTranslator));
    }
    [TestMethod]
    public void SuffixConvert_ConvertHundredMillionIntoWords_String()
    {
      Translator newTranslator = new Translator("300000227");
      string result = "ThreeHundredMillionTwoHundredTwentySeven";
      Assert.AreEqual(result, newTranslator.NumberConvert(newTranslator));
    }
    [TestMethod]
    public void SuffixConvert_ConvertBillionsIntoWords_String()
    {
      Translator newTranslator = new Translator("3000000227");
      string result = "ThreeBillionTwoHundredTwentySeven";
      Assert.AreEqual(result, newTranslator.NumberConvert(newTranslator));
    }
    [TestMethod]
    public void SuffixConvert_ConvertTenBillionsIntoWords_String()
    {
      Translator newTranslator = new Translator("30000000227");
      string result = "ThirtyBillionTwoHundredTwentySeven";
      Assert.AreEqual(result, newTranslator.NumberConvert(newTranslator));
    }
    [TestMethod]
    public void SuffixConvert_ConvertHundredBillionsIntoWords_String()
    {
      Translator newTranslator = new Translator("300000000227");
      string result = "ThreeHundredBillionTwoHundredTwentySeven";
      Assert.AreEqual(result, newTranslator.NumberConvert(newTranslator));
    }
    [TestMethod]
    public void SuffixNumberConvert_ConvertTrillionIntoWords_String()
    {
      Translator newTranslator = new Translator("1000000000000000");
      string result = "sorry";
      Assert.AreEqual(result, newTranslator.NumberConvert(newTranslator));
    }
    [TestMethod]
    public void SuffixNumberConvert_ConvertSpecificNumbers_String()
    {
      Translator newTranslator = new Translator("777777777");
      string result = "SevenHundredSeventySevenMillionSevenHundredSeventySevenThousandSevenHundredSeventySeven";
      Assert.AreEqual(result, newTranslator.NumberConvert(newTranslator));
    }
  }
}
