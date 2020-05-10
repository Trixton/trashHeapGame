using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class clock : MonoBehaviour
{
    public Transform hoursTransform, minutesTransform, secondsTransform;
    float degreesPerHour = 30f;
    float degreesPerMinute = 6f;
    float degreesPerSecond = 6f;
    public bool continuous;

    void Awake () {
		Debug.Log(Time.time);
        Debug.Log(DateTime.Now);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (continuous)
        {
            UpdateContinuous();
        }
        else
        {
            UpdateDiscrete();
        }
    }

    void UpdateContinuous()
    {
		TimeSpan time = DateTime.Now.TimeOfDay;
		hoursTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalHours * degreesPerHour, 0f);
		minutesTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalMinutes * degreesPerMinute, 0f);
		secondsTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalSeconds * degreesPerSecond, 0f);
    }

    void UpdateDiscrete()
    {
        var timeNow = DateTime.Now;
        hoursTransform.localRotation = Quaternion.Euler(0f, timeNow.Hour * degreesPerHour, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, timeNow.Minute * degreesPerMinute, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, timeNow.Second * degreesPerSecond, 0f);
    }
}
