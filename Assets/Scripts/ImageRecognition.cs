using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class ImageRecognition : MonoBehaviour
{
    private ARTrackedImageManager _arTrackedImageManager;

    private void Awake()
    {
        // Setup the tracked image manager
        _arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable()
    {
        // Show image from the reference list
        _arTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    public void OnDisable()
    {
        // Hide image from the reference list
        _arTrackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    // https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@2.2/api/UnityEngine.XR.ARFoundation.ARTrackedImagesChangedEventArgs.html
    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        // Iterating over the list of added reference images
        foreach(var trackedImage in args.added)
        {
            Debug.Log(trackedImage.name);
        }
    }

}
