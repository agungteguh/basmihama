﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tochlevel : MonoBehaviour {
    public void changescene(string scenename) {
        Application.LoadLevel(scenename);
    }
}
