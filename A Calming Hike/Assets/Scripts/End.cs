using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    void OnTriggerEnter()
    {
        Destroy(GameObject.FindWithTag("Player"));
        UnityEngine.SceneManagement.SceneManager.LoadScene(3);
    }
}
