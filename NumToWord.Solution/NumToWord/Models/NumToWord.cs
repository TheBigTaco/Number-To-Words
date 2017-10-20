using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NumToWord.Models
{
  public class Translator
  {
    private static Dictionary<long, string> _belowTwenty = new Dictionary<long, string>{{0,"Zero"},{1,"One "},{2,"Two "},{3,"Three "},{4,"Four "},{5,"Five "},{6,"Six "},{7,"Seven "},{8,"Eight "},{9,"Nine "},{10,"Ten "},{11,"Eleven "},{12,"Twelve "},{13,"Thirteen "},{14,"Fourteen "},{15,"Fifteen "},{16,"Sixteen "},{17,"Seventeen "},{18,"Eighteen "},{19,"Nineteen "}};
    private static Dictionary<long, string> _tenMultiples = new Dictionary<long, string>{{20,"Twenty "},{30,"Thirty "},{40,"Forty "},{50,"Fifty "},{60,"Sixty "},{70,"Seventy "},{80,"Eighty "},{90,"Ninety "}};
    private static Dictionary<int, string> _suffix = new Dictionary<int, string>{{100,"Hundred "},{1000,"Thousand "},{1000000,"Million "},{1000000000,"Billion "}};
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
      if (number == 0)
      {
        return _belowTwenty[number];
      }
      if (number > 999999999999)
      {
        return "sorry that number is too big";
      }
      while (number > 99)
      {
        number = input.SuffixConvert(number);
      }
      number = input.TensConvert(number);
      if(number != 0)
      {
        Output += _belowTwenty[number];
      }
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
    public long TenOfConvert(long number, long baseNum, int i)
    {
      if(number >= 20 && number < 100)
      {
        long tens = TensConvert(number);
        if(tens == 0){
          baseNum = baseNum - (number * i);
          Output += _suffix[i];
        } else {
          Output += _belowTwenty[tens];
          baseNum = baseNum - (number * i);
          Output += _suffix[i];
        }
      }
        return baseNum;
    }
    public long SuffixConvert(long number)
    {
      long newNumber = number;
      for (int i = 1000000000; i > 4; i/=1000) {
        if (newNumber >= i)
        {
          long amountOf = (long)Math.Floor((decimal)newNumber/i);
          if(amountOf >= 20 && amountOf < 100)
          {
            newNumber = TenOfConvert(amountOf, newNumber, i);
            break;
          }
          if(amountOf > 100)
          {
            long hundreds = SuffixConvert(amountOf);
            if (hundreds == 0)
            {
              newNumber = newNumber - (amountOf * i);
              Output += _suffix[i];
              break;
            }
            newNumber = TenOfConvert(amountOf, newNumber, i);
            break;
          }
          Output += _belowTwenty[amountOf];
          Output += _suffix[i];
          newNumber = newNumber - (amountOf * i);
        }
      }
      if (newNumber >= 100 && newNumber < 1000)
      {
        int hundreds = (int)Math.Floor(newNumber/100.0f);
        Output += _belowTwenty[hundreds];
        Output += _suffix[100];
        newNumber = newNumber - hundreds * 100;
      }
      return newNumber;
    }
  }
}
