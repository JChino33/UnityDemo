using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickBook : MonoBehaviour
{
    public TextMesh texto;
    public string mensaje;
    
    private void OnMouseDown()
    {
        print("hiciste un clic");
        texto.text = "hola amigo";              
    }    
}
