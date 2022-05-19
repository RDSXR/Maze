using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject door = null;
    private void Start()
    {
        door.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            if (door.activeInHierarchy)
            {
                door.SetActive(false);
                other.gameObject.SetActive(false);
            }
        }
    }
}
