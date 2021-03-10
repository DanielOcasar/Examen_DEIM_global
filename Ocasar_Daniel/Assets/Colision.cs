using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{   //variable para acceder al audiosource
    [SerializeField] AudioSource audioSource;
    //var para sacar el audio del huevo roto
    public AudioClip huevoRoto;
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    //trigger que cuando toque el tag enemy, suene la cancion huevo roto.
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            audioSource.PlayOneShot(huevoRoto);
            print("Sonido");
            //Destroy(this.gameObject);
        }
    }
    
}

