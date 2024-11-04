using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    public Inventario inventario;
    [SerializeField] Vector3 direccionRot;
    [SerializeField] float velRot;
    void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(20 ,0,0) * Time.deltaTime);

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
