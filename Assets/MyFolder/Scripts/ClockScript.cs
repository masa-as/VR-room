using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockScript : MonoBehaviour
{
    private Transform clockSecondHandTransform;
    private Transform clockMinuteHandTransform;
    private Transform clockHourHandTransform;

    private void Awake()
    {
        clockSecondHandTransform = transform.Find("Clock_Analog_A_Second");
        clockMinuteHandTransform = transform.Find("Clock_Analog_A_Minute");
        clockHourHandTransform = transform.Find("Clock_Analog_A_Hour");
    }

    private void Update()
    {
        float secondsPerMinute = 60f;
        float secondsPerHour = 3600f;
        clockSecondHandTransform.eulerAngles = new Vector3(Time.realtimeSinceStartup * 90f, 0, -90);
        clockMinuteHandTransform.eulerAngles = new Vector3(Time.realtimeSinceStartup * 90f / secondsPerMinute, 0, -90);
        clockHourHandTransform.eulerAngles = new Vector3(Time.realtimeSinceStartup * 90f / secondsPerHour, 0, -90);
    }

}
