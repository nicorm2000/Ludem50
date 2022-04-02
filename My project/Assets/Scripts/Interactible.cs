//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Interactible : MonoBehaviour
//{
//    // Start is called before the first frame update
//    [SerializeField] private bool isDestroyable = true;

//    private void OnTriggerStay2D(Collider2D collision)
//    {
//        if (collision.tag == "Player")
//        {
//            if (isDestroyable && Input.GetKeyDown(KeyCode.E))
//            {
//                Debug.Log("colisiona");
//                Destroy(gameObject);
//            }
//        }
//    }
//}
