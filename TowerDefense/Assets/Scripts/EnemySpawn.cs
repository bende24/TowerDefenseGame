﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
    void Start() {
        RoundManager.Instance.spawnLocations.Add(transform.position);
    }
}