﻿using UnityEngine;
using System.Collections.Generic;

namespace GI.UnityToolkit.Attributes.Test
{
    //[CreateAssetMenu(fileName = "TestScriptableObjectB", menuName = "NaughtyAttributes/TestScriptableObjectB")]
    public class _TestScriptableObjectB : ScriptableObject
    {
        [MinMaxSlider(0, 10)]
        public Vector2Int slider;
    }
}