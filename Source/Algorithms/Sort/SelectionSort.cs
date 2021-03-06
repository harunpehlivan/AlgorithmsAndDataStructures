﻿#region copyright
/* 
 * Copyright (c) 2019 (PiJei) 
 * 
 * This file is part of AlgorithmsAndDataStructures project.
 *
 * AlgorithmsAndDataStructures is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * AlgorithmsAndDataStructures is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with AlgorithmsAndDataStructures.  If not, see <http://www.gnu.org/licenses/>.
 */
#endregion
using System;
using System.Collections.Generic;
using AlgorithmsAndDataStructures.Decoration;

namespace AlgorithmsAndDataStructures.Algorithms.Sort
{
    /// <summary>
    /// Implements Selection sort algorithm. 
    /// </summary>
    public partial class SelectionSort
    {
        /// <summary>
        /// Implements selection sort, which is in-situ and unstable, and at each step, the list would look as one sorted part, and one unsorted part. 
        /// </summary>
        /// <param name="list">The list of values (of type T, e.g., int) to be sorted. </param>
        [Algorithm(AlgorithmType.Sort, "SelectionSort")]
        [SpaceComplexity("O(1)", InPlace = true)]
        [TimeComplexity(Case.Best, "O(n²)")]
        [TimeComplexity(Case.Worst, "O(n²)")]
        [TimeComplexity(Case.Average, "O(n²)")]
        public static void Sort<T>(List<T> list) where T : IComparable<T>
        {
            /*Notice that the loop does not have to repeat over the last element of the list, as by then the last element is already the largest element in the list.*/
            for (int i = 0; i < list.Count - 1; i++) /* Iteration i, determines the i-th smallest/min value. */
            {
                int minIndex = i;
                for (int j = i+1; j < list.Count; j++) /* This loop finds an element in the unsorted part of the list that is smaller than the current value at index i. */
                {
                    if (list[j].CompareTo(list[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }
                Utils.Swap(list, i, minIndex); /* Even though if minIndex has not changed, the swap happens. Can be made efficient by adding an if check. */
            }
        }
    }
}
