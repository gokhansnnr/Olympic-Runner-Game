using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStopper : MonoBehaviour
{
    public GameObject timeObject, block, playerBackBlock;
    public int esktraTime;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {

            timeObject.GetComponent<Controllers>().startTimer = false;
            timeObject.GetComponent<Controllers>().ekstraTime = esktraTime;
            playerBackBlock.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            timeObject.GetComponent<Controllers>().startTimer = true;
            block.SetActive(true);
        }
            
    }
}
