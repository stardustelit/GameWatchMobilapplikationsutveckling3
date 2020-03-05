using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    bool[] gameBoardGrid = new bool[5];

    GameObject[] gameObjectGrid = new GameObject[5];

    GameObject[] pancakes1;



   

    public bool GetValue(int x)
    {
        return gameBoardGrid[x] = true;
    }

    public void Clear()
    {
        for (int x = 0; x < 5; x++)
        {
            gameBoardGrid[x] = false;
        }
    }

    public void SetupGrid()
    {
        for (int x = 0; x < pancakes1.Length; x++)
        {
            foreach (var go in pancakes1)
            {
                gameObjectGrid[x] = pancakes1[x];
            }
        }
    }


    void Start()
    {
        Clear();
        SetupGrid();
        UpdateDisplay();
    }

    IEnumerator UpdateDisplay()
    {
        while (true)
        {
            for (int x = 0; x < 5; x++)
            {
                gameObjectGrid[x].SetActive(GetValue(x));
            }
            yield return null;
        }
    }


}
