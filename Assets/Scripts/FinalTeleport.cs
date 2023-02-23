using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTeleport : MonoBehaviour
{
    [SerializeField] public Vector3 TeleportPoint;
    public GameObject gm;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        gm.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        gm.SetActive(true);
        Invoke("FinTeleport", 3);
       
    }

    void FinTeleport()
    {
        Player.transform.position = TeleportPoint;
        gm.SetActive(false);
    }

   
}
