﻿using System;

namespace FB.BusinessManagerSharer
{
    public static class YesNoSelector
    {
        public static bool ReadAnswerEqualsYes()
        {
            var answer = Console.ReadKey();
            Console.WriteLine();
            return answer.KeyChar == 'Y' || answer.KeyChar == 'y';
        }
    }
}
