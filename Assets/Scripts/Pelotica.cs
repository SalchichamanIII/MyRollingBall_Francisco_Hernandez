using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pelotica : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float fuerza;
    [SerializeField] float velocidad;
    [SerializeField] float distanciaChoqueSuelo;

    private Vector3 movimiento;
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

        movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);
    }
    private void FixedUpdate()
    {
        rb.AddForce(movimiento * velocidad, ForceMode.Force);
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
