
using System;
using System.Collections.Generic;


public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary> 
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // PLAN:
        // 1. Create a new array of doubles called 'result' with a size of 'length'.
        // 2. Create a loop that runs 'length' times to fill each spot in the array.
        // 3. In each step of the loop, calculate the multiple number * (current index + 1).
        // 4. Store calculation in the current spot of the array.
        // 5. Return the completed array to whoever called the function.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            //I use (i + 1) because the first multiple is number * 1, not number * 0

            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // PLAN:
        // 1. Determine where to "cut" the list by substracting 'amount' from the total count.
        // 2. Use GetRange to copy the elements from that cut-point to the end of the list.
        // 3. Use RemoveRange to delete those same elements from their original position ath the end.
        // 4. Use Insertrange to put those copied elements back in at the very start (index 0).


        // Step 1: Find the starting index of the part we want to move.

        int splitIndex = data.Count - amount;

        // Step 2: Grab the piece from the end

        List<int>endPiece = data.GetRange(splitIndex, amount);

        // Step 3: Remove the piece from the end

        data.RemoveRange(splitIndex, amount);

        // Step 4: Insert the piece at the front

        data.InsertRange(0, endPiece);
    }
}
