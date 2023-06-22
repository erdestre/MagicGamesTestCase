using System;
using System.Linq;
using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class TestRunner
    {
        [Test]
        public void Test1()
        {
            var board = new Board(3, 3, new int[]
            {
                1, 2, 1,
                3, 1, 2,
                1, 2, 3
            });
            
            Assert.IsTrue(InterviewCase.MatchExists(board, 1, 4));
            Assert.IsTrue(InterviewCase.MatchExists(board, 3, 4));
            Assert.IsTrue(InterviewCase.MatchExists(board, 4, 5));
            
            Assert.IsFalse(InterviewCase.MatchExists(board, 7, 8));
            Assert.IsFalse(InterviewCase.MatchExists(board, 1, 5));
            
            var possibleMatches = InterviewCase.GetAllPossibleMatches(board);
            
            Assert.IsNotNull(possibleMatches);
            Assert.AreEqual(3, possibleMatches.Count);

            Assert.IsTrue(possibleMatches.Contains(new Tuple<int, int>(1, 4)) 
                          || possibleMatches.Contains(new Tuple<int, int>(4, 1)));
            
            Assert.IsTrue(possibleMatches.Contains(new Tuple<int, int>(3, 4)) 
                          || possibleMatches.Contains(new Tuple<int, int>(4, 3)));
            
            Assert.IsTrue(possibleMatches.Contains(new Tuple<int, int>(4, 5)) 
                          || possibleMatches.Contains(new Tuple<int, int>(5, 4)));
            
            var gridBeforeShuffle = (int[]) board.Grid.Clone();
            InterviewCase.Shuffle(board);
            
            Assert.AreNotEqual(gridBeforeShuffle, board.Grid);
            
            var possibleMatchesAfterShuffle = InterviewCase.GetAllPossibleMatches(board);
            Assert.IsNotNull(possibleMatchesAfterShuffle);
            Assert.IsNotEmpty(possibleMatchesAfterShuffle);
            Assert.IsFalse(InterviewCase.IsAnyMatchExistsInBoard(board));
            
        }

        [Test]
        public void Test2()
        {
            var board = new Board(6, 4, new int[]
            {
                1, 2, 1, 3, 1, 4,
                3, 4, 2, 1, 3, 4,
                1, 2, 3, 4, 3, 1,
                4, 1, 1, 3, 2, 3
            });
            
            Assert.IsTrue(InterviewCase.MatchExists(board, 3, 9));
            Assert.IsTrue(InterviewCase.MatchExists(board, 7, 8));
            Assert.IsTrue(InterviewCase.MatchExists(board, 12, 18));
            Assert.IsTrue(InterviewCase.MatchExists(board, 22, 21));
            
            Assert.IsFalse(InterviewCase.MatchExists(board, 13, 19));
            Assert.IsFalse(InterviewCase.MatchExists(board, 16, 17));
            Assert.IsFalse(InterviewCase.MatchExists(board, 0, 6));
            
            var possibleMatches = InterviewCase.GetAllPossibleMatches(board);
            Assert.IsNotNull(possibleMatches);
            Assert.AreEqual(8, possibleMatches.Count);

            Assert.IsTrue(possibleMatches.Contains(new Tuple<int, int>(3, 4)) 
                          || possibleMatches.Contains(new Tuple<int, int>(4, 3)));
            
            Assert.IsTrue(possibleMatches.Contains(new Tuple<int, int>(15, 21)) 
                          || possibleMatches.Contains(new Tuple<int, int>(21, 15)));
            
            Assert.IsTrue(possibleMatches.Contains(new Tuple<int, int>(16, 22)) 
                          || possibleMatches.Contains(new Tuple<int, int>(22, 16)));
            
            Assert.IsTrue(possibleMatches.Contains(new Tuple<int, int>(22, 23)) 
                          || possibleMatches.Contains(new Tuple<int, int>(23, 22)));
            
            var gridBeforeShuffle = (int[]) board.Grid.Clone();
            InterviewCase.Shuffle(board);
            
            Assert.AreNotEqual(gridBeforeShuffle, board.Grid);
            
            var possibleMatchesAfterShuffle = InterviewCase.GetAllPossibleMatches(board);
            Assert.IsNotNull(possibleMatchesAfterShuffle);
            Assert.IsNotEmpty(possibleMatchesAfterShuffle);
            Assert.IsFalse(InterviewCase.IsAnyMatchExistsInBoard(board));
        }

        [Test, MaxTime(1000)]
        public void Test3()
        {
            for (var i = 0; i < 10000; i++)
            {
                var board = new Board(3, 3, new int[]
                {
                    1, 2, 1,
                    3, 1, 2,
                    1, 2, 3
                });
                
                var gridBeforeShuffle = (int[]) board.Grid.Clone();
                InterviewCase.Shuffle(board);
                
                Assert.AreNotEqual(gridBeforeShuffle, board.Grid);
                
                var possibleMatchesAfterShuffle = InterviewCase.GetAllPossibleMatches(board);
                Assert.IsNotNull(possibleMatchesAfterShuffle);
                Assert.IsNotEmpty(possibleMatchesAfterShuffle);
                Assert.IsFalse(InterviewCase.IsAnyMatchExistsInBoard(board));
            }
        }
        
        [Test]
        public void Test4()
        {
            var board = new Board(7, 7, new int[]
            {
                1, 4, 3, 6, 4, 1, 1, 
                4, 2, 4, 1, 5, 2, 5, 
                4, 1, 6, 2, 3, 3, 5, 
                1, 4, 5, 2, 2, 3, 4, 
                3, 3, 6, 3, 2, 1, 5, 
                5, 5, 3, 5, 4, 1, 4, 
                4, 1, 5, 2, 5, 2, 5
            });
            
            Assert.IsTrue(InterviewCase.MatchExists(board, 0, 1));
            Assert.IsTrue(InterviewCase.MatchExists(board, 1, 8));
            Assert.IsTrue(InterviewCase.MatchExists(board, 17, 18));
            Assert.IsTrue(InterviewCase.MatchExists(board, 37, 44));
            Assert.IsTrue(InterviewCase.MatchExists(board, 37, 30));
            
            Assert.IsFalse(InterviewCase.MatchExists(board, 7, 8));
            Assert.IsFalse(InterviewCase.MatchExists(board, 1, 5));
            Assert.IsFalse(InterviewCase.MatchExists(board, 17, 24));
            Assert.IsFalse(InterviewCase.MatchExists(board, 35, 42));
            Assert.IsFalse(InterviewCase.MatchExists(board, 47, 48));
            
            var possibleMatches = InterviewCase.GetAllPossibleMatches(board);
            
            Assert.IsNotNull(possibleMatches);
            Assert.AreEqual(11, possibleMatches.Count);
            
            Assert.IsTrue(possibleMatches.Contains(new Tuple<int, int>(0, 1)) 
                          || possibleMatches.Contains(new Tuple<int, int>(1, 0)));
            
            Assert.IsTrue(possibleMatches.Contains(new Tuple<int, int>(1, 8)) 
                          || possibleMatches.Contains(new Tuple<int, int>(8, 1)));
            
            Assert.IsTrue(possibleMatches.Contains(new Tuple<int, int>(17, 18)) 
                          || possibleMatches.Contains(new Tuple<int, int>(18, 17)));

            Assert.IsTrue(possibleMatches.Contains(new Tuple<int, int>(37, 44)) 
                          || possibleMatches.Contains(new Tuple<int, int>(44, 37)));
            
            Assert.IsTrue(possibleMatches.Contains(new Tuple<int, int>(37, 30)) 
                          || possibleMatches.Contains(new Tuple<int, int>(30, 37)));
            
            var gridBeforeShuffle = (int[]) board.Grid.Clone();
            InterviewCase.Shuffle(board);
            
            Assert.AreNotEqual(gridBeforeShuffle, board.Grid);
            
            var possibleMatchesAfterShuffle = InterviewCase.GetAllPossibleMatches(board);
            Assert.IsNotNull(possibleMatchesAfterShuffle);
            Assert.IsNotEmpty(possibleMatchesAfterShuffle);
            Assert.IsFalse(InterviewCase.IsAnyMatchExistsInBoard(board));

        }
    }
}
