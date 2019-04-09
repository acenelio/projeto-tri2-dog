using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Coin")) {
            SFXManager.instance.ShowCoinParticles(other.gameObject);
            AudioManager.instance.PlaySoundCoinPickup(other.gameObject);
            Destroy(other.gameObject);
            LevelManager.instance.IncrementCoinCount();
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Enemies")) {
            Camera.main.GetComponentInChildren<AudioSource>().mute = true;
            LevelManager.instance.SetTapeSpeed(0);
            AudioManager.instance.PlaySoundFail(gameObject);
            Destroy(gameObject);
        }
    }
}
