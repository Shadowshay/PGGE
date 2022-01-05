using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public abstract class TPCBase

{
    protected Transform mCameraTransform;
    protected Transform mPlayerTransform;
    public Transform CameraTransform
    {
        get
        {
            return mCameraTransform;
        }
    }

    public Transform PlayerTransform
    {
        get
        {
            return mPlayerTransform;
        }
    }



    public TPCBase(Transform cameraTransform, Transform playerTransform)

    {

        mCameraTransform = cameraTransform;

        mPlayerTransform = playerTransform;

    }
    public abstract void Update();

}
