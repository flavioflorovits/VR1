using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed;
    public float fireRate;

    public Material[] materialVariations;

    private bool isFiring = false;

    public void StartFire()
    {
        if (!isFiring)
        {
            isFiring = true;
            StartCoroutine(FireCoroutine());
        }
    }

    public void CeaseFire()
    {
        isFiring = false;
        StopAllCoroutines();
    }

    private IEnumerator FireCoroutine()
    {
        while (isFiring)
        {
            int i = UnityEngine.Random.Range(0, materialVariations.Length);

            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
            bullet.GetComponent<MeshRenderer>().material = materialVariations[i];

            bulletRigidbody.velocity = transform.forward * bulletSpeed;

            Destroy(bullet, 6f);

            yield return new WaitForSeconds(fireRate);
        }
    }

}
