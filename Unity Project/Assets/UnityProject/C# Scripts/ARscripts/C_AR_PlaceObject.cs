using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;
using System;

public class C_AR_PlaceObject : MonoBehaviour
{
    public GameObject placementIndicator;
    // AR VARS
    private Pose placementPose;
    private ARSessionOrigin arOrigin;
    private ARRaycastManager arRayManager;
    private bool placementPoseValid = false;


    public C_AR_PlaceObject()
    {
       
    }

    private void Start()
    {
        arOrigin = FindObjectOfType<ARSessionOrigin>();
        arRayManager = arOrigin.GetComponent<ARRaycastManager>();
    }
    // Update is called once per frame
    void Update()
    {
        UpdatePlacementPose();
        UpdatePlacementinDicator();
    }

    private void UpdatePlacementinDicator()
    {
        if (placementPoseValid)
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);

        }
        else
        {
            placementIndicator.SetActive(false);
        }
    }

    private void UpdatePlacementPose()
    {
        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        arRayManager.Raycast(screenCenter, hits);

        placementPoseValid = hits.Count > 0;
        if (placementPoseValid == true)
        {
            placementPose = hits[0].pose;
        }

    }
}
