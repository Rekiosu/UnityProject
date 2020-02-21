using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class C_MainMenuGM : C_GameModeParent
{
    public delegate void newScene();
    public event newScene   SceneChanged;
    public string[] levels;
    public GameObject UImanager;

    void Start()
    {
        //fire init chain here for UI
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void LevelChange(int levelID)
    {
        ////foreach(string l in levels)
        //{
        //    if (levels[])
        //    {
               
        //    }
        //}


        SceneManager.LoadScene(levels[levelID]);

        //switch (levelID)
        //{
        //    case 0:
        //        //   Application.LoadLevel(1);
        //        SceneManager.LoadScene(levels[0]);
        //        break;
        //    case 1:
               
        //        break;
        //    case 2:
              
        //        break;
        //    case 3:
              
        //        break;
        //    default:
            
        //        break;
        //}
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
