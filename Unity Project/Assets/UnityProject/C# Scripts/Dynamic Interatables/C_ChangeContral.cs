using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_ChangeContral : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
   

    /*
    public void SwitchActorContral(MattsController controller, MattsActor player, int change)
    {
        controller.SetPlayer(false, player);
        player.SetActorAsPlayer(false);

        int currentID = player.GetActorID();
        int newID = currentID += change;

        if (newID == -1)
        {
            newID = m_actors.Length - 1;// if current ID was Actor 0, make new ID the last actor in the array
        }
        else if (newID == m_actors.Length)
        {
            newID = 0;// if current ID was the last actor, in array make new ID actor 0
        }

        foreach (MattsActor a in m_actors)
        {
            if (a.GetActorID() == newID)
            {
                a.SetActorAsPlayer(true);
                newOwnedA = a;
                break;
            }
        }

        foreach (MattsController c in m_controllers)
        {
            if (c.GetC_ID() == newID)
            {
                c.SetPlayer(true, newOwnedA);
                break;
            }
        }
    }*/
}
