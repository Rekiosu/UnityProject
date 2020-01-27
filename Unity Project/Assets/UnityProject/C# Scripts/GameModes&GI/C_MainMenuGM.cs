using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_MainMenuGM : C_GameModeParent
{
    public delegate void newScene();
    public event newScene   SceneChanged;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void LevelChange(int level)
    {
        switch (level)
        {
            case 0:
              
                break;
            case 1:
               
                break;
            case 2:
              
                break;
            case 3:
              
                break;
            default:
            
                break;
        }
    }
}
