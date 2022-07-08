using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimpodeVida : MonoBehaviour
{
    // Start is called before the first frame update
    public float tiempoVida;
    void Start()
    {
        Destroy(gameObject, tiempoVida);
    }

}
