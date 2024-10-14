using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelotica : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float fuerza;
    [SerializeField] float velocidad;
    [SerializeField] float distanciaChoqueSuelo;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        saltoNormal();
        estaEnElSuelo();


    }

    // Update is called once per frame
    void Update()
    {
        condicionSalto();
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);
        rb.AddForce(movimiento * velocidad);
    }

    private void condicionSalto()
    {
        if(Input.GetKeyDown(KeyCode.Space) && estaEnElSuelo())
        {
            saltoNormal();
        }
            
                       
                
    }

    private void saltoNormal()
    {
        rb.AddForce (Vector3.up * fuerza , ForceMode.Impulse);
    }
        

   

    private bool estaEnElSuelo()
    {
        return Physics.Raycast(transform.position, Vector3.down , distanciaChoqueSuelo);
    }
}
