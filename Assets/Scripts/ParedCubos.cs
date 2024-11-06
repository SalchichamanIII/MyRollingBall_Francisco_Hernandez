using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ParedCubos : MonoBehaviour
{
    private bool iniciarTimer;
    private float timer = 0;
    [SerializeField] private Rigidbody[] rbs;

    private void Update()
    {
        if (iniciarTimer == true)
        {
            timer += 1 * Time.unscaledDeltaTime; 
            if(timer >= 2)
            {
                Time.timeScale = 1;
                for (int i = 0; i < rbs.Length; i++)
                {
                    rbs[i].useGravity = true;
                }
                
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0.2f;
            iniciarTimer = true;

        }
    }
}
