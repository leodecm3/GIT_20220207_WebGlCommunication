using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFireGun : MonoBehaviour {

    [SerializeField] List<GameObject> bullets = new List<GameObject>();

    [SerializeField] private GameObject spawnPoint;


    public void Shoot() {
        foreach (GameObject bullet in bullets) {
            if (bullet.activeInHierarchy == false) {

                bullet.SetActive(true);

                bullet.transform.position = spawnPoint.transform.position;

                bullet.GetComponent<Rigidbody>().velocity = Vector3.zero;
                bullet.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * 500f);

                StartCoroutine(SetDeactive(bullet));
                return;
            }
        }

        Debug.Log("there is no more bullets on the pool manager! include more ASAP");

    }


    IEnumerator SetDeactive(GameObject gameObject) {
        yield return new WaitForSeconds(1.5f);
        gameObject.SetActive(false);
    }



}
