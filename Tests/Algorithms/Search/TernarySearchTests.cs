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
using CSFundamentals.Algorithms.Search;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// TODO: Binary search and Ternary searches are very similar, can I just pass a function to them instead?
namespace CSFundamentalsTests.Algorithms.Search
{
    /// <summary>
    /// Tests methods in <see cref="TernarySearch"/> class. 
    /// </summary>
    [TestClass]
    public class TernarySearchTests
    {
        /// <summary>
        /// Tests the correctness of Ternary search algorithm on an array with distinct elements. 
        /// To visualize step by step how Ternary Search finds a distinct element (int value of 3) in <see cref="SearchTests.List"/> see <img src = "../Images/Search/TernarySearch.png"/>.
        /// </summary>
        [TestMethod]
        public void Search_DistinctElements()
        {
            SearchTests.DistinctElements_ExpectsToSuccessfullyGetTheIndexOfTheirPosition(TernarySearch.Search);
        }

        /// <summary>
        /// Tests the correctness of Ternary search algorithm on an array with duplicate elements. 
        /// To visualize step by step how Ternary Search finds a duplicate element (int value of 90) in <see cref="SearchTests.List"/> see <img src = "../Images/Search/TernarySearch.png"/>.
        /// </summary>
        [TestMethod]
        public void Search_DuplicateElements()
        {
            SearchTests.DuplicateElements_ExpectsToGetTheIndexOfOneOfTheDupliatesNoMatterHowManyTimeSearchIsPerformed(TernarySearch.Search);
        }

        /// <summary>
        /// Tests the correctness of Ternary search algorithm when the key does not exist in the array. 
        /// To visualize step by step how Ternary Search terminates without finding a missing element (int value of 15) in <see cref="SearchTests.List"/> see <img src = "../Images/Search/TernarySearch.png"/>.
        /// </summary>
        [TestMethod]
        public void Search_NonExistingElements()
        {
            SearchTests.NonExistingElements_ExpectsToGetMinusOne(TernarySearch.Search);
        }
    }
}
