using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    public Inventario inventario;
    [SerializeField] Vector3 direccionRot;
    [SerializeField] float velRot;
    private AudioSource AudioSource;
    void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
        AudioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0 ,0,70) * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            inventario.cantidad = inventario.cantidad + 1;
            Destroy(gameObject);

           
        }
        
    }

    

   
}
