/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		MapManager.cs
* Date Created: 8/11/2019
*
* Class: MapManager (DontDestroyOnLoad)
*
* Purpose: Constructs a 2D array from the files specified by GameManager and passes it to MapMaker to place the map on-screen
*
* Manager Functions:
*       void Awake()
*       
* Methods:
*       void BuildMap(string tileIDFile, string decoIDFile)
*           Constructs and places a map specified by the files
*       Tile[,] ConstructArray(string tileIDFile, string decoIDFile)
*           Creates and returns a 2D Tile array built from the files
***********************************************************************************************************************************************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    private MapMaker m_mapMaker;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        m_mapMaker = gameObject.AddComponent<MapMaker>();
    }

    /**********************************************************************************************************************************************************************************************************************
    * Purpose: 
    *   Builds a 2D array from the given files and passes it to m_mapMaker for placement
    * 
    * Precondition: 
    *   The GameManager has detected a change in the map is needed and has passed the proper map csv files to its MapManager
    * 
    * Postcondition:
    *    A map is created and placed via the ConstructedArray
    ***********************************************************************************************************************************************************************************************************************/
    public void BuildMap(string tileIDFile, string decoIDFile)
    {
        m_mapMaker.PlaceMap(ConstructArray(tileIDFile, decoIDFile));
    }

    /**********************************************************************************************************************************************************************************************************************
    * Purpose: 
    *   Creates a 2D array from the passed in csvFile
    * 
    * Precondition: 
    *   BuildMap has been called from the GameManager
    * 
    * Postcondition:
    *   If any files are inaccessible or does not exist and exception is thrown
    *   Otherwise, a 2D array of Tiles that mimic the passed in files is returned
    *   
    ***********************************************************************************************************************************************************************************************************************/
    public Tile[,] ConstructArray(string tileIDFile, string decoIDFile)
    {
        string[] tileLines, decoLines, currTileLine, currDecoLine;
        Tile[,] finalArray;

        //Attempt to open the files and if it isn't found throw a custom exception message
        try
        {
            tileLines = File.ReadAllLines(GameManager.DIRECTORY_CSV_FILES + tileIDFile);
        }
        catch
        {
            throw new System.Exception("Could not open the file under" + GameManager.DIRECTORY_CSV_FILES + tileIDFile);
        }

        try
        {
            decoLines = File.ReadAllLines(GameManager.DIRECTORY_CSV_FILES + decoIDFile);
        }
        catch
        {
            throw new System.Exception("Could not open the file under" + GameManager.DIRECTORY_CSV_FILES + decoIDFile);
        }

        //Set memory for the returned 2D array before adding to it
        finalArray = new Tile[tileLines[0].Split(GameManager.FILE_DELIMITER).Length, tileLines.Length];

        //Go through each line of the file and split it by the delimiter making it into the ith row
        for(int y = 0; y < tileLines.Length; ++y)
        {
            //Split a single line from each file by the delimiter        
            currTileLine = tileLines[y].Split(GameManager.FILE_DELIMITER);
            currDecoLine = decoLines[y].Split(GameManager.FILE_DELIMITER);

           /* for (int x = 0; x < tileLines[0].Split(GameManager.FILE_DELIMITER).Length; ++x)
            {
                //AddComponent for each tile in the array for allocation and set its location
                finalArray[x, y] = gameObject.AddComponent<Tile>();
                finalArray[x, y].TileSpriteId = System.Convert.ToInt32(currTileLine[x]);

                //AddComponent for each decoration
                finalArray[x, y].DecoratorSpriteId = System.Convert.ToInt32(currDecoLine[x]);
            }*/
        }

        return finalArray;
    }
}
