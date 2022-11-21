using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coneTrigger : MonoBehaviour
{
    Collider m_ObjectCollider;
    [SerializeField] private int layer1 = 8;
    [SerializeField] private int layer2 = 6;
    private int finalMask;

    void Start()
    {
        int layerMask1 = 1 << layer1;
        int layerMask2 = 1 << layer2;
        int finalMask = layerMask1 | layerMask2;
        m_ObjectCollider = GetComponent<Collider>();
        m_ObjectCollider.isTrigger = true;
        Debug.Log("Trigger On: " + m_ObjectCollider.isTrigger);
        Debug.Log(m_ObjectCollider);
    }


    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Eyes")
        {
            RaycastHit hit;
            Debug.Log("Collision with " + other);
            Debug.Log("Eyes entered cone");
            string hitTag;

            Physics.Linecast(m_ObjectCollider.transform.position, other.transform.position, out hit);

            hitTag = hit.collider.tag;

            if (hitTag == "Eyes")
            {
                Debug.Log(hit.collider.name + " was hit");
                Debug.Log("Not Blocked");
                Destroy(other.gameObject);
                Debug.DrawLine(this.transform.position, other.transform.position, Color.green, 60f);
            }
            else
            {
                Debug.Log(hit.collider.name + " was blocking");
                Debug.Log("Blocked");
                Debug.DrawLine(this.transform.position, other.transform.position, Color.red, 60f);
                
            }
        }
        else
        {
            Debug.Log(other + " is not Eyes");
        }
        
    }
}
