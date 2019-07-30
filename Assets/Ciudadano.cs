using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadano
{
    //atributos de un ciudadano
    string nombre;
    int edad;

    //CONSTRUCTOR DE CIUDADANOS
    public Ciudadano(GameObject ciudadanos, string _nombre, int _edad)
    {
        GameObject ciudadano;
        ciudadano = Object.Instantiate(ciudadanos) as GameObject;
        ciudadano.transform.position = new Vector3(Random.Range(-10, 11), 0, Random.Range(-10, 11));
        nombre = _nombre;
        edad = _edad;
        Debug.Log(Print(nombre, edad));
    }

    string Print(string n, int e)// imprime mensaje de presentación de ciudadano
    {
        return "soy " + n + " y tengo " + e + " años :D";
    }


}
