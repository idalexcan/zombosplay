using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombo
{
    GameObject[] zombos;

    //CONSTRUCTOR DE ZOMBOS
    public Zombo(GameObject zombo, int cantZombos)
    {
        zombos = new GameObject[cantZombos];
        for (int i = 0; i < zombos.Length; i++)
        {
            zombos[i] = Object.Instantiate(zombo) as GameObject;
            zombos[i].transform.position = new Vector3(Random.Range(-10, 11), 0, Random.Range(-10, 11));
            zombos[i].transform.GetComponent<MeshRenderer>().material.color = RandomCol();
            Debug.Log(PrintCol(zombos[i]));
        }
    }

    public Color RandomCol()// ELIGE ALEATORIO DE COLOR
    {
        Color fincol = Color.black;
        switch (Random.Range(1, 4))
        {
            case 1:
                fincol = Color.cyan;
                break;
            case 2:
                fincol = Color.magenta;
                break;
            case 3:
                fincol = Color.green;
                break;
        }
        return fincol;
    }

    public string PrintCol(GameObject zombo)// IMPRIME EL MENSAJE DE PRESENTACIÓN DEL ZOMBO
    {
        string r = "";
        if (zombo.transform.GetComponent<MeshRenderer>().material.color == Color.cyan)
            r = "soy el zombo cyan";
        if (zombo.transform.GetComponent<MeshRenderer>().material.color == Color.green)
            r = "soy el zombo verde";
        if (zombo.transform.GetComponent<MeshRenderer>().material.color == Color.magenta)
            r = "soy el zombo magenta";

        return r;
    }
}