using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grain : MonoBehaviour
{
    public Camera cam;
    void OnTriggerEnter()
    {
        cam.GetComponent<postVHSPro>().bleedAmount = 9.0f;
        cam.GetComponent<postVHSPro>().vignetteOn = true;
        cam.GetComponent<postVHSPro>().vignetteAmount = 2.0f;
        cam.GetComponent<postVHSPro>().vignetteSpeed = 3.0f;
        cam.GetComponent<postVHSPro>().filmGrainAmount = 0.1f;
        cam.GetComponent<postVHSPro>().signalNoiseAmount = 0.7f;
        cam.GetComponent<postVHSPro>().signalNoisePower = 0.79f;
        cam.GetComponent<postVHSPro>().lineNoiseAmount = 5.0f;
        cam.GetComponent<postVHSPro>().tapeNoiseAmount = 1.0f;
        cam.GetComponent<postVHSPro>().tapeNoiseTH = 1.5f;
        cam.GetComponent<postVHSPro>().scanLinesOn = true;
        cam.GetComponent<postVHSPro>().scanLineWidth = 20.0f;
        cam.GetComponent<postVHSPro>().jitterHOn = true;
        cam.GetComponent<postVHSPro>().jitterHAmount = 5.0f;
        cam.GetComponent<postVHSPro>().jitterVOn = true;
        cam.GetComponent<postVHSPro>().jitterVAmount = 3.0f;
        cam.GetComponent<postVHSPro>().twitchHOn = true;
        cam.GetComponent<postVHSPro>().twitchVOn = true;
    }

}
