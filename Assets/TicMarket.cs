//El programa debe cumplir los siguientes requerimientos:
//Debe calcularse un descuento del 20% sobre la compra de un producto si la cantidad de unidades 
//del mismo supera las 3. 
//El programa debe devolver un mensaje de error descriptivo si el precio del producto o la 
//cantidad de unidades son menores a 1.
//El programa debe devolver el total de la compra de los tres productos mostrando un 
//mensaje que incluya el monto total sin descuento, el monto de los descuentos aplicados y 
//el total con los descuentos aplicados.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicMarket : MonoBehaviour
{
    public string producto1;
    public float valorP1;
    public int cantP1;

    public string producto2;
    public float valorP2;
    public int cantP2;

    public string producto3;
    public float valorP3;
    public int cantP3;
    float pTotal;
    int cantTotal;
    float descuento;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ingrese el nombre del primer producto que quiere llevar: " + producto1);
        Debug.Log("Ingrese la cantidad del primer producto: " + cantP1);
        Debug.Log("Ingrese el valor del primer producto: " + valorP1);

        Debug.Log("Ingrese el nombre del segundo producto que quiere llevar: " + producto2);
        Debug.Log("Ingrese la cantidad del segundo producto producto: " + cantP2);
        Debug.Log("Ingrese el valor del segundo producto: " + valorP2);

        Debug.Log("Ingrese el niombre del tercer producto que quiere llevar: " + producto3);
        Debug.Log("Ingrese la cantidad del tercer producto: " + cantP3);
        Debug.Log("Ingrese el valor del tercer producto: " + valorP3);

        pTotal = valorP1 + valorP2 + valorP3;
        cantTotal = cantP1 + cantP2 + cantP3;
        descuento = pTotal / 5;

        if (cantTotal > 3)
        {
            Debug.Log("Usted recibira un descuento del 20%");
            Debug.Log("El total de su descuento es de $" + descuento);
        }
        else if (cantTotal < 1)
        {
            Debug.Log("Hubo un error en su compra");
        }
        else if (cantTotal == 3)
        {
            Debug.Log("Su compra salio exitosa");
            Debug.Log("El valor de la compra es de $" + pTotal);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
