using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable][CreateAssetMenu(fileName = "LevelCenter", menuName = "ScriptableObjects/LevelCenter")]
public class LevelCenter : ScriptableObject
{
    public char[,] levelCenter = 
       {{'1','1','1','1','1','1','1'},
        {'0','0','0','0','0','0','0'},
        {'0','0','0','0','0','0','0'},
        {'0','0','0','0','0','0','0'},
        {'0','0','0','0','0','0','0'},
        {'0','0','0','0','0','0','0'},
        {'0','0','0','0','0','0','0'},
        {'0','0','0','P','0','0','0'},
        {'0','0','1','1','1','0','0'},
        {'0','0','0','0','0','0','0'},
        {'0','0','0','0','0','0','0'},
        {'0','0','0','0','0','0','0'},
        {'0','0','0','0','0','0','0'},
        {'0','0','0','0','0','0','0'},
        {'0','0','0','0','0','0','0'},
        {'1','1','1','1','1','1','1'}};
}
