using System;
using System.Collections.Generic;

public class InterviewCase
{
    // Case 1 - Check Match
    // Write a function that returns if any match exists after items that represented by given two indexes are swapped.
    // Definition of "Match": There must be 3 or more same colored items in vertical and/or horizontal order in board.

    public static bool MatchExists(Board board, int index1, int index2)
    {
        //TODO
        return false;
    }
    
    //
    

    // Case 2 - Find All Possible Matches
    // Write a function that returns tuple list of two indexes in board that creates at least one match after swap.
    // These tuples should be unique such that if a {1,2} possible match exists, {2,1} must be ignored.
    // Definition of "Possible Match": Items represented by two indexes must create a match after swapped.

    public static List<Tuple<int, int>> GetAllPossibleMatches(Board board)
    {
        //TODO
        return null;
    }
    
    //
    

    // Case 3 - Shuffle
    // Write a function that shuffles positions of items of given board.
    // After the shuffle there must be at least one possible match exists
    // and there shouldn't be any already formed match exists in board.

    public static void Shuffle(Board board)
    {
        //TODO
    }

    public static bool IsAnyMatchExistsInBoard(Board board)
    {
        //TODO
        return false;
    }
    
    //
}