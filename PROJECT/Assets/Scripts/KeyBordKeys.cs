using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBordKeys : MonoBehaviour
{
    public GameObject Portal;
    public GameObject Gameflow;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    Color ColConv(Color col)
    {
        return new Color(col.r / 255.0f, col.g / 255.0f, col.b / 255.0f);
    }
    void Update()
    {

        // PORTAL KEYS
        if (Input.GetKeyDown(KeyCode.Q))
        //Debug.Log("Sdadsd");
        {
            // if (!Portal.GetComponent<PortalOpener>().GetIsOpen())
            //Portal.GetComponent<PortalOpener>().StartCoroutine("Open", ColConv(new Color(255, 39, 39)));
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(216, 39, 39)));

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(217, 158, 39)));
        }
        if (Input.GetKeyDown(KeyCode.E))
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(172, 236, 43)));


        if (Input.GetKeyDown(KeyCode.A))
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(33, 152, 33)));

        if (Input.GetKeyDown(KeyCode.S))
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(36, 255, 182)));

        if (Input.GetKeyDown(KeyCode.D))
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(39, 158, 217)));



        if (Input.GetKeyDown(KeyCode.Z))
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(34, 34, 122)));
        if (Input.GetKeyDown(KeyCode.X))
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(157, 39, 217)));
        if (Input.GetKeyDown(KeyCode.C))
            Portal.GetComponent<PortalOpener>().Open(ColConv(new Color(217, 39, 158)));




        if (Input.GetKeyDown(KeyCode.R))
            //Debug.Log("sdas");
            Gameflow.GetComponent<Gameflow>().Spawn();



        if (Input.GetKeyUp(KeyCode.Q) ||
            Input.GetKeyUp(KeyCode.W) ||
            Input.GetKeyUp(KeyCode.E) ||

            Input.GetKeyUp(KeyCode.A) ||
            Input.GetKeyUp(KeyCode.S) ||
            Input.GetKeyUp(KeyCode.D) ||

            Input.GetKeyUp(KeyCode.Z) ||
            Input.GetKeyUp(KeyCode.X) ||
            Input.GetKeyUp(KeyCode.C)
            )
        //if (Portal.GetComponent<PortalOpener>().GetIsOpen())
        //Portal.GetComponent<PortalOpener>().StartCoroutine("Close");
        {
            Portal.GetComponent<PortalOpener>().Close();
        }
    }
}
