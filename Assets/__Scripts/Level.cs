using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level_", menuName ="ScriptableObjects/LevelMap")]
public class Level : ScriptableObject
{
    public GameObject[] types;
    
    public string[] enemyRows;

    public int[] parseEnemyRows(int row) {
        return Array.ConvertAll(enemyRows[row].Split((char)','), int.Parse);
    }
}
