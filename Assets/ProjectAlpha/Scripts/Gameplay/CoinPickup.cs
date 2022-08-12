#region Info
// -----------------------------------------------------------------------
// CoinPickup.cs
//
// Felix Jung 12.08.2022
// -----------------------------------------------------------------------
#endregion
#region
using TMPro;
using UnityEngine;
#endregion


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
