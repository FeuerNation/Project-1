using TMPro;
using UnityEngine;


namespace ProjectAlpha.Scripts.Gameplay {

  public class CoinPickup : MonoBehaviour {
    [SerializeField] private int _coins;



    [SerializeField] private TextMeshProUGUI _coinText;



    private void OnTriggerEnter(Collider other) {
      if (other.transform.CompareTag("Coin")) {
        Destroy(other.gameObject);
        _coins++;
        // coinText should be in format of "x coins"
        _coinText.text = $"{_coins} coins";


      }
    }

  }

}
