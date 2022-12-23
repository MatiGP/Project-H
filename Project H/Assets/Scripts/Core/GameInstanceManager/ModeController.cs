using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.GameInstance
{
    public abstract class ModeController : MonoBehaviour
    {
        public abstract void Activate();
        public abstract void Deactivate();
    }
}
