﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subPB : MonoBehaviour {

    public int selectedIndex;
    public PatchBay pb;

    void OnMouseOver() {
        if (Input.GetMouseButtonUp(0))
            pb.selectedIndex = selectedIndex;
    }
}
