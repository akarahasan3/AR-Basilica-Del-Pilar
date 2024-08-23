using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class akarahasan3_script : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    public GameObject videoPlane;
    public GameObject videoPOI;

    public GameObject slikaPlane;
    public GameObject slikaPOI;

    public GameObject tekst;
    public GameObject tekstPOI;
    public GameObject tekstPlane;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.name == "OrganoPOI")
            {
                videoPOI.SetActive(false);
                videoPlane.SetActive(true);
            }

            if (hit.collider.gameObject.name == "VideoPlane")
            {
                videoPlane.SetActive(false);
                videoPOI.SetActive(true);
            }

            if (hit.collider.gameObject.name == "SlikaPlane")
            {
                slikaPlane.SetActive(false);
                slikaPOI.SetActive(true);
            }

            if (hit.collider.gameObject.name == "SandTimer")
            {
                slikaPlane.SetActive(true);
                slikaPOI.SetActive(false);
            }

            if (hit.collider.gameObject.name == "SpousePOI")
            {
                tekstPOI.SetActive(false);
                tekst.SetActive(true);
                tekstPlane.SetActive(true);

            }

            if (hit.collider.gameObject.name == "Tekst" || hit.collider.gameObject.name == "PlaneText")
            {
                tekst.SetActive(false);
                tekstPlane.SetActive(false);
                tekstPOI.SetActive(true);
            }


        }

    }


}
