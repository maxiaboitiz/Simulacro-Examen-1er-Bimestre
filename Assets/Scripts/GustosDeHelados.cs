using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GustosDeHelados : MonoBehaviour
{
    public string sabor;
    public int gramos;
    float precio;

    void Start()
    {
        if (sabor != "CHO" && sabor != "DDL" && sabor != "FRU")
        {
            Debug.Log("El codigo no es valido");
            return;
        }

        if (sabor == "FRU")
        {
            precio = (gramos / 1000f) * 1250f * 0.9f;
        }
        else
        {
            precio = (gramos / 1000f) * 1250f;
        }

        if (gramos >= 250 && gramos <= 3000)
        {
            Debug.Log("El precio es: $" + precio);
        }
        else
        {
            Debug.Log("Cantidad de helado invalida");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
