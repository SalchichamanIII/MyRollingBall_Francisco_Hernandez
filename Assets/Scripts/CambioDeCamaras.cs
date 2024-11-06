using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDeCamaras : MonoBehaviour
{
    public Camera[] listaCamaras;
    // Start is called before the first frame update
    void Start()
    {
        listaCamaras[0].enabled = true;
        listaCamaras[1].enabled = false;
        listaCamaras[2].enabled = false;
        listaCamaras[3].enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            listaCamaras[0].enabled = true;
            listaCamaras[1].enabled = false;
            listaCamaras[2].enabled = false;
            listaCamaras[3].enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            listaCamaras[0].enabled = false;
            listaCamaras[1].enabled = true;
            listaCamaras[2].enabled = false;
            listaCamaras[3].enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            listaCamaras[0].enabled = false;
            listaCamaras[1].enabled = false;
            listaCamaras[2].enabled = true;
            listaCamaras[3].enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            listaCamaras[0].enabled = false;
            listaCamaras[1].enabled = false;
            listaCamaras[2].enabled = false;
            listaCamaras[3].enabled = true;
        }
    }
}
