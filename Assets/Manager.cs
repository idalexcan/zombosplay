using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject objectref, cam;
    //DECLARANDO VARIABLES DE CLASES
    Heroe h;
    public float speed;
    Zombo z;
    Ciudadano[] c;

    void Start()
    {

        int azarLimit = //variables para determinar cantidad de zombos y ciudadanos
            Random.Range(4, 9), cantCiudadanos = Random.Range(1, azarLimit);

        //INSTANCIAS DE HEREO, ZOMBOS Y CIUDADANOS
        h = new Heroe(objectref);
        z = new Zombo(objectref, azarLimit - cantCiudadanos);
        c = new Ciudadano[cantCiudadanos];//dimensionamiento de matriz de ciudadanos
        for (int i = 0; i < c.Length; i++)
        {
            c[i] = new Ciudadano(objectref, nombres()[Random.Range(0, 20)], Random.Range(0, 100));
        }
    }

    void Update()
    {
        CamMove();//direccion de cámara
        h.Moving(speed, cam.transform.eulerAngles.y);//movimiento del héroe 
        cam.transform.position = h.heroe.transform.position;//sincronización cámara/héroe en 1ra persona
    }

    float x, y;
    void CamMove()//movimiento de cámara
    {
        x += Input.GetAxis("Mouse X");
        y -= Input.GetAxis("Mouse Y");
        cam.transform.eulerAngles = new Vector3(y * 2, x * 2, 0);
    }

    string[] nombres()//banco de nombres
    {
        string[] nombres = new string[20]{
            "Francisco Alberto Buenavides",
            "Maria Clementina Aristizabal",
            "Mario Juvenal Ultrasubliminal",
            "Zeynep Seyven",
            "Ates Albayrak",
            "Santo Tomás de Carlos Dutty",
            "Ruperta Duque",
            "Vicente Fernandez",
            "Mia Khalifa",
            "Steve Rodriguez",
            "Johannes Chrysostomus Wolfgangus Theophilus Amadeus Mozart",
            "Leopoldo Quintero",
            "Adolf Hittler",
            "Simone Sedraia",
            "Joseph Haydn ",
            "Deadmau5",
            "Salomón Salazar",
            "María Cano",
            "Jean-Baptiste Grenouille",
            "Saori Hayami" }
            ;
        return nombres;
    }
}
