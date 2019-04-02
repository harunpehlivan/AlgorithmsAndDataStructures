﻿/* 
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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSFundamentals.Algorithms.Sort;
using System.Collections.Generic;

namespace CSFundamentalsTests.Algorithms.Sort
{
    [TestClass]
    public partial class InsertionSortTests
    {
        [TestMethod]
        public void InsertionSort_Iterative_V1_WithDistinctValues()
        {
            var values = new List<int>(Constants.ArrayWithDistinctValues);
            InsertionSort.Sort_Iterative_V1(values);
            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));
        }

        [TestMethod]
        public void InsertionSort_Iterative_V1_WithDuplicateValues()
        {
            var values = new List<int>(Constants.ArrayWithDuplicateValues);
            InsertionSort.Sort_Iterative_V1(values);
            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));
        }

        [TestMethod]
        public void InsertionSort_Iterative_V2_WithDistinctValues()
        {
            var values = new List<int>(Constants.ArrayWithDistinctValues);
            InsertionSort.Sort_Iterative_V2(values);
            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));
        }

        [TestMethod]
        public void InsertionSort_Iterative_V2_WithDuplicateValues()
        {
            var values = new List<int>(Constants.ArrayWithDuplicateValues);
            InsertionSort.Sort_Iterative_V2(values);
            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));
        }

        [TestMethod]
        public void InsertionSort_Recursive_WithDistinctValues()
        {
            var values = new List<int>(Constants.ArrayWithDistinctValues);
            InsertionSort.Sort_Recursive(values, values.Count - 1);
            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));
        }

        [TestMethod]
        public void InsertionSort_Recursive_WithDuplicateValues()
        {
            var values = new List<int>(Constants.ArrayWithDuplicateValues);
            InsertionSort.Sort_Recursive(values, values.Count - 1);
            Assert.IsTrue(UtilsTests.IsSortedAscendingly(values));
        }
        // TODO: add tests with other types of input arrays. 
    }
}
