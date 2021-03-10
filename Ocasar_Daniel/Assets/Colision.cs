using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    [SerializeField] MeshRenderer huevoMesh;
    [SerializeField] AudioSource audioSource;
    public AudioClip huevoRoto;
    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GetComponent<audioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Plano")
        {
            audioSource.PlayOneShot(huevoRoto);
            print("Sonido");
            //Destroy(this.gameObject);
        }
    }
    
}

