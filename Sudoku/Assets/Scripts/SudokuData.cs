﻿using System.Collections.Generic;
using UnityEngine;

public class SudokuData
{
    public static readonly SudokuData instance = new SudokuData();
    public SudokuData()
    {
        SudokuBoards.Add("Easy", GetEasyBoards());
        SudokuBoards.Add("Medium", new List<SudokuBoardData>());
        SudokuBoards.Add("Hard", new List<SudokuBoardData>());
        SudokuBoards.Add("VeryHard", new List<SudokuBoardData>());
    }

    public Dictionary<string, List<SudokuBoardData>> SudokuBoards { get; } = new Dictionary<string, List<SudokuBoardData>>();

    private List<SudokuBoardData> GetEasyBoards()
    {
        var list = new List<SudokuBoardData>();
        list.Add(new SudokuBoardData(
            new byte[81] { 0, 0, 0, 2, 6, 0, 7, 0, 1, 6, 8, 0, 0, 7, 0, 0, 9, 0, 1, 9, 0, 0, 0, 4, 5, 0, 0, 8, 2, 0, 1, 0, 0, 0, 4, 0, 0, 0, 4, 6, 0, 2, 9, 0, 0, 0, 5, 0, 0, 0, 3, 0, 2, 8, 0, 0, 9, 3, 0, 0, 0, 7, 4, 0, 4, 0, 0, 5, 0, 0, 3, 6, 7, 0, 3, 0, 1, 8, 0, 0, 0 },
            new byte[81] { 4, 3, 5, 2, 6, 9, 7, 8, 1, 6, 8, 2, 5, 7, 1, 4, 9, 3, 1, 9, 7, 8, 3, 4, 5, 6, 2, 8, 2, 6, 1, 9, 5, 3, 4, 7, 3, 7, 4, 6, 8, 2, 9, 1, 5, 9, 5, 1, 7, 4, 3, 6, 2, 8, 5, 1, 9, 3, 2, 6, 8, 7, 4, 2, 4, 8, 9, 5, 7, 1, 3, 6, 7, 6, 3, 4, 1, 8, 2, 5, 9 }
            ));

        return list;
    }
}