using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class porteria : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D bola){

        if(bola.name == "Bola"){
            if(this.name == "izquierda"){
              
              bola.GetComponent<Bola>().reiniciarBola("derecha");
            }else if(this.name == "derecha"){
                
              bola.GetComponent<Bola>().reiniciarBola("izquierda");
            }
        }
    }
}
