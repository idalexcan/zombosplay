using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroe
{
    public GameObject heroe;
    //CONSTRUCTOR DEL HEROE
    public Heroe(GameObject _heroe)
    {
        heroe = GameObject.Instantiate(_heroe) as GameObject;
        heroe.transform.GetComponent<MeshRenderer>().material.color = Color.black;
    }

    public void Moving(float _speed, float y) //MOVIMIENTO DEL HEROE
    {
        heroe.transform.eulerAngles = new Vector3(heroe.transform.eulerAngles.x, y, heroe.transform.eulerAngles.z);
        if (Input.GetKey("w")) heroe.transform.position += heroe.transform.forward * (_speed / 20);
        if (Input.GetKey("s")) heroe.transform.position -= heroe.transform.forward * (_speed / 20);
        if (Input.GetKey("a")) heroe.transform.position -= heroe.transform.right * (_speed / 20);
        if (Input.GetKey("d")) heroe.transform.position += heroe.transform.right * (_speed / 20);
    }
}
