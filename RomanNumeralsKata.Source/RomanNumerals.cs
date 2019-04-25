﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata.Source
{
    public class RomanNumerals
    {
        public string Convert(int arabic)
        {
            var arabicToRoman = new Dictionary<int, string>
            {
                {1, "I"},
                {2, "II"},
                {3, "III"},
                {4, "IV"},
                {5, "V"},
                {6, "VI"},
                {7, "VII"},
                {8, "VIII"},
                {9, "IX"},
                {10, "X"},
                {11, "XI"},
                {12, "XII"},
                {13, "XIII"},
                {14, "XIV"},
                {15, "XV"},
                {16, "XVI"},
                {17, "XVII"},
                {18, "XVIII"},
                {19, "XIX"},
                {20, "XX"}
            };

            return arabicToRoman[arabic];
        }
    }
}
