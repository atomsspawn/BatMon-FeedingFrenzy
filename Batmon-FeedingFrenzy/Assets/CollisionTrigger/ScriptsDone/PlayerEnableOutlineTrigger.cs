using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnableOutlineTrigger : MonoBehaviour {
    
    private void OnTriggerEnter2D(Collider2D collider) {
        PlayerOutline playerOutline = collider.GetComponent<PlayerOutline>();
        if (playerOutline != null) {
            playerOutline.ShowAnimatedOutline();
        }
    }

    private void OnTriggerExit2D(Collider2D collider) {
        PlayerOutline playerOutline = collider.GetComponent<PlayerOutline>();
        if (playerOutline != null) {
            playerOutline.HideAnimatedOutline();
        }
    }

}
