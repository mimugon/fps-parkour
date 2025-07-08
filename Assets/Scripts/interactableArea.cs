using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactableArea : MonoBehaviour
{
    GameObject interaction;
    public GameObject img_interaction;
    bool isOnInteraction = false;


    public void Update(){
        if(isOnInteraction && Input.GetKeyDown(KeyCode.E)){
            interaction.GetComponent<MercanciaScript>().onInteraction();
            StopInteraction();
        }
    }
    public void OnTriggerEnter(Collider other){
        bool isInteractable = other.GetComponent<MercanciaScript>();
        if(isInteractable){
            interaction = other.gameObject;
            isOnInteraction = true;
            img_interaction.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other){
        StopInteraction();
    }

    public void StopInteraction(){
        img_interaction.SetActive(false);
        isOnInteraction = false;
    }
}
