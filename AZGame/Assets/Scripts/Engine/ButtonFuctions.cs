﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFuctions : MonoBehaviour {

    [SerializeField] Animator cameraAnimator;
    [SerializeField] GameObject cameraParent;

    public void GoToTavern()
    {
        cameraParent.transform.position = new Vector3(180.9f, -25.98f, -18.8f);
        cameraParent.transform.Rotate(new Vector3(0f, 25.3f, 0f));
        cameraAnimator.Play("GoToTavern");
    }
    public void GoToMainMenu()
    {
        cameraParent.transform.position = new Vector3(0f, 0f, 0f);
        cameraParent.transform.Rotate(new Vector3(0f, -25.3f, 0f));
        cameraAnimator.Play("GoToMainMenu");
    }
}