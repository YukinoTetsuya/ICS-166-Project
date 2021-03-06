using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class GameManager_Tutorial : MonoBehaviour
{
    public GameObject player;
    public GameObject key1;
    public GameObject door1;

    public Flowchart mainFlowchart;

    public GameObject room1;
    public GameObject room0;
    public GameObject camer;

    // Bool Check
    private bool flowchartHasShown_key1 = false;
    private bool flowchartHasShown_door1 = false;

    private void Update()
    {
        CheckDistanceKey1();

        CheckDistanceDoor1();
    }

    private void CheckDistanceKey1()
    {
        if (!flowchartHasShown_key1 && Vector3.Distance(player.transform.position, key1.transform.position) < 5f)
        {
            flowchartHasShown_key1 = true;
            mainFlowchart.ExecuteBlock("Before Pick Up Key1");
        }
    }

    private void CheckDistanceDoor1()
    {
        if (!flowchartHasShown_door1 && Vector3.Distance(player.transform.position, door1.transform.position) < 7f)
        {
            flowchartHasShown_door1 = true;
            mainFlowchart.ExecuteBlock("Before Open Door1");
        }
    }

    public void TeleportPlayer()
    {
        player.transform.position = new Vector3(-5f, -1f, 0f);
        camer.transform.position = new Vector3(0f, 1f, -10f);
        room0.SetActive(false);
        room1.SetActive(true);
    }
}
