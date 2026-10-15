using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletObject;
    public Transform bulletOut;
    public float bulletForce;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Quaternion rot = bulletOut.rotation * Quaternion.Euler(0, 90, 0);
            GameObject bulletClone = Instantiate(bulletObject, bulletOut.position, rot);
            bulletClone.GetComponent<Rigidbody>().AddForce(bulletForce * bulletOut.forward);
        }
    }
}
