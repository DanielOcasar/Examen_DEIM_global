using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour

{   
    //variable para pedir la posicion de la caja. 
    [SerializeField] Transform posCaja;
    [SerializeField] AudioSource BGMusic;

    // Start is called before the first frame update
    void Start()
    {
        BGMusic = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(posCaja);
    }
}

