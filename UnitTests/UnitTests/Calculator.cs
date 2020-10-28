using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace UnitTestsExample
{
    public class Calculator
    {
        public int AddNumbers(params int[] numbers) {
            int sum = 0;
            foreach (var number in numbers) {
                sum += number;
            }

            return sum;
        }

        public int MaxValue(params int[] numbers) {
            int maxValue = numbers[0];
            foreach (var number in numbers) {
                if (number >= maxValue) {
                    maxValue = number;
                }
            }

            return maxValue;
        }

        public int MinValue(params int[] numbers) {
            int minValue = numbers[0];
            foreach (var number in numbers) {
                if (number <= minValue) {
                    minValue = number;
                }
            }

            return minValue;
        }

        public float CalculateAverage(params int[] numbers) {
            float average = Convert.ToSingle(AddNumbers(numbers) / numbers.Length);
            return average;
        }
    }
}
