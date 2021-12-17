using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOutline : MonoBehaviour {

    [SerializeField] private Material playerMaterial;
    [SerializeField] private Material playerOutlineMaterial;
    
    public void ShowAnimatedOutline() {
        transform.Find("Body").GetComponent<MeshRenderer>().material = playerOutlineMaterial;
    }

    public void HideAnimatedOutline() {
        transform.Find("Body").GetComponent<MeshRenderer>().material = playerMaterial;
    }

}
