using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] GameObject MainCube;
    int height;

    private void Update()
    {
        MainCube.transform.position = new Vector3(transform.position.x, height + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);
    }

    public void DecreaseHeight()
    {
        height--;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("collectable") && !other.gameObject.GetComponent<Collectable>().isCollected)
        {
            height += 1;
            other.gameObject.GetComponent<Collectable>().isCollected = true;
            other.gameObject.GetComponent<Collectable>().Index(height);
            other.gameObject.transform.parent = MainCube.transform;
        }
    }
}
