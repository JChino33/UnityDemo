using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickBook : MonoBehaviour
{
    public TextMesh texto;
    public GameObject sonidoHola;
    
    private void OnMouseDown()
    {
        Instantiate(sonidoHola);
        print("hiciste un clic");
        texto.text = "hola, como estas?";              
    }    
}
