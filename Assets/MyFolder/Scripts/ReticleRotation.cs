using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleRotation : MonoBehaviour
{
    private Transform reticleTransform;

    private void Awake()
    {
        Debug.Log("hello");
        reticleTransform = this.gameObject.transform;
    }

    private void Update()
    {
        reticleTransform.eulerAngles = new Vector3(0, Time.realtimeSinceStartup * 90f, 0);
    }

}
