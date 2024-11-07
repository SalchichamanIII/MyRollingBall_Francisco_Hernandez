using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoPared : MonoBehaviour
{
    [SerializeField] private AudioClip colectar1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cONTROLADORsONIDO.Instance.EjecutarSonido(colectar1);
            

        }
    }
}
