﻿using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace FileHelpers.Examples.Sorting.SortBigFilesString2
{
    //-> Name:Sort Big File without Record Class 2
    //-> Runnable:false
    //-> Description:Shows how to sort a big file without a record class
    [Ignore("Does not have input")]
    public class BigFileSortString2
        : ExampleBase
    {
        //-> Implements <a href="http://en.wikipedia.org/wiki/External_sorting">External Sorting (wikipedia)</a>

        //-> You can use any sort you want, for example sorting by line length

        protected override void Run()
        {
            //-> File:SortingWithoutRecord.cs

            var sorter = new BigFileSorter(
                (x, y) => {
                    // You can add here any custom function
                    return x.Length.CompareTo(y.Length);
                });

            sorter.Sort("unsorted.txt", "sorted.txt");

            //-> /File
        }

    }
}