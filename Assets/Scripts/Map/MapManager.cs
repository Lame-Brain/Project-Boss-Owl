/**********************************************************************************************************************************************************************************************************************
* Author:		Brett Roberts
* Filename:		MapManager.cs
* Date Created: 8/11/2019
*
* Class: MapManager (DontDestroyOnLoad)
*
* Purpose: Constructs a 2D array from the CSV file specified by GameManager and passes it to MapMaker to place the map on-screen
*
* Manager Functions:
*       void Awake()
*       
* Methods:
*       void BuildMap(string csvFile)
*           Constructs and places a map specified by the csvFile
*       int[,] ConstructArray(string csvFile)
*           Creates and returns a 2D array built from the csvFile
*           
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
    *   Builds a 2D array from the given csvFile and passes it to m_mapMaker for placement
    * 
    * Precondition: 
    *   The GameManager has detected a change in the map is needed and has passed the proper map csv to its MapManager
    * 
    * Postcondition:
    *    A map is created and placed via the ConstructedArray
    ***********************************************************************************************************************************************************************************************************************/
    public void BuildMap(string csvFile)
    {

        m_mapMaker.PlaceMap(ConstructArray(csvFile));
    }

    /**********************************************************************************************************************************************************************************************************************
    * Purpose: 
    *   Creates a 2D array from the passed in csvFile
    * 
    * Precondition: 
    *   BuildMap has been called from the GameManager
    * 
    * Postcondition:
    *   If the csvFile is inaccessible or does not exist and exception is thrown
    *   Otherwise, a 2D array that mimics the passed in csvFile is returned
    *   
    ***********************************************************************************************************************************************************************************************************************/
    public int[,] ConstructArray(string csvFile)
    {
        string[] fileLines;
        string[] currLine;
        int[,] finalArray;
        //Attempt to open the file and if it isn't found throw a custom exception message
        try
        {
            //Grab all lines
            fileLines = File.ReadAllLines(GameManager.DIRECTORY_CSV_FILES + csvFile);
            File.Open(GameManager.DIRECTORY_CSV_FILES + csvFile, FileMode.Open);
        }
        catch
        {
            throw new System.Exception("Could not open the file under" + GameManager.DIRECTORY_CSV_FILES + csvFile);
        }

        //Set memory for the returned 2D array before adding to it
        finalArray = new int[fileLines[0].Split(GameManager.FILE_DELIMITER).Length, fileLines.Length];

        //Go through each line of the file and split it by the delimiter making it into the ith row
        for(int y = 0; y < fileLines.Length; ++y)
        {
            //Split a single line by the delimiter        
            currLine = fileLines[y].Split(GameManager.FILE_DELIMITER);
            for(int x = 0; x < fileLines[0].Split(GameManager.FILE_DELIMITER).Length; ++x)
                finalArray[x, y] = System.Convert.ToInt32(currLine[x]);
        }

        return finalArray;
    }
}
