using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;
using System;

public class C_PrototypeVechile : MonoBehaviour
{
    private string VechileName;
    public GameObject turret;
    // Start is called before the first frame update
    public enum MovmentD { Forward, Backward, Left, Right, Stationary };
    public MovmentD directionEnum;
    //movementvars
    protected bool canMove = false;
    // AR VARS
    private Pose placementPose;
    private ARSessionOrigin arOrigin;
    private ARRaycastManager arRayManager;
    private bool placementPoseValid = false;
    public Camera arCam;//infuture add to GM or GI and get from their for each ar script

    public C_PrototypeVechile()// just like UE4 construction script BUT it is the only place you can modify readonly vars and should only be used for one time low process power functions
    {
        directionEnum = MovmentD.Stationary;

    }

   public void Init()
    {
        canMove = true;
        arOrigin = FindObjectOfType<ARSessionOrigin>();
        arRayManager = arOrigin.GetComponent<ARRaycastManager>();
        VechileName = "PrototypeTank";    
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            MovementDirection();
        }
        UpdatePlacementPose();
    }

    private void UpdatePlacementPose()
    {
        var screenCenter = arCam.ViewportToScreenPoint(new Vector3(0.5f,0.5f));
        var hits = new List<ARRaycastHit>();
        arRayManager.Raycast(screenCenter,hits);

        placementPoseValid = hits.Count > 0;
        if(placementPoseValid == true)
        {
            placementPose = hits[0].pose;
        }
        
    }

    public void FSM_Movement(MovmentD movement)
    {
        switch (movement)
        {
            case MovmentD.Forward:

                break;

            case MovmentD.Backward:

                break;

            case MovmentD.Right:

                break;

            case MovmentD.Left:

                break;

            default:

                break;
        }

    }

    public void MovementDirection()
    {

    }



}
