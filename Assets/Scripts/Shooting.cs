using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
  public Rigidbody projectile;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    handleShoot();
  }

  void handleShoot()
  {
    if (Input.GetMouseButtonDown(0))
    {
      Instantiate(projectile, gameObject.transform.position, UnityEngine.Quaternion.identity);
      projectile.velocity = transform.TransformDirection(UnityEngine.Vector3.forward * 10);
    }
  }
}
