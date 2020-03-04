using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using UnityEngine;
using System.Linq;
using System;

public class InitGame : MonoBehaviour
{
    public GameObject wall;
    public GameObject player;
    public int height = 16;
    public int width = 21;

    //public LevelCenter mapCenter;

    //public LevelLeft mapLeft;

    //public LevelRight mapRight;
    public LevelTop mapTop;
    public LevelMid mapMid;
    public LevelBottom mapBottom;

    [SerializeField] private List<char> _level;
    /* private char[,] level = {{'1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','P','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','1','1','1','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1'}}; */

    // Start is called before the first frame update
    void Awake()
    {
        _level = new List<char>();
        
        
        // _level.Add(levelMid);
        //_level.Add(levelBottom);
        /*CreateMapRight();
        CreateMapCenter();
        CreateMapLeft(); */
       
    }

    void Start()
    {
        AddSection(mapTop.levelTop);
        AddSection(mapMid.levelMid);
        AddSection(mapBottom.levelBottom);
        SpawnMap(_level);
        /* _level = new List<char[]>();
        //var left = mapLeft.levelLeft;
        //var center = mapCenter.levelCenter;
        //var right = mapRight.levelRight;
        
        ///   Not sure which of these methods of combining the level pieces will work.... 
        ///  The For loop?
         for (int i = 0; i < height; i += 1)
        {
            var centerAndRight = (center[i,[i].Length].Concat(right[i]).ToArray();
            var levelLine = left[i].Concat(centerAndRight).ToArray();
            
            _level[i].Add();
  
        } 
       The Linq expression? (I really hope it can be this one!) */
        //_level.Add((x => left[x,] + center[x] + right[x]));
    }

    void SpawnMap(List<char> level)
    {
        int x = 0;
        int y = 0;
        _level = level;
        foreach (char tile in _level)
        {
            
            //for (int x = 0; x < width; x += 1)
            //{
            if (tile == '1')
            {

                GameObject instance = Instantiate(wall, new Vector3(x, -y, 0f), Quaternion.identity) as GameObject;
                x += 1;
            }

            if (tile == '0')
            {
                x += 1;
            }
            else if (tile == 'P')
            {
                GameObject instance = Instantiate(player, new Vector3(x, -y, 0f), Quaternion.identity) as GameObject;
                instance.AddComponent<PlayerController>();
                instance.AddComponent<JumpAction>();
                x += 1;
            }

            if (x == width)
            {
                y += 1;
                x = 0;
            }

            //}
        }
    }

    void AddSection(char[,] section)
    {
        char[,] levelPiece = section;
        for (int i = 0; i < section.GetLength(0); i++)
        {
            //var levelSection = _level[i];
            //for(int x = 0; x < width; x++) 
            //foreach (var row in levelSection)
            //{
            for (int j = 0; j < width; j += 1)
            {
                _level.Add(levelPiece[i, j]);
                print("Added tile to List!" );
            }

            /* else if (levelPiece[y,x] == 'P')
             {
                 GameObject instance =
                     Instantiate(player, new Vector3(x, -y, 0f), Quaternion.identity) as GameObject;
                 instance.AddComponent<PlayerController>();
                 instance.AddComponent<JumpAction>();
                 
             }
        }*/
        }
    }
}


  // Update is called once per frame
    /* void Update()
    {
        
    } 
} */
