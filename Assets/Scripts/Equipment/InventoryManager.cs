﻿using GeneticAlgorithmForSpecies.Equipment;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {
    private static InventoryManager _instance;
    public static InventoryManager Instance { get => _instance; }


    [SerializeField] List<Item> items;
    [SerializeField] int size;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    // Start is called before the first frame update
    void Start() {
        // load items from PlayerPrefs
    }

    private static InventoryManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new InventoryManager();
        }
        return _instance;
    }

    public bool Add(Item item) {
        if (items.Count > size) {
            return false;
        }

        items.Add(item);
        return true;
    }

    public void Remove(Item item) {
        items.Remove(item);
    }
}
