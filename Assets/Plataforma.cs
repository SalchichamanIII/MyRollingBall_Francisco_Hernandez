using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    [SerializeField] Vector3  posicionInicial; 
    [SerializeField] Vector3  posicionFinal; 
    [SerializeField] float duracion = 5.0f;
    private float timer = 0.0f;
    private bool moverseAlFinal = true;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = posicionInicial;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > duracion)
        {
            timer = 0.0f;
            moverseAlFinal = moverseAlFinal == false;

        }
        float t = timer / duracion;
        if (moverseAlFinal)
        {
            transform.position = Vector3.Lerp(posicionInicial , posicionFinal, t);
        }
        else
        {
            transform.position = Vector3.Lerp(posicionFinal, posicionInicial, t);
        }
    }
}
