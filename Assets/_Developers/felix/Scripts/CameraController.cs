#region Info
// -----------------------------------------------------------------------
// CameraController.cs
//
// Felix Jung 10.08.2022
// -----------------------------------------------------------------------
#endregion
#region
using UnityEngine;
#endregion


namespace _Developers.felix.Scripts {

  public class CameraController : MonoBehaviour {
    public float sensX;
    public float sensY;

    public Transform orientation;

    private float xRotation;
    private float yRotation;


    private void Start() {
      Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible   = false;
    }

    private void Update() {

      float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
      float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

      yRotation += mouseX;


      xRotation -= mouseY;

      // rotate cam and orientation
      transform.rotation   = Quaternion.Euler(xRotation, yRotation, 0);
      orientation.rotation = Quaternion.Euler(0, yRotation, 0);




    }
  }

}
