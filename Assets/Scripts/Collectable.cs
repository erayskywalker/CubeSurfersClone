using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public bool isCollected { get; set; }
    int index;

    [SerializeField] Collector collector;

    private void Update()
    {
        if (isCollected)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("obstackle"))
        {
            collector.DecreaseHeight();
            transform.parent = null;
            GetComponent<Collider>().enabled = false;
            other.gameObject.GetComponent<Collider>().enabled = false;
        }
    }

    public void Index(int index)
    {
        this.index = index;
    }


}
