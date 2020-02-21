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
    public Camera arCam;

    private AndroidJavaObject deviceCam = null;

    public C_AR_PlaceObject()
    {
       
    }

    private void Start()
    {
        arOrigin = FindObjectOfType<ARSessionOrigin>();
        arRayManager = arOrigin.GetComponent<ARRaycastManager>();

        if (deviceCam == null)
        {
#if (UNITY_ANDROID && !UNITY_EDITOR)
			AndroidJavaClass cameraClass = new AndroidJavaClass("android.hardware.Camera");
			deviceCam = cameraClass.CallStatic<AndroidJavaObject>("open");
                  FlashLight();    
#endif
        }

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
        var screenCenter = arCam.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        arRayManager.Raycast(screenCenter, hits);

        placementPoseValid = hits.Count > 0;
        if (placementPoseValid == true)
        {
            placementPose = hits[0].pose;
        }

    }
    void FlashLight()
    {
        AndroidJavaObject cameraParameters = deviceCam.Call<AndroidJavaObject>("getParameters");
      cameraParameters.Call("setFlashMode", "torch");
        deviceCam.Call("setParameters", cameraParameters);
    }
}
