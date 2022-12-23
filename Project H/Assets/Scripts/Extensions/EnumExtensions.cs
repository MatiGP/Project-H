using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EnumExtensions
{
    public static string ToPrefabPath(this EPanelID panelID)
    {
        return string.Format(ResourcePaths.UI_PREFAB_PATH_FORMAT, panelID);
    }
}
