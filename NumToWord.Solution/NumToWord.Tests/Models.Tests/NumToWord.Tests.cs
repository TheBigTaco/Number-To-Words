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
      Translator newTranslator = new Translator("246");
      string result = "TwoHundredFortySix";
      Assert.AreEqual(result, newTranslator.NumberConvert(newTranslator));
    }
    // [TestMethod]
    // public void SuffixConvert_ConvertThousandsIntoWords_String()
    // {
    //   Translator newTranslator = new Translator("3246");
    //   string result = "ThreeThousandTwoHundredFortySix";
    //   Assert.AreEqual(result, newTranslator.NumberConvert(newTranslator));
    // }
  }
}
