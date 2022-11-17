using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Prompt : MonoBehaviour
{
    public TextMeshProUGUI textMesh1;
    public TextMeshProUGUI textMesh2;
    public string setText;
    public bool destroyOnActivate;
    void OnTriggerEnter()
    {
        textMesh1.SetText(setText);
        textMesh2.SetText(setText);
        if (destroyOnActivate == true)
        {
            Destroy(this);
        }
    }
}
