using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NumToWord.Models
{
  public class Translator
  {
    private static Dictionary<long, string> _belowTwenty = new Dictionary<long, string>{{0,"Zero"},{1,"One"},{2,"Two"},{3,"Three"},{4,"Four"},{5,"Five"},{6,"Six"},{7,"Seven"},{8,"Eight"},{9,"Nine"},{10,"Ten"},{11,"Eleven"},{12,"Twelve"},{13,"Thirteen"},{14,"Fourteen"},{15,"Fifteen"},{16,"Sixteen"},{17,"Seventeen"},{18,"Eighteen"},{19,"Nineteen"}};
    private static Dictionary<long, string> _tenMultiples = new Dictionary<long, string>{{20,"Twenty"},{30,"Thirty"},{40,"Forty"},{50,"Fifty"},{60,"Sixty"},{70,"Seventy"},{80,"Eighty"},{90,"Ninety"}};
    private static Dictionary<int, string> _suffix = new Dictionary<int, string>{{100,"Hundred"},{1000,"Thousand"},{1000000,"Million"},{1000000000,"Billion"}};
    public string Output { get; set; }
    public string Input { get; set; }

    public Translator(string input)
    {
      Output = "";
      Input = input;
    }
    public string NumberConvert(Translator input)
    {
      long number = long.Parse(input.Input);
      number = input.SuffixConvert(number);
      number = input.TensConvert(number);
      Output += _belowTwenty[number];
      return Output;
    }

    public long TensConvert(long number)
    {
      if (number < 20)
      {
        return number;
      }
      else
      {
        int tens = (int)Math.Floor(number/10.0f);
        int newNumber = tens*10;
        Output += _tenMultiples[newNumber];
        number = number-newNumber;
        return number;
      }
    }
    public long SuffixConvert(long number)
    {
      if (number >= 100 && number <= 1000)
      {
        int hundreds = (int)Math.Floor(number/100.0f);
        Output += _belowTwenty[hundreds];
        Output += _suffix[100];
        number = number - hundreds * 100;
      }
      return number;
    }
  }
}
