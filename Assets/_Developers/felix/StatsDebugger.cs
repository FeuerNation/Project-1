using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatsDebugger : MonoBehaviour {


  [SerializeField] private Rigidbody playerBody;
  [SerializeField] private TextMeshProUGUI speedText;

  private void FixedUpdate() {
    float speed = playerBody.velocity.magnitude;
    var s = speed.ToString("F2");

    speedText.text = "Speed: " + s;
  }
}
