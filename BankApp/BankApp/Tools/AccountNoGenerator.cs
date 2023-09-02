﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class AccountNoGenerator
    {
        public static string GenerateNewAccountNumber()
        {
            Random random = new Random();
            return GenerateRandomNumber(random, 10).ToString("D10");
        }

        static long GenerateRandomNumber(Random random, int digits)
        {
            if (digits <= 0)
                throw new ArgumentOutOfRangeException(" The number of digits must be greater than 0 ");

            long min = (long)Math.Pow(10, digits - 1);
            long max = (long)Math.Pow(10, digits) - 1;

            return random.Next((int)min, (int)max);
        }
    }
}
