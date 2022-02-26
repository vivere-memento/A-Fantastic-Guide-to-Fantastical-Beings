using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionBookScript : MonoBehaviour
{
    [SerializeField] GameObject collectionBook;
    void Start()
    {
        GameObject.Find("CollectionBookButton").GetComponent<Button>().onClick.AddListener(OnOpenCollectionBook);
        // Collection book initial state
        collectionBook.SetActive(false);
    }
    void OnOpenCollectionBook()
    {
        // open collection book
        if (!collectionBook.activeSelf) {
            collectionBook.SetActive(true);
        }
    }
}
