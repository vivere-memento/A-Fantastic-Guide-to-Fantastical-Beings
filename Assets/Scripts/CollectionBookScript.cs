using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionBookScript : MonoBehaviour
{
    [SerializeField] GameObject collectionBook;
    // Is the collection Book Open?
    bool collectionBookOpen;
    void Start()
    {
        GameObject.Find("CollectionBookButton").GetComponent<Button>().onClick.AddListener(OnCollectionBookClose);
        // Collection book initial state
        collectionBookOpen = false;
        collectionBook.SetActive(collectionBookOpen);
    }
    void OnCollectionBookClose()
    {
        // change into opposite value
        collectionBookOpen ^= true;
        collectionBook.SetActive(collectionBookOpen);
    }
}
