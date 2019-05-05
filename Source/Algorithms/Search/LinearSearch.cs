﻿#region copyright
/* 
 * Copyright (c) 2019 (PiJei) 
 * 
 * This file is part of CSFundamentalAlgorithms project.
 *
 * CSFundamentalAlgorithms is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * CSFundamentalAlgorithms is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with CSFundamentals.  If not, see <http://www.gnu.org/licenses/>.
 */
#endregion
using System;
using System.Collections.Generic;
using CSFundamentals.Decoration;

namespace CSFundamentals.Algorithms.Search
{
    /// <summary>
    /// Implements linear search, time complexity is O(N)
    /// </summary>
    public class LinearSearch
    {
        /// <summary>
        /// Searches for a given value in a list. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">A list of any comparable type.</param>
        /// <param name="startIndex">The lowest (left-most) index of the array - inclusive. </param>
        /// <param name="endIndex">The highest (right-most) index of the array - inclusive. </param>
        /// <param name="key">The value the method is searching for. </param>
        /// <returns></returns>
        [Algorithm(AlgorithmType.Search, "LinearSearch")]
        [SpaceComplexity("O(1)", InPlace = true)]
        [TimeComplexity(Case.Best, "O(1)")]
        [TimeComplexity(Case.Worst, "O(n)")]
        [TimeComplexity(Case.Average, "O(n)")]
        public static int Search<T>(List<T> list, int startIndex, int endIndex, T key) where T : IComparable<T>
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (list[i].CompareTo(key) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
